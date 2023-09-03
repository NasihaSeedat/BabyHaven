<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Frontend.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
    <div class="whole-wrap">
        <div class="container box_1170">

            <div class="section-top-border">
                <div class="row">
                    <div class="col-lg-8 col-md-8">
                        <h3 class="mb-30">User Regististration</h3>

                        <h5 class="mt-10">First Name</h5>
                         <div class="mt-10">
                            <input type="text" name="first_name" 
                              
                                class="single-input" runat="server" id="Username">
                        </div>
                        <h5 class="mt-10">Surname</h5>
                         <div class="mt-10">
                            <input type="text" name="first_name" 
                               
                                class="single-input" runat="server" id="Name">
                        </div>
                         <h5 class="mt-10">Phone Number</h5>
                         <div class="mt-10">
                            <input type="text" name="first_name" 
                               
                                class="single-input" runat="server" id="Contact">
                        </div>
                  
                     
                          <h5 class="mt-10">Email</h5>
                        <div class="mt-10">
                          
                            <input type="email" name="first_name"
                             
                                class="single-input" runat="server" id="Email">
                        </div>
                        <h5 class="mt-10">Password</h5>
                        <div class="mt-10">
                            <input type="Password" name="last_name" 
                               
                                class="single-input" runat="server" id="Password">
                        </div>
                          <h5 class="mt-10">Confirm Password</h5>
                         <div class="mt-10">
                            <input type="Password" name="last_name" 
                              
                                class="single-input" runat="server" id="ConfirmPass">
                        </div>
                        <div class="mt-10">
                             <asp:Button ID="btn_register" runat="server" Text="Register" class="genric-btn primary-border"  />
                        </div>
                        <div class="mt-10">
                            <asp:Label ID="error" runat="server" Text="" visible="false" ></asp:Label>
                        </div>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>

</asp:Content>
