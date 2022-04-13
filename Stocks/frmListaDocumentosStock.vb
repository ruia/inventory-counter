Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class frmListaDocumentosStock
  Private _IdDocumentoStock As Long = 0
  Public ReadOnly Property IdDocumentoStock() As Long
    Get
      Return _IdDocumentoStock
    End Get
  End Property

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    _IdDocumentoStock = dgvListaDocumentosStock.Item(0, Me.dgvListaDocumentosStock.SelectedRows.Item(0).Index).Value
    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub frmListaDocumentosStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.dgvListaDocumentosStock.Rows.Clear()

    Using conexao As New SqlConnection(Globais.connectionString)
      conexao.Open()
      Using cmd As New SqlCommand("SELECT * FROM Stocks", conexao)
        Using dr As SqlDataReader = cmd.ExecuteReader
          If (dr.HasRows) Then
            _IdDocumentoStock = 1
            While dr.Read
              Me.dgvListaDocumentosStock.Rows.Add(dr("Id"), dr("Data"), dr("DataUltimaAlteracao"), dr("Eliminado"))
            End While
          Else
            _IdDocumentoStock = -1
          End If
        End Using
      End Using
    End Using
  End Sub

  Private Sub dgvListaDocumentosStock_DoubleClick(sender As Object, e As EventArgs) Handles dgvListaDocumentosStock.DoubleClick
    If (Me.dgvListaDocumentosStock.Rows.Count > 0) Then
      _IdDocumentoStock = dgvListaDocumentosStock.Item(0, Me.dgvListaDocumentosStock.SelectedRows.Item(0).Index).Value
      Me.OK_Button.PerformClick()
    End If
  End Sub

  Private Sub frmListaDocumentosStock_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    Me.Text = "Lista Documentos Stock"
  End Sub
End Class
