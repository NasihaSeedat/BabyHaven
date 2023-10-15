<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="DelegateTask.aspx.cs" Inherits="Frontend.DelegateTask" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style type="text/css">
        #<%= ListBox1.ClientID %> {
            width: 100%; 
    height: 150px; 
    border: 1px solid #ccc;
    padding: 5px;
    font-size: 16px;
    background-color: white;
    color: #333;
        
        }

         #<%= ListBox1.ClientID %> option:nth-child(odd) {
        background-color: white; /* Set the background color for odd rows */
    }

    #<%= ListBox1.ClientID %> option:nth-child(even) {
        background-color: #e4edf7; /* Set the background color for even rows */
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Breadcrumb Begin -->
    <div class="breadcrumb-option">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="breadcrumb__links">
                        <a href="Home.aspx"><i class="fa fa-home"></i>Home</a>
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

                            <asp:Button ID="btnSearch" class="btnInvoice" runat="server" Text="Search" OnClick="btnSearch_Click" Style="margin-left: 30px; margin-top: -5px;" />


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

      <div class="container">
    <div class="row">
        <div class="col-md-6">
            <asp:TextBox ID="TaskTextBox" CssClass="search-bar" runat="server" placeholder="Enter Task" style="margin-left: -18px;"></asp:TextBox>
            <asp:Button ID="AddTaskButton" runat="server" Text="Add Task" CssClass="btnInvoice" OnClick="AddTaskButton_Click1" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:ListBox ID="ListBox1" runat="server" style="margin-left: -18px;"></asp:ListBox>
        </div>
    </div>
</div>





    </form>
</asp:Content>
