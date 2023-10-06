<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="allprods.aspx.cs" Inherits="Frontend.allprods" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .product-count-container,
        .product-info-container {
            font-size: 16px;
            margin-bottom: 15px;
            margin-left: 50px;
            color: #0d0d0d;
        }

            /* Style for the product information */
            .product-info-container strong {
                font-weight: bold;
            }


        /* Style for the first container to add margin-top */
        .product-count-container {
            margin-top: 20px;
        }

        /* Style for the labels */
        .lblAllProds {
            font-size: 16px;
            color: #0d0d0d;
            font-weight: 500;
            display: inline-block;
            margin-bottom: 0;
        }

        .lblCount {
            font-size: 16px;
            color: #0d0d0d;
            font-weight: 500;
            display: inline-block;
            margin-bottom: 0;
            transition: color 0.3s;
        }

            .lblCount:hover {
                color: #84B7EE;
            }

        .product-item {
            transition: color 0.3s;
        }

            .product-item:hover {
                color: #84B7EE;
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

        <div class="product-info-container">
            <asp:Label ID="lblProductInfo" runat="server" Text="" CssClass="lblAllProds"></asp:Label>
        </div>

    </div>




</asp:Content>
