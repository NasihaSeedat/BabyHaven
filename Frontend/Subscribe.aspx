<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="Subscribe.aspx.cs" Inherits="Frontend.Subscribe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <style>
       .my-input {
    width: 250px;
    padding: 10px;
    border: 1px solid #ccc;
    border-radius: 15px;
    font-size: 16px;
}


    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

         <!-- Breadcrumb Section Begin -->
    <section class="breadcrumb-subs set-bg" data-setbg="img/banner/banner.jpg">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h2>Subscribe To Our Newsletter</h2>
                </div>
            </div>
        </div>
    </section>
    <!-- Breadcrumb Section End -->
    <form runat="server">
        <div align="center">


    <asp:TextBox ID="txtEMAIL" placeholder="Enter Email To Subscribe" runat="server" CssClass="my-input"></asp:TextBox>

    <asp:Button ID="btnSUB" runat="server" Text="Subscribe" OnClick="btnSUB_Click" class="btnInvoice" />
        </div>
    </form>
</asp:Content>
