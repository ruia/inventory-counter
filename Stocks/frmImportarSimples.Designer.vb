<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarSimples
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
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
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.btnAbrirFicheiro = New System.Windows.Forms.Button()
    Me.txtFicheiro = New System.Windows.Forms.TextBox()
    Me.ofdAbrirFicheiro = New System.Windows.Forms.OpenFileDialog()
    Me.btnImportar = New System.Windows.Forms.Button()
    Me.dgv = New System.Windows.Forms.DataGridView()
    Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.preco = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cb = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.txtTotalLinhas = New System.Windows.Forms.TextBox()
    Me.txtProdutoAtual = New System.Windows.Forms.TextBox()
    Me.txtAtualizados = New System.Windows.Forms.TextBox()
    Me.txtCriados = New System.Windows.Forms.TextBox()
    Me.txtnAct = New System.Windows.Forms.TextBox()
    Me.dgvCompare = New System.Windows.Forms.DataGridView()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnComparar = New System.Windows.Forms.Button()
    CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dgvCompare, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnAbrirFicheiro
    '
    Me.btnAbrirFicheiro.Location = New System.Drawing.Point(447, 11)
    Me.btnAbrirFicheiro.Name = "btnAbrirFicheiro"
    Me.btnAbrirFicheiro.Size = New System.Drawing.Size(104, 23)
    Me.btnAbrirFicheiro.TabIndex = 3
    Me.btnAbrirFicheiro.Text = "Abrir Ficheiro"
    Me.btnAbrirFicheiro.UseVisualStyleBackColor = True
    '
    'txtFicheiro
    '
    Me.txtFicheiro.Location = New System.Drawing.Point(12, 12)
    Me.txtFicheiro.Name = "txtFicheiro"
    Me.txtFicheiro.ReadOnly = True
    Me.txtFicheiro.Size = New System.Drawing.Size(429, 20)
    Me.txtFicheiro.TabIndex = 2
    '
    'btnImportar
    '
    Me.btnImportar.Location = New System.Drawing.Point(557, 12)
    Me.btnImportar.Name = "btnImportar"
    Me.btnImportar.Size = New System.Drawing.Size(104, 23)
    Me.btnImportar.TabIndex = 4
    Me.btnImportar.Text = "Importar"
    Me.btnImportar.UseVisualStyleBackColor = True
    '
    'dgv
    '
    Me.dgv.AllowUserToAddRows = False
    Me.dgv.AllowUserToDeleteRows = False
    Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.Descricao, Me.preco, Me.cb})
    Me.dgv.Location = New System.Drawing.Point(12, 90)
    Me.dgv.Name = "dgv"
    Me.dgv.ReadOnly = True
    Me.dgv.Size = New System.Drawing.Size(539, 462)
    Me.dgv.TabIndex = 5
    '
    'codigo
    '
    Me.codigo.HeaderText = "Codigo"
    Me.codigo.Name = "codigo"
    Me.codigo.ReadOnly = True
    '
    'Descricao
    '
    Me.Descricao.HeaderText = "Descricao"
    Me.Descricao.Name = "Descricao"
    Me.Descricao.ReadOnly = True
    '
    'preco
    '
    Me.preco.HeaderText = "Preco"
    Me.preco.Name = "preco"
    Me.preco.ReadOnly = True
    '
    'cb
    '
    Me.cb.HeaderText = "Codigo Barras"
    Me.cb.Name = "cb"
    Me.cb.ReadOnly = True
    '
    'txtTotalLinhas
    '
    Me.txtTotalLinhas.Location = New System.Drawing.Point(12, 38)
    Me.txtTotalLinhas.Name = "txtTotalLinhas"
    Me.txtTotalLinhas.ReadOnly = True
    Me.txtTotalLinhas.Size = New System.Drawing.Size(197, 20)
    Me.txtTotalLinhas.TabIndex = 6
    Me.txtTotalLinhas.Text = "Numero total de linhas: 0"
    '
    'txtProdutoAtual
    '
    Me.txtProdutoAtual.Location = New System.Drawing.Point(215, 38)
    Me.txtProdutoAtual.Name = "txtProdutoAtual"
    Me.txtProdutoAtual.ReadOnly = True
    Me.txtProdutoAtual.Size = New System.Drawing.Size(396, 20)
    Me.txtProdutoAtual.TabIndex = 7
    Me.txtProdutoAtual.Text = "linha atual"
    '
    'txtAtualizados
    '
    Me.txtAtualizados.Location = New System.Drawing.Point(12, 64)
    Me.txtAtualizados.Name = "txtAtualizados"
    Me.txtAtualizados.ReadOnly = True
    Me.txtAtualizados.Size = New System.Drawing.Size(197, 20)
    Me.txtAtualizados.TabIndex = 8
    Me.txtAtualizados.Text = "Numero total de linhas: 0"
    '
    'txtCriados
    '
    Me.txtCriados.Location = New System.Drawing.Point(215, 64)
    Me.txtCriados.Name = "txtCriados"
    Me.txtCriados.ReadOnly = True
    Me.txtCriados.Size = New System.Drawing.Size(197, 20)
    Me.txtCriados.TabIndex = 9
    Me.txtCriados.Text = "Numero total de linhas: 0"
    '
    'txtnAct
    '
    Me.txtnAct.Location = New System.Drawing.Point(418, 64)
    Me.txtnAct.Name = "txtnAct"
    Me.txtnAct.ReadOnly = True
    Me.txtnAct.Size = New System.Drawing.Size(197, 20)
    Me.txtnAct.TabIndex = 10
    Me.txtnAct.Text = "Numero total de linhas: 0"
    '
    'dgvCompare
    '
    Me.dgvCompare.AllowUserToAddRows = False
    Me.dgvCompare.AllowUserToDeleteRows = False
    Me.dgvCompare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvCompare.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
    Me.dgvCompare.Location = New System.Drawing.Point(557, 90)
    Me.dgvCompare.Name = "dgvCompare"
    Me.dgvCompare.ReadOnly = True
    Me.dgvCompare.Size = New System.Drawing.Size(539, 462)
    Me.dgvCompare.TabIndex = 11
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.HeaderText = "Descricao"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.HeaderText = "Preco"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.HeaderText = "Codigo Barras"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.ReadOnly = True
    '
    'btnComparar
    '
    Me.btnComparar.Location = New System.Drawing.Point(667, 11)
    Me.btnComparar.Name = "btnComparar"
    Me.btnComparar.Size = New System.Drawing.Size(104, 23)
    Me.btnComparar.TabIndex = 12
    Me.btnComparar.Text = "Comparar"
    Me.btnComparar.UseVisualStyleBackColor = True
    '
    'frmImportarSimples
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1111, 564)
    Me.Controls.Add(Me.btnComparar)
    Me.Controls.Add(Me.dgvCompare)
    Me.Controls.Add(Me.txtnAct)
    Me.Controls.Add(Me.txtCriados)
    Me.Controls.Add(Me.txtAtualizados)
    Me.Controls.Add(Me.txtProdutoAtual)
    Me.Controls.Add(Me.txtTotalLinhas)
    Me.Controls.Add(Me.dgv)
    Me.Controls.Add(Me.btnImportar)
    Me.Controls.Add(Me.btnAbrirFicheiro)
    Me.Controls.Add(Me.txtFicheiro)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmImportarSimples"
    Me.Text = "frmImportarSimples"
    CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dgvCompare, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents btnAbrirFicheiro As Button
  Friend WithEvents txtFicheiro As TextBox
  Friend WithEvents ofdAbrirFicheiro As OpenFileDialog
  Friend WithEvents btnImportar As Button
  Friend WithEvents dgv As DataGridView
  Friend WithEvents txtTotalLinhas As TextBox
  Friend WithEvents txtProdutoAtual As TextBox
  Friend WithEvents codigo As DataGridViewTextBoxColumn
  Friend WithEvents Descricao As DataGridViewTextBoxColumn
  Friend WithEvents preco As DataGridViewTextBoxColumn
  Friend WithEvents cb As DataGridViewTextBoxColumn
  Friend WithEvents txtAtualizados As TextBox
  Friend WithEvents txtCriados As TextBox
  Friend WithEvents txtnAct As TextBox
  Friend WithEvents dgvCompare As DataGridView
  Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
  Friend WithEvents btnComparar As Button
End Class
