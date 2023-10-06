<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="Subscribe.aspx.cs" Inherits="Frontend.Subscribe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <style>
       .my-input {
    width: 250px;
    padding: 10px;
    border: 1px solid #ccc;
    border-radius: 5px;
    font-size: 16px;
}


    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <div align="center">


    <asp:TextBox ID="txtEMAIL" placeholder="Enter Email To Subscribe" runat="server" CssClass="my-input"></asp:TextBox>

    <asp:Button ID="btnSUB" runat="server" Text="Subscribe" OnClick="btnSUB_Click" class="btnInvoice" />
        </div>
    </form>
</asp:Content>
