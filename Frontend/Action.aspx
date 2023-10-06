<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="Action.aspx.cs" Inherits="Frontend.Action" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!-- Breadcrumb Begin -->
    <div class="breadcrumb-option">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="breadcrumb__links">
                        <span>Take Action</span>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="thank-you-container">
        <h2>Details sent to the police!</h2>
        <p>Your report has been successfully sent to the police.</p>
        <p>If you would like to view your other Project SafeHaven invoices, please click the button below:</p>
        <asp:HyperLink ID="ViewInvoicesLink" runat="server" NavigateUrl="ProjSafeInvoice.aspx" Text="View Invoices" CssClass="btnInvoice" />
    </div>
</asp:Content>
