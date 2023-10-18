#Region "Author"
'*********************************
'LUNA ORM -	http://www.lunaorm.org
'*********************************
'Code created with Luna 4.18.3.31 
'Author: Diego Lunadei
'Date: 23/03/2018 
#End Region


Imports System.Xml.Serialization

''' <summary>
'''DAO Class for table Td_tipopagamenti
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public MustInherit Class _TipoPagamentoW
	Inherits LUNA.LunaBaseClassEntity
	Implements _ITipoPagamentoW
	'******IMPORTANT: Don't write your code here. Write your code in the Class object that inherits from this Class.
	'******So you can replace this file without lost your code

	Public Sub New()

	End Sub

	Public Sub New(myRecord As IDataRecord)
		FillFromDataRecord(myRecord)
	End Sub

	Friend Overridable Sub FillFromDataRecord(myRecord As IDataRecord) Implements _ITipoPagamentoW.FillFromDataRecord
		IdTipoPagam = myRecord("IdTipoPagam")
		if not myRecord("Descrizione") is DBNull.Value then Descrizione = myRecord("Descrizione")
		if not myRecord("ggToAdd") is DBNull.Value then ggToAdd = myRecord("ggToAdd")
		if not myRecord("ImgWeb") is DBNull.Value then ImgWeb = myRecord("ImgWeb")
		if not myRecord("ImportoMaggiorazione") is DBNull.Value then ImportoMaggiorazione = myRecord("ImportoMaggiorazione")
		if not myRecord("ImportoMassimoPagabile") is DBNull.Value then ImportoMassimoPagabile = myRecord("ImportoMassimoPagabile")
		if not myRecord("ModoPagam") is DBNull.Value then ModoPagam = myRecord("ModoPagam")
		if not myRecord("OrdOnline") is DBNull.Value then OrdOnline = myRecord("OrdOnline")
		if not myRecord("PeriodoPagam") is DBNull.Value then PeriodoPagam = myRecord("PeriodoPagam")
		if not myRecord("TipoPagam") is DBNull.Value then TipoPagam = myRecord("TipoPagam")
   
		ResetIsChanged()
	End Sub

	Private Property Manager As LUNA.ILunaBaseClassDAO(Of TipoPagamentoW)
		Get
			If _Mgr Is Nothing Then
				Dim _MgrType As System.Type = LUNA.LunaContext.GetMgrTypeForEntity(Me.GetType)
				If _MgrType Is Nothing Then _MgrType = GetType(TipiPagamentiWDAO)
				_Mgr = Activator.CreateInstance(_MgrType)
			End If
			Return _Mgr
		End Get
		Set(value As LUNA.ILunaBaseClassDAO(Of TipoPagamentoW))
			_Mgr = value
		End Set
	End Property

#Region "Database Field Map"

	Public Class WhatIsChanged

		Public Shared Property IdTipoPagam As Boolean = LUNA.LunaContext.WriteAllFieldEveryTime 
		Public Shared Property Descrizione As Boolean = LUNA.LunaContext.WriteAllFieldEveryTime 
		Public Shared Property ggToAdd As Boolean = LUNA.LunaContext.WriteAllFieldEveryTime 
		Public Shared Property ImgWeb As Boolean = LUNA.LunaContext.WriteAllFieldEveryTime 
		Public Shared Property ImportoMaggiorazione As Boolean = LUNA.LunaContext.WriteAllFieldEveryTime 
		Public Shared Property ImportoMassimoPagabile As Boolean = LUNA.LunaContext.WriteAllFieldEveryTime 
		Public Shared Property ModoPagam As Boolean = LUNA.LunaContext.WriteAllFieldEveryTime 
		Public Shared Property OrdOnline As Boolean = LUNA.LunaContext.WriteAllFieldEveryTime 
		Public Shared Property PeriodoPagam As Boolean = LUNA.LunaContext.WriteAllFieldEveryTime 
		Public Shared Property TipoPagam As Boolean = LUNA.LunaContext.WriteAllFieldEveryTime 

	End Class

	Private Sub ResetIsChanged()

		IsChanged = False
		WhatIsChanged.IdTipoPagam = LUNA.LunaContext.WriteAllFieldEveryTime 
		WhatIsChanged.Descrizione = LUNA.LunaContext.WriteAllFieldEveryTime 
		WhatIsChanged.ggToAdd = LUNA.LunaContext.WriteAllFieldEveryTime 
		WhatIsChanged.ImgWeb = LUNA.LunaContext.WriteAllFieldEveryTime 
		WhatIsChanged.ImportoMaggiorazione = LUNA.LunaContext.WriteAllFieldEveryTime 
		WhatIsChanged.ImportoMassimoPagabile = LUNA.LunaContext.WriteAllFieldEveryTime 
		WhatIsChanged.ModoPagam = LUNA.LunaContext.WriteAllFieldEveryTime 
		WhatIsChanged.OrdOnline = LUNA.LunaContext.WriteAllFieldEveryTime 
		WhatIsChanged.PeriodoPagam = LUNA.LunaContext.WriteAllFieldEveryTime 
		WhatIsChanged.TipoPagam = LUNA.LunaContext.WriteAllFieldEveryTime 

	End Sub

	Protected _IdTipoPagam as integer  = 0 
	Public Overridable Property IdTipoPagam() as integer  Implements _ITipoPagamentoW.IdTipoPagam
		Get
			Return _IdTipoPagam
		End Get
		Set (byval value as integer)
			If _IdTipoPagam <> value Then
				IsChanged = True
				WhatIsChanged.IdTipoPagam = True
				_IdTipoPagam = value
			End If
		End Set
	End property 

	Protected _Descrizione as string  = "" 
	Public Overridable Property Descrizione() as string  Implements _ITipoPagamentoW.Descrizione
		Get
			Return _Descrizione
		End Get
		Set (byval value as string)
			If _Descrizione <> value Then
				IsChanged = True
				WhatIsChanged.Descrizione = True
				_Descrizione = value
			End If
		End Set
	End property 

	Protected _ggToAdd as integer  = 0 
	Public Overridable Property ggToAdd() as integer  Implements _ITipoPagamentoW.ggToAdd
		Get
			Return _ggToAdd
		End Get
		Set (byval value as integer)
			If _ggToAdd <> value Then
				IsChanged = True
				WhatIsChanged.ggToAdd = True
				_ggToAdd = value
			End If
		End Set
	End property 

	Protected _ImgWeb as string  = "" 
	Public Overridable Property ImgWeb() as string  Implements _ITipoPagamentoW.ImgWeb
		Get
			Return _ImgWeb
		End Get
		Set (byval value as string)
			If _ImgWeb <> value Then
				IsChanged = True
				WhatIsChanged.ImgWeb = True
				_ImgWeb = value
			End If
		End Set
	End property 

	Protected _ImportoMaggiorazione as decimal  = 0 
	Public Overridable Property ImportoMaggiorazione() as decimal  Implements _ITipoPagamentoW.ImportoMaggiorazione
		Get
			Return _ImportoMaggiorazione
		End Get
		Set (byval value as decimal)
			If _ImportoMaggiorazione <> value Then
				IsChanged = True
				WhatIsChanged.ImportoMaggiorazione = True
				_ImportoMaggiorazione = value
			End If
		End Set
	End property 

	Protected _ImportoMassimoPagabile as decimal  = 0 
	Public Overridable Property ImportoMassimoPagabile() as decimal  Implements _ITipoPagamentoW.ImportoMassimoPagabile
		Get
			Return _ImportoMassimoPagabile
		End Get
		Set (byval value as decimal)
			If _ImportoMassimoPagabile <> value Then
				IsChanged = True
				WhatIsChanged.ImportoMassimoPagabile = True
				_ImportoMassimoPagabile = value
			End If
		End Set
	End property 

	Protected _ModoPagam as string  = "" 
	Public Overridable Property ModoPagam() as string  Implements _ITipoPagamentoW.ModoPagam
		Get
			Return _ModoPagam
		End Get
		Set (byval value as string)
			If _ModoPagam <> value Then
				IsChanged = True
				WhatIsChanged.ModoPagam = True
				_ModoPagam = value
			End If
		End Set
	End property 

	Protected _OrdOnline as integer  = 0 
	Public Overridable Property OrdOnline() as integer  Implements _ITipoPagamentoW.OrdOnline
		Get
			Return _OrdOnline
		End Get
		Set (byval value as integer)
			If _OrdOnline <> value Then
				IsChanged = True
				WhatIsChanged.OrdOnline = True
				_OrdOnline = value
			End If
		End Set
	End property 

	Protected _PeriodoPagam as integer  = 0 
	Public Overridable Property PeriodoPagam() as integer  Implements _ITipoPagamentoW.PeriodoPagam
		Get
			Return _PeriodoPagam
		End Get
		Set (byval value as integer)
			If _PeriodoPagam <> value Then
				IsChanged = True
				WhatIsChanged.PeriodoPagam = True
				_PeriodoPagam = value
			End If
		End Set
	End property 

	Protected _TipoPagam as string  = "" 
	Public Overridable Property TipoPagam() as string  Implements _ITipoPagamentoW.TipoPagam
		Get
			Return _TipoPagam
		End Get
		Set (byval value as string)
			If _TipoPagam <> value Then
				IsChanged = True
				WhatIsChanged.TipoPagam = True
				_TipoPagam = value
			End If
		End Set
	End property 


#End Region

#Region "Method"
	''' <summary>
	'''This method read an TipoPagamentoW from DB.
	''' </summary>
	''' <returns>
	'''Return 0 if all ok, 1 if error
	''' </returns>
	Public Overridable Function Read(Id As Integer) As Integer
		'Return 0 if all ok
		Dim Ris As Integer = 0
		Try
			Using Manager
				Dim int As TipoPagamentoW = Manager.Read(Id)
				_IdTipoPagam = int.IdTipoPagam
				_Descrizione = int.Descrizione
				_ggToAdd = int.ggToAdd
				_ImgWeb = int.ImgWeb
				_ImportoMaggiorazione = int.ImportoMaggiorazione
				_ImportoMassimoPagabile = int.ImportoMassimoPagabile
				_ModoPagam = int.ModoPagam
				_OrdOnline = int.OrdOnline
				_PeriodoPagam = int.PeriodoPagam
				_TipoPagam = int.TipoPagam
			End Using
			Manager = nothing
		Catch ex As Exception
			ManageError(ex)
			Ris = 1
		End Try
		Return Ris
	End Function

	''' <summary>
	'''This method save an TipoPagamentoW on DB.
	''' </summary>
	''' <returns>
	'''Return Id insert in DB if all ok, 0 if error
	''' </returns>
	Public Overridable Function Save() As Integer
		'Return the id Inserted
		Dim Ris As Integer = 0
		Try
			Using Manager
				Ris = Manager.Save(Me)
			End Using
			Manager = nothing
		Catch ex As Exception
			ManageError(ex)
		End Try
		Return Ris
	End Function

	Protected Function InternalIsValid() As Boolean
		Dim Ris As Boolean = True
		if _Descrizione.Length > 255 then Ris = False
		if _ImgWeb.Length > 255 then Ris = False
		if _ModoPagam.Length > 255 then Ris = False
		if _TipoPagam.Length > 255 then Ris = False

		Return Ris
	End Function

#End Region

#Region "Embedded Class"


#End Region

End Class 

''' <summary>
'''Interface for table Td_tipopagamenti
''' </summary>
''' <remarks>
'''Don't write code here
''' </remarks>

Public Interface _ITipoPagamentoW

	Sub FillFromDataRecord(myRecord As IDataRecord)

#Region "Database Field Map"

	Property IdTipoPagam() as integer
	Property Descrizione() as string
	Property ggToAdd() as integer
	Property ImgWeb() as string
	Property ImportoMaggiorazione() as decimal
	Property ImportoMassimoPagabile() as decimal
	Property ModoPagam() as string
	Property OrdOnline() as integer
	Property PeriodoPagam() as integer
	Property TipoPagam() as string

#End Region

End Interface

Partial Public Class LFM

	Public Class TipoPagamentoW
		Public Shared ReadOnly Property IdTipoPagam As New LUNA.LunaFieldName("IdTipoPagam")
		Public Shared ReadOnly Property Descrizione As New LUNA.LunaFieldName("Descrizione")
		Public Shared ReadOnly Property ggToAdd As New LUNA.LunaFieldName("ggToAdd")
		Public Shared ReadOnly Property ImgWeb As New LUNA.LunaFieldName("ImgWeb")
		Public Shared ReadOnly Property ImportoMaggiorazione As New LUNA.LunaFieldName("ImportoMaggiorazione")
		Public Shared ReadOnly Property ImportoMassimoPagabile As New LUNA.LunaFieldName("ImportoMassimoPagabile")
		Public Shared ReadOnly Property ModoPagam As New LUNA.LunaFieldName("ModoPagam")
		Public Shared ReadOnly Property OrdOnline As New LUNA.LunaFieldName("OrdOnline")
		Public Shared ReadOnly Property PeriodoPagam As New LUNA.LunaFieldName("PeriodoPagam")
		Public Shared ReadOnly Property TipoPagam As New LUNA.LunaFieldName("TipoPagam")
	End Class

End Class