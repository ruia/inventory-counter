<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstadoCarregamentos
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
    Me.lblLinha = New System.Windows.Forms.Label()
    Me.bgwAbrirFicheiro = New System.ComponentModel.BackgroundWorker()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(124, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(143, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "A carregar..."
    '
    'lblLinha
    '
    Me.lblLinha.AutoSize = True
    Me.lblLinha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblLinha.Location = New System.Drawing.Point(5, 69)
    Me.lblLinha.MinimumSize = New System.Drawing.Size(380, 0)
    Me.lblLinha.Name = "lblLinha"
    Me.lblLinha.Size = New System.Drawing.Size(380, 13)
    Me.lblLinha.TabIndex = 1
    Me.lblLinha.Text = "A carregar"
    Me.lblLinha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'bgwAbrirFicheiro
    '
    Me.bgwAbrirFicheiro.WorkerReportsProgress = True
    '
    'frmEstadoCarregamentos
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(391, 151)
    Me.Controls.Add(Me.lblLinha)
    Me.Controls.Add(Me.Label1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmEstadoCarregamentos"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents lblLinha As Label
  Friend WithEvents bgwAbrirFicheiro As System.ComponentModel.BackgroundWorker
End Class
