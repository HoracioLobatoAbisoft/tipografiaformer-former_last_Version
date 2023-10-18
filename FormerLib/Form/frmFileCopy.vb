Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Friend Class frmFileCopy
    'Inherits baseFormInterna
    Private Enum enTipoAzione
        Copia = 1
        Sposta
    End Enum

    Private Azione As enTipoAzione = enTipoAzione.Copia

    Private _Ris As Integer = 0
    Private _Origine As String
    Private _Destinazione As String
    Private _ResizeImg As Boolean

    Friend Function Copia(ByVal Origine As String,
                          ByVal Destinazione As String,
                          Optional ByVal ResizeImg As Boolean = False) As Integer

        Azione = enTipoAzione.Copia
        _ResizeImg = ResizeImg
        _Origine = Origine
        _Destinazione = Destinazione

        lblOrigine.Text = Origine
        ToolTipFile.SetToolTip(lblOrigine, Origine)
        lblDestinazione.Text = Destinazione
        ToolTipFile.SetToolTip(lblDestinazione, Destinazione)

        ShowDialog()

        Return _Ris

    End Function

    Friend Function Sposta(ByVal Origine As String,
                           ByVal Destinazione As String,
                           Optional ByVal ResizeImg As Boolean = False) As Integer

        Azione = enTipoAzione.Sposta
        _ResizeImg = ResizeImg
        _Origine = Origine
        _Destinazione = Destinazione

        lblOrigine.Text = Origine
        ToolTipFile.SetToolTip(lblOrigine, Origine)
        lblDestinazione.Text = Destinazione
        ToolTipFile.SetToolTip(lblDestinazione, Destinazione)

        ShowDialog()

        Return _Ris

    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Close()

    End Sub

    Private Sub tmrStart_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrStart.Tick

        tmrStart.Enabled = False

        CopiaFile()

    End Sub

    Private Sub CopiaFile()
        'tenta di copiare il file di origine su quello di destinazione
        'se da errore permette di riprovare

        Try

            If _ResizeImg Then
                ResizeImg(_Origine, _Destinazione)
            Else
                If Azione = enTipoAzione.Copia Then
                    System.IO.File.Copy(_Origine, _Destinazione, True)
                ElseIf Azione = enTipoAzione.Sposta Then
                    System.IO.File.Copy(_Origine, _Destinazione, True)
                    Try
                        System.IO.File.Delete(_Origine)
                    Catch ex As Exception

                    End Try
                End If
            End If
            _Ris = 1
            Close()

        Catch ex As Exception
            'qui c'e' un errore

            'If FormerDebug.DebugAttivo = False Then
            If Not ex Is Nothing Then
                Dim Messaggio As String = "Si � verificato il seguente errore nella copia del file: " & ex.Message

                If FormerLib.FormerHelper.File.IsFileLocked(_Origine) Then
                    Messaggio &= ControlChars.NewLine & "Il file di origine '" & _Origine & "' risulta locked."
                End If

                If FormerLib.FormerHelper.File.IsFileLocked(_Destinazione) Then
                    Messaggio &= ControlChars.NewLine & "Il file di destinazione '" & _Destinazione & "' risulta locked."
                End If

                MessageBox.Show(Messaggio, "Errore copia file", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnRetry.Enabled = True
                btnIgnore.Enabled = True
            End If
            'Else
            '_Ris = 1
            '   Close()
            'End If

        End Try

    End Sub

    Private Sub ResizeImg(ByVal PathOld As String, ByVal PathNew As String)

        Dim Img As New Bitmap(PathOld)

        Dim width As Integer = 0, height As Integer = 0

        If Img.Width > Img.Height Then
            width = 800
            height = 600
        ElseIf Img.Width < Img.Height Then
            width = 600
            height = 800
        Else
            width = 800
            height = 800
        End If

        Dim ImgNew = New Bitmap(Img, New Size(width, height))

        Using ms As New MemoryStream()
            ImgNew.Save(ms, Imaging.ImageFormat.Jpeg)

            Dim imgData(ms.Length - 1) As Byte
            ms.Position = 0
            ms.Read(imgData, 0, ms.Length)
            Using fs As New FileStream(PathNew, FileMode.Create, FileAccess.Write)
                fs.Write(imgData, 0, UBound(imgData))
            End Using
        End Using
    End Sub

    Private Sub btnRetry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetry.Click
        btnRetry.Enabled = False
        btnIgnore.Enabled = False

        CopiaFile()
    End Sub

    Private Sub btnIgnore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIgnore.Click
        _Ris = 0
        Close()

    End Sub

End Class