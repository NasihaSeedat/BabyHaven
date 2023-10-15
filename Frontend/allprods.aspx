<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="allprods.aspx.cs" Inherits="Frontend.allprods" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .invoice-table-area {
            padding: 50px;
        }

        .invoice-table {
            border: 1px solid #ccc;
            padding: 20px;
            background-color: #fff;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        table.table {
            width: 100%;
            border-collapse: collapse;
        }

            table.table th,
            table.table td {
                padding: 10px;
                text-align: center;
                border-bottom: 1px solid #ccc;
            }

            table.table th {
                background-color: #f4f4f4;
            }

        h2 {
            text-align: center;
            font-size: 24px;
            color: #333;
        }

        table.table tbody tr:hover {
            background-color: #84B7EE;
            color: white;
            transition: background-color 0.3s, color 0.3s; /* Add smooth transition */
        }
    </style>


</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="breadcrumb-option">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="breadcrumb__links">
                        <a href="Home.aspx"><i class="fa fa-home"></i>Home</a>
                        <a href="reports.aspx">Reports</a>
                        <span>Number of different products sold</span>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="container">
        <div class="product-count-container">
            <asp:Label ID="lblProductCount" runat="server" Text="" CssClass="lblCount"></asp:Label>
        </div>
    </div>



    <div class="invoice-table-area section-padding-100">
        <div class="container">
            <div class="row">
                <div class="col-md-3">
                    <!-- Move the categories here -->
                    <div class="sidebar__categories">
                        <br />
                        <div class="section-title">
                            <h4>Sort By Categories</h4>
                        </div>
                        <div class="categories__accordion">
                            <div class="accordion" id="accordionExample">
                                <ul>
                                    <li><a style="color: black; transition: color 0.3s;" href="allprods.aspx?Category=Nursery Items" onmouseover="this.style.color='#84B7EE'" onmouseout="this.style.color='black'">Nursery Items</a></li>
                                    <li><a style="color: black; transition: color 0.3s;" href="allprods.aspx?Category=Baby Gear" onmouseover="this.style.color='#84B7EE'" onmouseout="this.style.color='black'">Baby Gear</a></li>
                                    <li><a style="color: black; transition: color 0.3s;" href="allprods.aspx?Category=Baby Clothes" onmouseover="this.style.color='#84B7EE'" onmouseout="this.style.color='black'">Baby Clothes</a></li>
                                    <li><a style="color: black; transition: color 0.3s;" href="allprods.aspx?Category=Feeding Essentials" onmouseover="this.style.color='#84B7EE'" onmouseout="this.style.color='black'">Feeding Essentials</a></li>
                                    <li><a style="color: black; transition: color 0.3s;" href="allprods.aspx?Category=Health Products" onmouseover="this.style.color='#84B7EE'" onmouseout="this.style.color='black'">Health Products</a></li>
                                    <li><a style="color: black; transition: color 0.3s;" href="allprods.aspx?Category=Baby Bedding" onmouseover="this.style.color='#84B7EE'" onmouseout="this.style.color='black'">Baby Bedding</a></li>
                                    <li><a style="color: black; transition: color 0.3s;" href="allprods.aspx?Category=Diapering Must-Haves" onmouseover="this.style.color='#84B7EE'" onmouseout="this.style.color='black'">Diapering Must-Haves</a></li>
                                    <li><a style="color: black; transition: color 0.3s;" href="allprods.aspx?Category=Bath Items" onmouseover="this.style.color='#84B7EE'" onmouseout="this.style.color='black'">Bath Items</a></li>
                                    <li><a style="color: black; transition: color 0.3s;" href="allprods.aspx?Category=Project SafeHaven" onmouseover="this.style.color='#84B7EE'" onmouseout="this.style.color='black'">Project SafeHaven</a></li>
                                </ul>

                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-9">
                    <h2>Products sold on the website</h2>
                    <br />
                    <!-- Rest of your content here -->
                    <form id="invoicesForm" runat="server">
                        <div class="invoice-table text-center">
                            <div class="table-responsive">
                                <table class="table">
                                    <thead>
                                        <tr>
                                            <th>Product ID</th>
                                            <th>Product Name</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <!-- You can use a repeater or data binding to populate rows with user's invoices -->
                                        <asp:Repeater ID="ProductsRepeater" runat="server">
                                            <ItemTemplate>
                                                <tr>
                                                    <td><%# Eval("Product_Id") %></td>
                                                    <td><%# Eval("P_Name") %></td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
