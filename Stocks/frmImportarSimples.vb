Imports System.Data.SqlClient

Public Class frmImportarSimples
  Structure produto
    Dim codigo As String
    Dim descricao As String
    Dim preco As String
    Dim cb As String
  End Structure

  Dim produtos As New List(Of String)
  Dim nAtualizados As Integer = 0
  Dim nCriados As Integer = 0

  Private Sub btnAbrirFicheiro_Click(sender As Object, e As EventArgs) Handles btnAbrirFicheiro.Click
    Dim produtos As New List(Of String)
    Dim nAtualizados As Integer = 0
    Dim nCriados As Integer = 0
    Me.dgv.Rows.Clear()

    Me.ofdAbrirFicheiro.Filter = "Ficheiros CSV|*.csv"
    Me.ofdAbrirFicheiro.CheckFileExists = True
    Me.ofdAbrirFicheiro.CheckPathExists = True
    If (Me.ofdAbrirFicheiro.ShowDialog = DialogResult.OK) Then
      Me.txtFicheiro.Text = Me.ofdAbrirFicheiro.FileName
      produtos.AddRange(IO.File.ReadAllLines(Me.txtFicheiro.Text))
      Me.txtTotalLinhas.Text = "Numero total de linhas: " & produtos.Count
      Dim p As New produto



      For Each linha As String In produtos
        Me.txtProdutoAtual.Text = linha
        Dim tmp() As String = linha.Split(";")
        p.codigo = RemoveWhitespace(tmp(0).Trim)
        p.descricao = tmp(1).Trim
        p.preco = RemoveWhitespace(tmp(2).Trim.Replace(",", "."))
        p.cb = RemoveWhitespace(tmp(3).Trim)

        If p.cb = "" Then
          p.cb = p.codigo
        End If

        Me.dgv.Rows.Add(New Object() {p.codigo, p.descricao, p.preco, p.cb})



      Next
      'Me.dgv.DataSource = produtos
    End If
  End Sub

  Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
    Using conexao As New SqlConnection With {.ConnectionString = Globais.connectionString}
      'Try
      conexao.Open()

      For i As Integer = 0 To Me.dgv.RowCount - 1
        Using cmd As New SqlCommand With {.CommandText = "SELECT Id FROM Produtos WHERE Id=@Id", .Connection = conexao}
          cmd.Parameters.AddWithValue("Id", Me.dgv(0, i).Value.ToString)
          Me.txtnAct.Text = "Registo atual nº: " & i + 1
          Me.txtProdutoAtual.Text = Me.dgv(0, i).Value.ToString
          Dim dataReader As SqlDataReader = cmd.ExecuteReader
          If (dataReader.HasRows) Then
            Using cmdUpdate As New SqlCommand With {.CommandText = "UPDATE Produtos SET Descricao=@Descricao, CodBarras=@CodBarras, PrecoCusto=@PrecoCusto WHERE Id=@Id", .Connection = conexao}
              cmdUpdate.Parameters.AddWithValue("Id", Me.dgv(0, i).Value.ToString)
              cmdUpdate.Parameters.AddWithValue("Descricao", Me.dgv(1, i).Value.ToString)
              cmdUpdate.Parameters.AddWithValue("PrecoCusto", Me.dgv(2, i).Value.ToString)
              cmdUpdate.Parameters.AddWithValue("CodBarras", Me.dgv(3, i).Value.ToString)
              nAtualizados += cmdUpdate.ExecuteNonQuery()
            End Using
          Else
            Using cmdInsert As New SqlCommand With {.CommandText = "INSERT INTO Produtos (Id, Descricao, CodBarras, PrecoCusto) VALUES (@Id, @Descricao, @CodBarras, @PrecoCusto)", .Connection = conexao}
              cmdInsert.Parameters.AddWithValue("Id", Me.dgv(0, i).Value.ToString)
              cmdInsert.Parameters.AddWithValue("Descricao", Me.dgv(1, i).Value.ToString)
              cmdInsert.Parameters.AddWithValue("PrecoCusto", Me.dgv(2, i).Value.ToString)
              cmdInsert.Parameters.AddWithValue("CodBarras", Me.dgv(3, i).Value.ToString)
              nCriados += cmdInsert.ExecuteNonQuery()
            End Using
          End If

          Me.txtAtualizados.Text = "Registos atualizados: " & nAtualizados
          Me.txtCriados.Text = "Registos criados: " & nCriados
        End Using
      Next

    End Using
  End Sub

  Private Sub btnComparar_Click(sender As Object, e As EventArgs) Handles btnComparar.Click
    Using conexao As New SqlConnection With {.ConnectionString = Globais.connectionString}
      'Try
      conexao.Open()
      For i As Integer = 0 To Me.dgv.RowCount - 1
        Using cmd As New SqlCommand With {.CommandText = "SELECT * FROM Produtos WHERE Id=@Id", .Connection = conexao}
          cmd.Parameters.AddWithValue("Id", Me.dgv(0, i).Value.ToString)
          Me.txtnAct.Text = "Registo atual nº: " & i + 1
          Me.txtProdutoAtual.Text = Me.dgv(0, i).Value.ToString
          Dim dataReader As SqlDataReader = cmd.ExecuteReader
          If (dataReader.HasRows) Then
            Me.dgvCompare.Rows.Add(New Object() {dataReader(0), dataReader(1), dataReader(5), dataReader(2)})
            'Using cmdUpdate As New SqlCommand With {.CommandText = "UPDATE Produtos SET Descricao=@Descricao, CodBarras=@CodBarras, PrecoCusto=@PrecoCusto WHERE Id=@Id", .Connection = conexao}
            '  cmdUpdate.Parameters.AddWithValue("Id", Me.dgv(0, i).Value.ToString)
            '  cmdUpdate.Parameters.AddWithValue("Descricao", Me.dgv(1, i).Value.ToString)
            '  cmdUpdate.Parameters.AddWithValue("PrecoCusto", Me.dgv(2, i).Value.ToString)
            '  cmdUpdate.Parameters.AddWithValue("CodBarras", Me.dgv(3, i).Value.ToString)
            '  nAtualizados += cmdUpdate.ExecuteNonQuery()
            'End Using
          Else
            'Using cmdInsert As New SqlCommand With {.CommandText = "INSERT INTO Produtos (Id, Descricao, CodBarras, PrecoCusto) VALUES (@Id, @Descricao, @CodBarras, @PrecoCusto)", .Connection = conexao}
            '  cmdInsert.Parameters.AddWithValue("Id", Me.dgv(0, i).Value.ToString)
            '  cmdInsert.Parameters.AddWithValue("Descricao", Me.dgv(1, i).Value.ToString)
            '  cmdInsert.Parameters.AddWithValue("PrecoCusto", Me.dgv(2, i).Value.ToString)
            '  cmdInsert.Parameters.AddWithValue("CodBarras", Me.dgv(3, i).Value.ToString)
            '  nCriados += cmdInsert.ExecuteNonQuery()
            'End Using
          End If

          Me.txtAtualizados.Text = "Registos atualizados: " & nAtualizados
          Me.txtCriados.Text = "Registos criados: " & nCriados
        End Using
      Next
      'Catch ex As Exception
      '  MsgBox("Ocorreu um erro ao gravar/atualizar a base de dados" & vbNewLine & vbNewLine & ex.Message)
      'End Try
    End Using
  End Sub

  Function RemoveWhitespace(fullString As String) As String
    Return New String(fullString.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())
  End Function
End Class