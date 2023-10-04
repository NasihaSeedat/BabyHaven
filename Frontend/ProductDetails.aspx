<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="Frontend.ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Breadcrumb Begin -->
    <div class="breadcrumb-option">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="breadcrumb__links">
                        <a href="Home.aspx"><i class="fa fa-home"></i>Home</a>
                        <a href="Shop.aspx">Shop</a>
                        <a href="Shop.aspx">
                            <asp:Label ID="categoryLabel" runat="server" Text=""></asp:Label>
                        </a>
                        <span>
                            <asp:Label ID="nameLabel" runat="server" Text=""></asp:Label>
                        </span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Breadcrumb End -->

    <!-- Product Details Section Begin -->
    <section class="product-details spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-6">
                    <div class="product__details__pic">
                        <div class="product__details__slider__content">
                            <div class="product__details__pic__slider owl-carousel">
                                <asp:Image ID="productImage" runat="server" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-lg-6">
                    <div class="product__details__text">
                        <h3>
                            <asp:Label ID="nameLabel2" runat="server" Text=""></asp:Label>
                        </h3>

                        <p>Category: <asp:Label ID="categoryLabel2" runat="server" Text=""></asp:Label></p>
                        <div class="product__details__price">
                            <p class="product-price">
                                R<asp:Label ID="priceLabel" runat="server" Text=""></asp:Label>
                            </p>
                        </div>
                        <div class="product__details__button">
                            <form runat="server">
                                <asp:Button runat="server" ID="addtocart" OnClick="AddToCart_Click" Text="Add to cart" CssClass="btn-AddtoCart" />
                            </form>
                        </div>
                        <div class="product__details__widget">
                            <ul>
                                <li>
                                    <span>Availability:</span>
                                    <div class="stock__checkbox">
                                        <asp:Label ID="availabilityLabel" runat="server" Text=""></asp:Label>
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class="col-lg-12">
                    <div class="product__details__tab">
                        <ul class="nav nav-tabs" role="tablist">
                            <li class="nav-item">
                                <a class="nav-link active" data-toggle="tab" href="#tabs-1" role="tab">Description</a>
                            </li>
                        </ul>
                        <div class="tab-content">
                            <div class="tab-pane active" id="tabs-1" role="tabpanel">
                                <h6>Description</h6>
                                <p>
                                    <asp:Label ID="descriptionLabel" runat="server" Text=""></asp:Label>
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Product Details Section End -->
</asp:Content>
