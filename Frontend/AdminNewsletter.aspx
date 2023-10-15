<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="AdminNewsletter.aspx.cs" Inherits="Frontend.AdminNewsletter" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .confirmation-label {
            transition: color 0.3s; /* Smooth transition effect */
        }

            .confirmation-label:hover {
                color: #84B7EE;
            }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="checkout spad">
        <div class="container">
            <form action="#" class="checkout__form" runat="server">
                <div class="row">
                    <div class="col-lg-8">
                        <h5>Send Newsletter to Subscribed Users</h5>
                        <div class="row">

                            <div class="col-lg-12">
                                <div class="checkout__form__input">
                                    <p>Subject <span>*</span></p>
                                    <input type="text" id="subjectTextBox" runat="server" placeholder="Subject" required>
                                </div>
                            </div>

                            <div class="col-lg-8">
                                <div class="checkout__form__input">
                                    <p>Body <span>*</span></p>
                                    <textarea id="bodyTextBox" runat="server" placeholder="Message Body" rows="4" style="width: 153%;"></textarea>
                                </div>
                            </div>

                            <div class="col-lg-12">
                                <asp:Button ID="sendButton" runat="server" Text="Send Email" OnClick="sendButton_Click" class="btnInvoice" />
                                <div>
                                    <asp:Label ID="confirmationLabel" runat="server" Visible="false" CssClass="confirmation-label" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </section>

</asp:Content>
