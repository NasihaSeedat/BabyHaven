<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Frontend.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Categories Section Begin -->
    <section class="categories">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-6 p-0">
                    <div class="categories__item categories__large__item set-bg"
                    data-setbg="img/categories/babygoods.jpg">
                        <div class="categories__text">
                            <h1>Baby Products</h1>
                            <a href="Shop.aspx">Shop now</a>
                        </div>
                    </div>
                </div>
            <div class="col-lg-6">
                <div class="row">
                    <div class="col-lg-6 col-md-6 col-sm-6 p-0">
                        <div class="categories__item set-bg" data-setbg="img/categories/nursery.jpg">
                            <div class="categories__text">
                                <h4>Nursery Needs</h4>
                                <a href="Shop.aspx">Shop now</a>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-6 p-0">
                        <div class="categories__item set-bg" data-setbg="img/categories/bib.jpg">
                            <div class="categories__text">
                                <h4>Feeding Essentials</h4>
                                <a href="Shop.aspx">Shop now</a>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-6 p-0">
                        <div class="categories__item set-bg" data-setbg="img/categories/swing.jpg">
                            <div class="categories__text">
                                <h4>Baby Gear</h4>
                                <a href="Shop.aspx">Shop now</a>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-6 p-0">
                        <div class="categories__item set-bg" data-setbg="img/categories/bath.jpg">
                            <div class="categories__text">
                                <h4>Bath Time</h4>
                                <a href="Shop.aspx">Shop now</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            </div>
        </div>
    </section>
    <!-- Categories Section End -->
   
    <!-- Banner Section Begin -->
    <section class="banner set-bg" data-setbg="img/banner/banner.jpg">
        <div class="container">
            <div class="row">
                <div class="col-xl-7 col-lg-8 m-auto">
                    <div class="banner__slider owl-carousel">
                        <div class="banner__item">
                            <div class="banner__text">
                                <span>BabyHaven</span>
                                <h1>Catering for your baby's needs</h1>
                                <a href="Shop.aspx">Shop now</a>
                            </div>
                        </div>
                        <div class="banner__item">
                            <div class="banner__text">
                                <span>BabyHaven</span>
                                <h1>Free Shipping for all orders over R2000</h1>
                                <a href="Shop.aspx">Shop now</a>
                            </div>
                        </div>
                        <div class="banner__item">
                            <div class="banner__text">
                                <span>BabyHaven</span>
                                <h1>Project SafeHaven</h1>
                                <a href="#">need help with GBV?</a>
                            </div>
                        </div>
                        
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Banner Section End -->

    <br/>

    <!-- Discount Section Begin -->
    <section class="discount">
        <div class="container">
            <div class="row">
                <div class="col-lg-6 p-0">
                    <div class="discount__pic">
                        <img src="img/discount1.jpg" alt="">
                    </div>
                </div>
                <div class="col-lg-6 p-0">
                    <div class="discount__text">
                        <div class="discount__text__title">
                            <span>Countdown</span>
                            <h2>Projects Day 2023</h2>
                            <h5><span>Sale</span> 50%</h5>
                        </div>
                        <div class="discount__countdown" id="countdown-time">
                            <div class="countdown__item">
                                <span>22</span>
                                <p>Days</p>
                            </div>
                            <div class="countdown__item">
                                <span>18</span>
                                <p>Hour</p>
                            </div>
                            <div class="countdown__item">
                                <span>46</span>
                                <p>Min</p>
                            </div>
                            <div class="countdown__item">
                                <span>05</span>
                                <p>Sec</p>
                            </div>
                        </div>
                        <a href="Shop.aspx">Shop now</a>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Discount Section End -->

    <!-- Services Section Begin -->
    <section class="services spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-3 col-md-4 col-sm-6">
                    <div class="services__item">
                        <i class="fa fa-car"></i>
                        <h6>Free Shipping</h6>
                        <p>For all orders over R1000</p>
                    </div>
                </div>
                <div class="col-lg-3 col-md-4 col-sm-6">
                    <div class="services__item">
                        <i class="fa fa-money"></i>
                        <h6>Money Back Guarantee</h6>
                        <p>If goods has problems</p>
                    </div>
                </div>
                <div class="col-lg-3 col-md-4 col-sm-6">
                    <div class="services__item">
                        <i class="fa fa-support"></i>
                        <h6>Online Support 24/7</h6>
                        <p>Dedicated support</p>
                    </div>
                </div>
                <div class="col-lg-3 col-md-4 col-sm-6">
                    <div class="services__item">
                        <i class="fa fa-headphones"></i>
                        <h6>Payment Secure</h6>
                        <p>100% secure payment</p>
                    </div>
                </div>
            </div>
        </div>
    </section>
<!-- Services Section End -->
</asp:Content>
