<%@ Page Title="" Language="C#" MasterPageFile="~/BabyHaven.Master" AutoEventWireup="true" CodeBehind="DealtWith.aspx.cs" Inherits="Frontend.DealtWith" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="invoice-table-area section-padding-100">
        <div class="container-fluid">

            <div class="row">
                <div class="col-md-12">
                    <h2>Dealt With Project SafeHaven orders</h2>
                    <br />
                </div>
            </div>
            <form id="DealtWithForm" runat="server">
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
                                <asp:Repeater ID="DealtInvoicesRepeater" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <td><%# Eval("O_Id") %></td>
                                            <td>R <%# Eval("O_Total", "{0:N2}") %></td>
                                            <td><%# Eval("O_Date", "{0:yyyy-MM-dd}") %></td>
                                            <td>
                                                <asp:Button runat="server" Text="Get Details" CssClass="btn btn-primary" Style="background-color: #84B7EE; border-color: #84B7EE;"
                                                    OnClick="DownloadPdfButton_Click" CommandArgument='<%# Eval("O_Id") %>' />
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
