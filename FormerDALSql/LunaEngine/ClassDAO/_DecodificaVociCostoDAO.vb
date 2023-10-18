#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 5.20.1.8 
'Author: Diego Lunadei
'Date: 20/02/2020 
#End Region


Imports System.Data.Common
''' <summary>
'''This class manage persistency on db of DecodificaVoceCosto object
''' </summary>
''' <remarks>
'''
''' </remarks>

Public MustInherit Class _DecodificaVociCostoDAO
	Inherits LUNA.LunaBaseClassDAO(Of DecodificaVoceCosto)

	''' <summary>
	'''New() create an istance of this class. Use default DB Connection
	''' </summary>
	Public Sub New()
		MyBase.New()
	End Sub

	''' <summary>
	'''New() create an istance of this class and specify an OPENED DB connection
	''' </summary>
	Public Sub New(ByVal Connection As DbConnection)
		MyBase.New(Connection)
	End Sub

	''' <summary>
	'''Read from DB table T_decodificavocicosto
	''' </summary>
	''' <returns>
	'''Return a DecodificaVoceCosto object
	''' </returns>
	Public Overrides Function Read(Id as integer) as DecodificaVoceCosto
		Dim cls as new DecodificaVoceCosto

		Try
			Using myCommand As DbCommand = _cn.CreateCommand
				myCommand.CommandText = "SELECT * FROM T_decodificavocicosto WHERE IdDecodificaVociCosto = " & Id
				If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
				Using myReader As DbDataReader = myCommand.ExecuteReader
					myReader.Read()
					If myReader.HasRows Then
						cls.FillFromDataRecord(CType(myReader, IDataRecord))	
					End If
					myReader.Close()
				End Using
			End Using
		Catch ex As Exception
			ManageError(ex)
		End Try
		Return cls
	End Function

	''' <summary>
	'''Save on DB table T_decodificavocicosto
	''' </summary>
	''' <returns>
	'''Return ID insert in DB
	''' </returns>
	Public Overrides Function Save(byRef cls as DecodificaVoceCosto) as Integer

		Dim Ris as integer=0 'in Ris return Insert Id

		If cls.IsValid Then
			If cls.IsChanged Then
				Using myCommand As DbCommand = _Cn.CreateCommand()
					Try
						Dim sql As String = String.Empty
						If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
						If cls.IdDecodificaVociCosto = 0 Then
							sql = "INSERT INTO T_decodificavocicosto ("
							sql &= " IdFornitore,"
							sql &= " IdRis,"
							sql &= " QtaMoltiplicatore,"
							sql &= " TextToSearch,"
							sql &= " TipoDecodifica,"
							sql &= " Um"
							sql &= ") VALUES ("
							sql &= " @IdFornitore,"
							sql &= " @IdRis,"
							sql &= " @QtaMoltiplicatore,"
							sql &= " @TextToSearch,"
							sql &= " @TipoDecodifica,"
							sql &= " @Um"
							sql &= ")"
						Else
							sql = "UPDATE T_decodificavocicosto SET "
							If cls.WhatIsChanged.IdFornitore Then sql &= "IdFornitore = @IdFornitore,"
							If cls.WhatIsChanged.IdRis Then sql &= "IdRis = @IdRis,"
							If cls.WhatIsChanged.QtaMoltiplicatore Then sql &= "QtaMoltiplicatore = @QtaMoltiplicatore,"
							If cls.WhatIsChanged.TextToSearch Then sql &= "TextToSearch = @TextToSearch,"
							If cls.WhatIsChanged.TipoDecodifica Then sql &= "TipoDecodifica = @TipoDecodifica,"
							If cls.WhatIsChanged.Um Then sql &= "Um = @Um"
							sql = sql.TrimEnd(",")
							sql &= " WHERE IdDecodificaVociCosto= " & cls.IdDecodificaVociCosto
						End If
					
						Dim p As DbParameter = Nothing 
						If cls.WhatIsChanged.IdFornitore Then 
							p = myCommand.CreateParameter
							p.ParameterName = "@IdFornitore"
							p.Value = cls.IdFornitore
							myCommand.Parameters.Add(p)
						End If

						If cls.WhatIsChanged.IdRis Then 
							p = myCommand.CreateParameter
							p.ParameterName = "@IdRis"
							p.Value = cls.IdRis
							myCommand.Parameters.Add(p)
						End If

						If cls.WhatIsChanged.QtaMoltiplicatore Then 
							p = myCommand.CreateParameter
							p.ParameterName = "@QtaMoltiplicatore"
							p.Value = cls.QtaMoltiplicatore
							myCommand.Parameters.Add(p)
						End If

						If cls.WhatIsChanged.TextToSearch Then 
							p = myCommand.CreateParameter
							p.ParameterName = "@TextToSearch"
							p.Value = cls.TextToSearch
							myCommand.Parameters.Add(p)
						End If

						If cls.WhatIsChanged.TipoDecodifica Then 
							p = myCommand.CreateParameter
							p.ParameterName = "@TipoDecodifica"
							p.Value = cls.TipoDecodifica
							myCommand.Parameters.Add(p)
						End If

						If cls.WhatIsChanged.Um Then 
							p = myCommand.CreateParameter
							p.ParameterName = "@Um"
							p.Value = cls.Um
							myCommand.Parameters.Add(p)
						End If

						myCommand.CommandType = CommandType.Text
						myCommand.CommandText = sql
						myCommand.ExecuteNonQuery()

		            
						If cls.IdDecodificaVociCosto=0 Then
							Dim IdInserito as integer = 0
							Sql = "select @@identity"
							myCommand.CommandText = Sql
							IdInserito = myCommand.ExecuteScalar()
							cls.IdDecodificaVociCosto = IdInserito
							Ris = IdInserito
						Else
							Ris  =  cls.IdDecodificaVociCosto
						End If
					Catch ex As Exception
						ManageError(ex)
					End Try
				End Using
			else
				Ris  =  cls.IdDecodificaVociCosto
			End If
		Else
			throw new ApplicationException("Object data is not valid")
		End If
		Return Ris
	End Function

	Private Sub DestroyPermanently(Id as integer) 
		Try
			Using myCommand As DbCommand = _Cn.CreateCommand
				myCommand.Connection = _cn

				'******IMPORTANT: You can use this commented instruction to make a logical delete .
				'******Replace DELETED Field with your logic deleted field name.
				'Dim Sql As String = "UPDATE T_decodificavocicosto SET DELETED=True "
				Dim Sql As String = "DELETE FROM T_decodificavocicosto"
				Sql &= " WHERE IdDecodificaVociCosto = " & Id 
				myCommand.CommandText = Sql
				If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
				myCommand.ExecuteNonQuery()
    		End Using
		Catch ex As Exception
			ManageError(ex)
		End Try
	End Sub

	''' <summary>
	'''Delete from DB table T_decodificavocicosto. Accept id of object to delete.
	''' </summary>
	Public Overrides Sub Delete(Id as integer) 
		DestroyPermanently (Id)
	End Sub

	''' <summary>
	'''Delete from DB table T_decodificavocicosto. Accept object to delete and optional a List to remove the object from.
	''' </summary>
	Public Overrides Sub Delete(byref obj as DecodificaVoceCosto, Optional ByRef ListaObj as List (of DecodificaVoceCosto) = Nothing)
		DestroyPermanently (obj.IdDecodificaVociCosto)
		If Not ListaObj Is Nothing Then ListaObj.Remove(obj)
 
	End Sub

	Private Function InternalFind(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As DecodificaVoceCosto
		Dim ris As DecodificaVoceCosto = Nothing
		Dim So As New LUNA.LunaSearchOption With {.Top = 1, .OrderBy = OrderBy}
		Dim l As IEnumerable(Of DecodificaVoceCosto) = FindReal(So, Parameter)
		If l.Count Then
			ris = l(0)
		End If
		Return ris
	End Function

	''' <summary>
	'''Find one on DB table T_decodificavocicosto
	''' </summary>
	''' <returns>
	'''Return first of DecodificaVoceCosto
	''' </returns>
	Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As DecodificaVoceCosto
		Return InternalFind(String.Empty, Parameter)
	End Function

	''' <summary>
	'''Find one on DB table T_decodificavocicosto
	''' </summary>
	''' <returns>
	'''Return first of DecodificaVoceCosto
	''' </returns>
	<Obsolete("Use Instead Constructor with LFM field definition")>
	Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As DecodificaVoceCosto
		Return InternalFind(OrderBy, Parameter)
	End Function
		
	''' <summary>
	'''Find one on DB table DecodificaVoceCosto
	''' </summary>
	''' <returns>
	'''Return first of DecodificaVoceCosto
	''' </returns>
	Public Overloads Function Find(ByVal OrderBy As LUNA.LunaFieldName, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As DecodificaVoceCosto
		Return InternalFind(OrderBy.Name, Parameter)
	End Function

	''' <summary>
	'''Find on DB table T_decodificavocicosto
	''' </summary>
	''' <returns>
	'''Return a list of DecodificaVoceCosto
	''' </returns>
	Public Overrides Function FindAll(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of DecodificaVoceCosto)
		Dim So As New Luna.LunaSearchOption
		Return FindReal(So, Parameter)
	End Function

	''' <summary>
	'''Find on DB table T_decodificavocicosto
	''' </summary>
	''' <returns>
	'''Return a list of DecodificaVoceCosto
	''' </returns>
	<Obsolete("Use Instead Constructor with LFM field definition")>
	Public Overloads Function FindAll(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of DecodificaVoceCosto)
		Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy}
		Return FindReal(So, Parameter)
	End Function

	''' <summary>
	'''Find on DB table T_decodificavocicosto
	''' </summary>
	''' <returns>
	'''Return a list of DecodificaVoceCosto
	''' </returns>
	<Obsolete("Use Instead Constructor with LFM field definition")>
	Public Overloads Function FindAll(byVal Top as integer, ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of DecodificaVoceCosto)
		Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy}
		Return FindReal(So, Parameter)
	End Function
	
	''' <summary>
	'''Find on DB table T_decodificavocicosto
	''' </summary>
	''' <returns>
	'''Return a list of DecodificaVoceCosto
	''' </returns>
	Public Overloads Function FindAll(ByVal OrderBy As Luna.LunaFieldName, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of DecodificaVoceCosto)
		Dim So As New Luna.LunaSearchOption With {.OrderBy = OrderBy.Name}
		Return FindReal(So, Parameter)
	End Function

	''' <summary>
	'''Find on DB table T_decodificavocicosto
	''' </summary>
	''' <returns>
	'''Return a list of DecodificaVoceCosto
	''' </returns>
	Public Overloads Function FindAll(byVal Top as integer, ByVal OrderBy As Luna.LunaFieldName, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as IEnumerable(Of DecodificaVoceCosto)
		Dim So As New Luna.LunaSearchOption With {.Top = Top, .OrderBy = OrderBy.Name}
		Return FindReal(So, Parameter)
	End Function

	''' <summary>
	'''Find on DB table T_decodificavocicosto
	''' </summary>
	''' <returns>
	'''Return a list of DecodificaVoceCosto
	''' </returns>
	Public Overloads Function FindAll(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of DecodificaVoceCosto)
		Return FindReal(SearchOption, Parameter)
	End Function

	''' <summary>
	'''Find on DB table T_decodificavocicosto by custom query 
	''' </summary>
	''' <returns>
	'''Return a list of DecodificaVoceCosto by custom query
	''' </returns>
	Public Function GetBySQL(SQlQuery As String, Optional AddEmptyItem As Boolean = False) As IEnumerable(Of DecodificaVoceCosto)
		Dim Ls As New List(Of DecodificaVoceCosto)
		Try
			Ls = GetData(SQlQuery, AddEmptyItem)
		Catch ex As Exception
			ManageError(ex)
		End Try
		Return Ls
	End Function
		
	Private Function FindReal(ByVal SearchOption As LUNA.LunaSearchOption, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of DecodificaVoceCosto)
		Dim Ls As New List(Of DecodificaVoceCosto)
		Try
			Dim sql As String = ""
			sql ="SELECT "   
			If SearchOption.Top Then sql &= " TOP " & SearchOption.Top
			If SearchOption.Distinct Then sql &= " DISTINCT "
			sql &=" * FROM T_decodificavocicosto" 
			For Each Par As LUNA.LunaSearchParameter In Parameter
				If Not Par Is Nothing Then
					If Sql.IndexOf("WHERE") = -1 Then Sql &= " WHERE " Else Sql &=  " " & Par.LogicOperatorStr & " "
					sql &= Par.FieldName & " " & Par.SqlOperator
					If Par.SqlOperator.ToUpper.IndexOf("IN") <> -1 Then
						sql &= " " & ApIn(Par.Value)
					Else
						sql &= " " & Ap(Par.Value)
					End If
				End if
			Next

			If SearchOption.OrderBy.Length Then Sql &= " ORDER BY " & SearchOption.OrderBy

			Ls = GetData(sql, SearchOption.AddEmptyItem)

		Catch ex As Exception
			ManageError(ex)
		End Try
		Return Ls
	End Function

	''' <summary>
	'''Return all record on DB table T_decodificavocicosto
	''' </summary>
	''' <returns>
	'''Return all record in list of DecodificaVoceCosto
	''' </returns>
	Public Overloads Function GetAll() As IEnumerable(Of DecodificaVoceCosto)
		Return InternalGetAll()
	End Function

	''' <summary>
	'''Return all record on DB table T_decodificavocicosto
	''' </summary>
	''' <returns>
	'''Return all record in list of DecodificaVoceCosto
	''' </returns>
	Public Overloads Function GetAll(Optional OrderByField As LUNA.LunaFieldName = Nothing, Optional ByVal AddEmptyItem As Boolean = False) As IEnumerable(Of DecodificaVoceCosto)
		Return InternalGetAll(IIf(Not OrderByField Is Nothing, OrderByField.Name, String.Empty), AddEmptyItem)
	End Function

	''' <summary>
	'''Return all record on DB table T_decodificavocicosto
	''' </summary>
	''' <returns>
	'''Return all record in list of DecodificaVoceCosto
	''' </returns>
	<Obsolete("Use Instead Constructor with LFM field definition")>
	Public Overrides Function GetAll(Optional OrderByField As String = "",Optional ByVal AddEmptyItem As Boolean = False) As IEnumerable(Of DecodificaVoceCosto)
		Return InternalGetAll(OrderByField, AddEmptyItem)
	End Function

	Private Function InternalGetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of DecodificaVoceCosto)
		Dim Ls As List(Of DecodificaVoceCosto)
		Try
			Dim sql As String = ""
			sql ="SELECT * FROM T_decodificavocicosto" 
			If OrderByField.Length Then
				Sql &= " ORDER BY " & OrderByField
			End If
			Ls = GetData(Sql,AddEmptyItem)

		Catch ex As Exception
			ManageError(ex)
		End Try
		Return Ls
	End Function

	Protected Overridable Property EmptyItemDescription As String = "Selezionare una voce"

	Protected Function GetData(sql as string, Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of DecodificaVoceCosto)
		Dim Ls As New List(Of DecodificaVoceCosto)
		Try
			Using myCommand As DbCommand = _Cn.CreateCommand
				myCommand.CommandText = sql
				If Not LUNA.LunaContext.TransactionBox Is Nothing Then myCommand.Transaction = LUNA.LunaContext.TransactionBox.Transaction
				Using myReader As DbDataReader = myCommand.ExecuteReader()
					If AddEmptyItem Then Ls.Add(New  DecodificaVoceCosto() With {.IdDecodificaVociCosto = 0 ,.IdFornitore = 0 ,.IdRis = 0 ,.QtaMoltiplicatore = 0 ,.TextToSearch = "" ,.TipoDecodifica = 0 ,.Um = ""  })
					While myReader.Read
						Dim classe as new DecodificaVoceCosto(CType(myReader, IDataRecord))
						Ls.Add(classe)
					End While
					myReader.Close()
				End Using
			End Using
		Catch ex As Exception
			ManageError(ex)
		End Try
		Return Ls
	End Function
End Class