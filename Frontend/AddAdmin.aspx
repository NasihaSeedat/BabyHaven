<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="AddAdmin.aspx.cs" Inherits="Frontend.AddAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <!-- Breadcrumb Begin -->
    <div class="breadcrumb-option">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="breadcrumb__links">
                        <a href="Home.aspx"><i class="fa fa-home"></i> Home</a>
                        <span>Add Admin</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Breadcrumb End -->
    <form id="userForm" runat="server">

              <section>


        <div class="container">
            <div class="row">
               <div class="row">
    <div class="col-md-6">
        

        <asp:TextBox ID="txtSearch" class="search-bar" placeholder="Search by Name" runat="server"></asp:TextBox>
    </div>
    <div class="col-md-6">

        <asp:Button id="btnSearch" class="btnInvoice" runat="server" Text="Search" OnClick="btnSearch_Click" style=" margin-left: 30px;margin-top: -5px;" />

       
    </div>
</div>

                <asp:Label ID="error" runat="server" Text="" Visible="false"></asp:Label>
            </div>
            <!-- User data table -->
            <div class="row">
              <%--  <asp:Table ID="userTable" runat="server" Class="table table-bordered">
                    <asp:TableHeaderRow>
                        <asp:TableHeaderCell>User ID</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Email</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Name</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Surname</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Phone Number</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Select Admin</asp:TableHeaderCell>
                    </asp:TableHeaderRow>
                </asp:Table>--%>
                <asp:Literal ID="userTabless" runat="server"></asp:Literal>
                 

            </div>
            <asp:Button ID="btnAddAdmin" runat="server" CssClass="btnInvoice" Text="Add Admin" OnClick="btn_register"/>
          
        </div>

    </section>
        </form>

</asp:Content>
