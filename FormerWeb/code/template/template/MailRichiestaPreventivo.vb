﻿Imports System.Linq
Imports System.Text
Imports System.Collections.Generic
Imports FormerDALWeb
Imports FormerLib
Imports FormerLib.FormerEnum
Imports System

'------------------------------------------------------------------------------
'<auto-generated>
'    Questo codice è stato generato da uno strumento.
'    Versione runtime: 16.0.0.0
' 
'    Le modifiche a questo file possono causare un comportamento non corretto e verranno perse se
'    il codice viene rigenerato.
'</auto-generated>
'------------------------------------------------------------------------------
Namespace My.Templates
    '''<summary>
    '''Class to produce the template output
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")>  _
    Partial Public Class MailRichiestaPreventivo
        Inherits MailRichiestaPreventivoBase
        '''<summary>
        '''Create the template output
        '''</summary>
        Public Overridable Function TransformText() As String
            Me.Write("<h1>Richiesta di Preventivo</h1>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<div style='heigth:100px;border:5px solid #d6e0"& _ 
                    "3d;border-radius:5px;padding:10px;margin:20px;'>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<h2>Richiesta di Preventivo: F"& _ 
                    "PGUID {")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",12)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(R.GuidRichiesta))
            
            #End ExternalSource
            Me.Write("}</h2>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<font size=1>In ogni successiva mail che invierete riguardo questo preven"& _ 
                    "tivo includete nel testo della vostra mail il testo: FPGUID{")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",13)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(R.GuidRichiesta))
            
            #End ExternalSource
            Me.Write("}</font><br><br>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<center><table style='border:1px solid #aaaaaa;border-radius:5p"& _ 
                    "x;'>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<tr><td width=128><img src='https://www.tipografiaformer.it/listino/img/")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",15)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(R.LPart.GetImgFormato))
            
            #End ExternalSource
            Me.Write("'></td><td valign=top>Richiesta di preventivo per variante di <h3 style='backgrou"& _ 
                    "nd-color:white;padding:3px;'>")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",15)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(R.LPart.Nome))
            
            #End ExternalSource
            Me.Write("</h3>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<a href='https://www.tipografiaformer.it")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",16)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(FormerUrlCreator.GetUrlLb(R.LPart)))
            
            #End ExternalSource
            Me.Write("'>(clicca qui per andare al dettaglio sul sito)</a></td></tr>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"</table></center>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<br>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Data: <b style='font-size:14px;'>")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",19)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(R.QuandoStr))
            
            #End ExternalSource
            Me.Write("</b><br>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Cliente: <b style='font-size:14px;'>")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",20)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(R.RagioneSocialeNome))
            
            #End ExternalSource
            Me.Write("</b><br>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Email: <b style='font-size:14px;'>")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",21)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(R.Email))
            
            #End ExternalSource
            Me.Write("</b><br><br>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"</div>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<div style='heigth:100px;border:5px solid #850c70;border-"& _ 
                    "radius:5px;padding:10px;margin:20px;'>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<h2>Variante Richiesta</h2>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<table>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<t"& _ 
                    "r><td>Reparto</td><td bgcolor=""")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",27)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(R.RepartoBkgColor))
            
            #End ExternalSource
            Me.Write("""><b>")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",27)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(R.RepartoStr))
            
            #End ExternalSource
            Me.Write("</b></td></tr>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<tr bgcolor=""#f1f1f1""><td>Nome Lavoro</td><td><b>")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",28)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(R.NomeLavoro))
            
            #End ExternalSource
            Me.Write("</b></td></tr>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<tr><td>Quantit&agrave;</td><td><b>")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",29)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(R.Qta))
            
            #End ExternalSource
            Me.Write("</b></td></tr>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<tr bgcolor=""#f1f1f1""><td>Larghezza</td><td><b>")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",30)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(R.Larghezza))
            
            #End ExternalSource
            Me.Write("</b></td></tr>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<tr><td>Lunghezza</td><td><b>")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",31)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(R.Lunghezza))
            
            #End ExternalSource
            Me.Write("</b></td></tr>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<tr bgcolor=""#f1f1f1""><td>Orientamento</td><td><b>")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",32)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(R.OrientamentoStr))
            
            #End ExternalSource
            Me.Write("</b></td></tr>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<tr><td>Finitura</td><td><b>")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",33)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(R.Finitura))
            
            #End ExternalSource
            Me.Write("</b></td></tr>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<tr bgcolor=""#f1f1f1""><td>Tipo Carta</td><td><b>")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",34)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(R.TipoCarta))
            
            #End ExternalSource
            Me.Write("</b></td></tr>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<tr><td>Colore Stampa</td><td><b>")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",35)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(R.CS.Descrizione))
            
            #End ExternalSource
            Me.Write("</b></td></tr>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<tr><td valign=top>Opzioni scelte</td><td>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",37)
For Each L As LavorazioneW In R.ElencoOpzioniSel
            
            #End ExternalSource
            Me.Write("<img src='https://www.tipografiaformer.it/listino/img/")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",38)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(L.ImgRif))
            
            #End ExternalSource
            Me.Write("' align=absmiddle style='border-radius:5px; border:1px solid #d6e03d; width:64px;"& _ 
                    "'> <b>")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",38)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(L.Descrizione))
            
            #End ExternalSource
            Me.Write("</b><br>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",39)
Next 
            
            #End ExternalSource
            Me.Write("</td></tr>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<tr bgcolor=""#f1f1f1""><td valign=top>Note e Indicazioni aggiuntive</t"& _ 
                    "d><td><b>")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",41)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(R.Annotazioni))
            
            #End ExternalSource
            Me.Write("</b></td></tr></table>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"</div>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<div style='heigth:100px;border:5px solid #f582"& _ 
                    "20;border-radius:5px;padding:10px;margin:20px;'>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<h2>Preventivo suggerito dal s"& _ 
                    "istema</h2>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<center><table style='border:1px solid #aaaaaa;border-radius:5px;'>"& _ 
                    ""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<tr><td width=128><img src='https://www.tipografiaformer.it/listino/img/")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",47)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(R.Lrif.GetImgFormato))
            
            #End ExternalSource
            Me.Write("'></td><td valign=top>Variante di <h3 style='background-color:white;padding:3px;'"& _ 
                    ">")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",47)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(R.Lrif.Nome))
            
            #End ExternalSource
            Me.Write("</h3>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<a href='https://www.tipografiaformer.it")
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",48)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(FormerUrlCreator.GetUrlLb(R.Lrif)))
            
            #End ExternalSource
            Me.Write("'>(clicca qui per andare al dettaglio sul sito)</a></td></tr>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"</table></center>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))
            
            #ExternalSource("D:\lavoro\Former\Source\main\FormerWeb\code\template\template\MailRichiestaPreventivo.tt",50)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(R.BufferPreventivo))
            
            #End ExternalSource
            Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"</div>")
            Return Me.GenerationEnvironment.ToString
        End Function
    End Class
    #Region "Base class"
    '''<summary>
    '''Base class for this transformation
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")>  _
    Public Class MailRichiestaPreventivoBase
        #Region "Fields"
        Private generationEnvironmentField As Global.System.Text.StringBuilder
        Private errorsField As Global.System.CodeDom.Compiler.CompilerErrorCollection
        Private indentLengthsField As Global.System.Collections.Generic.List(Of Integer)
        Private currentIndentField As String = ""
        Private endsWithNewline As Boolean
        Private sessionField As Global.System.Collections.Generic.IDictionary(Of String, Object)
        #End Region
        #Region "Properties"
        '''<summary>
        '''The string builder that generation-time code is using to assemble generated output
        '''</summary>
        Protected Property GenerationEnvironment() As System.Text.StringBuilder
            Get
                If (Me.generationEnvironmentField Is Nothing) Then
                    Me.generationEnvironmentField = New Global.System.Text.StringBuilder()
                End If
                Return Me.generationEnvironmentField
            End Get
            Set
                Me.generationEnvironmentField = value
            End Set
        End Property
        '''<summary>
        '''The error collection for the generation process
        '''</summary>
        Public ReadOnly Property Errors() As System.CodeDom.Compiler.CompilerErrorCollection
            Get
                If (Me.errorsField Is Nothing) Then
                    Me.errorsField = New Global.System.CodeDom.Compiler.CompilerErrorCollection()
                End If
                Return Me.errorsField
            End Get
        End Property
        '''<summary>
        '''A list of the lengths of each indent that was added with PushIndent
        '''</summary>
        Private ReadOnly Property indentLengths() As System.Collections.Generic.List(Of Integer)
            Get
                If (Me.indentLengthsField Is Nothing) Then
                    Me.indentLengthsField = New Global.System.Collections.Generic.List(Of Integer)()
                End If
                Return Me.indentLengthsField
            End Get
        End Property
        '''<summary>
        '''Gets the current indent we use when adding lines to the output
        '''</summary>
        Public ReadOnly Property CurrentIndent() As String
            Get
                Return Me.currentIndentField
            End Get
        End Property
        '''<summary>
        '''Current transformation session
        '''</summary>
        Public Overridable Property Session() As Global.System.Collections.Generic.IDictionary(Of String, Object)
            Get
                Return Me.sessionField
            End Get
            Set
                Me.sessionField = value
            End Set
        End Property
        #End Region
        #Region "Transform-time helpers"
        '''<summary>
        '''Write text directly into the generated output
        '''</summary>
        Public Overloads Sub Write(ByVal textToAppend As String)
            If String.IsNullOrEmpty(textToAppend) Then
                Return
            End If
            'If we're starting off, or if the previous text ended with a newline,
            'we have to append the current indent first.
            If ((Me.GenerationEnvironment.Length = 0)  _
                        OrElse Me.endsWithNewline) Then
                Me.GenerationEnvironment.Append(Me.currentIndentField)
                Me.endsWithNewline = false
            End If
            'Check if the current text ends with a newline
            If textToAppend.EndsWith(Global.System.Environment.NewLine, Global.System.StringComparison.CurrentCulture) Then
                Me.endsWithNewline = true
            End If
            'This is an optimization. If the current indent is "", then we don't have to do any
            'of the more complex stuff further down.
            If (Me.currentIndentField.Length = 0) Then
                Me.GenerationEnvironment.Append(textToAppend)
                Return
            End If
            'Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(Global.System.Environment.NewLine, (Global.System.Environment.NewLine + Me.currentIndentField))
            'If the text ends with a newline, then we should strip off the indent added at the very end
            'because the appropriate indent will be added when the next time Write() is called
            If Me.endsWithNewline Then
                Me.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - Me.currentIndentField.Length))
            Else
                Me.GenerationEnvironment.Append(textToAppend)
            End If
        End Sub
        '''<summary>
        '''Write text directly into the generated output
        '''</summary>
        Public Overloads Sub WriteLine(ByVal textToAppend As String)
            Me.Write(textToAppend)
            Me.GenerationEnvironment.AppendLine
            Me.endsWithNewline = true
        End Sub
        '''<summary>
        '''Write formatted text directly into the generated output
        '''</summary>
        Public Overloads Sub Write(ByVal format As String, <System.ParamArrayAttribute()> ByVal args() As Object)
            Me.Write(String.Format(Global.System.Globalization.CultureInfo.CurrentCulture, format, args))
        End Sub
        '''<summary>
        '''Write formatted text directly into the generated output
        '''</summary>
        Public Overloads Sub WriteLine(ByVal format As String, <System.ParamArrayAttribute()> ByVal args() As Object)
            Me.WriteLine(String.Format(Global.System.Globalization.CultureInfo.CurrentCulture, format, args))
        End Sub
        '''<summary>
        '''Raise an error
        '''</summary>
        Public Sub [Error](ByVal message As String)
            Dim [error] As System.CodeDom.Compiler.CompilerError = New Global.System.CodeDom.Compiler.CompilerError()
            [error].ErrorText = message
            Me.Errors.Add([error])
        End Sub
        '''<summary>
        '''Raise a warning
        '''</summary>
        Public Sub Warning(ByVal message As String)
            Dim [error] As System.CodeDom.Compiler.CompilerError = New Global.System.CodeDom.Compiler.CompilerError()
            [error].ErrorText = message
            [error].IsWarning = true
            Me.Errors.Add([error])
        End Sub
        '''<summary>
        '''Increase the indent
        '''</summary>
        Public Sub PushIndent(ByVal indent As String)
            If (indent = Nothing) Then
                Throw New Global.System.ArgumentNullException("indent")
            End If
            Me.currentIndentField = (Me.currentIndentField + indent)
            Me.indentLengths.Add(indent.Length)
        End Sub
        '''<summary>
        '''Remove the last indent that was added with PushIndent
        '''</summary>
        Public Function PopIndent() As String
            Dim returnValue As String = ""
            If (Me.indentLengths.Count > 0) Then
                Dim indentLength As Integer = Me.indentLengths((Me.indentLengths.Count - 1))
                Me.indentLengths.RemoveAt((Me.indentLengths.Count - 1))
                If (indentLength > 0) Then
                    returnValue = Me.currentIndentField.Substring((Me.currentIndentField.Length - indentLength))
                    Me.currentIndentField = Me.currentIndentField.Remove((Me.currentIndentField.Length - indentLength))
                End If
            End If
            Return returnValue
        End Function
        '''<summary>
        '''Remove any indentation
        '''</summary>
        Public Sub ClearIndent()
            Me.indentLengths.Clear
            Me.currentIndentField = ""
        End Sub
        #End Region
        #Region "ToString Helpers"
        '''<summary>
        '''Utility class to produce culture-oriented representation of an object as a string.
        '''</summary>
        Public Class ToStringInstanceHelper
            Private formatProviderField  As System.IFormatProvider = Global.System.Globalization.CultureInfo.InvariantCulture
            '''<summary>
            '''Gets or sets format provider to be used by ToStringWithCulture method.
            '''</summary>
            Public Property FormatProvider() As System.IFormatProvider
                Get
                    Return Me.formatProviderField 
                End Get
                Set
                    If (Not (value) Is Nothing) Then
                        Me.formatProviderField  = value
                    End If
                End Set
            End Property
            '''<summary>
            '''This is called from the compile/run appdomain to convert objects within an expression block to a string
            '''</summary>
            Public Function ToStringWithCulture(ByVal objectToConvert As Object) As String
                If (objectToConvert Is Nothing) Then
                    Throw New Global.System.ArgumentNullException("objectToConvert")
                End If
                Dim t As System.Type = objectToConvert.GetType
                Dim method As System.Reflection.MethodInfo = t.GetMethod("ToString", New System.Type() {GetType(System.IFormatProvider)})
                If (method Is Nothing) Then
                    Return objectToConvert.ToString
                Else
                    Return CType(method.Invoke(objectToConvert, New Object() {Me.formatProviderField }),String)
                End If
            End Function
        End Class
        Private toStringHelperField As ToStringInstanceHelper = New ToStringInstanceHelper()
        '''<summary>
        '''Helper to produce culture-oriented representation of an object as a string
        '''</summary>
        Public ReadOnly Property ToStringHelper() As ToStringInstanceHelper
            Get
                Return Me.toStringHelperField
            End Get
        End Property
        #End Region
    End Class
    #End Region
End Namespace
