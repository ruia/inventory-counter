Public Class frmProdutos
  Dim prod As Produto

  Private Sub cmdProcurar_Click(sender As Object, e As EventArgs) Handles cmdProcurar.Click
    Using frmProcurarProdutos As New frmProcurarProdutos
      With frmProcurarProdutos
        If (.Produto = String.Empty) Then
          .ShowDialog()
          If (.Produto <> String.Empty) Then
            prod = New Produto
            prod.ObterPorId(.Produto)
            CarregarProduto(prod)
            EstadoEditaProduto()
          End If
        End If
      End With
    End Using
  End Sub



  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    EstadoInicialFrm()
    EstadoEditaProduto()
  End Sub

  Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
    prod = New Produto
    With prod
      .Id = Me.txtCodigo.Text
      .Descricao = Me.txtDescricao.Text
      .CodBarras = Me.txtCodBarras.Text
      .Categoria = Me.txtCategoria.Text
      .UnidadeMedida = Me.txtUnidadeMedida.Text
      .PrecoCusto = Conversion.Val(Me.txtPrecoCusto.Text)
      .Eliminado = Me.chkEliminado.CheckState
    End With
    If (prod.Gravar = True) Then
      MsgBox("Produto gravado com sucesso!")
      EstadoInicialFrm()
    Else
      MsgBox("Ocorreu um erro!", MsgBoxStyle.Critical)
    End If
  End Sub

  Private Sub EstadoInicialFrm()
    Me.txtCodigo.Text = String.Empty
    Me.txtDescricao.Text = String.Empty
    Me.txtCodBarras.Text = String.Empty
    Me.txtPrecoCusto.Text = String.Empty
    Me.chkEliminado.CheckState = CheckState.Unchecked

    Me.txtDescricao.Enabled = False
    Me.txtPrecoCusto.Enabled = False
    Me.chkEliminado.Enabled = False

    Me.cmdGuardar.Enabled = False
    Me.cmdAtlerarCodigo.Enabled = False

    Me.txtCodigo.Focus()
  End Sub

  Private Sub EstadoEditaProduto()
    Me.txtDescricao.Enabled = True
    Me.txtPrecoCusto.Enabled = True
    Me.chkEliminado.Enabled = True

    Me.cmdGuardar.Enabled = True
    Me.cmdAtlerarCodigo.Enabled = False

    Me.txtCodigo.Focus()
  End Sub

  Private Sub CarregarProduto(produto As Produto)
    Me.txtCodigo.Text = produto.Id
    Me.txtDescricao.Text = produto.Descricao
    Me.txtCodBarras.Text = produto.CodBarras
    Me.txtPrecoCusto.Text = produto.PrecoCusto
    Me.chkEliminado.Checked = produto.Eliminado
  End Sub

  Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
    If (e.KeyCode = Keys.Enter) And (Me.txtCodigo.Text IsNot String.Empty) Then
      prod = New Produto
      prod.ObterPorId(Me.txtCodigo.Text)
      If (prod.Erros.Count = 0) Then
        CarregarProduto(prod)
        EstadoEditaProduto()
      Else
        MsgBox(prod.Erros(0))
        prod = Nothing
        Me.txtCodigo.Text = ""
        Me.txtCodigo.Focus()
      End If
    End If
  End Sub

  Private Sub txtCodBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodBarras.KeyDown
    If (e.KeyCode = Keys.Enter) And (Me.txtCodBarras.Text IsNot String.Empty) And (Me.txtCodigo.Text Is String.Empty) Then
      prod = New Produto
      prod.ObterPorCodBarras(Me.txtCodBarras.Text)
      If (prod.Erros.Count = 0) Then
        CarregarProduto(prod)
        EstadoEditaProduto()
      Else
        MsgBox(prod.Erros(0))
        prod = Nothing
        Me.txtCodBarras.Text = ""
        Me.txtCodBarras.Focus()
      End If
    End If
  End Sub
End Class