<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="handprods.aspx.cs" Inherits="Frontend.handprods" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script
        src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.4/Chart.js">
    </script>

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
        <div class="container" style="padding-top: 50px;">
            <div class="row">
                <!-- Filter Controls Column -->
                <div class="col-lg-4" style="margin-bottom: 20px;">
                    <!-- Minimum Quantity Filter -->
                    <label for="txtMinQuantity">Minimum Quantity:</label>
                    <asp:TextBox ID="txtMinQuantity" runat="server" CssClass="quantity-textbox" placeholder="Enter minimum quantity"></asp:TextBox>

                    <!-- Maximum Quantity Filter -->
                    <label for="txtMaxQuantity">Maximum Quantity:</label>
                    <asp:TextBox ID="txtMaxQuantity" runat="server" CssClass="quantity-textbox" placeholder="Enter maximum quantity"></asp:TextBox>

                    <!-- Filter Button -->
                    <asp:Button ID="btnFilter" runat="server" Text="Filter" OnClick="btnFilter_Click" CssClass="btnFilter" />
                </div>
                <!-- Table Column -->
                <div class="col-lg-8">
                    <!-- GridView -->
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
