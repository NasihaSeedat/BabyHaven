<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="ProjSafeInvoice.aspx.cs" Inherits="Frontend.ProjSafeInvoice" %>

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
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="invoice-table-area section-padding-100">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <h2>Project SafeHaven Purchase History</h2>
                    <br />
                </div>
            </div>
            <form id="invoicesForm" runat="server">
                <div class="invoice-table text-center">
                    <div class="table-responsive">
                        <table class="table">
                            <thead>
                                <tr>
                                    <th>Order ID</th>
                                    <th>Total Amount</th>
                                    <th>Date</th>
                                    <th>Actions</th>
                                </tr>
                            </thead>
                            <tbody>

                                <asp:Repeater ID="InvoicesRepeater2" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <td><%# Eval("O_Id") %></td>
                                            <td>R <%# Eval("O_Total", "{0:N2}") %></td>
                                            <td><%# Eval("O_Date", "{0:yyyy-MM-dd}") %></td>
                                            <td>
                                                <asp:Button runat="server" Text="Get Details" CssClass="btn btn-primary" Style="background-color: #84B7EE; border-color: #84B7EE;"
                                                    OnClick="DownloadPdfButton_Click" CommandArgument='<%# Eval("O_Id") %>' />

                                                <asp:Button runat="server" Text="Take Action" CssClass="btn btn-warning" Style="background-color: #FFA500; border-color: #FFA500;"
                                                    OnClick="TakeActionButton_Click" CommandArgument='<%# Eval("O_Id") %>' />
                                            </td>
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
