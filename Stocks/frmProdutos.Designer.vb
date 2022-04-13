<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdutos
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtCodigo = New System.Windows.Forms.TextBox()
    Me.txtDescricao = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtUnidadeMedida = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtCodBarras = New System.Windows.Forms.TextBox()
    Me.txtPrecoCusto = New System.Windows.Forms.TextBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.chkEliminado = New System.Windows.Forms.CheckBox()
    Me.cmdProcurar = New System.Windows.Forms.Button()
    Me.cmdNovo = New System.Windows.Forms.Button()
    Me.cmdGuardar = New System.Windows.Forms.Button()
    Me.cmdAtlerarCodigo = New System.Windows.Forms.Button()
    Me.txtCategoria = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(13, 15)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(69, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Cód. Produto"
    '
    'txtCodigo
    '
    Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtCodigo.Location = New System.Drawing.Point(88, 12)
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.Size = New System.Drawing.Size(305, 20)
    Me.txtCodigo.TabIndex = 1
    '
    'txtDescricao
    '
    Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtDescricao.Enabled = False
    Me.txtDescricao.Location = New System.Drawing.Point(88, 38)
    Me.txtDescricao.Multiline = True
    Me.txtDescricao.Name = "txtDescricao"
    Me.txtDescricao.Size = New System.Drawing.Size(452, 75)
    Me.txtDescricao.TabIndex = 2
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(13, 41)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(55, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Descrição"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(13, 122)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(62, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Cód. Barras"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(13, 148)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(52, 13)
    Me.Label4.TabIndex = 6
    Me.Label4.Text = "Categoria"
    '
    'txtUnidadeMedida
    '
    Me.txtUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtUnidadeMedida.Location = New System.Drawing.Point(291, 145)
    Me.txtUnidadeMedida.Name = "txtUnidadeMedida"
    Me.txtUnidadeMedida.ReadOnly = True
    Me.txtUnidadeMedida.Size = New System.Drawing.Size(102, 20)
    Me.txtUnidadeMedida.TabIndex = 98
    Me.txtUnidadeMedida.TabStop = False
    Me.txtUnidadeMedida.Text = "UNIDADE"
    Me.txtUnidadeMedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(200, 148)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(85, 13)
    Me.Label5.TabIndex = 8
    Me.Label5.Text = "Unidade Medida"
    '
    'txtCodBarras
    '
    Me.txtCodBarras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtCodBarras.Location = New System.Drawing.Point(88, 119)
    Me.txtCodBarras.Name = "txtCodBarras"
    Me.txtCodBarras.Size = New System.Drawing.Size(305, 20)
    Me.txtCodBarras.TabIndex = 3
    '
    'txtPrecoCusto
    '
    Me.txtPrecoCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtPrecoCusto.Enabled = False
    Me.txtPrecoCusto.Location = New System.Drawing.Point(88, 171)
    Me.txtPrecoCusto.Name = "txtPrecoCusto"
    Me.txtPrecoCusto.Size = New System.Drawing.Size(102, 20)
    Me.txtPrecoCusto.TabIndex = 4
    Me.txtPrecoCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(13, 174)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(65, 13)
    Me.Label6.TabIndex = 11
    Me.Label6.Text = "Preço Custo"
    '
    'chkEliminado
    '
    Me.chkEliminado.AutoSize = True
    Me.chkEliminado.Enabled = False
    Me.chkEliminado.Location = New System.Drawing.Point(302, 173)
    Me.chkEliminado.Name = "chkEliminado"
    Me.chkEliminado.Size = New System.Drawing.Size(71, 17)
    Me.chkEliminado.TabIndex = 5
    Me.chkEliminado.Text = "Eliminado"
    Me.chkEliminado.UseVisualStyleBackColor = True
    '
    'cmdProcurar
    '
    Me.cmdProcurar.Location = New System.Drawing.Point(422, 10)
    Me.cmdProcurar.Name = "cmdProcurar"
    Me.cmdProcurar.Size = New System.Drawing.Size(118, 23)
    Me.cmdProcurar.TabIndex = 6
    Me.cmdProcurar.Text = "Procurar"
    Me.cmdProcurar.UseVisualStyleBackColor = True
    '
    'cmdNovo
    '
    Me.cmdNovo.Location = New System.Drawing.Point(422, 117)
    Me.cmdNovo.Name = "cmdNovo"
    Me.cmdNovo.Size = New System.Drawing.Size(118, 23)
    Me.cmdNovo.TabIndex = 7
    Me.cmdNovo.Text = "Novo"
    Me.cmdNovo.UseVisualStyleBackColor = True
    '
    'cmdGuardar
    '
    Me.cmdGuardar.Enabled = False
    Me.cmdGuardar.Location = New System.Drawing.Point(422, 143)
    Me.cmdGuardar.Name = "cmdGuardar"
    Me.cmdGuardar.Size = New System.Drawing.Size(118, 23)
    Me.cmdGuardar.TabIndex = 8
    Me.cmdGuardar.Text = "Guardar"
    Me.cmdGuardar.UseVisualStyleBackColor = True
    '
    'cmdAtlerarCodigo
    '
    Me.cmdAtlerarCodigo.Enabled = False
    Me.cmdAtlerarCodigo.Location = New System.Drawing.Point(422, 169)
    Me.cmdAtlerarCodigo.Name = "cmdAtlerarCodigo"
    Me.cmdAtlerarCodigo.Size = New System.Drawing.Size(118, 23)
    Me.cmdAtlerarCodigo.TabIndex = 9
    Me.cmdAtlerarCodigo.Text = "Alterar Cód. Produto"
    Me.cmdAtlerarCodigo.UseVisualStyleBackColor = True
    '
    'txtCategoria
    '
    Me.txtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtCategoria.Location = New System.Drawing.Point(88, 145)
    Me.txtCategoria.Name = "txtCategoria"
    Me.txtCategoria.ReadOnly = True
    Me.txtCategoria.Size = New System.Drawing.Size(35, 20)
    Me.txtCategoria.TabIndex = 99
    Me.txtCategoria.TabStop = False
    Me.txtCategoria.Text = "M"
    Me.txtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'frmProdutos
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(553, 202)
    Me.Controls.Add(Me.cmdAtlerarCodigo)
    Me.Controls.Add(Me.cmdGuardar)
    Me.Controls.Add(Me.cmdNovo)
    Me.Controls.Add(Me.cmdProcurar)
    Me.Controls.Add(Me.chkEliminado)
    Me.Controls.Add(Me.txtPrecoCusto)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.txtCodBarras)
    Me.Controls.Add(Me.txtUnidadeMedida)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.txtCategoria)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtDescricao)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtCodigo)
    Me.Controls.Add(Me.Label1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmProdutos"
    Me.Text = "Adicionar/Editar Produtos"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents txtCodigo As TextBox
  Friend WithEvents txtDescricao As TextBox
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents txtUnidadeMedida As TextBox
  Friend WithEvents Label5 As Label
  Friend WithEvents txtCodBarras As TextBox
  Friend WithEvents txtPrecoCusto As TextBox
  Friend WithEvents Label6 As Label
  Friend WithEvents chkEliminado As CheckBox
  Friend WithEvents cmdProcurar As Button
  Friend WithEvents cmdNovo As Button
  Friend WithEvents cmdGuardar As Button
  Friend WithEvents cmdAtlerarCodigo As Button
  Friend WithEvents txtCategoria As TextBox
End Class
