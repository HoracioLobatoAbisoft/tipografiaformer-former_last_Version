﻿Public Class lanostraazienda
    Inherits FormerFreePage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DirectCast(Page, FormerPage).Title = "La Nostra Azienda"
        Session("PageTitle") = "La Nostra Azienda"

    End Sub

End Class