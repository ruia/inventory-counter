Imports System.IO
Public Class Log
  Private _PastaLogs As String = "Logs"
  Private _FicheiroAtual As String = ""

  Public Sub New()
    _FicheiroAtual = Data() & ".log.txt"
    If (Not Directory.Exists(_PastaLogs)) Then
      Directory.CreateDirectory(_PastaLogs)
    End If
  End Sub

  Public Sub Escreve(Texto As String)
    Try
      Using writer As New StreamWriter(Ficheiro, True, Text.Encoding.UTF8)
        writer.Write(DataHora)
        writer.WriteLine(Texto)
      End Using
    Catch ex As Exception
      Dim msgErro As String = "erro a escrever o log omg lolz" & vbNewLine & ex.ToString & vbNewLine & ex.Message.ToString
      MsgBox(msgErro)
      IO.File.WriteAllText(Path.Combine(_PastaLogs, "logger.logs.txt"), msgErro)
    End Try
  End Sub

  Private Function Ficheiro() As String
    Return Path.Combine(_PastaLogs, _FicheiroAtual)
  End Function

  Private Function Data() As String
    Return Now.Year & Now.Month & Now.Day
  End Function

  Private Function DataHora() As String
    Return "[" & Now.Year & "/" & Now.Month & "/" & Now.Day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "] - "

  End Function
End Class
