Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmPrincipal
  Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
    If (configs.UI("start_maximized") = True) Then
      Me.WindowState = FormWindowState.Maximized
    Else
      Me.WindowState = FormWindowState.Normal
    End If
    SetConnectionString()
  End Sub

  Private Sub frmPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    Dim formsAbertos = System.Windows.Forms.Application.OpenForms
    If (formsAbertos.Count > 1) Then
      formsAbertos(1).Activate()
      e.Cancel = True
      If (MsgBox("Tem formularios abertos deseja sair?", vbYesNo) = MsgBoxResult.Yes) Then
        e.Cancel = False
      End If
    End If
  End Sub

#Region "Menus"
  Private Sub mnuProdutos_Click(sender As Object, e As EventArgs) Handles mnuProdutos.Click
    With frmProdutos
      .ShowInTaskbar = False
      .Owner = Me
      .Show()
    End With
  End Sub

  Private Sub mnuImportarExportar_Click(sender As Object, e As EventArgs) Handles mnuImportar.Click
    Dim id As String = InputBox("cod")
        If (id = "password") Then
            With frmImportar
                .ShowInTaskbar = False
                .Owner = Me
                .Show()
            End With
        End If
    End Sub

  Private Sub mnuStocks_Click(sender As Object, e As EventArgs) Handles mnuStocks.Click
    With frmStocks
      .ShowInTaskbar = False
      .Owner = Me
      .Show()
      .txtCod.Focus()
    End With
  End Sub

    Private Sub mnuExportarFicheiroInventario_Click(sender As Object, e As EventArgs) Handles mnuExportarFicheiroInventario.Click
    'ProductCategory;ProductCode;ProductDescription;ProductNumberCode;ClosingStockQuantity;UnitOfMeasure
    'M;1234;Batatas;11111115;500,4567;Kg
    Dim sfd As New SaveFileDialog
    sfd.Filter = "Ficheiros CSV|*.csv"
    Dim linhas As New List(Of String)
    frmListaDocumentosStock.Text = "Escolha o documento de stock a Exportar"
    frmListaDocumentosStock.ShowDialog()
    If (frmListaDocumentosStock.DialogResult = DialogResult.OK) Then
      'MsgBox(frmListaDocumentosStock.IdDocumentoStock)
      linhas.Add("ProductCategory;ProductCode;ProductDescription;ProductNumberCode;ClosingStockQuantity;UnitOfMeasure")
      Using conexao As New SqlConnection(Globais.connectionString)
        conexao.Open()
        Using cmdSelect As New SqlCommand("SELECT p.Categoria, p.Id,p.Descricao,p.CodBarras,sd.Qtd, p.UnidadeMedida FROM StocksDetalhes sd INNER JOIN Produtos p ON p.Id = sd.IdProduto WHERE sd.IdStock = @IdStock", conexao)
          cmdSelect.Parameters.Add("@IdStock", SqlDbType.NVarChar, 60).Value = frmListaDocumentosStock.IdDocumentoStock
          Using dr As SqlDataReader = cmdSelect.ExecuteReader
            If (dr.HasRows) Then
              While (dr.Read)
                linhas.Add(dr(0) & ";" & dr(1) & ";" & dr(2) & ";" & dr(3) & ";" & dr(4) & ";" & dr(5))
              End While
              If (sfd.ShowDialog = DialogResult.OK) Then
                IO.File.WriteAllLines(sfd.FileName, linhas)
                MsgBox("Exportação concluida com sucesso")
              End If
            Else
              MsgBox("Não existem linhas nesse documento de stock!")

              Exit Sub
            End If
          End Using
        End Using
      End Using
    End If
  End Sub

  Private Sub ImportarSimplesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarSimplesToolStripMenuItem.Click
    Dim id As String = InputBox("cod")
    If (id = "q0k5g7") Then
      With frmImportarSimples
        .ShowInTaskbar = False
        .Owner = Me
        .Show()
      End With
    End If
  End Sub

  Private Sub ExportarFicheiroContabilidadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarFicheiroContabilidadeToolStripMenuItem.Click
    'ProductCategory;ProductCode;ProductDescription;ProductNumberCode;ClosingStockQuantity;UnitOfMeasure;PrecoCusto
    'M;1234;Batatas;11111115;500,4567;Kg;12.5
    Dim sfd As New SaveFileDialog
    sfd.Filter = "Ficheiros CSV|*.csv"
    Dim linhas As New List(Of String)
    frmListaDocumentosStock.Text = "Escolha o documento de stock a Exportar"
    frmListaDocumentosStock.ShowDialog()
    If (frmListaDocumentosStock.DialogResult = DialogResult.OK) Then
      'MsgBox(frmListaDocumentosStock.IdDocumentoStock)
      linhas.Add("ProductCategory;ProductCode;ProductDescription;ProductNumberCode;ClosingStockQuantity;UnitOfMeasure;PrecoCusto")
      Using conexao As New SqlConnection(Globais.connectionString)
        conexao.Open()
        Using cmdSelect As New SqlCommand("SELECT p.Categoria, p.Id,p.Descricao,p.CodBarras,sd.Qtd, p.UnidadeMedida, p.PrecoCusto FROM StocksDetalhes sd INNER JOIN Produtos p ON p.Id = sd.IdProduto WHERE sd.IdStock = @IdStock", conexao)
          cmdSelect.Parameters.Add("@IdStock", SqlDbType.NVarChar, 60).Value = frmListaDocumentosStock.IdDocumentoStock
          Using dr As SqlDataReader = cmdSelect.ExecuteReader
            If (dr.HasRows) Then
              While (dr.Read)
                linhas.Add(dr(0) & ";" & dr(1) & ";" & dr(2) & ";" & dr(3) & ";" & dr(4) & ";" & dr(5) & ";" & dr(6))
              End While
              If (sfd.ShowDialog = DialogResult.OK) Then
                IO.File.WriteAllLines(sfd.FileName, linhas)
                MsgBox("Exportação concluida com sucesso")
              End If
            Else
              MsgBox("Não existem linhas nesse documento de stock!")

              Exit Sub
            End If
          End Using
        End Using
      End Using
    End If
  End Sub

#End Region
End Class