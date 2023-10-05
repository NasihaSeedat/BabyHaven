<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Frontend.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>

    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Breadcrumb Begin -->
    <div class="breadcrumb-option">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="breadcrumb__links">
                        <a href="Home.aspx"><i class="fa fa-home"></i> Home</a>
                        <span>Shopping cart</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Breadcrumb End -->

    <!-- Shop Cart Section Begin -->
    <section class="shop-cart spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="shop__cart__table">
                        <form runat="server">
                            <table>
                                <thead>
                                    <tr>
                                        <th>Product</th>
                                        <th>Price</th>
                                        <th>Quantity</th>
                                        <th>Total</th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Repeater ID="CartTable" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td class="cart__product__item">
                                                    <img src='<%# GetProductImage(Eval("P_ID")) %>' alt='<%# GetProductName(Eval("P_ID")) %>'>
                                                    <div class="cart__product__item__title">
                                                        <h6><%# GetProductName(Eval("P_ID")) %></h6>
                                                    </div>
                                                </td>
                                                <td class="cart__price"><%# GetProductPrice(Eval("P_ID")) %></td>
                                                <td class="cart__quantity">
                                                    <div class="pro-qty">
                                                        <asp:Button runat="server" ID="DecreaseQuantityButton" Text="-" OnClick="DecreaseQuantity_Click" CommandArgument='<%# Eval("P_ID") %>' CssClass="quantity-button minus" />
                                                        <asp:TextBox runat="server" ID="QuantityTextBox" Text='<%# Eval("Cart_Quantity") %>' CssClass="quantity-input" />
                                                        <asp:Button runat="server" ID="IncreaseQuantityButton" Text="+" OnClick="IncreaseQuantity_Click" CommandArgument='<%# Eval("P_ID") %>' CssClass="quantity-button plus" />
                                                    </div>
                                                </td>

                                                <td class="cart__total"><%# Eval("Cart_Price", "{0:C}") %></td>
                                                <td class="cart__close">
                                                    <asp:Button runat="server" ID="RemoveFromCartButton" Text="X" OnClick="RemoveFromCartButton_Click" CommandArgument='<%# Eval("P_ID") %>' CssClass="cart-remove-button" />
                                                </td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>


                                </tbody>
                            </table>
                        </form>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-6 col-md-6 col-sm-6">
                    <div class="cart__btn">
                        <a href="Shop.aspx">Continue Shopping</a>
                    </div>
                </div>
                <div class="col-lg-4 offset-lg-2">
                    <div class="cart__total__procced">
                        <h6>Cart total</h6>
                        <ul>
                            <li>Subotal <span><asp:Label ID="SubtotalLabel" runat="server" Text="R 0.00"></asp:Label></span></li>
                            <li>VAT <span><asp:Label ID="VATLabel" runat="server" Text="R 0.00"></asp:Label></span></li>
                            <li>Total <span><asp:Label ID="TotalLabel" runat="server" Text="R 0.00"></asp:Label></span></li>
                        </ul>
                        <%-- Add a conditional check for clientId --%>
                        <asp:HyperLink ID="ProceedToCheckoutLink" runat="server" CssClass="primary-btn" Text="Proceed to checkout"></asp:HyperLink>
                    </div>
                </div>
            </div>
            <div class="row">
                
            </div>
        </div>
    </section>
    <!-- Shop Cart Section End -->
</asp:Content>
