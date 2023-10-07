<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="reguserday.aspx.cs" Inherits="Frontend.reguserday" %>
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
                        <span>Users Registered Per Day </span>
                    </div>
                </div>
            </div>
        </div>
    </div>
   <div class="container">
            <div class="row">
                <div class="col-lg-12">
    <form id="form1" runat="server">
        <div id="regchart" runat="server">
            <!-- Canvas element for the chart -->
            <canvas id="userRegistrationChart" width="400" height="200"></canvas>
        </div>
    </form>

                    </div>
                </div>
       </div>
</asp:Content>
