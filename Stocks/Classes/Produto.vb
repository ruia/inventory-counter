Imports System.Data.SqlClient
Public Class Produto

  Public Property Id As String = String.Empty
  Public Property Descricao As String = String.Empty
  Public Property CodBarras As String = String.Empty
  Public Property Categoria As String = "M"
  Public Property UnidadeMedida As String = "UNIDADE"
  Public Property PrecoCusto As Decimal = 0.00
  Public Property Eliminado As Boolean = 0

  Public Property Erros As New List(Of String)

  'Public Sub New(ID As String, Descricao As String, CodBarras As String, Categoria As String, UnidadeMedida As String, PrecoCusto As Decimal, Eliminado As Boolean)
  '  _Id = ID
  '  _Descricao = Descricao
  '  _CodBarras = CodBarras
  '  _Categoria = Categoria
  '  _UnidadeMedida = UnidadeMedida
  '  _PrecoCusto = PrecoCusto
  '  _Eliminado = Eliminado
  'End Sub

  Public Sub ObterPorId(Id As String) 'As Produto
    If (Id <> "") Then
      Dim sql As String = "SELECT * FROM Produtos Where ID=@Id"

      Using conexao As New SqlConnection(Globais.connectionString)
        Using comando As New SqlCommand(sql, conexao)
          conexao.Open()
          With comando
            .Parameters.Add("@Id", SqlDbType.NVarChar, 60).Value = Id
          End With
          Using dataReader As SqlDataReader = comando.ExecuteReader
            If (dataReader.HasRows) Then
              While dataReader.Read
                _Id = dataReader("Id")
                _Descricao = dataReader("Descricao")
                _CodBarras = dataReader("CodBarras")
                _Categoria = dataReader("Categoria")
                _UnidadeMedida = dataReader("UnidadeMedida")
                _PrecoCusto = dataReader("PrecoCusto")
                _Eliminado = dataReader("Eliminado")
              End While
            Else
              Erros.Add(String.Format("Não foi possivel encontrar o produto com o ID: {0}", Id))
              'Return Nothing
            End If
          End Using
        End Using
      End Using
    End If

    'Return Me
  End Sub

  Public Sub ObterPorCodBarras(cb As String) 'As Produto
    If (cb <> "") Then
      Dim sql As String = "SELECT * FROM Produtos Where CodBarras=@cb"

      Using conexao As New SqlConnection(Globais.connectionString)
        Using comando As New SqlCommand(sql, conexao)
          conexao.Open()
          With comando
            .Parameters.Add("@cb", SqlDbType.NVarChar, 60).Value = cb
          End With
          Using dataReader As SqlDataReader = comando.ExecuteReader
            If (dataReader.HasRows) Then
              While dataReader.Read
                _Id = dataReader("Id")
                _Descricao = dataReader("Descricao")
                _CodBarras = dataReader("CodBarras")
                _Categoria = dataReader("Categoria")
                _UnidadeMedida = dataReader("UnidadeMedida")
                _PrecoCusto = dataReader("PrecoCusto")
                _Eliminado = dataReader("Eliminado")
              End While
            Else
              Erros.Add(String.Format("Não foi possivel encontrar o produto com o codigo de barras: {0}", cb))
              'Return Nothing
            End If
          End Using
        End Using
      End Using
    End If

    'Return Me
  End Sub

  Public Function ObterTodos(Optional ByVal MostrarEliminados As Boolean = False) As DataTable
    Dim Sql As String = String.Empty
    If MostrarEliminados Then
      Sql = "SELECT * FROM Produtos"
    Else
      Sql = "SELECT Id, Descricao, CodBarras, Categoria, UnidadeMedida, PrecoCusto FROM Produtos WHERE Eliminado=0"
    End If
    Using conexao As New SqlConnection(Globais.connectionString)
      Using comando As New SqlCommand(Sql, conexao)
        Using da As New SqlDataAdapter(comando)
          Using dt As New DataTable
            Try
              da.Fill(dt)
              da.FillSchema(dt, SchemaType.Mapped)
              Return dt
            Catch ex As Exception
              Return Nothing
            End Try
          End Using
        End Using
      End Using
    End Using
    Return Nothing
  End Function

  Private Function Validar() As Boolean
    Dim retorno As Boolean = False
    If (Me.Id.Length < 60) Then
      If (Me.Id <> String.Empty) Then
        retorno = True
      Else
        Me.Erros.Add("Código do produto está vazio.")
      End If
    Else
      Me.Erros.Add("Código do produto tem mais de 60 caracteres.")
    End If
    If (Me.Descricao.Length < 200) Then
      If (Me.Descricao <> String.Empty) Then
        retorno = True
      Else
        Me.Erros.Add("Descrição está vazia.")
      End If
    Else
      Me.Erros.Add("Descrição tem mais que 200 caracteres") 
    End If
    If (Me.CodBarras = String.Empty) Then
      _CodBarras = Me.Id
    End If
    If (Me.CodBarras.Length > 60) Then
      '  If (Me.CodBarras <> Me.Id) Then
      '    retorno = True
      '  Else
      '    Me.Erros.Add("Erro no Código de Barras")
      '  End If
      'Else
      Me.Erros.Add("Código de barras tem mais que 60 caracteres")
    End If
    Return retorno
  End Function

  Private Function Existe(Id As String) As Boolean
    Dim sql As String = "SELECT Id FROM Produtos Where Id=@Id"
    Using conexao As New SqlConnection(Globais.connectionString)
      Using comando As New SqlCommand(sql, conexao)
        conexao.Open()
        With comando
          .Parameters.Add("@Id", SqlDbType.NVarChar, 60).Value = Id
        End With
        Using dataReader As SqlDataReader = comando.ExecuteReader
          If (dataReader.HasRows) Then
            Return True
          End If
        End Using
      End Using
    End Using
    Return False
  End Function

  Private Function Eliminar(Id As String) As Boolean
    Dim sql As String = "DELETE FROM Produtos Where Id=@Id"
    Using conexao As New SqlConnection(Globais.connectionString)
      Using comando As New SqlCommand(sql, conexao)
        conexao.Open()
        With comando
          .Parameters.Add("@Id", SqlDbType.NVarChar, 60).Value = Id
        End With
        Dim resultado As Integer = comando.ExecuteNonQuery
        If (resultado > 0) Then
          Return True
        End If
      End Using
    End Using
    Return False
  End Function

  Private Function ExisteCodBarras(CodBarras As String) As Boolean
    Dim sql As String = "SELECT CodBarras FROM Produtos Where CodBarras=@CB"
    Using conexao As New SqlConnection(Globais.connectionString)
      Using comando As New SqlCommand(sql, conexao)
        conexao.Open()
        With comando
          .Parameters.Add("@CB", SqlDbType.NVarChar, 60).Value = CodBarras
        End With
        Using dataReader As SqlDataReader = comando.ExecuteReader
          If (dataReader.HasRows) Then
            Return True
          End If
        End Using
      End Using
    End Using
    Return False
  End Function

  Private Function CriarAtualizar(Id As String) As Boolean
    Dim sql As String = String.Empty
    If (Existe(Id)) Then
      sql = "UPDATE Produtos SET Descricao=@Descricao, CodBarras=@CodBarras, Categoria=@Categoria, UnidadeMedida=@UnidadeMedida, PrecoCusto=@PrecoCusto, Eliminado=@Eliminado WHERE Id=@Id"
    Else
      sql = "INSERT INTO Produtos VALUES (@Id, @Descricao, @CodBarras, @Categoria, @UnidadeMedida, @PrecoCusto, @Eliminado)"
    End If
    If (Not Existe(Id) And ExisteCodBarras(CodBarras)) Then
      sql = "UPDATE Produtos SET Descricao=@Descricao, CodBarras=@CodBarras, Categoria=@Categoria, UnidadeMedida=@UnidadeMedida, PrecoCusto=@PrecoCusto, Eliminado=@Eliminado WHERE CodBarras=@CodBarras"
    End If
    Using conexao As New SqlConnection(Globais.connectionString)
      Using comando As New SqlCommand(sql, conexao)
        Try
          conexao.Open()
          With comando
            .Parameters.Add("@Id", SqlDbType.NVarChar, 60).Value = Me.Id
            .Parameters.Add("@Descricao", SqlDbType.NVarChar, 200).Value = Me.Descricao
            .Parameters.Add("@CodBarras", SqlDbType.NVarChar, 60).Value = Me.CodBarras
            .Parameters.Add("@Categoria", SqlDbType.NChar, 10).Value = Me.Categoria
            .Parameters.Add("@UnidadeMedida", SqlDbType.NVarChar, 50).Value = Me.UnidadeMedida
            .Parameters.Add("@PrecoCusto", SqlDbType.SmallMoney).Value = Me.PrecoCusto
            .Parameters.Add("@Eliminado", SqlDbType.Bit).Value = Me.Eliminado
          End With
          Dim resultado As Integer = comando.ExecuteNonQuery
          If (resultado > 0) Then
            Return True
          Else
            Return False
          End If
        Catch ex As Exception
          Return False
          Logger.Escreve(String.Format("Erro ao criar/atualizar produto. - ID: {0} - COD: {1} - MSG: {2}", Me.Id, ex.ToString, ex.Message.ToString))
        End Try
      End Using
    End Using
    Return False
  End Function

  Public Function Gravar() As Boolean
    If (Not Me.Validar) Then
      Return False
    End If
    'If (ExisteCodBarras(Me.CodBarras)) Then
    '  Me.CodBarras = "DUP-" & Me.CodBarras
    'End If
    Return CriarAtualizar(Me.Id)
  End Function
End Class
