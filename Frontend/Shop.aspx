<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="Frontend.Shop" %>
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
                                    <div class="card">
                                        <div class="card-heading active">
                                            <a data-toggle="collapse" data-target="#collapseOne">Nursery Items</a>
                                        </div>
                                        <div id="collapseOne" class="collapse show" data-parent="#accordionExample">
                                            <div class="card-body">
                                                <ul>
                                                    <li><a href="#">Cribs</a></li>
                                                    <li><a href="#">Baby Monitors</a></li>
                                                    <li><a href="#">Dressers</a></li>
                                                    <li><a href="#">Cradling Chairs</a></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="card">
                                        <div class="card-heading">
                                            <a data-toggle="collapse" data-target="#collapseTwo">Baby Gear </a>
                                        </div>
                                        <div id="collapseTwo" class="collapse" data-parent="#accordionExample">
                                            <div class="card-body">
                                                <ul>
                                                    <li><a href="#">Car Seats</a></li>
                                                    <li><a href="#">Strollers</a></li>
                                                    <li><a href="#">Swings</a></li>
                                                    <li><a href="#">Playards</a></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="card">
                                        <div class="card-heading">
                                            <a data-toggle="collapse" data-target="#collapseThree">Baby Clothes</a>
                                        </div>
                                        <div id="collapseThree" class="collapse" data-parent="#accordionExample">
                                            <div class="card-body">
                                                <ul>
                                                    <li><a href="#">Onesies</a></li>
                                                    <li><a href="#">Pajamas</a></li>
                                                    <li><a href="#">Sweaters/Jackets</a></li>
                                                    <li><a href="#">Socks</a></li>    
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="card">
                                        <div class="card-heading">
                                            <a data-toggle="collapse" data-target="#collapseFour">Feeding Essentials</a>
                                        </div>
                                        <div id="collapseFour" class="collapse" data-parent="#accordionExample">
                                            <div class="card-body">
                                                <ul>
                                                    <li><a href="#">Bottles</a></li>
                                                    <li><a href="#">Bibs</a></li>
                                                    <li><a href="#">Pacifiers</a></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="card">
                                        <div class="card-heading">
                                            <a data-toggle="collapse" data-target="#collapseFive">Health Products</a>
                                        </div>
                                        <div id="collapseFive" class="collapse" data-parent="#accordionExample">
                                            <div class="card-body">
                                                <ul>
                                                    <li><a href="#">Baby Thermometers</a></li>
                                                    <li><a href="#">First Aid Kit</a></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="card">
                                        <div class="card-heading">
                                            <a data-toggle="collapse" data-target="#collapseSix">Baby Bedding</a>
                                        </div>
                                        <div id="collapseSix" class="collapse" data-parent="#accordionExample">
                                            <div class="card-body">
                                                <ul>
                                                    <li><a href="#">Mattress pads</a></li>
                                                    <li><a href="#">Sheets</a></li>
                                                    <li><a href="#">Blankets</a></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="card">
                                        <div class="card-heading">
                                            <a data-toggle="collapse" data-target="#collapseSeven">Diapering Must-Haves</a>
                                        </div>
                                        <div id="collapseSeven" class="collapse" data-parent="#accordionExample">
                                            <div class="card-body">
                                                <ul>
                                                    <li><a href="#">Changing Tables</a></li>
                                                    <li><a href="#">Diaper Bags</a></li>
                                                    <li><a href="#">Diaper Creams</a></li>
                                                    <li><a href="#">Baby Wipes</a></li>
                                                    <li><a href="#">Diapers</a></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="card">
                                        <div class="card-heading">
                                            <a data-toggle="collapse" data-target="#collapseEight">Bath Items</a>
                                        </div>
                                        <div id="collapseEight" class="collapse" data-parent="#accordionExample">
                                            <div class="card-body">
                                                <ul>
                                                    <li><a href="#">Bathtubs</a></li>
                                                    <li><a href="#">Towels</a></li>
                                                    <li><a href="#">Hairbrushes</a></li>
                                                    <li><a href="#">Washcloths</a></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
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
                <!-- Nursery Items -->
                <div class="col-lg-9 col-md-9">
                    <div class="row">
                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/white-crib.jpeg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/white-crib.jpeg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">White Wooden Cot</a></h6>
                                  <br />
                                    <div class="product__price">R3500,99</div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/wooden-crib.jpeg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/wooden-crib.jpeg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Solid Wood Baby Crib Cot</a></h6>
                                    <br />
                                    <div class="product__price">R2499,99</div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/baby-monitor.jpeg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/baby-monitor.jpeg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Baby Monitor Wireless Two-way Speaker</a></h6>
                                    <br />
                                    <div class="product__price">R1489,00</div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/multi-cradlechair.jpeg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/multi-cradlechair.jpeg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Multifunctional baby Cradle Chair</a></h6>
                                   <br />
                                    <div class="product__price">R2399,99</div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6">
                            <div class="product__item sale">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/wooden-cradlechair.jpeg">
                                    <div class="label">Sale</div>
                                    <ul class="product__hover">
                                        <li><a href="img/shop/wooden-cradlechair.jpeg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Wooden Baby Bouncer Cradle Chair </a></h6>
                                    <br />
                                    <div class="product__price">R1250,99<span>R1899,99</span></div>
                                </div>
                            </div>
                        </div>
                        <!-- Baby Gear -->
                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/carseat.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/carseat.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">LuvLap Sports Convertible Car Seat</a></h6>
                                    <br />
                                    <div class="product__price">R1199,99</div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/stroller.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/stroller.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Infant Baby Stroller</a></h6>
                                    <br />
                                    <div class="product__price">R850,00</div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/swing.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/swing.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Compact Baby Swing</a></h6>
                                    <br />
                                    <div class="product__price">R950,00</div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/playard.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/playard.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Lullaby Baby Playard</a></h6>
                                    <br />
                                    <div class="product__price">R6999,00</div>
                                </div>
                            </div>
                        </div>

                         <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/onesie.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/onesie.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Daddys Girl Onesie</a></h6>
                                    <br />
                                    <div class="product__price">399,00</div>
                                </div>
                            </div>
                        </div>

                         <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/pjs.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/pjs.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Cute Cotton Pyjamas</a></h6>
                                    <br />
                                    <div class="product__price">R199,00</div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/sweater.jfif">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/sweater.jfif" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Crochet Baby Sweater</a></h6>
                                    <br />
                                    <div class="product__price">R399,00</div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/socks.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/socks.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">5 Pairs Baby Socks</a></h6>
                                    <br />
                                    <div class="product__price">R419,99</div>
                                </div>
                            </div>
                        </div>

                        <!-- Feeding Essentials -->
                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/bottle.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/bottle.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">NUK Baby Bottle</a></h6>
                                    <br />
                                    <div class="product__price">R199,99</div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/bib.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/bib.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Skattig Baby Bib</a></h6>
                                    <br />
                                    <div class="product__price">R80,00</div>
                                </div>
                            </div>
                        </div>

                         <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/dummy.jfif">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/dummy.jfif" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Baby Pink Pacifier</a></h6>
                                    <br />
                                    <div class="product__price">R100,00</div>
                                </div>
                            </div>
                        </div>
                        <!-- Health Products 
                        <!-- Health Products -->
                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/thermo.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/thermo.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Digital Thermometer</a></h6>
                                    <br />
                                    <div class="product__price">R59,99</div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/firstaid1.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/firstaid1.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Safety 1st Healthcare kit</a></h6>
                                    <br />
                                    <div class="product__price">R289,00</div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/matresspad1.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/matresspad1.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Newton Waterproof Mattress Pad</a></h6>
                                    <br />
                                    <div class="product__price">R1520,00</div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/babysheets.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/babysheets.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Snuggletime Stay Safe Fitted Sheet</a></h6>
                                    <br />
                                    <div class="product__price">R99,99</div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/blanket.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/blanket.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">BabySense Receiver Blanket</a></h6>
                                    <br />
                                    <div class="product__price">R189,00</div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/babytable.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/babytable.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Chelino Prima Rossi Change Table</a></h6>
                                    <br />
                                    <div class="product__price">R2299,00</div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/diaperbag.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/diaperbag.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Ryco Willow Diaper Bag</a></h6>
                                    <br />
                                    <div class="product__price">R1099,99</div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/diapercream.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/diapercream.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Johnson's Baby Diaper Cream</a></h6>
                                    <br />
                                    <div class="product__price">R199,99</div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/babywipes.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/babywipes.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Pampers Baby Wipes</a></h6>
                                    <br />
                                    <div class="product__price">R269,99</div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/diapers.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/diapers.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Pampers Premium Care Diapers</a></h6>
                                    <br />
                                    <div class="product__price">R479,99</div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/bathtub.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/bathtub.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Chellino Bath Tub</a></h6>
                                    <br />
                                    <div class="product__price">R599,99</div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/towel.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/towel.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Snuggle Time Soft Hooded Towel</a></h6>
                                    <br />
                                    <div class="product__price">R84,99</div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/brush.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/brush.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Safety First Easy Brush & Comb</a></h6>
                                    <br />
                                    <div class="product__price">R94,99</div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-6">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/shop/washcloth.jpg">
                                    <ul class="product__hover">
                                        <li><a href="img/shop/washcloth.jpg" class="image-popup"><span class="arrow_expand"></span></a></li>
                                        <li><a href="#"><span class="icon_heart_alt"></span></a></li>
                                        <li><a href="#"><span class="icon_bag_alt"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="#">Snuggletime Washcloth</a></h6>
                                    <br />
                                    <div class="product__price">R99,99</div>
                                </div>
                            </div>
                        </div>
                        
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
