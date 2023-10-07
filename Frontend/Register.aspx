<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Frontend.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="register spad">
        <form id="form1" class="register__form" runat="server">
            <div class="whole-wrap">
                <div class="container box_1170">
                    <div class="section-top-border">
                        <div class="row">
                            <div class="col-lg-8">
                                <h5>Registration Details</h5>
                                <div class="row">

                                    <div class="col-lg-6 col-md-6 col-sm-6">
                                        <div class="register__form__input">
                                            <p>First Name<span>*</span></p>
                                            <input type="text" name="first_name" class="single-input" runat="server" id="firstname">
                                        </div>
                                    </div>

                                    <div class="col-lg-6 col-md-6 col-sm-6">
                                        <div class="register__form__input">
                                            <p>Surname <span>*</span></p>
                                            <input type="text" name="last_name" class="single-input" runat="server" id="lastname">
                                        </div>
                                    </div>

                                    <div class="col-lg-12">
                                        <div class="register__form__input">
                                            <p>Phone Number <span>*</span></p>
                                            <input type="text" name="phone" class="single-input" runat="server" id="contact">
                                        </div>
                                    </div>

                                    <div class="col-lg-12">
                                        <div class="register__form__input">
                                            <p>Email <span>*</span></p>
                                            <input type="email" name="first_name" class="single-input" runat="server" id="Email">
                                        </div>
                                    </div>

                                    <div class="col-lg-12">
                                        <div class="register__form__input">

                                            <p>Address <span>*</span></p>
                                            <input type="text" name="address1" class="single-input" runat="server" id="addressUser">
                                        </div>
                                    </div>

                                    <div class="col-lg-12">
                                        <div class="register__form__input">

                                            <p>Password <span>*</span></p>
                                            <input type="Password" name="last_name" class="single-input" runat="server" id="Password">
                                        </div>
                                    </div>

                                    <div class="col-lg-12">
                                        <div class="register__form__input">
                                            <p>Confirm Password <span>*</span></p>
                                            <input type="Password" name="last_name" class="single-input" runat="server" id="ConfirmPass">
                                        </div>
                                    </div>

                                </div>


                                <asp:Button ID="register" class="register__button" runat="server" Text="Register" OnClick="Register_Click" />

                                <div class="register__error">
                                    <asp:Label ID="error" runat="server" Text="" Visible="false"></asp:Label>
                                </div>

                                <!-- Registration link -->
                                <div class="login__link">
                                    <a href="Login.aspx">Already registered? Login here.</a>
                                </div>



                            </div>



                        </div>

                    </div>
                </div>
            </div>

        </form>
    </section>

</asp:Content>
