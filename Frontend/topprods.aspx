<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="topprods.aspx.cs" Inherits="Frontend.topprods" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .invoice-table-area {
            padding: 100px;
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
                        <span>Top 5 performing products</span>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="invoice-table-area section-padding-100">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <h2>Top 5 performing products</h2>
                    <br />
                </div>
            </div>
            <form id="invoicesForm" runat="server">
                <div class="invoice-table text-center">
                    <div class="table-responsive">
                        <table class="table">
                            <thead>
                                <tr>
                                    <th>Product Name</th>
                                    <th>Quantity Sold</th>
                                </tr>
                            </thead>
                            <tbody>
                                <!-- You can use a repeater or data binding to populate rows with user's invoices -->
                                <asp:Repeater ID="InvoicesRepeater" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <td><%# Eval("P_Name") %></td>
                                            <td><%# Eval("P_Quantity") %></td>
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
</asp:Content>
