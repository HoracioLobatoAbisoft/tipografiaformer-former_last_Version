﻿<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ucCarrello.ascx.vb" Inherits="FormerWeb.ucCarrello" %>
<div class="CarrelloBox" >
    <%If UtenteConnesso.IdUtente = 1684 Or UtenteConnesso.IdUtente = 3 Or UtenteConnesso.IdUtente = 292 Or UtenteConnesso.IdUtente = 38 Then %>
        <%--<asp:Literal runat="server" ID="iframeNC" />--%>
        <table class="" style="width:100%">
            <tbody id = "TableCarrelloNotifiche">
                
            </tbody>
        </table>
    <%Else %>
        <asp:Table ID="tblCarrello" Width="100%" runat="server"></asp:Table>
    <%End If %>
</div>