﻿Public Class pPrivacy
    Inherits FormerFreePage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DirectCast(Page, FormerPage).Title = "Privacy"
        Session("PageTitle") = "Privacy e dichiarazione di Consenso"

    End Sub

End Class