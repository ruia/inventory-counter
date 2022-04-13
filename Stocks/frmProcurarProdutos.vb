Public Class frmProcurarProdutos
  Private Structure PropriedadesCampos
    Dim Nome As String
    Dim Tamanho As String
    Dim ModoAutoSize As DataGridViewAutoSizeColumnMode
    Dim Formato As DataGridViewCellStyle
  End Structure

  Private Produtos As New Produto
  Private dvProdutos As DataView
  Public Property Produto As String = String.Empty

  Private Sub frmProcurarProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.Show()
    ResetForm()
    dvProdutos = New DataView(Produtos.ObterTodos)
    InicializaDataGridView(dvProdutos.Table.Columns)
  End Sub

  Private Sub txtProdutoProcurar_TextChanged(sender As Object, e As EventArgs) Handles txtProdutoProcurar.TextChanged
    dvProdutos.RowFilter = "Id LIKE '%" & Me.txtProdutoProcurar.Text & "%' OR Descricao LIKE '%" & Me.txtProdutoProcurar.Text & "%'"
  End Sub

  Private Sub dgvProdutos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvProdutos.CellMouseDoubleClick
    _Produto = dgvProdutos.Item(0, e.RowIndex).Value
    Me.Close()
  End Sub

  Private Sub chkMostrarEliminados_CheckedChanged(sender As Object, e As EventArgs) Handles chkMostrarEliminados.CheckedChanged
    ResetForm()
    dvProdutos = New DataView(Produtos.ObterTodos(Me.chkMostrarEliminados.Checked))
    InicializaDataGridView(dvProdutos.Table.Columns)
  End Sub

  Private Sub ResetForm()
    Me.txtProdutoProcurar.Text = String.Empty
    Me.dgvProdutos.Columns.Clear()
    Me.txtProdutoProcurar.Focus()
  End Sub

  Private Sub InicializaDataGridView(Colunas As DataColumnCollection)
    Dim CamposProdutos As New Dictionary(Of String, PropriedadesCampos) From {
    {"Id", New PropriedadesCampos With {.Nome = "Cód. Produto", .Tamanho = 100, .ModoAutoSize = DataGridViewAutoSizeColumnMode.NotSet}},
    {"Descricao", New PropriedadesCampos With {.Nome = "Descrição", .Tamanho = 200, .ModoAutoSize = DataGridViewAutoSizeColumnMode.Fill}},
    {"CodBarras", New PropriedadesCampos With {.Nome = "Cód. Barras", .Tamanho = 100, .ModoAutoSize = DataGridViewAutoSizeColumnMode.NotSet}},
    {"Categoria", New PropriedadesCampos With {.Nome = "Cat.", .Tamanho = 30, .ModoAutoSize = DataGridViewAutoSizeColumnMode.NotSet}},
    {"UnidadeMedida", New PropriedadesCampos With {.Nome = "U.M.", .Tamanho = 60, .ModoAutoSize = DataGridViewAutoSizeColumnMode.NotSet}},
    {"PrecoCusto", New PropriedadesCampos With {.Nome = "P.C.", .Tamanho = 50, .ModoAutoSize = DataGridViewAutoSizeColumnMode.NotSet, .Formato = New DataGridViewCellStyle With {.Format = "0.00"}}},
    {"Eliminado", New PropriedadesCampos With {.Nome = "Elimindao", .Tamanho = 50, .ModoAutoSize = DataGridViewAutoSizeColumnMode.NotSet}}
    }

    Me.dgvProdutos.AutoGenerateColumns = False
    Dim tmpColunaDgv As DataGridViewColumn
    For Each Coluna As DataColumn In Colunas
      If (Coluna.ColumnName <> "Eliminado") Then
        tmpColunaDgv = New DataGridViewTextBoxColumn
      Else
        tmpColunaDgv = New DataGridViewCheckBoxColumn
        tmpColunaDgv.ReadOnly = True
      End If
      tmpColunaDgv.HeaderText = CamposProdutos(Coluna.ColumnName).Nome
      tmpColunaDgv.Width = CamposProdutos(Coluna.ColumnName).Tamanho
      tmpColunaDgv.AutoSizeMode = CamposProdutos(Coluna.ColumnName).ModoAutoSize
      tmpColunaDgv.DataPropertyName = Coluna.ColumnName
      tmpColunaDgv.DefaultCellStyle = CamposProdutos(Coluna.ColumnName).Formato
      Me.dgvProdutos.Columns.Add(tmpColunaDgv)
    Next
    Me.dgvProdutos.DataSource = dvProdutos
  End Sub
End Class