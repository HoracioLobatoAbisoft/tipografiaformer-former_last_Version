#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.4.18.19488 
'Author: Diego Lunadei
'Date: 18/09/2013 
#End Region


'Imports System
'Imports System.Xml
'Imports System.Xml.Serialization
'Imports System.Data
Imports System.Data.Common

'Imports System.Data.SqlClient


''' <summary>
'''DAO Class for table T_zone
''' </summary>
''' <remarks>
'''Write your DATABASE custom method here
''' </remarks>
Public Class ZoneDAO
    Inherits _ZoneDAO
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As DbConnection)
        MyBase.New(Connection)
    End Sub

    Protected Overrides Property EmptyItemDescription As String = "Selezionare una Zona"

End Class