﻿Imports System.Linq
Imports System.Text
Imports System.Collections.Generic
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
    Partial Public Class FormatoProdottoWizard
        Inherits FormatoProdottoWizardBase
        '''<summary>
        '''Create the template output
        '''</summary>
        Public Overridable Function TransformText() As String
            Me.Write("<div class=""bloccoW ")
            
            #ExternalSource("C:\Lavoro\Former\Source\main\FormerWeb\code\template\template\FormatoProdottoWizard.tt",7)
if IsConsigliato then 
            
            #End ExternalSource
            Me.Write(" bloccoConsigliato ")
            
            #ExternalSource("C:\Lavoro\Former\Source\main\FormerWeb\code\template\template\FormatoProdottoWizard.tt",7)
end if
            
            #End ExternalSource
            Me.Write(" hasTooltip"">"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<a href=""")
            
            #ExternalSource("C:\Lavoro\Former\Source\main\FormerWeb\code\template\template\FormatoProdottoWizard.tt",8)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(FormerUrlCreator.GetUrl(IdPrev,_F.IdFormProd)))
            
            #End ExternalSource
            Me.Write(""" title=""")
            
            #ExternalSource("C:\Lavoro\Former\Source\main\FormerWeb\code\template\template\FormatoProdottoWizard.tt",8)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(_F.FormatoCartaStr))
            
            #End ExternalSource
            Me.Write(" ")
            
            #ExternalSource("C:\Lavoro\Former\Source\main\FormerWeb\code\template\template\FormatoProdottoWizard.tt",8)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(_F.OrientamentoStr))
            
            #End ExternalSource
            Me.Write(""">"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<img src=""")
            
            #ExternalSource("C:\Lavoro\Former\Source\main\FormerWeb\code\template\template\FormatoProdottoWizard.tt",9)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(FormerWebApp.PathListinoImg))
            
            #End ExternalSource
            
            #ExternalSource("C:\Lavoro\Former\Source\main\FormerWeb\code\template\template\FormatoProdottoWizard.tt",9)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(_F.Imgrif))
            
            #End ExternalSource
            Me.Write(""" border=0 alt=""")
            
            #ExternalSource("C:\Lavoro\Former\Source\main\FormerWeb\code\template\template\FormatoProdottoWizard.tt",9)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(_F.FormatoCartaStr))
            
            #End ExternalSource
            Me.Write(" ")
            
            #ExternalSource("C:\Lavoro\Former\Source\main\FormerWeb\code\template\template\FormatoProdottoWizard.tt",9)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(_F.OrientamentoStr))
            
            #End ExternalSource
            Me.Write("""><br />"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))
            
            #ExternalSource("C:\Lavoro\Former\Source\main\FormerWeb\code\template\template\FormatoProdottoWizard.tt",10)
if _f.Prodottofinito then 
            
            #End ExternalSource
            Me.Write("<h3>")
            
            #ExternalSource("C:\Lavoro\Former\Source\main\FormerWeb\code\template\template\FormatoProdottoWizard.tt",11)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(_F.Formato))
            
            #End ExternalSource
            Me.Write("</h3>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<h4>&nbsp;</h4>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))
            
            #ExternalSource("C:\Lavoro\Former\Source\main\FormerWeb\code\template\template\FormatoProdottoWizard.tt",13)
else 
            
            #End ExternalSource
            Me.Write("<h3>")
            
            #ExternalSource("C:\Lavoro\Former\Source\main\FormerWeb\code\template\template\FormatoProdottoWizard.tt",14)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(_F.FormatoCartaStr))
            
            #End ExternalSource
            Me.Write(" ")
            
            #ExternalSource("C:\Lavoro\Former\Source\main\FormerWeb\code\template\template\FormatoProdottoWizard.tt",14)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(_F.OrientamentoStr))
            
            #End ExternalSource
            Me.Write(" </h3>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<h4>")
            
            #ExternalSource("C:\Lavoro\Former\Source\main\FormerWeb\code\template\template\FormatoProdottoWizard.tt",16)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(_F.DimensioniCartaStr))
            
            #End ExternalSource
            Me.Write("</h4>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))
            
            #ExternalSource("C:\Lavoro\Former\Source\main\FormerWeb\code\template\template\FormatoProdottoWizard.tt",17)
end if 
            
            #End ExternalSource
            Me.Write("</a>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"</div><div class=""hidden tooltiptext"">"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<img src=""/img/icoInformation.png"" "& _ 
                    "class=""imgSx"" />"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<h4>")
            
            #ExternalSource("C:\Lavoro\Former\Source\main\FormerWeb\code\template\template\FormatoProdottoWizard.tt",21)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(_F.Formato))
            
            #End ExternalSource
            Me.Write("</h4>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))
            
            #ExternalSource("C:\Lavoro\Former\Source\main\FormerWeb\code\template\template\FormatoProdottoWizard.tt",22)
            Me.Write(Me.ToStringHelper.ToStringWithCulture(_F.DescrizioneHTML))
            
            #End ExternalSource
            Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"</div>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))
            Return Me.GenerationEnvironment.ToString
        End Function
    End Class
    #Region "Base class"
    '''<summary>
    '''Base class for this transformation
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")>  _
    Public Class FormatoProdottoWizardBase
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
