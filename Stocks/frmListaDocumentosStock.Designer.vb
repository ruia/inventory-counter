<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaDocumentosStock
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.dgvListaDocumentosStock = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataUltimaAlteracao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvListaDocumentosStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(464, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'dgvListaDocumentosStock
        '
        Me.dgvListaDocumentosStock.AllowUserToAddRows = False
        Me.dgvListaDocumentosStock.AllowUserToResizeColumns = False
        Me.dgvListaDocumentosStock.AllowUserToResizeRows = False
        Me.dgvListaDocumentosStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaDocumentosStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaDocumentosStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Data, Me.DataUltimaAlteracao, Me.Eliminado})
        Me.dgvListaDocumentosStock.Location = New System.Drawing.Point(12, 12)
        Me.dgvListaDocumentosStock.MultiSelect = False
        Me.dgvListaDocumentosStock.Name = "dgvListaDocumentosStock"
        Me.dgvListaDocumentosStock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvListaDocumentosStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaDocumentosStock.Size = New System.Drawing.Size(595, 256)
        Me.dgvListaDocumentosStock.TabIndex = 1
        '
        'Id
        '
        Me.Id.FillWeight = 113.0288!
        Me.Id.HeaderText = "ID"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'Data
        '
        Me.Data.FillWeight = 113.0288!
        Me.Data.HeaderText = "Data"
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        '
        'DataUltimaAlteracao
        '
        Me.DataUltimaAlteracao.FillWeight = 113.0288!
        Me.DataUltimaAlteracao.HeaderText = "Data Ultima Alteração"
        Me.DataUltimaAlteracao.Name = "DataUltimaAlteracao"
        Me.DataUltimaAlteracao.ReadOnly = True
        '
        'Eliminado
        '
        Me.Eliminado.FillWeight = 60.9137!
        Me.Eliminado.HeaderText = "Eliminado"
        Me.Eliminado.Name = "Eliminado"
        Me.Eliminado.ReadOnly = True
        '
        'frmListaDocumentosStock
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(622, 315)
        Me.Controls.Add(Me.dgvListaDocumentosStock)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListaDocumentosStock"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lista Documentos Stock"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvListaDocumentosStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents Cancel_Button As System.Windows.Forms.Button
  Friend WithEvents dgvListaDocumentosStock As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents DataUltimaAlteracao As DataGridViewTextBoxColumn
    Friend WithEvents Eliminado As DataGridViewCheckBoxColumn
End Class
