<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="Frontend.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <form id="form1" runat="server">
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
                            Product Name:<td>
                                <input type="text" class="textbox" placeholder="Product name" required runat="server" id="ProName"></td>
                        </tr>

                        <tr>
                            <td class="Pro_Description">
                            Product Description:<td>
                                <input type="text" class="textbox" placeholder="Product description" required runat="server" id="ProDescription"></td>
                        </tr>

                        <tr>
                            <td class="Pro_Price">
                            Product Price:<td>
                                <input type="number" class="textbox" placeholder="Product price" required min="1" runat="server" id="ProPrice"></td>
                        </tr>

                        <tr>
                            <td class="Pro_Category">
                            Product Category:<td>
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
                            <td >
                            Product Activation Status:<td>
                                <select  class="Cat_option" name="active" required runat="server" id="ProActive">
                                    <option disabled="disabled" selected="selected">Choose status</option>
                                    <option value="1">Active</option>
                                    <option value="2">Not active</option>
                                </select></td>
                        </tr>

                        <tr>
                              <td >
                                Product Quantity:
                              </td>
                              <td>
                                <input  class="textbox" type="number" placeholder="Product quantity" required min="1" runat="server" id="ProQuantity">
                              </td>
                        </tr>


                        <!---ERROR MESSAGE --->
                        <tr>
                            <td class="Error">
                            Error Message:<td>
                                <input type="text" visible="false" runat="server" id="error"></td>
                        </tr>

                    </tbody>
                </table>

                <!--- BUTTONS: -->

                <div class="btn btn-link">
                    
                     <!--  <div class="site-btn clear-btn" onclick="AddProduct_Click" >Add Product</div>-->
                        <asp:Button ID="AddProds" class="site-btn" runat="server" Text="Add Product"  Width="198px" />
                    </div>
                </div>

              

                            

              

            </div>
        </div>
    </div>

    <!---END ADD PRODUCT PAGE --->
    </form>
</asp:Content>
