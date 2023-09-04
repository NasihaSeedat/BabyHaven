<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Frontend.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
         <div class="whole-wrap">
        <div class="container box_1170">
          <!--  container box_1170-->
            <div class="section-top-border">
                <div class="row">
                    <div class="col-lg-8 col-md-8">
                        <h3 class="mb-30">Login</h3>

                        <h4 class="mt-10">Email</h4>
                        <div class="mt-10">
                            <input type="email" name="first_name" 
                             
                                class="single-input" runat="server" id="Email">
                        </div>
                        <h5 class="mt-10">Password</h5>
                        <div class="mt-10">
                            <input type="Password" name="last_name" 
                                
                                class="single-input" runat="server" id="Password">
                        </div>
                        <div class="mt-10">
                            <asp:Button id="login" runat="server" Text="Login" class="genric-btn primary-border"  />
                            <a href="Register.aspx" class="genric-btn info-border">Register</a>
                        </div>
                        <div class="mt-10">
                            <asp:Label ID="error" runat="server" Text="Incorrect Password or Username" visible="false" ></asp:Label>
                        </div>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
<<<<<<< Updated upstream
     </form>
=======
    <!-- Breadcrumb End -->

    <section class="login spad">
        <form id="form1" class="login__form" runat="server">
            <div class="whole-wrap">
                <div class="container box_1170">
                    <div class="section-top-border">
                        <div class="row">
                            <div class="col-lg-8">
                                <h5>Login details</h5>
                                <div class="row">
                                    <div class="col-lg-12">
                                        <div class="login__form__input">
                                            <p>Email <span>*</span></p>
                                            <input type="email" name="first_name" class="single-input" runat="server" id="Email">
                                        </div>
                                    </div>

                                    <div class="col-lg-12">
                                        <div class="login__form__input">
                                            <p>Password <span>*</span></p>
                                            <input type="Password" name="last_name" class="single-input" runat="server" id="Password">
                                        </div>
                                    </div>
                                </div>

                                <div class="login__button">
                                    <asp:Button id="login" class="site-btn" runat="server" Text="Login" OnClick="login_Click"/>
                                </div>
                                <div class="login__error">
                                    <asp:Label ID="error" runat="server" Text="Incorrect Password or Username" visible="false" ></asp:Label>
                                </div>

                                <!-- Registration link -->
                                <div class="registration__link">
                                    <a href="Register.aspx">Don't have an account? Register here.</a>
                                </div>
                        
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </form>
    </section>
>>>>>>> Stashed changes
</asp:Content>
