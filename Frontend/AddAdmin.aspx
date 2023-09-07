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
                        <span>Add Admin</span>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Breadcrumb End -->
               <section >
        <div class="container">
            <div class ="row"  id="addadmins" runat="server">
   
                        <div class="mt-10">
                         
                             <asp:Button id="AddAminbtn" class="site-btn" runat="server" Text="Add Admin"  OnClick="btn_register"/>
                        </div>
                        <div class="mt-10">
                            <asp:Label ID="error" runat="server" Text="" visible="false" ></asp:Label>
                        </div>
                       
                        
       </div>

               
          </div>
    </section>

</asp:Content>
