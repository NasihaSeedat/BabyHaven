<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="Frontend.Checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- Breadcrumb Begin -->
    <div class="breadcrumb-option">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="breadcrumb__links">
                        <span>Checkout</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Breadcrumb End -->

    <!-- Checkout Section Begin -->
    <section class="checkout spad">
        <div class="container">

            <form action="#" class="checkout__form" runat="server">
                <div class="row">
                    <div class="col-lg-12">
                        <h6 class="coupon__link" id="couponLink">
                            <span class="icon_tag_alt"></span>
                            Have a coupon? Click here to enter your code.
                        </h6>
                        <div class="coupon__input" id="couponInput" style="display: none;">
                            <input type="text" id="txtCouponCode" placeholder="Enter coupon code" runat="server">
                            <asp:Button ID="btnApplyCoupon" runat="server" Text="Apply" OnClick="btnApplyCoupon_Click" CssClass="couponbutton" />

                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-8">
                        <h5>Billing details</h5>
                        <div class="row">
                            <div class="col-lg-6 col-md-6 col-sm-6">
                                <div class="checkout__form__input">
                                    <p>First Name <span>*</span></p>
                                    <input type="text" id="txtFirstName" runat="server" required>
                                </div>
                            </div>
                            <div class="col-lg-6 col-md-6 col-sm-6">
                                <div class="checkout__form__input">
                                    <p>Last Name <span>*</span></p>
                                    <input type="text" id="txtLastName" runat="server" required>
                                </div>
                            </div>
                            <div class="col-lg-12">
                                <div class="checkout__form__input">
                                    <p>Street Address <span>*</span></p>
                                    <input type="text" id="txtStreetAddress" runat="server" placeholder="Street Address" required>
                                </div>

                                <div class="checkout__form__input">
                                    <p>Town/City <span>*</span></p>
                                    <input type="text" id="txtCity" runat="server" required>
                                </div>
                                <div class="checkout__form__input">
                                    <p>Postcode/Zip <span>*</span></p>
                                    <input type="text" id="txtZip" runat="server" required>
                                </div>
                            </div>
                            <div class="col-lg-6 col-md-6 col-sm-6">
                                <div class="checkout__form__input">
                                    <p>Phone <span>*</span></p>
                                    <input type="text" id="txtPhone" runat="server" required>
                                </div>
                            </div>
                            <div class="col-lg-6 col-md-6 col-sm-6">
                                <div class="checkout__form__input">
                                    <p>Email <span>*</span></p>
                                    <input type="email" id="txtEmail" runat="server" required>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="checkout__order">
                            <h5>Your order</h5>
                            <div class="checkout__order__product">
                                <ul>
                                    <!-- Display cart items dynamically -->
                                    <asp:Repeater ID="rptCartItems" runat="server">
                                        <ItemTemplate>
                                            <li>
                                                <span class="top__text"><%# Eval("ProductName") %></span>
                                                <span class="top__text__right">$<%# Eval("Price") %></span>
                                            </li>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </ul>
                            </div>
                            <div class="checkout__order__total">
                                <ul>
                                    <li>Subtotal: <span id="lblSubtotal" runat="server"></span></li>
                                    <li>Delivery: <span id="lblDelivery" runat="server"></span></li>
                                    <li>Discount: <span id="lblDiscount" runat="server"></span></li>
                                    <li>Total: <span id="lblTotal" runat="server"></span></li>
                                </ul>
                            </div>

                            <asp:Label ID="lblConfirmationMessage" runat="server" Visible="false" CssClass="confirmation-message"></asp:Label>
                            <asp:Button ID="btnPlaceOrder" runat="server" Text="Place Order" CssClass="site-btn" OnClick="btnPlaceOrder_Click" />
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </section>
    <!-- Checkout Section End -->
</asp:Content>
