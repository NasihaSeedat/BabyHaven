<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="ThankYou.aspx.cs" Inherits="Frontend.ThankYou" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Breadcrumb Begin -->
    <div class="breadcrumb-option">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="breadcrumb__links">
                        <span>Thank you</span>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="thank-you-container">
        <h2>Thank You for Your Purchase!</h2>
        <p>Your order has been successfully placed.</p>
        <p>If you would like to view your invoices, please click the button below:</p>
        <asp:HyperLink ID="ViewInvoicesLink" runat="server" NavigateUrl="Invoices.aspx" Text="View Invoices" CssClass="btnInvoice" />
    </div>

</asp:Content>
