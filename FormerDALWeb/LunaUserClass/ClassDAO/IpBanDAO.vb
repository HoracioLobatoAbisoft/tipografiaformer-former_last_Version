#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.16.6.1 
'Author: Diego Lunadei
'Date: 14/07/2016 
#End Region


Imports System.Data.Common

''' <summary>
'''DAO Class for table Ipban
''' </summary>
''' <remarks>
'''Write your DATABASE custom method here
''' </remarks>
Public Class IpBanDAO
	Inherits _IpBanDAO

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As DbConnection)
        MyBase.New(Connection)
    End Sub

    Protected Overrides Property EmptyItemDescription As String = "Selezionare una voce"

End Class