<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="Action.aspx.cs" Inherits="Frontend.Action" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <div class="thank-you-container">
        <h2>Details sent to the police!</h2>
        <p>Your report has been successfully sent to the police.</p>
        <p>View your other Project SafeHaven invoices:</p>
        <asp:HyperLink ID="ViewInvoicesLink" runat="server" NavigateUrl="ProjSafeInvoice.aspx" Text="View Invoices" CssClass="btnInvoice" />
    </div>
</asp:Content>
