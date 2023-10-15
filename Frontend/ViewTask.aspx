<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="ViewTask.aspx.cs" Inherits="Frontend.ViewTask" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
   

    /* Style for checked items */
    .checked-item label {
        text-decoration: line-through;
        margin-left: 10px;
        color: #e0dede; /* Gray out the text */
    }

    /* Border around CheckBoxList */
    .checkbox-list {
       margin-left: 15px;
      box-shadow: -1px 3px 12px rgba(132, 183, 238, 0.8);
        font-size: 18px;
line-height: 2;
  
        padding: 200px 100px;/* Optional: Add some padding for spacing */
        padding-left: 20px; 
    }
    .checkbox-list label{
         margin-left: 10px;
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
                        <span>View Tasks</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Breadcrumb End -->
    <form runat="server">
        <div align="center" runat="server" id="Taskss" visible="true">
        <h2 >Pending Tasks</h2><br />
           
            <asp:CheckBoxList ID="CheckBoxList1" CssClass="checkbox-list"  runat="server" AutoPostBack="true"  OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" Width="570px" ></asp:CheckBoxList>
            <br />
            <asp:Button ID="donetasks" CssClass="btnInvoice" runat="server" Text="Done" OnClick="donetasks_Click" />
        </div>

        <div class="thank-you-container" id="notask" runat="server" visible="false">
            <h2>No Current Tasks!</h2>
        </div>
    </form>
</asp:Content>
