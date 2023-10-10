<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="salesreport.aspx.cs" Inherits="Frontend.salesreport" %>
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
                        <span>Sales Report </span>
                    </div>
                </div>
            </div>
        </div>
    </div>

     <section class="banner-bottom py-4">
        <div class="container py-5">
            <div class="col-md-12">
                <h2>Sales Report</h2>
                <br />
                
        <form runat="server">
                <asp:DropDownList ID="ddlMonths" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlMonths_SelectedIndexChanged" CssClass="styled-dropdown"> 
                    <asp:ListItem Text="Select" Value="0"></asp:ListItem>
                    <asp:ListItem Text="3 months" Value="3"></asp:ListItem>
                    <asp:ListItem Text="6 months" Value="6"></asp:ListItem>
                    <asp:ListItem Text="9 months" Value="9"></asp:ListItem>
                </asp:DropDownList>

            </form>
                <br />
                   <asp:Label ID="valid" runat="server" Visible="true" Text="" />
            </div>

            <div id="ChartDiv" runat="server" style="position: center; top: 60px; left: 10px; width: 600px; height: 500px;">
            </div>
        </div>
    </section>
</asp:Content>
