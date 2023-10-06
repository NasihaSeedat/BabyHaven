<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="handprods.aspx.cs" Inherits="Frontend.handprods" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="breadcrumb-option">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="breadcrumb__links">
                        <a href="Home.aspx"><i class="fa fa-home"></i>Home</a>
                        <a href="reports.aspx">Reports</a>
                        <span>Number of products  on hand</span>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <form id="form1" runat="server">
        
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
        <asp:GridView ID="ProductGridView" runat="server" AutoGenerateColumns="false" CssClass="custom-gridview">
            <Columns>
                <asp:BoundField DataField="p_name" HeaderText="Product Name" />
                <asp:BoundField DataField="numhand" HeaderText="Number on Hand" />
            </Columns>
        </asp:GridView>

                    </div>
                </div>
            </div>
    </form>

</asp:Content>
