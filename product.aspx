<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="DuongVanTrongDai_2906.product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .main{
            padding: 5px;
        }
        .hinhsp{
            width: 180px;
            height: 230px;
        }

    </style>
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="4">
        <ItemTemplate>
            <div class="main">
            <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/img/" + Eval("HinhAnh") %>' CssClass="hinhsp" />
                <br />
                <b>TÊN SP</b>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenDT") %>'></asp:Label>
                <br />
                <b>ĐƠN GIÁ</b>
                <span class="gia"> <%# Eval("GiaBan") %> VNĐ</span>
                <br />
                <asp:Button ID="Button1" runat="server" Text="XEM CHI TIẾT" CssClass="btn" />
            </div>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
