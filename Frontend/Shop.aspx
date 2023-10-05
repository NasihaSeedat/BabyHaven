<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="Frontend.Shop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .Cat_option {
            height: 50px;
            width: 100%;
            border: 1px solid #e1e1e1;
            border-radius: 2px;
            margin-bottom: 25px;
            font-size: 14px;
            padding-left: 20px;
            color: #666666;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Shop Section Begin -->
    <section class="shop spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-3 col-md-3">
                    <div class="shop__sidebar">

                        <%-- <span class="icon_search search-switch"></span>--%>


                        <form runat="server">
                            <div class="search-container">
                                <asp:TextBox ID="txtSearch" CssClass="search-bar" placeholder="Search for product" runat="server"></asp:TextBox>
                                <asp:Button ID="btnSearch" runat="server" Text="" CssClass="search-button" Style="margin-left: 10px;" OnClick="btnSearch_Click" /><br />
                            </div>


                            <div class="sidebar__categories">
                                <br />
                                <div class="section-title">
                                    <h4>Sort By Categories</h4>
                                </div>
                                <div class="categories__accordion">
                                    <div class="accordion" id="accordionExample">
                                        <ul>
                                            <li><a style="color: black" href="Shop.aspx?Category=Nursery Items">Nursery Items</a></li>
                                            <li><a style="color: black" href="Shop.aspx?Category=Baby Gear">Baby Gear</a></li>
                                            <li><a style="color: black" href="Shop.aspx?Category=Baby Clothes">Baby Clothes</a></li>
                                            <li><a style="color: black" href="Shop.aspx?Category=Feeding Essentials">Feeding Essentials</a></li>
                                            <li><a style="color: black" href="Shop.aspx?Category=Health Products">Health Products</a></li>
                                            <li><a style="color: black" href="Shop.aspx?Category=Baby Bedding">Baby Bedding</a></li>
                                            <li><a style="color: black" href="Shop.aspx?Category=Diapering Must-Haves">Diapering Must-Haves</a></li>
                                            <li><a style="color: black" href="Shop.aspx?Category=Bath Items">Bath Items</a></li>
                                            <li><a style="color: black" href="Shop.aspx?Category=Project SafeHaven">Project SafeHaven</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class="sidebar__filter">
                                <div class="section-title">
                                    <h4>Sort by price</h4>
                                </div>
                                <div class="priceFilter">

                                    <label for="minPrice">Min Price:</label>
                                    <select class="Cat_option" id="minPrice" runat="server">
                                        <option value="0">R0</option>
                                        <option value="50">R50</option>
                                        <option value="100">R100</option>
                                        <option value="250">R250</option>
                                        <option value="500">R500</option>
                                        <option value="1000">R1000</option>
                                    </select>
                                    <br />
                                    <label for="maxPrice">Max Price:</label>
                                    <select class="Cat_option" id="maxPrice" runat="server">
                                        <option value="100">R100</option>
                                        <option value="250">R250</option>
                                        <option value="500">R500</option>
                                        <option value="1000">R1000</option>
                                        <option value="2500">R2500</option>
                                        <option value="5000">R5000</option>
                                    </select>
                                    <input type="submit" value="Filter" onserverclick="SearchProducts" runat="server" class="btnFilter" />

                                    <br />
                                    <br />

                                    <!-- Alphabetical Sort -->
                                    <div class="sidebar__alphabetical-sort">
                                        <div class="section-title">
                                            <h4>Sort by Alphabet</h4>
                                        </div>
                                        <div class="filter-group">
                                            <label for="alphabeticalSort">Alphabetical Sort:</label>
                                            <select class="Cat_option" id="alphabeticalSort" runat="server">
                                                <option value="asc">A to Z</option>
                                                <option value="desc">Z to A</option>
                                            </select>
                                            <input type="submit" value="Sort" onserverclick="SortProductsByName" runat="server" class="btnFilter" />
                                        </div>
                                    </div>
                        </form>
                        <br />
                    </div>
                </div>




            </div>
        </div>
        <!-- show content -->
        <asp:Literal ID="productDisplay" runat="server"></asp:Literal>

        </div>
        </div>
    </section>
    <!-- Shop Section End -->

</asp:Content>
