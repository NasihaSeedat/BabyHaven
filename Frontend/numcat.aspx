<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="numcat.aspx.cs" Inherits="Frontend.numcat" %>

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
                        <span>Number of products per category</span>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <section class="banner-bottom py-4">
        <div class="container py-5">
            <div class="col-md-12">
                <h2>Number of products per category</h2>
                <br />
            </div>

            <div id="UT" runat="server" style="position: center; top: 60px; left: 10px; width: 600px; height: 500px;">
            </div>
        </div>
    </section>

</asp:Content>
