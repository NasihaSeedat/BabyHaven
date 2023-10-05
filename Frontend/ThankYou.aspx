<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="ThankYou.aspx.cs" Inherits="Frontend.ThankYou" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="thank-you-container">
    <h2>Thank You for Your Purchase!</h2>
    <p>Your order has been successfully placed.</p>
    <p>If you would like to view your invoices, please click the button below:</p>
    <asp:HyperLink ID="ViewInvoicesLink" runat="server" NavigateUrl="Invoices.aspx" Text="View Invoices" CssClass="btn amado-btn w-100" />
</div>
</asp:Content>
