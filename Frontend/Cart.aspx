<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Frontend.Cart" %>
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
                                            <td><%# Eval("ProductName") %></td>
                                            <td><%# Eval("Price", "{0:C}") %></td>
                                            <td>
                                                <asp:TextBox runat="server" ID="QuantityTextBox" Text='<%# Eval("Quantity") %>'></asp:TextBox>
                                            </td>
                                            <td><%# Eval("Total", "{0:C}") %></td>
                                            <td>
                                                <asp:Button runat="server" Text="Remove" OnClick="RemoveFromCartButton_Click" CommandArgument='<%# Eval("ProductId") %>' />
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-6 col-md-6 col-sm-6">
                    <div class="cart__btn">
                        <a href="Shop.aspx">Continue Shopping</a>
                    </div>
                </div>
                <div class="col-lg-6 col-md-6 col-sm-6">
                    <%-- Add a conditional check for clientId --%>
                    <asp:Label ID="ClientIdLabel" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-4 offset-lg-2">
                    <div class="cart__total__procced">
                        <h6>Cart total</h6>
                        <ul>
                            <li>Subtotal <span><asp:Label ID="SubtotalLabel" runat="server" Text="R 0.00"></asp:Label></span></li>
                            <li>Total <span><asp:Label ID="TotalLabel" runat="server" Text="R 0.00"></asp:Label></span></li>
                        </ul>
                        <%-- Add a conditional check for clientId --%>
                        <asp:HyperLink ID="ProceedToCheckoutLink" runat="server" CssClass="primary-btn" Text="Proceed to checkout"></asp:HyperLink>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Shop Cart Section End -->
</asp:Content>
