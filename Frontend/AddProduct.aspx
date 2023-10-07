<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="Frontend.AddProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        table {
            width: 100%;
            padding-top: 120px;
        }

        th.addProduct {
            font-size: 24px;
            text-align: center;
            padding: 10px;
        }

        td.Pro_Name,
        td.Pro_Description,
        td.Pro_Price,
        td.Pro_Category,
        td.ProActive,
        td.ProQuantity,
        td.Error {
            color: #444444;
            font-weight: 500;
            margin-bottom: 10px;
        }

        .textbox,
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

        table td {
            text-align: center;
        }

        .p {
            color: #444444;
            font-weight: 500;
            margin-bottom: 10px;
        }
    </style>

    <script>
        function addPrefix(input) {
            var prefix = "img/shop/";
            var value = input.value;

            // Check if the current value does not start with the prefix
            if (!value.startsWith(prefix)) {
                // Prepend the prefix to the current value
                input.value = prefix + value;
            }
        }
    </script>


</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Breadcrumb Begin -->
    <div class="breadcrumb-option">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="breadcrumb__links">
                        <a href="Home.aspx"><i class="fa fa-home"></i>Home</a>
                        <span>Add Products</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Breadcrumb End -->
    <form id="form1" runat="server" class="checkout__form">
        <div class="AddProduct_Page">
            <div class="container">
                <div class="col-lg-10 offset-lg-1 text-left text-lg-right">
                    <div class="AddProduct_Table">
                        <table>
                            <thead>
                                <tr>
                                    <th class="addProduct">Add Product</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>

                                    <td class="Pro_Name">
                                        <p>Product Name:</p>
                                    </td>
                                    <td>
                                        <input type="text" class="textbox" placeholder="Product name" required runat="server" id="ProName">
                                    </td>
                                </tr>

                                <tr>
                                    <td class="Pro_Description">
                                        <p>Product Description:</p>
                                    </td>
                                    <td>
                                        <textarea class="textbox" placeholder="Product description" required runat="server" style="height: 150px;" id="ProDescription"></textarea>
                                    </td>
                                </tr>

                                <tr>
                                    <td class="Pro_Price">
                                        <p>Product Price:</p>
                                    </td>
                                    <td>
                                        <input type="number" class="textbox" placeholder="Product price" required min="1" runat="server" id="ProPrice"></td>
                                </tr>

                                <tr>
                                    <td class="Pro_Category">
                                        <p>Product Category:</p>

                                    </td>
                                    <td>
                                        <select class="Cat_option" name="category" required runat="server" id="ProCategory">
                                            <option disabled="disabled" selected="selected">Choose Category</option>
                                            <option value="1">Nursery Items</option>
                                            <option value="2">Baby Gear</option>
                                            <option value="3">Baby Clothes</option>
                                            <option value="4">Feeding Essentials</option>
                                            <option value="5">Health Products</option>
                                            <option value="6">Baby Bedding</option>
                                            <option value="7">Diapering Must-Haves</option>
                                            <option value="8">Bath Items</option>
                                            <option value="9">Project SafeHaven</option>
                                        </select></td>
                                </tr>

                                <tr>
                                    <td>
                                        <p>Product Activation Status:</p>
                                    </td>
                                    <td>
                                        <select class="Cat_option" name="active" required runat="server" id="ProActive">
                                            <option disabled="disabled" selected="selected">Choose status</option>
                                            <option value="1">Active</option>
                                            <option value="2">Not active</option>
                                        </select></td>
                                </tr>

                                <tr>
                                    <td>
                                        <p>Product Quantity:</p>
                                    </td>
                                    <td>
                                        <input class="textbox" type="number" placeholder="Product quantity" required min="1" runat="server" id="ProQuantity">
                                    </td>
                                </tr>

                                <tr>
                                    <td>
                                        <p>Product Image:</p>
                                    </td>
                                    <td>
                                        <div style="display: flex; align-items: center;">
                                            <input type="text" class="textbox" placeholder="img/shop/" required runat="server" id="ProImage" style="flex: 1;" oninput="addPrefix(this);">
    
                                        </div>
                                    </td>
                                </tr>


                                <!---ERROR MESSAGE --->
                                <tr>
                                    <td class="Error">
                                        <p>Error Message:</p>
                                    </td>
                                    <td>
                                        <input type="text" visible="false" runat="server" id="error"></td>
                                </tr>

                            </tbody>
                        </table>

                        <!--- BUTTONS: -->

                        <div class="btn btn-link">


                            <asp:Button ID="AddProds" class="btnInvoice" runat="server" Text="Add Product" Width="198px" OnClick="AddProds_Click" />
                        </div>
                    </div>

                </div>
            </div>
        </div>

        <!---END ADD PRODUCT PAGE --->
    </form>
</asp:Content>
