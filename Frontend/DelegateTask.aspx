<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="DelegateTask.aspx.cs" Inherits="Frontend.DelegateTask" %>

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
                        <span>Delgate Tasks</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Breadcrumb End -->
    <form runat="server">

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
            
                <asp:Literal ID="userTabless" runat="server"></asp:Literal>
                 

            </div>
            <%-- <asp:Button ID="btnSelAdmin" runat="server" CssClass="btnInvoice" Text="Select Admin" OnClick="btnSelAdmin_Click" />--%>
          



        </div>

    </section>
      <div align="center">
          <asp:TextBox ID="TaskTextBox" runat="server"></asp:TextBox>
<asp:Button ID="AddTaskButton" runat="server" Text="Add Task" OnClick="AddTaskButton_Click1" />


                        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
      </div>


        </form>
</asp:Content>
