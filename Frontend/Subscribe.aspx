<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="Subscribe.aspx.cs" Inherits="Frontend.Subscribe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <style>
    /*   .my-input {
    width: 250px;
    padding: 10px;
    border: 1px solid #ccc;
    border-radius: 15px;
    font-size: 16px;
}*/
    


     .container {
    text-align: center;
  }

  p {
    font-size: 1.2em; /* Increase the font size as needed */
    text-align: left; /* Left-align the text within the paragraph */
    margin: 0 auto;
    max-width: 400px; /* Adjust the max-width to your preference */
  }

  .my-input {
    width: 40%; /* Adjust the width as needed */
    padding: 10px;
    margin: 0 auto;
    display: block;
  }

  b {
    font-size: 1.2em; /* Adjust the font size as needed */
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
        <div align="center" class="container">
            <p><br /><br />
                <b>HEY THERE, JOIN THE <i>FAMILY!</i></b><br /><br />

We want to <i>baby</i> you with just the perfect amount of love! <br /><br />

Why not sign up for our monthly update and become the first to know about all the fantastic specials and promotions we have in store for you? 
                <br /><br />
Don't worry, we promise there'll be no spamming involved!<br /><br />
            </p>

    <asp:TextBox ID="txtEMAIL" placeholder="Enter Email To Subscribe" runat="server" CssClass="my-input"></asp:TextBox>

    <asp:Button ID="btnSUB" runat="server" Text="Subscribe" OnClick="btnSUB_Click" class="btnInvoice" />
        </div>
    </form>
</asp:Content>
