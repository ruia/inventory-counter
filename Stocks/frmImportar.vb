Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmImportar
  Private _tabelasColunas As Dictionary(Of String, List(Of String))
  Private _headersFicheiro As New List(Of String)
  Private _linhasFicheiro As New List(Of String)

#Region "BETA STUFF"
  Private _headers As Boolean = False
  Private _listaColunas As New List(Of String)
  'Private Sub GeraDataTAble()
  'Private prod As Produto

  Private Function Existe(Id As String) As Boolean
    Dim sql As String = "SELECT Id FROM Produtos Where Id=@Id"
    Using conexao As New SqlConnection(Globais.connectionString)
      Using comando As New SqlCommand(sql, conexao)
        conexao.Open()
        With comando
          .Parameters.Add("@Id", SqlDbType.NVarChar, 60).Value = Id
        End With
        Using dataReader As SqlDataReader = comando.ExecuteReader
          If (dataReader.HasRows) Then
            Return True
          End If
        End Using
      End Using
    End Using
    Return False
  End Function

  Private Function ExisteCodBarras(CodBarras As String) As Boolean
    Dim sql As String = "SELECT CodBarras FROM Produtos Where CodBarras=@CB"
    Using conexao As New SqlConnection(Globais.connectionString)
      Using comando As New SqlCommand(sql, conexao)
        conexao.Open()
        With comando
          .Parameters.Add("@CB", SqlDbType.NVarChar, 60).Value = CodBarras
        End With
        Using dataReader As SqlDataReader = comando.ExecuteReader
          If (dataReader.HasRows) Then
            Return True
          End If
        End Using
      End Using
    End Using
    Return False
  End Function

  Private Function Eliminar(Id As String) As Boolean
    Dim sql As String = "DELETE FROM Produtos Where Id=@Id"
    Using conexao As New SqlConnection(Globais.connectionString)
      Using comando As New SqlCommand(sql, conexao)
        conexao.Open()
        With comando
          .Parameters.Add("@Id", SqlDbType.NVarChar, 60).Value = Id
        End With
        Dim resultado As Integer = comando.ExecuteNonQuery
        If (resultado > 0) Then
          Return True
        End If
      End Using
    End Using
    Return False
  End Function


  Private Sub btnImportarBETA_Click(sender As Object, e As EventArgs) Handles btnImportarBETA.Click
    Dim nAtualizados As Integer = 0

    If (Me.dgvFicheiro.Columns.Count > 2) Then
      For Each coluna As DataGridViewColumn In Me.dgvFicheiro.Columns
        _listaColunas.Add(coluna.Name)
      Next
      If ((_listaColunas.Contains("Id") Or _listaColunas.Contains("ID")) And _listaColunas.Contains("Descricao")) Then
        For i As Integer = 0 To Me.dgvFicheiro.Rows.Count - 1

          If (_listaColunas.Contains("CodBarras")) Then
            If ExisteCodBarras(Me.dgvFicheiro("CodBarras", i).Value.ToString) Then
              Eliminar(Me.dgvFicheiro("Id", i).Value.ToString)
            End If
          End If
          Dim prod As New Produto
          prod.Id = Me.dgvFicheiro("Id", i).Value.ToString
          prod.Descricao = Me.dgvFicheiro("Descricao", i).Value.ToString
          If (_listaColunas.Contains("CodBarras")) Then
            prod.CodBarras = Me.dgvFicheiro("CodBarras", i).Value.ToString
          End If
          If (_listaColunas.Contains("Categoria")) Then
            prod.Categoria = Me.dgvFicheiro("Categoria", i).Value.ToString
          End If
          If (_listaColunas.Contains("UnidadeMedida")) Then
            prod.UnidadeMedida = Me.dgvFicheiro("UnidadeMedida", i).Value.ToString
          End If
          If (_listaColunas.Contains("PrecoCusto")) Then
            If (Me.dgvFicheiro("PrecoCusto", i).Value.ToString <> "") Then
              prod.PrecoCusto = Convert.ToDecimal(Me.dgvFicheiro("PrecoCusto", i).Value)
            End If
          End If
          If (prod.Gravar()) Then
            prod = Nothing
            nAtualizados += 1
          Else
            MsgBox("erro ao gravar produto")
            _listaColunas.Clear()
          End If

        Next
        MsgBox("Importação terminada!" & vbNewLine & "Nº items ficheiro: " & Me.lblNumLinhasFicheiro.Text.Replace("Linhas ficheiro: ", "") & vbNewLine & "Nº items atualizados: " & nAtualizados)
        _listaColunas.Clear()
      Else
        MsgBox("O ficheiro tem menos de duas colunas")
        _listaColunas.Clear()
        Exit Sub
      End If
    End If
    Using conexao As New SqlConnection With {.ConnectionString = Globais.connectionString}
      Try
        conexao.Open()

      Catch ex As Exception

      End Try
    End Using
    _listaColunas.Clear()
  End Sub

#End Region

  Private Sub frmImportar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ResetFrm()
    _tabelasColunas = GetTabelasColunas()
    Me.cmbTabelas.Items.AddRange(_tabelasColunas.Keys.ToArray)
  End Sub

  Private Sub btnAbrirFicheiro_Click(sender As Object, e As EventArgs) Handles btnAbrirFicheiro.Click
    ResetFrm()
    Me.ofdAbrirFicheiro.Filter = "Ficheiros CSV|*.csv"
    Me.ofdAbrirFicheiro.CheckFileExists = True
    Me.ofdAbrirFicheiro.CheckPathExists = True
    If (Me.ofdAbrirFicheiro.ShowDialog = DialogResult.OK) Then
      Me.txtFicheiro.Text = Me.ofdAbrirFicheiro.FileName
      _linhasFicheiro.AddRange(IO.File.ReadAllLines(Me.txtFicheiro.Text))
      '_headersFicheiro.Add("") <- DÀ MERDA NO RESTO
      _headersFicheiro.AddRange(_linhasFicheiro(0).Replace("'", "").Split(";"))

      Me.dgvFicheiro.ColumnCount = _headersFicheiro.Count

      If (MsgBox("Nomes das colunas na primeira linha?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
        _headers = True 'BETA
        _linhasFicheiro.RemoveAt(0)
      End If

      'BETA
      If (_headers) Then
        For Each coluna As DataGridViewColumn In Me.dgvFicheiro.Columns
          coluna.Name = _headersFicheiro(coluna.Index)
        Next
      End If
      'FIM BETA 

      For Each linha As String In _linhasFicheiro
        Dim tmp() As String
        tmp = linha.Replace("'", "").Replace("""", "").ToUpper.Split(";")
        For i = 0 To tmp.Count - 1
          tmp(i) = tmp(i).Trim
        Next
        Me.dgvFicheiro.Rows.Add(tmp)
      Next
      Me.lblNumLinhasFicheiro.Text = "Linhas ficheiro:  " & Me.dgvFicheiro.RowCount

      Me.camposFicheiro.DataSource = _headersFicheiro
      Me.camposServidor.ReadOnly = True
      Me.camposFicheiro.ReadOnly = False
      Me.btnImportar.Enabled = True
      Me.cmbTabelas.Enabled = True
      Me.dgvMapeamentos.Enabled = True
    End If
  End Sub

  Private Sub cmbTabelas_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbTabelas.SelectedValueChanged
    If ((Me.cmbTabelas.SelectedItem IsNot String.Empty) And (Me.cmbTabelas.SelectedItem IsNot Nothing)) Then
      Me.dgvMapeamentos.Rows.Clear()
      For Each coluna As String In _tabelasColunas.Item(Me.cmbTabelas.SelectedItem)
        Me.dgvMapeamentos.Rows.Add(coluna)
      Next
    End If
  End Sub

  Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
    Dim SQL As String = String.Empty
    Dim nAtualizados As Integer = 0

    Dim nomeTabela As String = Me.cmbTabelas.Text
    'Dim listaCampos As New List(Of List(Of String))
    Dim lstCampos As New Dictionary(Of String, Integer)
    For i As Integer = 0 To Me.dgvMapeamentos.RowCount - 1
      If (Me.dgvMapeamentos(1, i).Value <> "") Then
        'listaCampos.Add(New List(Of String) From {dgvMapeamentos(0, i).Value, i})
        lstCampos.Add(dgvMapeamentos(0, i).Value, _headersFicheiro.IndexOf(Me.dgvMapeamentos(1, i).Value))
      End If
    Next

    Using conexao As New SqlConnection With {.ConnectionString = Globais.connectionString}
      Try
        conexao.Open()
        Using cmd As New SqlCommand With {.CommandText = SQL, .Connection = conexao}
          For i As Integer = 0 To Me.dgvFicheiro.RowCount - 1
            Dim update As String = String.Empty
            Dim updateWhere As String = String.Empty

            Dim insertColunas As String = String.Empty
            Dim insertValores As String = String.Empty

            Dim nCampos As Integer = lstCampos.Count - 1
            Dim j As Integer = 0

            For Each chave As String In lstCampos.Keys

              If (j = 0) Then
                updateWhere = chave & "=" & "'" & Me.dgvFicheiro(lstCampos(chave), i).Value.ToString & "'"
                insertColunas = chave & ", "
                insertValores = "'" & Me.dgvFicheiro(lstCampos(chave), i).Value.ToString & "', "
                j += 1
              Else
                update &= chave & "='" & Me.dgvFicheiro(lstCampos(chave), i).Value.ToString & "'"
                insertColunas &= chave
                insertValores &= "'" & Me.dgvFicheiro(lstCampos(chave), i).Value.ToString & "'"

                If (j <> nCampos) Then
                  update &= ", "
                  insertColunas &= ", "
                  insertValores &= ", "
                End If
                j += 1
              End If
            Next

            SQL = String.Format("UPDATE {0} SET {1} WHERE {2} " _
                                & "IF @@ROWCOUNT=0 INSERT INTO {0} ({3}) VALUES ({4});",
                                Me.cmbTabelas.Text, update, updateWhere, insertColunas, insertValores)

            cmd.CommandText = SQL
            nAtualizados += cmd.ExecuteNonQuery()

          Next
          MsgBox("Importação terminada!" & vbNewLine & "Nº items ficheiro: " & Me.lblNumLinhasFicheiro.Text.Replace("Linhas ficheiro: ", "") & vbNewLine & "Nº items atualizados: " & nAtualizados)
          'Me.lblNumInsertUpdate.Text = "Linhas atualizadas: " & nAtualizados

          ResetFrm()

        End Using
      Catch ex As Exception
        MsgBox("Ocorreu um erro ao gravar/atualizar a base de dados" & vbNewLine & SQL & vbNewLine & ex.Message)
      End Try
    End Using

  End Sub

  Private Sub ResetFrm()
    _headersFicheiro.Clear()
    _linhasFicheiro.Clear()

    Me.txtFicheiro.Text = String.Empty
    Me.btnAbrirFicheiro.Enabled = True
    Me.btnImportar.Enabled = False
    Me.cmbTabelas.Enabled = False
    Me.cmbTabelas.SelectedIndex = -1
    Me.lblNumLinhasFicheiro.Text = String.Empty
    Me.lblNumInsertUpdate.Text = String.Empty
    Me.dgvMapeamentos.Rows.Clear()
    Me.dgvFicheiro.Rows.Clear()
    Me.dgvFicheiro.Columns.Clear()
  End Sub

  Private Sub btnAgrupador_Click(sender As Object, e As EventArgs) Handles btnAgrupador.Click

    Dim id As String = InputBox("Id do documento")
    If (id <> String.Empty) Then
      Dim tmp As New Dictionary(Of String, Integer)
      Dim prod As String
      Dim qtd As Integer

      If (ExisteIdStock(id)) Then
        Using conexao As New SqlConnection(Globais.connectionString)
          conexao.Open()
          Using comando As New SqlCommand("SELECT * FROM StocksDetalhes WHERE IdStock=@IdStock", conexao)
            comando.Parameters.Add("@IdStock", SqlDbType.BigInt).Value = id
            Dim dataReader As SqlDataReader = comando.ExecuteReader
            If (dataReader.HasRows) Then
              While dataReader.Read
                prod = dataReader("IdProduto")
                qtd = dataReader("Qtd")
                If (tmp.ContainsKey(prod)) Then
                  tmp(prod) += qtd
                Else
                  tmp.Add(prod, qtd)
                End If
                'tmpProduto = New Produto
                'tmpProduto.ObterPorId(dataReader("IdProduto"))
                'Me.dgvProdutos.Rows.Add(tmpProduto.Id, tmpProduto.Descricao, dataReader("Qtd"), tmpProduto.PrecoCusto, FormatNumber((dataReader("Qtd") * tmpProduto.PrecoCusto), 2))
              End While
              'AtualizaTotalDocumento()
              'Me.dgvProdutos.FirstDisplayedScrollingRowIndex = Me.dgvProdutos.RowCount - 1
              'Me.txtCod.Focus()
            End If
          End Using
          Dim idNDoc As String = InputBox("Id novo documento")
          If (idNDoc <> String.Empty) Then
            Using comando As New SqlCommand("INSERT INTO Stocks (Data) VALUES (@Data)", conexao)
              comando.Parameters.Add("@Data", SqlDbType.Date).Value = Now.Date
              If (comando.ExecuteNonQuery <= 0) Then
                MsgBox("erro ao gravar o documento (Stock Agrupa)")
                Exit Sub
              End If
            End Using
            Dim SqlInsertDetalhes As String = "INSERT INTO StocksDetalhes (IdStock, IdProduto, Qtd) VALUES (@IdStock, @IdProduto, @Qtd)"
            Using comando As New SqlCommand(SqlInsertDetalhes, conexao)
              For Each tmpE As String In tmp.Keys
                With comando.Parameters
                  .Clear()
                  .Add("@IdStock", SqlDbType.BigInt).Value = idNDoc
                  .Add("@IdProduto", SqlDbType.NVarChar, 60).Value = tmpE
                  .Add("@Qtd", SqlDbType.Int).Value = tmp(tmpE)
                End With
                If (comando.ExecuteNonQuery <= 0) Then
                  MsgBox("erro ao gravar o documento (Detalhes Stocks - Prod: " & tmpE & ")")
                  'Me.cmdGravar.Enabled = True
                  Exit Sub
                End If

              Next
            End Using
            MsgBox("Novo documento Guardado")
          End If

        End Using
      Else
        MsgBox("Não existe documento")
      End If
    End If
  End Sub

  Private Function ExisteIdStock(id As Long) As Boolean
    Dim SQL As String = "SELECT Id FROM Stocks WHERE Id=@Id"
    Using conexao As New SqlConnection(Globais.connectionString)
      Using comando As New SqlCommand(SQL, conexao)
        conexao.Open()
        comando.Parameters.Add("@Id", SqlDbType.BigInt).Value = id
        Using dataReader As SqlDataReader = comando.ExecuteReader
          If (dataReader.HasRows) Then
            Return True
          Else
            Return False
          End If
        End Using
      End Using
    End Using

    Return False
  End Function

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    Dim linhas As New List(Of String)
    Dim linhasCorrigidas As New List(Of String)
    Dim x As Integer = 0
    Dim tmp As String = ""
    Me.ofdAbrirFicheiro.CheckFileExists = True
    Me.ofdAbrirFicheiro.CheckPathExists = True
    If (Me.ofdAbrirFicheiro.ShowDialog = DialogResult.OK) Then
      linhas.AddRange(IO.File.ReadAllLines(Me.ofdAbrirFicheiro.FileName))
      For Each linha As String In linhas
        If (x = 8) Then
          linhasCorrigidas.Add(tmp)
          tmp = ""
          x = 0
        End If
        tmp &= linha & ";"
        x += 1
      Next
      IO.File.WriteAllLines("C:\Users\Rui\Desktop\TabelasPrecos\file.txt", linhasCorrigidas)
    End If
  End Sub

  Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    Dim linhas As New List(Of String)
    Dim tmp() As String
    Me.ofdAbrirFicheiro.CheckFileExists = True
    Me.ofdAbrirFicheiro.CheckPathExists = True
    If (Me.ofdAbrirFicheiro.ShowDialog = DialogResult.OK) Then
      linhas.AddRange(IO.File.ReadAllLines(Me.ofdAbrirFicheiro.FileName))
    End If

    Dim sqlSelect As String = "SELECT * FROM Produtos WHERE CodBarras=@CodBarras"
    Using conexao As New SqlConnection(Globais.connectionString)
      conexao.Open()
      For Each linha As String In linhas
        Using cmd As New SqlCommand(sqlSelect, conexao)
          cmd.Parameters.Add("@CodBarras", SqlDbType.NVarChar, 60).Value = linha.Split(";")(0)
          Using DataReader As SqlDataReader = cmd.ExecuteReader
            If (DataReader.HasRows) Then 'atualiza produto
              Using cmdUpdate As New SqlCommand("UPDATE Produtos SET PrecoCusto=@PrecoCusto, Descricao=@Descricao WHERE CodBarras=@CodBarras", conexao)
                cmdUpdate.Parameters.Add("@PrecoCusto", SqlDbType.SmallMoney).Value = linha.Split(";")(2)
                cmdUpdate.Parameters.Add("@Descricao", SqlDbType.NVarChar, 200).Value = linha.Split(";")(1)
                cmdUpdate.Parameters.Add("@CodBarras", SqlDbType.NVarChar, 60).Value = linha.Split(";")(0)
                If (cmdUpdate.ExecuteNonQuery <= 0) Then
                  MsgBox("erro ao gravar o documento (Detalhes Stocks - Prod: " & linha.Split(";")(0))
                  Exit Sub
                End If
              End Using
            Else 'cria produto novo
              Using cmdInsert As New SqlCommand("INSERT INTO Produtos (Id, Descricao, CodBarras, PrecoCusto) VALUES (@Id, @Descricao, @CodBarras, @PrecoCusto)", conexao)
                cmdInsert.Parameters.Add("@Id", SqlDbType.NVarChar, 60).Value = linha.Split(";")(0)
                cmdInsert.Parameters.Add("@Descricao", SqlDbType.NVarChar, 200).Value = linha.Split(";")(1)
                cmdInsert.Parameters.Add("@CodBarras", SqlDbType.NVarChar, 60).Value = linha.Split(";")(0)
                cmdInsert.Parameters.Add("@PrecoCusto", SqlDbType.SmallMoney).Value = linha.Split(";")(2)
                If (cmdInsert.ExecuteNonQuery <= 0) Then
                  MsgBox("erro ao gravar o documento (Detalhes Stocks - Prod: " & linha.Split(";")(0))
                  Exit Sub
                End If
              End Using
            End If
          End Using
        End Using
      Next
    End Using
    MsgBox("update completo")
  End Sub

  Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnUpdatePrecoCusto.Click
    Dim linhas As New List(Of String)
    Dim tmp() As String
    Me.ofdAbrirFicheiro.CheckFileExists = True
    Me.ofdAbrirFicheiro.CheckPathExists = True
    If (Me.ofdAbrirFicheiro.ShowDialog = DialogResult.OK) Then
      linhas.AddRange(IO.File.ReadAllLines(Me.ofdAbrirFicheiro.FileName))
    End If

    Dim sqlSelect As String = "SELECT * FROM Produtos WHERE CodBarras=@CodBarras"
    Using conexao As New SqlConnection(Globais.connectionString)
      conexao.Open()
      For Each linha As String In linhas
        Using cmdUpdate As New SqlCommand("UPDATE Produtos SET PrecoCusto=@PrecoCusto WHERE Id=@Id", conexao)
          cmdUpdate.Parameters.Add("@PrecoCusto", SqlDbType.SmallMoney).Value = Trim(linha.Split(";")(1))
          cmdUpdate.Parameters.Add("@Id", SqlDbType.NVarChar, 60).Value = Trim(linha.Split(";")(0))
          If (cmdUpdate.ExecuteNonQuery <= 0) Then
            MsgBox("erro ao gravar o documento (Detalhes Stocks - Prod: " & linha.Split(";")(0))
            Exit Sub
          End If
        End Using
      Next
    End Using
    MsgBox("update completo")
  End Sub

  Private Sub cmdFixCbVazios_Click(sender As Object, e As EventArgs) Handles cmdFixCbVazios.Click
    Dim nprods As Integer = 0
    Using conexao As New SqlConnection(Globais.connectionString)
      conexao.Open()
      Using cmdSelect As New SqlCommand("SELECT Id From Produtos WHERE CodBarras=''", conexao)
        Using dr As SqlDataReader = cmdSelect.ExecuteReader
          If (dr.HasRows) Then
            While (dr.Read())
              Using cmdUpdate As New SqlCommand("UPDATE Produtos SET CodBarras=@CodBarras Where Id=@Id", conexao)
                cmdUpdate.Parameters.Add("@CodBarras", SqlDbType.NVarChar, 60).Value = dr(0).ToString
                cmdUpdate.Parameters.Add("@Id", SqlDbType.NVarChar, 60).Value = dr(0).ToString
                If (cmdUpdate.ExecuteNonQuery <= 0) Then
                  MsgBox("erro ao atualizar produto: " & dr(0).ToString)
                  Exit Sub
                End If
                nprods += 1
              End Using
            End While

          Else
            MsgBox("Não existem produtos com o codigo de barras em branco!")
          End If
        End Using
      End Using
    End Using
    MsgBox("Produtos Atualizados!" & vbNewLine & "Nº de registos: " & nprods.ToString)
  End Sub

  Private Sub btnFixDupsEX_Click(sender As Object, e As EventArgs) Handles btnFixDupsEX.Click
    Dim produtosEx As New List(Of String)
    Dim codBarrasDupsBD As New Dictionary(Of String, String)
    Dim idsParaApagar As New List(Of String)

    Dim dicProd As New Dictionary(Of String, String)

    Me.ofdAbrirFicheiro.CheckFileExists = True
    Me.ofdAbrirFicheiro.CheckPathExists = True
    If (Me.ofdAbrirFicheiro.ShowDialog = DialogResult.OK) Then
      produtosEx.AddRange(IO.File.ReadAllLines(Me.ofdAbrirFicheiro.FileName))
    End If
    For Each linha As String In produtosEx '0-3
      If ((Trim(linha.Split(";")(3)) <> String.Empty) And (dicProd.ContainsKey(Trim(linha.Split(";")(0))) = False)) Then
        dicProd.Add(Trim(linha.Split(";")(0)), Trim(linha.Split(";")(3)))
      End If
    Next
    Using conexao As New SqlConnection(Globais.connectionString)
      conexao.Open()
      Using cmdSelect As New SqlCommand("SELECT p.Id, p.CodBarras FROM Produtos p INNER JOIN ( SELECT CodBarras, COUNT(*) as dupeCount FROM Produtos	GROUP BY CodBarras 	HAVING COUNT(*) > 1 ) x ON p.CodBarras = x.CodBarras ORDER BY p.CodBarras", conexao)
        Using dr As SqlDataReader = cmdSelect.ExecuteReader
          If (dr.HasRows) Then
            While (dr.Read)
              codBarrasDupsBD.Add(dr(0), dr(1))
            End While
          End If
        End Using
      End Using
      For Each item As String In dicProd.Keys
        If codBarrasDupsBD.ContainsKey(item) Then
          codBarrasDupsBD.Remove(item)
        End If
      Next
      For Each item In codBarrasDupsBD
        Using cmdDelete As New SqlCommand("DELETE FROM Produtos WHERE Id=@Id", conexao)
          cmdDelete.Parameters.Add("@Id", SqlDbType.NVarChar, 60).Value = item.Key
          cmdDelete.ExecuteNonQuery()
        End Using
      Next
    End Using
  End Sub

  Private Sub btnImportarPortugalPet_Click(sender As Object, e As EventArgs) Handles btnImportarPortugalPet.Click
    'melhorar verificações de existencias Id e CodBarras ?? 
    Dim errorlist As New List(Of String)
    Dim debugList As New List(Of String)
    Using conexao As New SqlConnection With {.ConnectionString = Globais.connectionString}
      conexao.Open()
      For Each row As DataGridViewRow In Me.dgvFicheiro.Rows
        Using cmdSelct As New SqlCommand("SELECT * FROM Produtos WHERE Id=@Id OR CodBarras=@CodBarras", conexao)
          cmdSelct.Parameters.Add("@Id", SqlDbType.NVarChar, 60).Value = row.Cells(0).Value
          cmdSelct.Parameters.Add("@CodBarras", SqlDbType.NVarChar, 60).Value = row.Cells(3).Value
          Using dr As SqlDataReader = cmdSelct.ExecuteReader
            If (dr.HasRows) Then
              Using cmdUpdate As New SqlCommand("UPDATE Produtos SET PrecoCusto=@PrecoCusto WHERE Id=@Id", conexao)
                cmdUpdate.Parameters.Add("@Id", SqlDbType.NVarChar, 60).Value = row.Cells(0).Value
                cmdUpdate.Parameters.Add("@PrecoCusto", SqlDbType.SmallMoney).Value = row.Cells(2).Value
                If (cmdUpdate.ExecuteNonQuery <= 0) Then
                  errorlist.Add("erro ao atualizar produto: " & row.Cells(0).Value)
                End If
              End Using
            Else
              Using cmdInsert As New SqlCommand("INSERT INTO Produtos (Id, Descricao, CodBarras, PrecoCusto) VALUES (@Id, @Descricao, @CodBarras, @PrecoCusto)", conexao)
                cmdInsert.Parameters.Add("@Id", SqlDbType.NVarChar, 60).Value = row.Cells(0).Value
                cmdInsert.Parameters.Add("@Descricao", SqlDbType.NVarChar, 200).Value = row.Cells(1).Value
                cmdInsert.Parameters.Add("@CodBarras", SqlDbType.NVarChar, 60).Value = row.Cells(3).Value
                cmdInsert.Parameters.Add("@PrecoCusto", SqlDbType.SmallMoney).Value = row.Cells(2).Value
                If (cmdInsert.ExecuteNonQuery <= 0) Then
                  errorlist.Add("erro ao inserir produto: " & row.Cells(0).Value)
                End If
              End Using
            End If
          End Using
        End Using
      Next
    End Using
    If errorlist.Count <> 0 Then
      MsgBox("erros!")
      Dim tmp As String = String.Empty
      For Each erro As String In errorlist
        tmp &= erro & vbNewLine
      Next
      MsgBox(tmp)
    Else
      MsgBox("update ok")
    End If
  End Sub
End Class