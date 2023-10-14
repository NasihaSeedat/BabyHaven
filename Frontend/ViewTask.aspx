<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="ViewTask.aspx.cs" Inherits="Frontend.ViewTask" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Breadcrumb Begin -->
    <div class="breadcrumb-option">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="breadcrumb__links">
                        <a href="Home.aspx"><i class="fa fa-home"></i>Home</a>
                        <span>View Tasks</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Breadcrumb End -->
    <form runat="server">
        <div align="center" runat="server" id="Taskss" visible="true">
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="true"></asp:CheckBoxList>
            <asp:Button ID="donetasks" CssClass="btnInvoice" runat="server" Text="Done" OnClick="donetasks_Click" />
        </div>

        <div class="thank-you-container" id="notask" runat="server" visible="false">
            <h2>No Current Tasks!</h2>
        </div>
    </form>
</asp:Content>
