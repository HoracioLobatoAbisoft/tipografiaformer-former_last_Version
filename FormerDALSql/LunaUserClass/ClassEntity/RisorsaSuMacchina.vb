#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.14.6.7 
'Author: Diego Lunadei
'Date: 08/11/2014 
#End Region


Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data
Imports System.Data.SqlClient
                
''' <summary>
'''Entity Class for table Tr_rismacchina
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class RisorsaSuMacchina
	Inherits _RisorsaSuMacchina
    Implements IRisorsaSuMacchina

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord as IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


Public Overrides Property IdRisMacchina() as integer
    Get
	    Return MyBase.IdRisMacchina
    End Get
    Set (byval value as integer)
        MyBase.IdRisMacchina= value
    End Set
End property 


Public Overrides Property IdRisorsa() as integer
    Get
	    Return MyBase.IdRisorsa
    End Get
    Set (byval value as integer)
        MyBase.IdRisorsa= value
    End Set
End property 


Public Overrides Property IdMacchinario() as integer
    Get
	    Return MyBase.IdMacchinario
    End Get
    Set (byval value as integer)
        MyBase.IdMacchinario= value
    End Set
End property 


#End Region

#Region "Logic Field"


#End Region

#Region "Method"

Public Overrides Function IsValid() As Boolean Implements IRisorsaSuMacchina.IsValid
	'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
	'RETURN FALSE IF LOGIC CONTROL FAIL
	'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
	Dim Ris As Boolean = InternalIsValid
	'PUT YOUR LOGIC VALIDATION CODE HERE
	Return Ris
End Function

Public Overrides Function Read(Id As Integer) As Integer Implements IRisorsaSuMacchina.Read
	Dim Ris as integer = MyBase.Read(Id)
    Return Ris
End Function

Public Overrides Function Save() As Integer Implements IRisorsaSuMacchina.Save
	Dim Ris as integer = MyBase.Save()
    Return Ris
End Function

Public Overrides Function ToString() As String
	Return MyBase.ToString()
End Function

#End Region

End Class



''' <summary>
'''Interface for table Tr_rismacchina
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IRisorsaSuMacchina
        Inherits _IRisorsaSuMacchina

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface