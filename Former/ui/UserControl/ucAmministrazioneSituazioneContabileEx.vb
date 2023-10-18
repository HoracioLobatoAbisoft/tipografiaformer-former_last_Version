Imports FormerDALSql
Imports FormerLib.FormerEnum
Public Class ucAmministrazioneSituazioneContabileEx
    Inherits ucFormerUserControl

    Private _IdRub As Integer = 0
    Private _DaIncassare As Decimal = 0
    Private _Incassati As Decimal = 0
    Private _TotaleDoc As Decimal = 0
    Private _Scaduti As Decimal = 0
    Private _TotProntoStampa As Decimal = 0
    Private Rigasel As Integer = 0
    Private GrigliaSel As DataGridView


    Public Property IdRub() As Integer
        Get
            Return _IdRub
        End Get
        Set(ByVal value As Integer)
            _IdRub = value
        End Set
    End Property

    Public Sub New()

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        BackColor = Color.White

    End Sub

    Friend Sub MostraSituaz()
        'If Not _cnOld Is Nothing Then

        'carico quando e' stata inviata l'ultima email riguardante il rendiconto economico
        Dim Mgr As New EmailDAO()
        Dim Par1 As New LUNA.LunaSearchParameter(LFM.Email.Titolo, "Situazione contabile aggiornata%", "LIKE")
        Dim Par2 As New LUNA.LunaSearchParameter(LFM.Email.IdRubDest, _IdRub)
        Dim Lst As List(Of Email) = Mgr.FindAll(New LUNA.LunaSearchOption With {.OrderBy = "QUANDO DESC"},
                                                Par1,
                                                Par2)

        If Lst.Count Then
            Dim email As Email = Lst(0)
            lblLastEmail.Text = email.Quando.ToString("dd/MM/yyyy HH:mm")
            email = Nothing
        Else
            lblLastEmail.Text = "-"
        End If
        Lst = Nothing
        Mgr = Nothing


        _DaIncassare = 0
        _Incassati = 0
        _Scaduti = 0
        _TotaleDoc = 0
        _TotProntoStampa = 0

        Dim dttable As DataTable
        Dim Contab As cContab = New cContab

        'dttable = Contab.Lista(cmbAnnoRif.Text.ToString, cmbMese.SelectedValue, _IdRub)
        Dim IdRif As Integer = 0
        If _IdRub Then
            IdRif = _IdRub
        End If

        Dim TipoDoc As Integer = 0

        dttable = Contab.ListaSituaz(IdRif, chkOnlyInCons.Checked, False) ', chkOnlyInCons.Checked)
        DgSituazNonScad.DataSource = dttable
        If DgSituazNonScad.ColumnCount Then

            DgSituazNonScad.Columns(0).Visible = False
            DgSituazNonScad.Columns(1).Visible = False
            DgSituazNonScad.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            DgSituazNonScad.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgSituazNonScad.Columns(8).DefaultCellStyle.Format = "0.00"
            DgSituazNonScad.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgSituazNonScad.Columns(9).DefaultCellStyle.Format = "0.00"
            DgSituazNonScad.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgSituazNonScad.Columns(10).DefaultCellStyle.Format = "0.00"
            DgSituazNonScad.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgSituazNonScad.Columns(11).DefaultCellStyle.Format = "0.00"

            DgSituazNonScad.Columns(12).Visible = False
            DgSituazNonScad.Columns(13).Visible = False
            DgSituazNonScad.Columns(15).Visible = False

            DgSituazNonScad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        End If

        Dim dtTableScad As DataTable = Contab.ListaSituaz(IdRif, False, chkOnlyNotPayd.Checked, True)
        DgScad.DataSource = dtTableScad
        If DgScad.ColumnCount Then

            DgScad.Columns(0).Visible = False
            DgScad.Columns(1).Visible = False
            DgScad.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            DgScad.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgScad.Columns(8).DefaultCellStyle.Format = "0.00"
            DgScad.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgScad.Columns(9).DefaultCellStyle.Format = "0.00"
            DgScad.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgScad.Columns(10).DefaultCellStyle.Format = "0.00"
            DgScad.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgSituazNonScad.Columns(11).DefaultCellStyle.Format = "0.00"

            DgScad.Columns(12).Visible = False
            DgScad.Columns(13).Visible = False
            DgScad.Columns(15).Visible = False

            DgScad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        End If

        RigaInserita()
        RigaInseritaScad()

        lblTotDoc.Text = FormerLib.FormerHelper.Stringhe.FormattaPrezzo(_TotaleDoc)
        lblTotDaIncassare.Text = FormerLib.FormerHelper.Stringhe.FormattaPrezzo(_DaIncassare)
        lblTotIncassato.Text = FormerLib.FormerHelper.Stringhe.FormattaPrezzo(_Incassati)
        lblTotDaIncassareScaduto.Text = FormerLib.FormerHelper.Stringhe.FormattaPrezzo(_Scaduti)
        lblTotProntoStampa.Text = FormerLib.FormerHelper.Stringhe.FormattaPrezzo(_TotProntoStampa)
        lblTotScopComples.Text = FormerLib.FormerHelper.Stringhe.FormattaPrezzo((_TotProntoStampa + _Scaduti))
        'End If
    End Sub

    Private Sub RigaInserita()
        'Exit Sub

        Dim Row As DataGridViewRow

        Dim RigaScaduta As Boolean

        For Each Row In DgSituazNonScad.Rows

            RigaScaduta = False
            Dim x As DataGridViewRow = Row 'DGRichieste.Rows.Item(Row.Index)
            Dim Incassati As Decimal = 0
            Dim Importi As Decimal = 0
            Try
                Dim TipoVoce As Integer = CType(x.Cells(1).FormattedValue, Integer)

                x.Cells(2).Style.ForeColor = Color.White
                x.Cells(2).Style.SelectionForeColor = Color.White
                Try
                    If x.Cells(5).Value.ToString.Length Then
                        If CDate(x.Cells(5).Value) < Now Then
                            x.Cells(5).Style.BackColor = Color.Red
                            x.Cells(5).Style.SelectionBackColor = Color.Red
                            RigaScaduta = True
                        End If
                    End If
                Catch ex As Exception

                End Try
                If TipoVoce = enTipoVoceContab.VoceAcquisto Then
                    x.Cells(2).Style.BackColor = Color.Red
                    x.Cells(2).Style.SelectionBackColor = Color.Red
                Else
                    x.Cells(2).Style.BackColor = Color.Green
                    x.Cells(2).Style.SelectionBackColor = Color.Green
                End If

                If x.Cells(10).Value.ToString.Length = 0 Then
                    If x.Cells(8).Value Then
                        x.Cells(10).Value = x.Cells(8).Value + x.Cells(9).Value
                    End If
                End If

                If x.Cells(10).Value.ToString.Length Then Importi = x.Cells(10).Value Else Importi = 0
                If x.Cells(11).Value.ToString.Length Then Incassati = x.Cells(11).Value Else Incassati = 0
                If Importi Then
                    If Importi > Incassati Then
                        x.Cells(11).Style.BackColor = Color.Red
                        x.Cells(11).Style.SelectionBackColor = Color.Red
                    ElseIf Importi <= Incassati Then
                        x.Cells(11).Style.BackColor = Color.Green
                        x.Cells(11).Style.SelectionBackColor = Color.Green
                    End If
                End If
                _TotaleDoc += Importi
                _DaIncassare += Importi - Incassati
                _Incassati += Incassati
                If RigaScaduta Then _Scaduti += Importi - Incassati
                'controllo se sta in fattura
                Try
                    If DirectCast(x.Cells(15).Value, Integer) Then
                        'qui c'e' l'id del documento
                        Dim NumFat As String
                        Using fat As New cContabRicavi
                            fat.Read(x.Cells(15).Value)
                            NumFat = fat.Numero
                        End Using
                        x.Cells(15).Value = "Fat. " & NumFat
                    End If
                Catch ex As Exception

                End Try
            Catch ex As Exception

            End Try



        Next

        'qui calcolo il totale pronto stampa per il cliente selezionato o per tutti 
        Dim cOrd As New OrdiniDAO

        _TotProntoStampa = cOrd.TotaleProntoStampa(_IdRub)

    End Sub

    Private Sub RigaInseritaScad()
        'Exit Sub

        Dim Row As DataGridViewRow

        Dim RigaScaduta As Boolean

        For Each Row In DgScad.Rows

            RigaScaduta = False
            Dim x As DataGridViewRow = Row 'DGRichieste.Rows.Item(Row.Index)
            Dim Incassati As Decimal = 0
            Dim Importi As Decimal = 0

            Try
                Dim TipoVoce As Integer = CType(x.Cells(1).FormattedValue, Integer)

                x.Cells(2).Style.ForeColor = Color.White
                x.Cells(2).Style.SelectionForeColor = Color.White
                Try
                    If x.Cells(5).Value.ToString.Length Then
                        If CDate(x.Cells(5).Value) < Now Then
                            x.Cells(5).Style.BackColor = Color.Red
                            x.Cells(5).Style.SelectionBackColor = Color.Red
                            RigaScaduta = True
                        End If
                    End If
                Catch ex As Exception

                End Try
                If TipoVoce = enTipoVoceContab.VoceAcquisto Then
                    x.Cells(2).Style.BackColor = Color.Red
                    x.Cells(2).Style.SelectionBackColor = Color.Red
                Else
                    x.Cells(2).Style.BackColor = Color.Green
                    x.Cells(2).Style.SelectionBackColor = Color.Green
                End If

                If x.Cells(10).Value.ToString.Length = 0 Then
                    If x.Cells(8).Value Then
                        x.Cells(10).Value = x.Cells(8).Value + x.Cells(9).Value
                    End If
                End If

                If x.Cells(10).Value.ToString.Length Then Importi = x.Cells(10).Value Else Importi = 0
                If x.Cells(11).Value.ToString.Length Then Incassati = x.Cells(11).Value Else Incassati = 0
                If Importi Then
                    If Importi > Incassati Then
                        x.Cells(11).Style.BackColor = Color.Red
                        x.Cells(11).Style.SelectionBackColor = Color.Red
                    ElseIf Importi <= Incassati Then
                        x.Cells(11).Style.BackColor = Color.Green
                        x.Cells(11).Style.SelectionBackColor = Color.Green
                    End If
                End If
                _TotaleDoc += Importi
                _DaIncassare += (Importi - Incassati)
                _Incassati += Incassati
                If RigaScaduta Then _Scaduti += Importi - Incassati
                'controllo se sta in fattura
                If x.Cells(15).Value.ToString.Length Then
                    If x.Cells(15).Value Then
                        'qui c'e' l'id del documento
                        Dim NumFat As String
                        Using fat As New cContabRicavi
                            fat.Read(x.Cells(15).Value)
                            NumFat = fat.Numero
                        End Using
                        x.Cells(15).Value = "Fat. " & NumFat
                    End If

                End If
            Catch ex As Exception

            End Try



        Next

        'qui calcolo il totale pronto stampa per il cliente selezionato o per tutti 
        Dim cOrd As New OrdiniDAO

        _TotProntoStampa = cOrd.TotaleProntoStampa(_IdRub)

    End Sub


    'Private Sub DgSituaz_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DgSituazNonScad.RowsAdded

    '    RigaInserita()
    'End Sub

    'Private Sub DgScad_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DgScad.RowsAdded

    '    RigaInseritaScad()
    'End Sub
    Private Sub DgSituaz_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgSituazNonScad.CellContentDoubleClick

        Rigasel = e.RowIndex

        If Rigasel <> -1 Then
            Dim IdVoce As Integer = CType(GrigliaSel.Rows(Rigasel).Cells(0).FormattedValue, Integer)
            Dim TipoVoce As Integer = CType(GrigliaSel.Rows(Rigasel).Cells(1).FormattedValue, Integer)
            Dim TipoDoc As Integer = CType(GrigliaSel.Rows(Rigasel).Cells(13).FormattedValue, Integer)
            'riapertura appuntamento
            ParentFormEx.Sottofondo()
            If TipoDoc = enTipoDocumento.FatturaRiepilogativa Then
                Dim appForm As New frmContabilitaFatturaRiepilogativaRicavo
                If appForm.Carica(IdVoce) Then MostraSituaz()
                ParentFormEx.Sottofondo()

            Else
                Dim appForm As New frmContabilitaRicavo
                If appForm.Carica(IdVoce, TipoVoce, _IdRub) Then MostraSituaz()
                ParentFormEx.Sottofondo()

            End If

        End If
    End Sub

    Private Sub DgSituaz_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DgSituazNonScad.CellMouseClick, DgScad.CellMouseClick

        sender.Select()
        Rigasel = e.RowIndex
        If e.RowIndex <> -1 Then

            If e.Button = Windows.Forms.MouseButtons.Right Then

                Dim x As System.Drawing.Point = MousePosition
                'btnNuovoCliente.ContextMenu = menuNuovo.
                x = MousePosition
                'x = lnkNew.PointToClient(x)

                Dim rig As DataGridViewRow
                rig = sender.Rows(e.RowIndex)
                rig.Selected = True
                sender.Select()
                menuVoce.Show(x)

            End If
        End If
    End Sub

    Private Sub ModificaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificaToolStripMenuItem.Click
        If Rigasel <> -1 Then
            Dim IdVoce As Integer = CType(GrigliaSel.Rows(Rigasel).Cells(0).FormattedValue, Integer)
            Dim TipoVoce As Integer = CType(GrigliaSel.Rows(Rigasel).Cells(1).FormattedValue, Integer)
            Dim TipoDoc As Integer = CType(GrigliaSel.Rows(Rigasel).Cells(12).FormattedValue, Integer)
            'riapertura appuntamento
            ParentFormEx.Sottofondo()
            If TipoDoc = enTipoDocumento.FatturaRiepilogativa Then
                Dim appForm As New frmContabilitaFatturaRiepilogativaRicavo
                If appForm.Carica(IdVoce) Then MostraSituaz()
                ParentFormEx.Sottofondo()

            Else
                Dim appForm As New frmContabilitaRicavo
                If appForm.Carica(IdVoce, TipoVoce) Then MostraSituaz()
                ParentFormEx.Sottofondo()

            End If

        End If
    End Sub

    Private Sub EliminaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminaToolStripMenuItem.Click
        If MessageBox.Show("ATTENZIONE! Si sta eliminando una voce di contabilitÓ, confermi la cancellazione della voce selezionata? L'operazione non e' reversibile!", "Vesta.Net", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim IdVoce As Integer = GrigliaSel.Rows(Rigasel).Cells(0).Value
            Dim IdTipoVoce As Integer = GrigliaSel.Rows(Rigasel).Cells(1).Value


            If IdTipoVoce = enTipoVoceContab.VoceAcquisto Then
                Dim c As cContabCostiColl = New cContabCostiColl
                c.Delete(IdVoce)

            Else
                Using r As New RicavoEx
                    r.Read(IdVoce)
                    MgrDocumentiFiscali.EliminaDocumentoFiscaleVendita(r)
                End Using


            End If

            MostraSituaz()
        End If
    End Sub

    Private Sub lnkStampa_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkStampa.LinkClicked
        ParentFormEx.Sottofondo()
        Dim Rub As New VoceRubrica

        Rub.Read(_IdRub)
        StampaBuffer(Rub.SituazioneContabile)
        Rub = Nothing

        ParentFormEx.Sottofondo()
    End Sub

    Public Sub RegistraPagamento()
        Dim IdDocSel As Integer = GrigliaSel.Rows(Rigasel).Cells(0).Value

        If IdDocSel Then

            Dim IdTipoVoce As Integer = GrigliaSel.Rows(Rigasel).Cells(1).Value

            'Dim Totale As Single = GrigliaSel.Rows(Rigasel).Cells(10).Value
            'Dim Pagato As Single = 0
            'Try
            'Pagato = GrigliaSel.Rows(Rigasel).Cells(11).Value
            'Catch ex As Exception

            '            End Try

            'Dim Differenza As Single = Totale - Pagato
            Dim Differenza As Single = 0
            Using mgr As New PagamentiDAO
                Differenza = mgr.ImportoAncoraDaPagareDocumento(IdDocSel, IdTipoVoce)
            End Using

            If Differenza Then
                ParentFormEx.Sottofondo()

                Using frmP As New frmContabilitaPagamento
                    If frmP.Carica(0, _IdRub, IdDocSel, IdTipoVoce) Then MostraSituaz()
                End Using

                'Using frmC As New frmDocumentoContabile
                '    frmC.Carica(CodiceRif, enTipoVoceContab.enTipoVoceVendita)
                'End Using

                ParentFormEx.Sottofondo()
            Else
                MessageBox.Show("Il documento risultÓ gia pagato")
            End If

        Else
            MessageBox.Show("Selezionare un documento dalla lista!", "Registra pagamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub RegistraPagamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistraPagamentoToolStripMenuItem.Click
        RegistraPagamento()
    End Sub



    Private Sub SegnaComePagatoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SegnaComePagatoToolStripMenuItem.Click
        RegistraPagamento()
    End Sub


    Private Sub PassaAlloStatoDiConsegnatoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PassaAlloStatoDiConsegnatoToolStripMenuItem.Click
        If GrigliaSel.SelectedRows.Count Then

            Dim IdDoc As Integer = GrigliaSel.SelectedRows(0).Cells(0).Value
            If MessageBox.Show("Confermi il passaggio a consegnato di tutti gli ordini di questo documento?", "Consegna ordini", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim doc As New cContabRicaviColl
                doc.PassaA(IdDoc, enStatoOrdine.Consegnato)
                MessageBox.Show("Gli ordini sono passati allo stato di consegnato!", "Consegna ordini", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End If
    End Sub

    Private Sub chkOnlyNotPayd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOnlyNotPayd.CheckedChanged
        If IdRub Then MostraSituaz()
    End Sub

    Private Sub chkOnlyInCons_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOnlyInCons.CheckedChanged
        If IdRub Then MostraSituaz()
    End Sub

    Private Sub lnkAll_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        If IdRub Then MostraSituaz()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        ParentFormEx.Sottofondo()
        StampaGlobale("Situazione contabile Documenti scaduti", DgScad)
        ParentFormEx.Sottofondo()
    End Sub

    Private Sub DgSituazNonScad_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgSituazNonScad.CellContentClick

    End Sub


    Private Sub DgScad_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DgScad.MouseClick, DgSituazNonScad.MouseClick
        GrigliaSel = sender
    End Sub

    Private Sub DgScad_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgScad.CellContentClick

    End Sub
End Class
