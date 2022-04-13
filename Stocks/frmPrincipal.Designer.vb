<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.mnuTabelas = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuProdutos = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuStocks = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuUtilitarios = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuImportar = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
    Me.ImportarSimplesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuExportarFicheiroInventario = New System.Windows.Forms.ToolStripMenuItem()
    Me.ExportarFicheiroContabilidadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTabelas, Me.mnuUtilitarios})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(692, 24)
    Me.MenuStrip1.TabIndex = 1
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'mnuTabelas
    '
    Me.mnuTabelas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProdutos, Me.mnuStocks})
    Me.mnuTabelas.Name = "mnuTabelas"
    Me.mnuTabelas.Size = New System.Drawing.Size(58, 20)
    Me.mnuTabelas.Text = "Tabelas"
    '
    'mnuProdutos
    '
    Me.mnuProdutos.Name = "mnuProdutos"
    Me.mnuProdutos.Size = New System.Drawing.Size(122, 22)
    Me.mnuProdutos.Text = "Produtos"
    '
    'mnuStocks
    '
    Me.mnuStocks.Name = "mnuStocks"
    Me.mnuStocks.Size = New System.Drawing.Size(122, 22)
    Me.mnuStocks.Text = "Stocks"
    '
    'mnuUtilitarios
    '
    Me.mnuUtilitarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuImportar, Me.ToolStripMenuItem2, Me.ImportarSimplesToolStripMenuItem, Me.ToolStripMenuItem1, Me.mnuExportarFicheiroInventario, Me.ExportarFicheiroContabilidadeToolStripMenuItem})
    Me.mnuUtilitarios.Name = "mnuUtilitarios"
    Me.mnuUtilitarios.Size = New System.Drawing.Size(69, 20)
    Me.mnuUtilitarios.Text = "Utilitários"
    '
    'mnuImportar
    '
    Me.mnuImportar.Name = "mnuImportar"
    Me.mnuImportar.Size = New System.Drawing.Size(267, 22)
    Me.mnuImportar.Text = "Importar"
    '
    'ToolStripMenuItem2
    '
    Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
    Me.ToolStripMenuItem2.Size = New System.Drawing.Size(264, 6)
    '
    'ImportarSimplesToolStripMenuItem
    '
    Me.ImportarSimplesToolStripMenuItem.Name = "ImportarSimplesToolStripMenuItem"
    Me.ImportarSimplesToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
    Me.ImportarSimplesToolStripMenuItem.Text = "Importar Simples"
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(264, 6)
    '
    'mnuExportarFicheiroInventario
    '
    Me.mnuExportarFicheiroInventario.Name = "mnuExportarFicheiroInventario"
    Me.mnuExportarFicheiroInventario.Size = New System.Drawing.Size(267, 22)
    Me.mnuExportarFicheiroInventario.Text = "Exportar Ficheiro Inventario Finanças"
    '
    'ExportarFicheiroContabilidadeToolStripMenuItem
    '
    Me.ExportarFicheiroContabilidadeToolStripMenuItem.Name = "ExportarFicheiroContabilidadeToolStripMenuItem"
    Me.ExportarFicheiroContabilidadeToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
    Me.ExportarFicheiroContabilidadeToolStripMenuItem.Text = "Exportar Ficheiro Contabilidade"
    '
    'frmPrincipal
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(692, 440)
    Me.Controls.Add(Me.MenuStrip1)
    Me.IsMdiContainer = True
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "frmPrincipal"
    Me.Text = "Stocks 2016"
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents MenuStrip1 As MenuStrip
  Friend WithEvents mnuTabelas As ToolStripMenuItem
  Friend WithEvents mnuProdutos As ToolStripMenuItem
  Friend WithEvents mnuUtilitarios As ToolStripMenuItem
  Friend WithEvents mnuImportar As ToolStripMenuItem
  Friend WithEvents mnuStocks As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
  Friend WithEvents mnuExportarFicheiroInventario As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ImportarSimplesToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents ExportarFicheiroContabilidadeToolStripMenuItem As ToolStripMenuItem
End Class
