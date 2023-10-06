<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="ProjSafeInvoiceDetails.aspx.cs" Inherits="Frontend.ProjSafeInvoiceDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

     <style>
        /* Add your CSS styles here */
        .invoice-container {
            max-width: 800px; /* Increase container width */
            margin: 20px auto;
            padding: 20px;
            background-color: #f9f9f9;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        .invoice-label {
            font-size: 18px;
            color: #333;
            font-weight: bold; /* Make labels stand out */
        }

        .invoice-value {
            font-size: 16px;
            color: #555;
            margin-left: 10px;
        }

        .return-link {
            margin-top: 20px;
            text-align: center;
        }

            .return-link a {
                text-decoration: none;
                font-weight: bold;
                color: #007BFF;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="invoice-container">
        <div class="row">
            <div class="col-md-12 text-center">
                <h2>Invoice Details</h2>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <asp:Label ID="OrderIdLabel" runat="server" CssClass="invoice-label" Text="Order ID:" />
            </div>
            <div class="col-md-6">
                <span class="invoice-value" runat="server" id="OrderIdValue"></span>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <asp:Label ID="FirstNameLabel" runat="server" CssClass="invoice-label" Text="First Name:" />
            </div>
            <div class="col-md-6">
                <span class="invoice-value" runat="server" id="FirstNameValue"></span>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <asp:Label ID="LastNameLabel" runat="server" CssClass="invoice-label" Text="Last Name:" />
            </div>
            <div class="col-md-6">
                <span class="invoice-value" runat="server" id="LastNameValue"></span>
            </div>
        </div>

        <div class="row">
            <div class="col-md-6">
                <asp:Label ID="DateLabel" runat="server" CssClass="invoice-label" Text="Date:" />
            </div>
            <div class="col-md-6">
                <span class="invoice-value" runat="server" id="DateValue"></span>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <asp:Label ID="EmailLabel" runat="server" CssClass="invoice-label" Text="Email:" />
            </div>
            <div class="col-md-6">
                <span class="invoice-value" runat="server" id="EmailValue"></span>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <asp:Label ID="AddressLabel" runat="server" CssClass="invoice-label" Text="Address:" />
            </div>
            <div class="col-md-6">
                <span class="invoice-value" runat="server" id="AddressValue"></span>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <asp:Label ID="CityLabel" runat="server" CssClass="invoice-label" Text="City:" />
            </div>
            <div class="col-md-6">
                <span class="invoice-value" runat="server" id="CityValue"></span>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <asp:Label ID="ZipCodeLabel" runat="server" CssClass="invoice-label" Text="Zip Code:" />
            </div>
            <div class="col-md-6">
                <span class="invoice-value" runat="server" id="ZipCodeValue"></span>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <asp:Label ID="PhoneNumberLabel" runat="server" CssClass="invoice-label" Text="Phone Number:" />
            </div>
            <div class="col-md-6">
                <span class="invoice-value" runat="server" id="PhoneNumberValue"></span>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <asp:Label ID="TotalAmountLabel" runat="server" CssClass="invoice-label" Text="Total Amount:" />
            </div>
            <div class="col-md-6">
                <span class="invoice-value" runat="server" id="TotalAmountValue"></span>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12 text-center">
                <!-- Add a link to return to Invoices.aspx page -->
                <asp:HyperLink ID="ReturnToInvoicesLink" runat="server" NavigateUrl="~/ProjSafeInvoice.aspx" CssClass="return-link" Text="Return to Invoices" />
            </div>
        </div>
    </div>
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
                                       
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Repeater ID="OrderTable" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td class="cart__product__item">
                                                    <img src='<%# GetProductImage(Eval("Product_ID")) %>' alt='<%# GetProductName(Eval("Product_ID")) %>'>
                                                    <div class="cart__product__item__title">
                                                        <h6><%# GetProductName(Eval("Product_ID")) %></h6>
                                                    </div>
                                                </td>
                                                <td class="cart__price"><%# GetProductPrice(Eval("Product_ID")) %></td>
                                                <td class="cart__quantity">
                                                    <div class="pro-qty">

                                                        <asp:TextBox runat="server" ID="QuantityTextBox" Text='<%# Eval("Quantity") %>' CssClass="quantity-input" />

                                                    </div>
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
</asp:Content>
