Imports System.Data.SqlClient

Module Funcoes
#Region "Principal"
  Public Sub SetConnectionString()
    Dim DadosBD As Dictionary(Of String, String)
    DadosBD = configs.BaseDados
    Globais.connectionString = String.Format("Data Source={0};Database={1};MultipleActiveResultSets=True;", DadosBD("server"), DadosBD("bd"))
    If (DadosBD("trusted_conection") = False) Then
      Globais.connectionString &= String.Format("User Id={0};Password={1}", DadosBD("user"), DadosBD("pass"))
    Else
      Globais.connectionString &= String.Format("Trusted_Connection=True")
    End If
  End Sub

  Private Sub backup()
    Using conexao As New SqlClient.SqlConnection(Globais.connectionString)
      Using cmd As New SqlClient.SqlCommand(String.Format("backup database Stocks2016 to disk='{0}'", "D:\bd.bak"), conexao)
        conexao.Open()
        cmd.ExecuteNonQuery()
      End Using
    End Using
  End Sub
#End Region

  'Dim debugSQL As String = cmdUpdate.CommandText

  'For Each param As SqlParameter In cmdUpdate.Parameters
  '                debugSQL = debugSQL.Replace(param.ParameterName, param.Value.ToString())
  '              Next
  '              debugList.Add(debugSQL)
#Region "frmImportar"
  Public Function GetTabelasColunas() As Dictionary(Of String, List(Of String))
    Dim tmpReturn As New Dictionary(Of String, List(Of String))
    Dim sqlTabelas As String = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG='Stocks2016'"
    Dim sqlColumas As String
    Dim tmp As List(Of String)

    Using conexao As New SqlConnection With {.ConnectionString = Globais.connectionString}
      conexao.Open()
      Using cmd As New SqlCommand With {.CommandText = sqlTabelas, .Connection = conexao}
        Using reader As SqlDataReader = cmd.ExecuteReader
          Try
            If (reader.HasRows) Then
              While reader.Read
                sqlColumas = String.Format("SELECT COLUMN_NAME FROM Stocks2016.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'{0}'", reader(0))
                Using cmdColunas As New SqlCommand With {.CommandText = sqlColumas, .Connection = conexao}
                  Using readerColunas As SqlDataReader = cmdColunas.ExecuteReader
                    If (readerColunas.HasRows) Then
                      tmp = New List(Of String)
                      While readerColunas.Read
                        tmp.Add(readerColunas(0))
                      End While
                      tmpReturn(reader(0)) = tmp
                    End If
                  End Using
                End Using
              End While
            End If
          Catch ex As Exception
            MsgBox(ex.Message)
          End Try
        End Using
      End Using
    End Using
    Return tmpReturn
  End Function
#End Region
End Module
