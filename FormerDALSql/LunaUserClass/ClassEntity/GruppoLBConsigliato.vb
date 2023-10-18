#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 5.20.2.11 
'Author: Diego Lunadei
'Date: 13/05/2020 
#End Region



''' <summary>
'''Entity Class for table T_gruppilbconsigliati
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class GruppoLBConsigliato
	Inherits _GruppoLBConsigliato
	Implements IGruppoLBConsigliato

	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(myRecord as IDataRecord)
		MyBase.New(myRecord)
	End Sub

#Region "Database Field"


	Public Overrides Property IdGC() as integer
		Get
			Return MyBase.IdGC
		End Get
		Set (byval value as integer)
			MyBase.IdGC= value
		End Set
	End Property 


	Public Overrides Property Nome() as string
		Get
			Return MyBase.Nome
		End Get
		Set (byval value as string)
			MyBase.Nome= value
		End Set
	End Property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

	Public Overrides Function IsValid() As Boolean Implements IGruppoLBConsigliato.IsValid
		'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
		'RETURN FALSE IF LOGIC CONTROL FAIL
		'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
		Dim Ris As Boolean = InternalIsValid
		'PUT YOUR LOGIC VALIDATION CODE HERE
		Return Ris
	End Function

	Public Overrides Function Read(Id As Integer) As Integer Implements IGruppoLBConsigliato.Read
		Dim Ris as integer = MyBase.Read(Id)
		Return Ris
	End Function

	Public Overrides Function Refresh() As Integer
		Return MyBase.Refresh
	End Function

	Public Overrides Function Save() As Integer Implements IGruppoLBConsigliato.Save
		Dim Ris as integer = MyBase.Save()
		Return Ris
	End Function

	Public Overrides Function ToString() As String
		Return MyBase.ToString()
	End Function

#End Region

End Class

''' <summary>
'''Interface for table T_gruppilbconsigliati
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IGruppoLBConsigliato
	Inherits _IGruppoLBConsigliato

#Region "Method"

	Function Read(Id As Integer) As Integer

	Function Save() As Integer

	Function IsValid() As Boolean

#End Region

End Interface