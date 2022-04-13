Module configs
  Private _ficheiro As String = Application.StartupPath & "\configs\configs.xml"
  Private _xml As New Data.DataSet
  Private _bd As New Dictionary(Of String, String)
  Private _ui As New Dictionary(Of String, String)

  Sub New()
    _xml.ReadXml(_ficheiro)
    CarregaInfo("base_dados", _bd)
    CarregaInfo("ui", _ui)
  End Sub

  ''Public Property FicheiroConfiguracoes() As String
  ''  Set(ficheiro As String)
  ''    _ficheiro = ficheiro
  ''  End Set
  ''  Get
  ''    Return _ficheiro
  ''  End Get
  ''End Property

  Public ReadOnly Property BaseDados As Dictionary(Of String, String)
    Get
      Return _bd
    End Get
  End Property

  Public ReadOnly Property UI As Dictionary(Of String, String)
    Get
      Return _ui
    End Get

  End Property

  Private Sub CarregaInfo(modulo As String, dic As Dictionary(Of String, String))
    For Each linha As DataRow In _xml.Tables(modulo).Rows
      For Each coluna As DataColumn In _xml.Tables(modulo).Columns
        dic.Add(coluna.ColumnName, linha(coluna).ToString)
      Next
    Next
  End Sub
End Module