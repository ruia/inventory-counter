<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStocks
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.dtpData = New System.Windows.Forms.DateTimePicker()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cmdProcurarDocStock = New System.Windows.Forms.Button()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtDocStock = New System.Windows.Forms.TextBox()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.cmdLimpar = New System.Windows.Forms.Button()
    Me.lblValorDocumento = New System.Windows.Forms.Label()
    Me.dgvProdutos = New System.Windows.Forms.DataGridView()
    Me.CodProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Descicao = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Qtd = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.PrecoUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TotLinha = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.txtCod = New System.Windows.Forms.TextBox()
    Me.txtDescricao = New System.Windows.Forms.TextBox()
    Me.txtQtd = New System.Windows.Forms.TextBox()
    Me.txtPrecoUnitario = New System.Windows.Forms.TextBox()
    Me.txtTotalLinha = New System.Windows.Forms.TextBox()
    Me.cmdAdicionar = New System.Windows.Forms.Button()
    Me.chkAgrupar = New System.Windows.Forms.CheckBox()
    Me.chkAlterarPrecoProduto = New System.Windows.Forms.CheckBox()
    Me.lblUltimaGravacao = New System.Windows.Forms.Label()
    CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'dtpData
    '
    Me.dtpData.CustomFormat = "dd/MM/yyyy hh:mm"
    Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtpData.Location = New System.Drawing.Point(378, 17)
    Me.dtpData.Name = "dtpData"
    Me.dtpData.Size = New System.Drawing.Size(126, 20)
    Me.dtpData.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(8, 21)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(108, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Documento Stock Nº"
    '
    'cmdProcurarDocStock
    '
    Me.cmdProcurarDocStock.Location = New System.Drawing.Point(228, 16)
    Me.cmdProcurarDocStock.Name = "cmdProcurarDocStock"
    Me.cmdProcurarDocStock.Size = New System.Drawing.Size(58, 23)
    Me.cmdProcurarDocStock.TabIndex = 2
    Me.cmdProcurarDocStock.Text = "Procurar"
    Me.cmdProcurarDocStock.UseVisualStyleBackColor = True
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(292, 20)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(84, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Ultima Alteração"
    '
    'txtDocStock
    '
    Me.txtDocStock.Location = New System.Drawing.Point(122, 17)
    Me.txtDocStock.Name = "txtDocStock"
    Me.txtDocStock.ReadOnly = True
    Me.txtDocStock.Size = New System.Drawing.Size(100, 20)
    Me.txtDocStock.TabIndex = 4
    '
    'cmdGravar
    '
    Me.cmdGravar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdGravar.Location = New System.Drawing.Point(510, 16)
    Me.cmdGravar.Name = "cmdGravar"
    Me.cmdGravar.Size = New System.Drawing.Size(120, 23)
    Me.cmdGravar.TabIndex = 5
    Me.cmdGravar.Text = "Gravar Documento"
    Me.cmdGravar.UseVisualStyleBackColor = True
    '
    'cmdLimpar
    '
    Me.cmdLimpar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdLimpar.Location = New System.Drawing.Point(648, 16)
    Me.cmdLimpar.Name = "cmdLimpar"
    Me.cmdLimpar.Size = New System.Drawing.Size(120, 23)
    Me.cmdLimpar.TabIndex = 6
    Me.cmdLimpar.Text = "Limpar Campos"
    Me.cmdLimpar.UseVisualStyleBackColor = True
    '
    'lblValorDocumento
    '
    Me.lblValorDocumento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblValorDocumento.AutoSize = True
    Me.lblValorDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblValorDocumento.Location = New System.Drawing.Point(781, 9)
    Me.lblValorDocumento.Name = "lblValorDocumento"
    Me.lblValorDocumento.Size = New System.Drawing.Size(192, 50)
    Me.lblValorDocumento.TabIndex = 7
    Me.lblValorDocumento.Text = "Valor Documento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.00 €"
    Me.lblValorDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'dgvProdutos
    '
    Me.dgvProdutos.AllowUserToAddRows = False
    Me.dgvProdutos.AllowUserToDeleteRows = False
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
    Me.dgvProdutos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
    Me.dgvProdutos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodProduto, Me.Descicao, Me.Qtd, Me.PrecoUnitario, Me.TotLinha})
    Me.dgvProdutos.Location = New System.Drawing.Point(11, 65)
    Me.dgvProdutos.Name = "dgvProdutos"
    Me.dgvProdutos.ReadOnly = True
    Me.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvProdutos.Size = New System.Drawing.Size(957, 585)
    Me.dgvProdutos.TabIndex = 8
    '
    'CodProduto
    '
    Me.CodProduto.FillWeight = 449.2386!
    Me.CodProduto.HeaderText = "Cód. Produto"
    Me.CodProduto.Name = "CodProduto"
    Me.CodProduto.ReadOnly = True
    Me.CodProduto.Width = 150
    '
    'Descicao
    '
    Me.Descicao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.Descicao.FillWeight = 49.69296!
    Me.Descicao.HeaderText = "Descrição"
    Me.Descicao.Name = "Descicao"
    Me.Descicao.ReadOnly = True
    '
    'Qtd
    '
    Me.Qtd.FillWeight = 0.3561488!
    Me.Qtd.HeaderText = "Qtd."
    Me.Qtd.Name = "Qtd"
    Me.Qtd.ReadOnly = True
    Me.Qtd.Width = 75
    '
    'PrecoUnitario
    '
    Me.PrecoUnitario.FillWeight = 0.3561488!
    Me.PrecoUnitario.HeaderText = "Preço"
    Me.PrecoUnitario.Name = "PrecoUnitario"
    Me.PrecoUnitario.ReadOnly = True
    Me.PrecoUnitario.Width = 125
    '
    'TotLinha
    '
    Me.TotLinha.FillWeight = 0.3561488!
    Me.TotLinha.HeaderText = "Total Linha"
    Me.TotLinha.Name = "TotLinha"
    Me.TotLinha.ReadOnly = True
    Me.TotLinha.Width = 125
    '
    'txtCod
    '
    Me.txtCod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtCod.Location = New System.Drawing.Point(11, 656)
    Me.txtCod.Name = "txtCod"
    Me.txtCod.Size = New System.Drawing.Size(100, 20)
    Me.txtCod.TabIndex = 9
    '
    'txtDescricao
    '
    Me.txtDescricao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtDescricao.Location = New System.Drawing.Point(117, 656)
    Me.txtDescricao.Name = "txtDescricao"
    Me.txtDescricao.ReadOnly = True
    Me.txtDescricao.Size = New System.Drawing.Size(508, 20)
    Me.txtDescricao.TabIndex = 10
    '
    'txtQtd
    '
    Me.txtQtd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtQtd.Location = New System.Drawing.Point(631, 656)
    Me.txtQtd.Name = "txtQtd"
    Me.txtQtd.Size = New System.Drawing.Size(58, 20)
    Me.txtQtd.TabIndex = 11
    '
    'txtPrecoUnitario
    '
    Me.txtPrecoUnitario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtPrecoUnitario.Location = New System.Drawing.Point(695, 656)
    Me.txtPrecoUnitario.Name = "txtPrecoUnitario"
    Me.txtPrecoUnitario.Size = New System.Drawing.Size(88, 20)
    Me.txtPrecoUnitario.TabIndex = 12
    '
    'txtTotalLinha
    '
    Me.txtTotalLinha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtTotalLinha.Location = New System.Drawing.Point(789, 656)
    Me.txtTotalLinha.Name = "txtTotalLinha"
    Me.txtTotalLinha.ReadOnly = True
    Me.txtTotalLinha.Size = New System.Drawing.Size(88, 20)
    Me.txtTotalLinha.TabIndex = 13
    '
    'cmdAdicionar
    '
    Me.cmdAdicionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdAdicionar.Location = New System.Drawing.Point(883, 654)
    Me.cmdAdicionar.Name = "cmdAdicionar"
    Me.cmdAdicionar.Size = New System.Drawing.Size(85, 23)
    Me.cmdAdicionar.TabIndex = 15
    Me.cmdAdicionar.Text = "Adicionar"
    Me.cmdAdicionar.UseVisualStyleBackColor = True
    '
    'chkAgrupar
    '
    Me.chkAgrupar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.chkAgrupar.AutoSize = True
    Me.chkAgrupar.Checked = True
    Me.chkAgrupar.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkAgrupar.Enabled = False
    Me.chkAgrupar.Location = New System.Drawing.Point(510, 45)
    Me.chkAgrupar.Name = "chkAgrupar"
    Me.chkAgrupar.Size = New System.Drawing.Size(191, 17)
    Me.chkAgrupar.TabIndex = 16
    Me.chkAgrupar.Text = "Agrupar produtos automaticamente"
    Me.chkAgrupar.UseVisualStyleBackColor = True
    '
    'chkAlterarPrecoProduto
    '
    Me.chkAlterarPrecoProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.chkAlterarPrecoProduto.AutoSize = True
    Me.chkAlterarPrecoProduto.Checked = True
    Me.chkAlterarPrecoProduto.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkAlterarPrecoProduto.Location = New System.Drawing.Point(228, 45)
    Me.chkAlterarPrecoProduto.Name = "chkAlterarPrecoProduto"
    Me.chkAlterarPrecoProduto.Size = New System.Drawing.Size(177, 17)
    Me.chkAlterarPrecoProduto.TabIndex = 17
    Me.chkAlterarPrecoProduto.Text = "Alterar Preço Produto ao Gravar"
    Me.chkAlterarPrecoProduto.UseVisualStyleBackColor = True
    '
    'lblUltimaGravacao
    '
    Me.lblUltimaGravacao.AutoSize = True
    Me.lblUltimaGravacao.Location = New System.Drawing.Point(8, 46)
    Me.lblUltimaGravacao.Name = "lblUltimaGravacao"
    Me.lblUltimaGravacao.Size = New System.Drawing.Size(92, 13)
    Me.lblUltimaGravacao.TabIndex = 18
    Me.lblUltimaGravacao.Text = "Ultima Gravação: "
    Me.lblUltimaGravacao.Visible = False
    '
    'frmStocks
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(980, 686)
    Me.Controls.Add(Me.lblUltimaGravacao)
    Me.Controls.Add(Me.chkAlterarPrecoProduto)
    Me.Controls.Add(Me.chkAgrupar)
    Me.Controls.Add(Me.cmdAdicionar)
    Me.Controls.Add(Me.txtTotalLinha)
    Me.Controls.Add(Me.txtPrecoUnitario)
    Me.Controls.Add(Me.txtQtd)
    Me.Controls.Add(Me.txtDescricao)
    Me.Controls.Add(Me.txtCod)
    Me.Controls.Add(Me.dgvProdutos)
    Me.Controls.Add(Me.lblValorDocumento)
    Me.Controls.Add(Me.cmdLimpar)
    Me.Controls.Add(Me.cmdGravar)
    Me.Controls.Add(Me.txtDocStock)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.cmdProcurarDocStock)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.dtpData)
    Me.MinimizeBox = False
    Me.Name = "frmStocks"
    Me.Text = "Stocks"
    CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents dtpData As DateTimePicker
  Friend WithEvents Label1 As Label
  Friend WithEvents cmdProcurarDocStock As Button
  Friend WithEvents Label2 As Label
  Friend WithEvents txtDocStock As TextBox
  Friend WithEvents cmdGravar As Button
  Friend WithEvents cmdLimpar As Button
  Friend WithEvents lblValorDocumento As Label
  Friend WithEvents dgvProdutos As DataGridView
  Friend WithEvents CodProduto As DataGridViewTextBoxColumn
  Friend WithEvents Descicao As DataGridViewTextBoxColumn
  Friend WithEvents Qtd As DataGridViewTextBoxColumn
  Friend WithEvents PrecoUnitario As DataGridViewTextBoxColumn
  Friend WithEvents TotLinha As DataGridViewTextBoxColumn
  Friend WithEvents txtCod As TextBox
  Friend WithEvents txtDescricao As TextBox
  Friend WithEvents txtQtd As TextBox
  Friend WithEvents txtPrecoUnitario As TextBox
  Friend WithEvents txtTotalLinha As TextBox
  Friend WithEvents cmdAdicionar As Button
  Friend WithEvents chkAgrupar As CheckBox
  Friend WithEvents chkAlterarPrecoProduto As CheckBox
  Friend WithEvents lblUltimaGravacao As Label
End Class
