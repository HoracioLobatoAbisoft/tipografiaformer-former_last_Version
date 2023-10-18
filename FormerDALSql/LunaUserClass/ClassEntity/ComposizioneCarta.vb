#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.4.18.19488 
'Author: Diego Lunadei
'Date: 18/09/2013 
#End Region


Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data
Imports System.Data.SqlClient
Imports FormerBusinessLogicInterface

''' <summary>
'''Entity Class for table Tr_cartacomposta
''' </summary>
''' <remarks>
'''Write your custom method and property here
''' </remarks>

Public Class ComposizioneCarta
    Inherits _ComposizioneCarta
    Implements IComposizioneCarta
    Implements IComposizioneCartaB

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(myRecord As IDataRecord)
        MyBase.New(myRecord)
    End Sub

#Region "Database Field"


    Public Overrides Property IdCartaComposta() As Integer Implements IComposizioneCartaB.IdCartaComposta
        Get
            Return MyBase.IdCartaComposta
        End Get
        Set(ByVal value As Integer)
            MyBase.IdCartaComposta = value
        End Set
    End Property


    Public Overrides Property IdCartaPadre() As Integer Implements IComposizioneCartaB.IdCartaPadre
        Get
            Return MyBase.IdCartaPadre
        End Get
        Set(ByVal value As Integer)
            MyBase.IdCartaPadre = value
        End Set
    End Property


    Public Overrides Property IdCartaSingola() As Integer Implements IComposizioneCartaB.IdCartaSingola
        Get
            Return MyBase.IdCartaSingola
        End Get
        Set(ByVal value As Integer)
            MyBase.IdCartaSingola = value
        End Set
    End Property


    Public Overrides Property NumFogli() As Integer Implements IComposizioneCartaB.NumFogli
        Get
            Return MyBase.NumFogli
        End Get
        Set(ByVal value As Integer)
            MyBase.NumFogli = value
        End Set
    End Property


#End Region

#Region "Logic Field"

    Public ReadOnly Property CartaSingolaB As ITipoCartaB Implements IComposizioneCartaB.CartaSingola
        Get
            Return CartaSingola
        End Get
    End Property

    Private _CartaSingola As TipoCarta
    Public Property CartaSingola As TipoCarta
        Get
            If _CartaSingola Is Nothing Then
                _CartaSingola = New TipoCarta
                _CartaSingola.Read(_IdCartaSingola)

            End If
            Return _CartaSingola
        End Get
        Set(value As TipoCarta)
            _CartaSingola = value
        End Set
    End Property

#End Region

#Region "Method"

    Public Overrides Function IsValid() As Boolean Implements IComposizioneCarta.IsValid
        'RETURN TRUE IF THE OBJECT IS READY FOR SAVE
        'RETURN FALSE IF LOGIC CONTROL FAIL
        'INTERNALISVALID FUNCTION MADE SIMPLE DB CONTROL
        Dim Ris As Boolean = InternalIsValid
        'PUT YOUR LOGIC VALIDATION CODE HERE
        Return Ris
    End Function

    Public Overrides Function Read(Id As Integer) As Integer Implements IComposizioneCarta.Read
        Dim Ris As Integer = MyBase.Read(Id)
        Return Ris
    End Function

    Public Overrides Function Save() As Integer Implements IComposizioneCarta.Save
        Dim Ris As Integer = MyBase.Save()
        Return Ris
    End Function

    Public Overrides Function ToString() As String
        Return CartaSingola.Riassunto
    End Function

#End Region

End Class



''' <summary>
'''Interface for table Tr_cartacomposta
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface IComposizioneCarta
    Inherits _IComposizioneCarta

#Region "Method"

    Function Read(Id As Integer) As Integer

    Function Save() As Integer

    Function IsValid() As Boolean

#End Region

End Interface