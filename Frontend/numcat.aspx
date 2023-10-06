<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="numcat.aspx.cs" Inherits="Frontend.numcat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script
        src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.4/Chart.js">
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="banner-bottom py-5">
        <div class="container py-5">
            <h1>Number of products per category</h1>

            <div id="UT" runat="server" style="position: center; top: 60px; left: 10px; width: 500px; height: 500px;">
            </div>
        </div>
    </section>
  
</asp:Content>
