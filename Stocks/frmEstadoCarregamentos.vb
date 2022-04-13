Public Class frmEstadoCarregamentos
  Public WriteOnly Property linha As String
    Set(ByVal valor As String)
      Me.lblLinha.Text = valor
    End Set
  End Property

  Private Sub frmEstadoCarregamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub
End Class