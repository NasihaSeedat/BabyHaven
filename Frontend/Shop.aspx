﻿<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="Frontend.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Shop Section Begin -->
    <section class="shop spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-3 col-md-3">
                    <div class="shop__sidebar">
                        <div class="sidebar__categories">
                            <div class="section-title">
                                <h4>Categories</h4>
                            </div>
                            <div class="categories__accordion">
                                <div class="accordion" id="accordionExample">
                            <ul>
							<li><a style="color:black" href="Shop.aspx?Category=Nursery Items">Nursery Items</a></li>
							<li><a style="color:black" href="Shop.aspx?Category=Baby Gear">Baby Gear</a></li>
							<li><a style="color:black" href="Shop.aspx?Category=Baby Clothes">Baby Clothes</a></li>
							<li><a style="color:black" href="Shop.aspx?Category=Feeding Essentials">Feeding Essentials</a></li>
							<li><a style="color:black" href="Shop.aspx?Category=Health Products">Health Products</a></li>
							<li><a style="color:black" href="Shop.aspx?Category=Baby Bedding">Baby Bedding</a></li>
							<li><a style="color:black" href="Shop.aspx?Category=Diapering Must-Haves">Diapering Must-Haves</a></li>
							<li><a style="color:black" href="Shop.aspx?Category=Bath Items">Bath Items</a></li>
                            <li><a style="color:black" href="Shop.aspx?Category=Project SafeHaven">Project SafeHaven</a></li>
						</ul> 
                               </div>
                            </div>
                        </div>
                        <div class="sidebar__filter">
                            <div class="section-title">
                                <h4>Shop by price</h4>
                            </div>
                            <div class="filter-range-wrap">
                                <div class="price-range ui-slider ui-corner-all ui-slider-horizontal ui-widget ui-widget-content"
                                data-min="33" data-max="99"></div>
                                <div class="range-slider">
                                    <div class="price-input">
                                        <p>Price:</p>
                                        <input type="text" id="minamount">
                                        <input type="text" id="maxamount">
                                    </div>
                                </div>
                            </div>
                            <a href="#">Filter</a>
                        </div>
                        <div class="sidebar__sizes">
                            <div class="section-title">
                                <h4>Shop by size</h4>
                            </div>
                            <div class="size__list">
                                <label for="xxs">
                                    xxs
                                    <input type="checkbox" id="xxs">
                                    <span class="checkmark"></span>
                                </label>
                                &nbsp;<label for="xs">xs
                                    <input type="checkbox" id="xs">
                                    <span class="checkmark"></span>
                                </label>
                                &nbsp;<label for="xss">xs-s
                                    <input type="checkbox" id="xss">
                                    <span class="checkmark"></span>
                                </label>
                                &nbsp;<label for="s">s
                                    <input type="checkbox" id="s">
                                    <span class="checkmark"></span>
                                </label>
                                &nbsp;<label for="m">m
                                    <input type="checkbox" id="m">
                                    <span class="checkmark"></span>
                                </label>
                                &nbsp;<label for="ml">m-l
                                    <input type="checkbox" id="ml">
                                    <span class="checkmark"></span>
                                </label>
                                &nbsp;<label for="l">l
                                    <input type="checkbox" id="l">
                                    <span class="checkmark"></span>
                                </label>
                                &nbsp;<label for="xl">xl
                                    <input type="checkbox" id="xl">
                                    <span class="checkmark"></span>
                                </label>
                            &nbsp;</div>
                        </div>
                        <div class="sidebar__color">
                            <div class="section-title">
                                <h4>Shop by size</h4>
                            </div>
                            <div class="size__list color__list">
                                <label for="black">
                                    Blacks
                                    <input type="checkbox" id="black">
                                    <span class="checkmark"></span>
                                </label>
                                &nbsp;<label for="whites">Whites
                                    <input type="checkbox" id="whites">
                                    <span class="checkmark"></span>
                                </label>
                                &nbsp;<label for="reds">Reds
                                    <input type="checkbox" id="reds">
                                    <span class="checkmark"></span>
                                </label>
                                &nbsp;<label for="greys">Greys
                                    <input type="checkbox" id="greys">
                                    <span class="checkmark"></span>
                                </label>
                                &nbsp;<label for="blues">Blues
                                    <input type="checkbox" id="blues">
                                    <span class="checkmark"></span>
                                </label>
                                &nbsp;<label for="beige">Beige Tones
                                    <input type="checkbox" id="beige">
                                    <span class="checkmark"></span>
                                </label>
                                &nbsp;<label for="greens">Greens
                                    <input type="checkbox" id="greens">
                                    <span class="checkmark"></span>
                                </label>
                                &nbsp;<label for="yellows">Yellows
                                    <input type="checkbox" id="yellows">
                                    <span class="checkmark"></span>
                                </label>
                            &nbsp;</div>
                        </div>
                    </div>
                </div>
                <!-- show content -->
               <asp:Literal ID="productDisplay" runat="server"></asp:Literal>

                        
                        <div class="col-lg-12 text-center">
                            <div class="pagination__option">
                                <a href="#">1</a>
                                <a href="#">2</a>
                                <a href="#">3</a>
                                <a href="#"><i class="fa fa-angle-right"></i></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Shop Section End -->

</asp:Content>
