<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProcurarProdutos
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
    Me.dgvProdutos = New System.Windows.Forms.DataGridView()
    Me.txtProdutoProcurar = New System.Windows.Forms.TextBox()
    Me.chkMostrarEliminados = New System.Windows.Forms.CheckBox()
    CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'dgvProdutos
    '
    Me.dgvProdutos.AllowUserToAddRows = False
    Me.dgvProdutos.AllowUserToDeleteRows = False
    Me.dgvProdutos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvProdutos.Location = New System.Drawing.Point(12, 43)
    Me.dgvProdutos.Name = "dgvProdutos"
    Me.dgvProdutos.ReadOnly = True
    Me.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvProdutos.Size = New System.Drawing.Size(1006, 535)
    Me.dgvProdutos.TabIndex = 0
    '
    'txtProdutoProcurar
    '
    Me.txtProdutoProcurar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtProdutoProcurar.Location = New System.Drawing.Point(12, 17)
    Me.txtProdutoProcurar.Name = "txtProdutoProcurar"
    Me.txtProdutoProcurar.Size = New System.Drawing.Size(664, 20)
    Me.txtProdutoProcurar.TabIndex = 1
    '
    'chkMostrarEliminados
    '
    Me.chkMostrarEliminados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.chkMostrarEliminados.AutoSize = True
    Me.chkMostrarEliminados.Location = New System.Drawing.Point(682, 20)
    Me.chkMostrarEliminados.Name = "chkMostrarEliminados"
    Me.chkMostrarEliminados.Size = New System.Drawing.Size(114, 17)
    Me.chkMostrarEliminados.TabIndex = 2
    Me.chkMostrarEliminados.Text = "Mostrar Eliminados"
    Me.chkMostrarEliminados.UseVisualStyleBackColor = True
    '
    'frmProcurarProdutos
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1030, 594)
    Me.Controls.Add(Me.chkMostrarEliminados)
    Me.Controls.Add(Me.txtProdutoProcurar)
    Me.Controls.Add(Me.dgvProdutos)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmProcurarProdutos"
    Me.Text = "Procurar Produtos"
    CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents dgvProdutos As DataGridView
  Friend WithEvents txtProdutoProcurar As TextBox
  Friend WithEvents chkMostrarEliminados As CheckBox
End Class
