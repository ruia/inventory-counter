Imports System.Data.SqlClient

Public Class frmStocks
  Dim prodLinha As New Produto
  Dim linhaEditada As Boolean = False

  Private Sub CriaOuAtualiza()
    'TODO: alterar codigo de forma a fazer o update correcto se não estiver a agrupar... id detalhe na datagrid view???
    If (Me.dgvProdutos.RowCount <> 0) Then
      Me.cmdGravar.Enabled = False
      'grava documento
      'cria ou atualiza
      '--with cte
      '--as
      '--( select row_number() OVER(order by Id) as RowID, * from StocksDetalhes 
      '--) delete from cte where RowId =

      Dim SqlInsert As String = "INSERT INTO Stocks (Data) VALUES (@Data)"
      Dim SqlInsertDetalhes As String = "INSERT INTO StocksDetalhes (IdStock, IdProduto, Qtd) VALUES (@IdStock, @IdProduto, @Qtd)"
      'Dim SqlUpdateDetalhes As String = "UPDATE StocksDetalhes SET Qtd=@Qtd WHERE IdStock=@IdStock AND IdProduto=@IdProduto"
      Dim Sql As String = SqlInsertDetalhes
      Dim LastId As Long

      Using conexao As New SqlConnection(Globais.connectionString)
        conexao.Open()
        If (Me.txtDocStock.Text = String.Empty) Then 'cria doc stock
          Using comando As New SqlCommand(SqlInsert, conexao)
            comando.Parameters.Add("@Data", SqlDbType.Date).Value = Me.dtpData.Value.Date
            If (comando.ExecuteNonQuery <= 0) Then
              MsgBox("erro ao gravar o documento (Stock)")
              Me.cmdGravar.Enabled = True
              Exit Sub
            Else 'gravou doc stock, gravar detalhes

            End If
            Sql = SqlInsertDetalhes
            LastId = UltimoIdStock()
            Me.txtDocStock.Text = LastId
          End Using
        Else
          LastId = Convert.ToInt64(Me.txtDocStock.Text)
        End If


      End Using

      Me.cmdGravar.Enabled = True
      MsgBox("Documento Guardado!")
    End If
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs, Optional reset As Boolean = False) Handles cmdGravar.Click
    GravarDocumento()

#Region "CODIGO VELHO"
    '  CODIGO VELHO

    '  Using cmdDelete As New SqlCommand("DELETE FROM StocksDetalhes WHERE IdStock=@IdStock", conexao) 'dirty hack
    '    cmdDelete.Parameters.Add("@IdStock", SqlDbType.BigInt).Value = Me.txtDocStock.Text
    '    cmdDelete.ExecuteNonQuery()
    '    Using comando As New SqlCommand(Sql, conexao)
    '      For Each dgvRow As DataGridViewRow In Me.dgvProdutos.Rows
    '        With comando.Parameters
    '          .Clear()
    '          .Add("@IdStock", SqlDbType.BigInt).Value = LastId
    '          .Add("@IdProduto", SqlDbType.NVarChar, 60).Value = dgvRow.Cells("CodProduto").Value
    '          .Add("@Qtd", SqlDbType.Int).Value = dgvRow.Cells("Qtd").Value
    '        End With
    '        If (comando.ExecuteNonQuery <= 0) Then
    '          MsgBox("erro ao gravar o documento (Detalhes Stocks - Prod: " & dgvRow.Cells("CodProduto").Value & ")")
    '          Me.cmdGravar.Enabled = True
    '          Exit Sub
    '        End If
    '      Next
    '    End Using
    '  End Using

    'End Using
#End Region

  End Sub

  Private Sub GravarDocumento(Optional ByVal reset As Boolean = False)
    If (Me.dgvProdutos.RowCount <> 0) Then
      Me.cmdGravar.Enabled = False
      Dim SqlInsert As String = "INSERT INTO Stocks (Data, DataUltimaAlteracao, Eliminado) VALUES (@Data, @DataUltimaAlteracao, @Eliminado)"
      Dim SqlInsertDetalhes As String = "INSERT INTO StocksDetalhes (IdStock, IdProduto, Qtd) VALUES (@IdStock, @IdProduto, @Qtd)"
      Dim SqlUpdateDetalhes As String = "UPDATE StocksDetalhes SET Qtd=@Qtd WHERE IdStock=@IdStock AND IdProduto=@IdProduto"
      Dim Sql As String = SqlInsertDetalhes
      Dim IdDocStock As Long

      Using conexao As New SqlConnection(Globais.connectionString)
        conexao.Open()
        If (Me.txtDocStock.Text = String.Empty) Then
          'cria doc stock
          Using comando As New SqlCommand(SqlInsert, conexao)
            comando.Parameters.Add("@Data", SqlDbType.DateTime).Value = Me.dtpData.Value.Date
            comando.Parameters.Add("@DataUltimaAlteracao", SqlDbType.DateTime).Value = Me.dtpData.Value.Date
            comando.Parameters.Add("@Eliminado", SqlDbType.Bit).Value = False
            If (comando.ExecuteNonQuery <= 0) Then
              MsgBox("erro ao gravar o documento (Stock)")
              Me.cmdGravar.Enabled = True
              Exit Sub
            End If
            Sql = SqlInsertDetalhes
            IdDocStock = UltimoIdStock()
            Me.txtDocStock.Text = IdDocStock
          End Using
        Else
          IdDocStock = Convert.ToInt64(Me.txtDocStock.Text)
          Using cmdUpdateStock As New SqlCommand("UPDATE Stocks SET DataUltimaAlteracao=@DataUltimaAlteracao WHERE Id=@Id", conexao)
            cmdUpdateStock.Parameters.Add("@Id", SqlDbType.BigInt).Value = IdDocStock
            cmdUpdateStock.Parameters.Add("@DataUltimaAlteracao", SqlDbType.DateTime).Value = DateTime.Now
            If (cmdUpdateStock.ExecuteNonQuery <= 0) Then
              MsgBox("erro ao atualizar documento (Stock)")
              Me.cmdGravar.Enabled = True
              Exit Sub
            End If
          End Using
        End If

        Using cmd As New SqlCommand("SELECT * FROM StocksDetalhes WHERE IdStock=@IdStock AND IdProduto=@IdProduto", conexao)
          cmd.Parameters.Add("@IdStock", SqlDbType.BigInt).Value = IdDocStock
          cmd.Parameters.Add("@IdProduto", SqlDbType.NVarChar, 60)
          For Each dgvRow As DataGridViewRow In Me.dgvProdutos.Rows
            cmd.Parameters.Item("@IdProduto").Value = dgvRow.Cells("CodProduto").Value
            Using DataReader As SqlDataReader = cmd.ExecuteReader
              If (DataReader.HasRows) Then 'existe produto no stock atualiza
                Using cmdUpdate As New SqlCommand(SqlUpdateDetalhes, conexao)
                  cmdUpdate.Parameters.Add("@IdStock", SqlDbType.BigInt).Value = IdDocStock
                  cmdUpdate.Parameters.Add("@IdProduto", SqlDbType.NVarChar, 60).Value = dgvRow.Cells("CodProduto").Value
                  cmdUpdate.Parameters.Add("@Qtd", SqlDbType.Int).Value = dgvRow.Cells("Qtd").Value
                  If (cmdUpdate.ExecuteNonQuery <= 0) Then
                    MsgBox("erro ao gravar o documento (Detalhes Stocks - Prod: " & dgvRow.Cells("CodProduto").Value & ")")
                    Me.cmdGravar.Enabled = True
                    Exit Sub
                  End If
                End Using
              Else 'cria nova linha no documento
                Using cmdInsert As New SqlCommand(SqlInsertDetalhes, conexao)
                  cmdInsert.Parameters.Add("@IdStock", SqlDbType.BigInt).Value = IdDocStock
                  cmdInsert.Parameters.Add("@IdProduto", SqlDbType.NVarChar, 60).Value = dgvRow.Cells("CodProduto").Value
                  cmdInsert.Parameters.Add("@Qtd", SqlDbType.Int).Value = dgvRow.Cells("Qtd").Value
                  If (cmdInsert.ExecuteNonQuery <= 0) Then
                    MsgBox("erro ao gravar o documento (Detalhes Stocks - Prod: " & dgvRow.Cells("CodProduto").Value & ")")
                    Me.cmdGravar.Enabled = True
                    Exit Sub
                  End If
                End Using
              End If
            End Using
          Next
        End Using
      End Using

      Me.cmdGravar.Enabled = True
      If (reset <> False) Then
        If (MsgBox("Documento Guardado! Deseja inicializar o formulario?", vbYesNo) = MsgBoxResult.Yes) Then
          Me.InicializaForm()
        End If
      Else
        Me.lblUltimaGravacao.Visible = True
        Me.lblUltimaGravacao.Text = "Ultima Gravação: " & DateTime.Now
      End If
    End If
  End Sub

  Private Sub cmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    If (Me.txtDocStock.Text IsNot String.Empty) Then
      If (MsgBox("Documento não guardado pretende continuar?", vbYesNo) = vbNo) Then
        Exit Sub
      End If
    End If
    InicializaForm()
  End Sub

  Private Sub txtCod_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCod.KeyDown
    If (e.KeyCode = Keys.Enter) Then
      If (Me.txtCod.Text = String.Empty) Then
        Using frmProcurarProdutos As New frmProcurarProdutos
          With frmProcurarProdutos
            If (.Produto = String.Empty) Then
              .ShowDialog()
              If (.Produto <> String.Empty) Then
                prodLinha = New Produto
                prodLinha.ObterPorId(.Produto)
              Else
                Exit Sub
              End If
            End If
          End With
        End Using
      Else
        prodLinha = New Produto
        prodLinha.ObterPorId(Me.txtCod.Text)
        If (prodLinha.Id = String.Empty) Then
          prodLinha = New Produto
          prodLinha.ObterPorCodBarras(Me.txtCod.Text)
          If (prodLinha.Id = String.Empty) Then
            prodLinha = New Produto
            prodLinha.Erros.Add("Produto não encontrado!")
          End If
        End If
      End If
      'If (prodLinha IsNot Nothing) And (prodLinha.Id = String.Empty) Then
      '  MsgBox("Produto não encontrado!")
      '  Exit Sub
      'End If
      If (prodLinha.Erros.Count > 0) Then
        MsgBox("Erro: " & prodLinha.Erros(0))
        Exit Sub
      Else
        Me.txtCod.Text = prodLinha.Id
        Me.txtDescricao.Text = prodLinha.Descricao
        Me.txtPrecoUnitario.Text = Math.Round(prodLinha.PrecoCusto, 2)
        Me.txtTotalLinha.Text = Val(Me.txtQtd.Text) * Me.txtPrecoUnitario.Text
        Me.txtQtd.SelectAll()
        Me.txtQtd.Focus()
      End If
    End If
  End Sub

  Private Sub txtQtd_TextChanged(sender As Object, e As EventArgs) Handles txtQtd.TextChanged
    Me.txtTotalLinha.Text = Val(Me.txtQtd.Text) * Decimal.Parse(Me.txtPrecoUnitario.Text)
  End Sub

  Private Sub txtPrecoUnitario_TextChanged(sender As Object, e As EventArgs) Handles txtPrecoUnitario.TextChanged
    If (Me.txtPrecoUnitario.Text <> "") Then
      Me.txtTotalLinha.Text = Val(Me.txtQtd.Text) * Me.txtPrecoUnitario.Text
    End If
  End Sub

  Private Sub txtPrecoUnitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecoUnitario.KeyPress
    If e.KeyChar = "." Then
      e.KeyChar = ","
    End If
  End Sub

  Private Sub txtQtd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQtd.KeyDown
    If (e.KeyCode = Keys.Enter) And Val(Me.txtQtd.Text) > 0 Then
      If (Me.chkAlterarPrecoProduto.Checked) Then
        Me.txtPrecoUnitario.Focus()
      Else
        Me.cmdAdicionar.PerformClick()
      End If
    End If
  End Sub

  Private Sub txtPrecoUnitario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrecoUnitario.KeyDown
    If (e.KeyCode = Keys.Enter) And (Me.chkAlterarPrecoProduto.Checked) Then
      Me.cmdAdicionar.PerformClick()
    End If
  End Sub


  Private Sub chkAlterarPrecoProduto_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlterarPrecoProduto.CheckedChanged
    Me.txtPrecoUnitario.ReadOnly = Not Me.chkAlterarPrecoProduto.Checked
  End Sub

  Private Sub cmdAdicionar_Click(sender As Object, e As EventArgs) Handles cmdAdicionar.Click
    If ((Me.txtCod.Text <> "") And (Me.txtDescricao.Text <> "") And (Me.txtQtd.Text <> "") And (Me.txtPrecoUnitario.Text <> "")) Then
      If (Me.dgvProdutos.RowCount = 0) Or (Me.chkAgrupar.Checked = False) Then
        Me.dgvProdutos.Rows.Add(Me.txtCod.Text, Me.txtDescricao.Text, Me.txtQtd.Text, Me.txtPrecoUnitario.Text, Me.txtTotalLinha.Text)
      Else
        If (Me.chkAgrupar.Checked = True) Then
          Dim encontrou As Boolean = False
          For Each dgvRow As DataGridViewRow In Me.dgvProdutos.Rows
            If (dgvRow.Cells("CodProduto").Value = Me.txtCod.Text) Then
              If (linhaEditada) Then
                dgvRow.Cells("Qtd").Value = Val(Me.txtQtd.Text)
              Else
                dgvRow.Cells("Qtd").Value += Val(Me.txtQtd.Text)
              End If
              dgvRow.Cells("TotLinha").Value = dgvRow.Cells("Qtd").Value * dgvRow.Cells("PrecoUnitario").Value
              encontrou = True
              Exit For
            End If
          Next
          If (encontrou = False) Then
            Me.dgvProdutos.Rows.Add(Me.txtCod.Text, Me.txtDescricao.Text, Me.txtQtd.Text, Me.txtPrecoUnitario.Text, Me.txtTotalLinha.Text)
          End If
        End If
      End If
      If (chkAlterarPrecoProduto.Checked) Then
        Using conexao As New SqlConnection(Globais.connectionString)
          conexao.Open()
          Using cmdUpdate As New SqlCommand("UPDATE Produtos SET PrecoCusto=@PrecoCusto WHERE Id=@Id", conexao)
            cmdUpdate.Parameters.Add("@Id", SqlDbType.NVarChar, 60).Value = Me.dgvProdutos.Rows(Me.dgvProdutos.RowCount - 1).Cells(0).Value
            cmdUpdate.Parameters.Add("@PrecoCusto", SqlDbType.SmallMoney).Value = Me.dgvProdutos.Rows(Me.dgvProdutos.RowCount - 1).Cells(3).Value
            cmdUpdate.ExecuteNonQuery()
          End Using
        End Using
      End If
      GravarDocumento()
      linhaEditada = False
      AtualizaTotalDocumento()
      LimpaTxtProdLinha()
      Me.dgvProdutos.FirstDisplayedScrollingRowIndex = Me.dgvProdutos.RowCount - 1
    End If
  End Sub

  Private Sub chkAgrupar_CheckedChanged(sender As Object, e As EventArgs) Handles chkAgrupar.CheckedChanged
    Me.txtCod.Focus()
  End Sub

  Private Sub txtTotalLinha_TextChanged(sender As Object, e As EventArgs) Handles txtTotalLinha.TextChanged
    If (Me.txtTotalLinha.Text IsNot String.Empty) Then
      Me.txtTotalLinha.Text = FormatNumber(Me.txtTotalLinha.Text, 2)
    End If
  End Sub

  Private Sub dgvProdutos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvProdutos.KeyDown
    If (e.KeyCode = Keys.Delete) Then
      For Each dgvRow As DataGridViewRow In Me.dgvProdutos.SelectedRows
        Me.dgvProdutos.Rows.Remove(dgvRow)
      Next
      GravarDocumento()
      AtualizaTotalDocumento()
    End If
  End Sub

  Private Sub InicializaForm()
    Me.txtDocStock.Text = String.Empty
    Me.dtpData.Value = DateTime.Now
    Me.lblValorDocumento.Text = "Valor Documento" & vbNewLine & "0.00 €"
    Me.dgvProdutos.Rows.Clear()
    Me.txtCod.Text = String.Empty
    Me.txtDescricao.Text = String.Empty
    Me.txtQtd.Text = String.Empty
    Me.txtPrecoUnitario.Text = String.Empty
    Me.txtTotalLinha.Text = String.Empty
    Me.chkAgrupar.Checked = True
    Me.chkAlterarPrecoProduto.Checked = False
    Me.txtCod.Focus()
  End Sub

  Private Sub LimpaTxtProdLinha()
    Me.txtCod.Text = String.Empty
    Me.txtDescricao.Text = String.Empty
    Me.txtQtd.Text = String.Empty
    Me.txtPrecoUnitario.Text = 0.00
    Me.txtTotalLinha.Text = 0.00
    Me.txtCod.Focus()
  End Sub

  Private Sub AtualizaTotalDocumento()
    Dim tot As Decimal = 0.00
    For Each dgvRow As DataGridViewRow In Me.dgvProdutos.Rows
      tot += Convert.ToDecimal(dgvRow.Cells("TotLinha").Value)
    Next
    Me.lblValorDocumento.Text = "Valor Documento" & vbNewLine & FormatNumber(tot, 2) & " €"
  End Sub

  Private Function UltimoIdStock() As Long
    Dim SQL As String = "SELECT MAX(Id) AS Id FROM Stocks"
    Using conexao As New SqlConnection(Globais.connectionString)
      Using comando As New SqlCommand(SQL, conexao)
        conexao.Open()
        Using dataReader As SqlDataReader = comando.ExecuteReader
          If (dataReader.HasRows) Then
            dataReader.Read()
            Return dataReader("Id")
          End If
        End Using
      End Using
    End Using

    Return 0
  End Function

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

  Private Sub cmdProcurarDocStock_Click(sender As Object, e As EventArgs) Handles cmdProcurarDocStock.Click
    frmListaDocumentosStock.ShowDialog()
    If (frmListaDocumentosStock.DialogResult = DialogResult.OK) Then
      If (frmListaDocumentosStock.IdDocumentoStock <> -1) Then
        Dim id As String = frmListaDocumentosStock.IdDocumentoStock
        'Dim id As String = InputBox("Id do documento")
        'If (id <> String.Empty) Then
        Dim data As Date
        Dim tmpProduto As Produto

        If (ExisteIdStock(id)) Then
          InicializaForm()
          Using conexao As New SqlConnection(Globais.connectionString)
            conexao.Open()
            Using comando As New SqlCommand("SELECT DataUltimaAlteracao FROM Stocks WHERE Id=@Id", conexao)
              comando.Parameters.Add("@Id", SqlDbType.BigInt).Value = id
              Dim dataReader As SqlDataReader = comando.ExecuteReader
              dataReader.Read()
              data = dataReader("DataUltimaAlteracao")
              Me.txtDocStock.Text = id
              Me.dtpData.Value = data
            End Using
            Using comando As New SqlCommand("SELECT * FROM StocksDetalhes WHERE IdStock=@IdStock", conexao)
              comando.Parameters.Add("@IdStock", SqlDbType.BigInt).Value = id
              Dim dataReader As SqlDataReader = comando.ExecuteReader
              If (dataReader.HasRows) Then
                While dataReader.Read
                  tmpProduto = New Produto
                  tmpProduto.ObterPorId(dataReader("IdProduto"))
                  Me.dgvProdutos.Rows.Add(tmpProduto.Id, tmpProduto.Descricao, dataReader("Qtd"), tmpProduto.PrecoCusto, FormatNumber((dataReader("Qtd") * tmpProduto.PrecoCusto), 2))
                End While
                AtualizaTotalDocumento()
                Me.dgvProdutos.FirstDisplayedScrollingRowIndex = Me.dgvProdutos.RowCount - 1
                Me.txtCod.Focus()
              End If
            End Using
          End Using
        Else
          MsgBox("Não existe documento")
        End If
      End If
    End If
  End Sub

  Private Sub dgvProdutos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvProdutos.CellMouseDoubleClick
    Select Case e.ColumnIndex
      Case 2
        LimpaTxtProdLinha()
        Me.txtCod.Text = Me.dgvProdutos.Item(0, e.RowIndex).Value
        Me.txtDescricao.Text = Me.dgvProdutos.Item(1, e.RowIndex).Value
        Me.txtQtd.Text = Me.dgvProdutos.Item(2, e.RowIndex).Value
        Me.txtPrecoUnitario.Text = Me.dgvProdutos.Item(3, e.RowIndex).Value
        Me.txtTotalLinha.Text = Me.dgvProdutos.Item(4, e.RowIndex).Value
        linhaEditada = True
        Me.txtQtd.Focus()
      Case 3
        LimpaTxtProdLinha()
        Me.txtCod.Text = Me.dgvProdutos.Item(0, e.RowIndex).Value
        Me.txtDescricao.Text = Me.dgvProdutos.Item(1, e.RowIndex).Value
        Me.txtQtd.Text = Me.dgvProdutos.Item(2, e.RowIndex).Value
        Me.txtPrecoUnitario.Text = Me.dgvProdutos.Item(3, e.RowIndex).Value
        Me.txtTotalLinha.Text = Me.dgvProdutos.Item(4, e.RowIndex).Value
        linhaEditada = True
        Me.txtPrecoUnitario.Focus()
    End Select
  End Sub

End Class