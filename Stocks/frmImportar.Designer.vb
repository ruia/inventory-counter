<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImportar
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
    Me.txtFicheiro = New System.Windows.Forms.TextBox()
    Me.btnAbrirFicheiro = New System.Windows.Forms.Button()
    Me.ofdAbrirFicheiro = New System.Windows.Forms.OpenFileDialog()
    Me.dgvFicheiro = New System.Windows.Forms.DataGridView()
    Me.cmbTabelas = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.dgvMapeamentos = New System.Windows.Forms.DataGridView()
    Me.camposServidor = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.camposFicheiro = New System.Windows.Forms.DataGridViewComboBoxColumn()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.btnImportar = New System.Windows.Forms.Button()
    Me.bgwAbrirFicheiro = New System.ComponentModel.BackgroundWorker()
    Me.bgwImportar = New System.ComponentModel.BackgroundWorker()
    Me.lblNumLinhasFicheiro = New System.Windows.Forms.Label()
    Me.lblNumInsertUpdate = New System.Windows.Forms.Label()
    Me.btnImportarBETA = New System.Windows.Forms.Button()
    Me.btnAgrupador = New System.Windows.Forms.Button()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.Button2 = New System.Windows.Forms.Button()
    Me.btnUpdatePrecoCusto = New System.Windows.Forms.Button()
    Me.cmdFixCbVazios = New System.Windows.Forms.Button()
    Me.btnFixDupsEX = New System.Windows.Forms.Button()
    Me.btnImportarPortugalPet = New System.Windows.Forms.Button()
    CType(Me.dgvFicheiro, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dgvMapeamentos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtFicheiro
    '
    Me.txtFicheiro.Location = New System.Drawing.Point(20, 18)
    Me.txtFicheiro.Name = "txtFicheiro"
    Me.txtFicheiro.ReadOnly = True
    Me.txtFicheiro.Size = New System.Drawing.Size(429, 20)
    Me.txtFicheiro.TabIndex = 0
    '
    'btnAbrirFicheiro
    '
    Me.btnAbrirFicheiro.Location = New System.Drawing.Point(455, 17)
    Me.btnAbrirFicheiro.Name = "btnAbrirFicheiro"
    Me.btnAbrirFicheiro.Size = New System.Drawing.Size(104, 23)
    Me.btnAbrirFicheiro.TabIndex = 1
    Me.btnAbrirFicheiro.Text = "Abrir Ficheiro"
    Me.btnAbrirFicheiro.UseVisualStyleBackColor = True
    '
    'dgvFicheiro
    '
    Me.dgvFicheiro.AllowUserToAddRows = False
    Me.dgvFicheiro.AllowUserToDeleteRows = False
    Me.dgvFicheiro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvFicheiro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dgvFicheiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvFicheiro.Location = New System.Drawing.Point(565, 17)
    Me.dgvFicheiro.Name = "dgvFicheiro"
    Me.dgvFicheiro.ReadOnly = True
    Me.dgvFicheiro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvFicheiro.Size = New System.Drawing.Size(649, 442)
    Me.dgvFicheiro.TabIndex = 2
    '
    'cmbTabelas
    '
    Me.cmbTabelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbTabelas.FormattingEnabled = True
    Me.cmbTabelas.Location = New System.Drawing.Point(20, 62)
    Me.cmbTabelas.Name = "cmbTabelas"
    Me.cmbTabelas.Size = New System.Drawing.Size(160, 21)
    Me.cmbTabelas.TabIndex = 3
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(17, 46)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(45, 13)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "Tabelas"
    '
    'dgvMapeamentos
    '
    Me.dgvMapeamentos.AllowUserToAddRows = False
    Me.dgvMapeamentos.AllowUserToDeleteRows = False
    Me.dgvMapeamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dgvMapeamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvMapeamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.camposServidor, Me.camposFicheiro})
    Me.dgvMapeamentos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
    Me.dgvMapeamentos.Location = New System.Drawing.Point(20, 107)
    Me.dgvMapeamentos.MultiSelect = False
    Me.dgvMapeamentos.Name = "dgvMapeamentos"
    Me.dgvMapeamentos.Size = New System.Drawing.Size(429, 274)
    Me.dgvMapeamentos.TabIndex = 6
    '
    'camposServidor
    '
    Me.camposServidor.HeaderText = "Campos Servidor"
    Me.camposServidor.Name = "camposServidor"
    '
    'camposFicheiro
    '
    Me.camposFicheiro.HeaderText = "CamposFicheiro"
    Me.camposFicheiro.Name = "camposFicheiro"
    Me.camposFicheiro.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.camposFicheiro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(17, 91)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(74, 13)
    Me.Label2.TabIndex = 7
    Me.Label2.Text = "Mapeamentos"
    '
    'btnImportar
    '
    Me.btnImportar.Location = New System.Drawing.Point(455, 46)
    Me.btnImportar.Name = "btnImportar"
    Me.btnImportar.Size = New System.Drawing.Size(104, 23)
    Me.btnImportar.TabIndex = 8
    Me.btnImportar.Text = "Importar"
    Me.btnImportar.UseVisualStyleBackColor = True
    '
    'bgwAbrirFicheiro
    '
    Me.bgwAbrirFicheiro.WorkerReportsProgress = True
    '
    'bgwImportar
    '
    Me.bgwImportar.WorkerReportsProgress = True
    '
    'lblNumLinhasFicheiro
    '
    Me.lblNumLinhasFicheiro.AutoSize = True
    Me.lblNumLinhasFicheiro.Location = New System.Drawing.Point(300, 56)
    Me.lblNumLinhasFicheiro.Name = "lblNumLinhasFicheiro"
    Me.lblNumLinhasFicheiro.Size = New System.Drawing.Size(77, 13)
    Me.lblNumLinhasFicheiro.TabIndex = 9
    Me.lblNumLinhasFicheiro.Text = "nlinhas ficheiro"
    '
    'lblNumInsertUpdate
    '
    Me.lblNumInsertUpdate.AutoSize = True
    Me.lblNumInsertUpdate.Location = New System.Drawing.Point(300, 70)
    Me.lblNumInsertUpdate.Name = "lblNumInsertUpdate"
    Me.lblNumInsertUpdate.Size = New System.Drawing.Size(94, 13)
    Me.lblNumInsertUpdate.TabIndex = 10
    Me.lblNumInsertUpdate.Text = "nlinhas importadas"
    '
    'btnImportarBETA
    '
    Me.btnImportarBETA.Location = New System.Drawing.Point(455, 75)
    Me.btnImportarBETA.Name = "btnImportarBETA"
    Me.btnImportarBETA.Size = New System.Drawing.Size(104, 23)
    Me.btnImportarBETA.TabIndex = 11
    Me.btnImportarBETA.Text = "ImportarBETA"
    Me.btnImportarBETA.UseVisualStyleBackColor = True
    '
    'btnAgrupador
    '
    Me.btnAgrupador.Location = New System.Drawing.Point(455, 107)
    Me.btnAgrupador.Name = "btnAgrupador"
    Me.btnAgrupador.Size = New System.Drawing.Size(104, 23)
    Me.btnAgrupador.TabIndex = 12
    Me.btnAgrupador.Text = "AgrupadorBeta"
    Me.btnAgrupador.UseVisualStyleBackColor = True
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(20, 436)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(104, 23)
    Me.Button1.TabIndex = 13
    Me.Button1.Text = "Prepara file instinct"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(130, 436)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(151, 23)
    Me.Button2.TabIndex = 14
    Me.Button2.Text = "Import Advance codbarras"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'btnUpdatePrecoCusto
    '
    Me.btnUpdatePrecoCusto.Location = New System.Drawing.Point(287, 436)
    Me.btnUpdatePrecoCusto.Name = "btnUpdatePrecoCusto"
    Me.btnUpdatePrecoCusto.Size = New System.Drawing.Size(151, 23)
    Me.btnUpdatePrecoCusto.TabIndex = 15
    Me.btnUpdatePrecoCusto.Text = "UpdatePrecos [Id;PrecoCusto]"
    Me.btnUpdatePrecoCusto.UseVisualStyleBackColor = True
    '
    'cmdFixCbVazios
    '
    Me.cmdFixCbVazios.Location = New System.Drawing.Point(20, 407)
    Me.cmdFixCbVazios.Name = "cmdFixCbVazios"
    Me.cmdFixCbVazios.Size = New System.Drawing.Size(104, 23)
    Me.cmdFixCbVazios.TabIndex = 16
    Me.cmdFixCbVazios.Text = "Fix CB Vazios"
    Me.cmdFixCbVazios.UseVisualStyleBackColor = True
    '
    'btnFixDupsEX
    '
    Me.btnFixDupsEX.Location = New System.Drawing.Point(130, 407)
    Me.btnFixDupsEX.Name = "btnFixDupsEX"
    Me.btnFixDupsEX.Size = New System.Drawing.Size(151, 23)
    Me.btnFixDupsEX.TabIndex = 17
    Me.btnFixDupsEX.Text = "Fix Dups EX"
    Me.btnFixDupsEX.UseVisualStyleBackColor = True
    '
    'btnImportarPortugalPet
    '
    Me.btnImportarPortugalPet.Location = New System.Drawing.Point(290, 407)
    Me.btnImportarPortugalPet.Name = "btnImportarPortugalPet"
    Me.btnImportarPortugalPet.Size = New System.Drawing.Size(104, 23)
    Me.btnImportarPortugalPet.TabIndex = 18
    Me.btnImportarPortugalPet.Text = "Importar PP"
    Me.btnImportarPortugalPet.UseVisualStyleBackColor = True
    '
    'frmImportar
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1232, 476)
    Me.Controls.Add(Me.btnImportarPortugalPet)
    Me.Controls.Add(Me.btnFixDupsEX)
    Me.Controls.Add(Me.cmdFixCbVazios)
    Me.Controls.Add(Me.btnUpdatePrecoCusto)
    Me.Controls.Add(Me.Button2)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.btnAgrupador)
    Me.Controls.Add(Me.btnImportarBETA)
    Me.Controls.Add(Me.lblNumInsertUpdate)
    Me.Controls.Add(Me.lblNumLinhasFicheiro)
    Me.Controls.Add(Me.btnImportar)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.dgvMapeamentos)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.cmbTabelas)
    Me.Controls.Add(Me.dgvFicheiro)
    Me.Controls.Add(Me.btnAbrirFicheiro)
    Me.Controls.Add(Me.txtFicheiro)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmImportar"
    Me.Text = "Importar"
    CType(Me.dgvFicheiro, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dgvMapeamentos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents txtFicheiro As TextBox
  Friend WithEvents btnAbrirFicheiro As Button
  Friend WithEvents ofdAbrirFicheiro As OpenFileDialog
  Friend WithEvents lstProdutos As ListBox
  Friend WithEvents dgvFicheiro As DataGridView
  Friend WithEvents cmbTabelas As ComboBox
  Friend WithEvents Label1 As Label
  Friend WithEvents dgvMapeamentos As DataGridView
  Friend WithEvents Label2 As Label
  Friend WithEvents camposServidor As DataGridViewTextBoxColumn
  Friend WithEvents camposFicheiro As DataGridViewComboBoxColumn
  Friend WithEvents btnImportar As Button
  Friend WithEvents bgwAbrirFicheiro As System.ComponentModel.BackgroundWorker
  Friend WithEvents bgwImportar As System.ComponentModel.BackgroundWorker
  Friend WithEvents lblNumLinhasFicheiro As Label
  Friend WithEvents lblNumInsertUpdate As Label
  Friend WithEvents btnImportarBETA As Button
  Friend WithEvents btnAgrupador As Button
  Friend WithEvents Button1 As Button
  Friend WithEvents Button2 As Button
  Friend WithEvents btnUpdatePrecoCusto As Button
  Friend WithEvents cmdFixCbVazios As Button
  Friend WithEvents btnFixDupsEX As Button
  Friend WithEvents btnImportarPortugalPet As Button
End Class
