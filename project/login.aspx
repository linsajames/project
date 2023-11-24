<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="project.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
            width: 256px;
        }
    .auto-style2 {
            width: 154px;
        }
    .auto-style3 {
            width: 154px;
            height: 27px;
        }
    .auto-style4 {
            width: 256px;
            height: 27px;
        }
    .auto-style5 {
        height: 27px;
    }
        .auto-style6 {
            width: 372px;
            height: 27px;
        }
        .auto-style7 {
            width: 372px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
    <tr>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style3"></td>
        <td class="auto-style4">LOGIN FORM</td>
        <td class="auto-style5"></td>
    </tr>
    <tr>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style3"></td>
        <td class="auto-style4"></td>
        <td class="auto-style5"></td>
    </tr>
    <tr>
        <td class="auto-style7">
            &nbsp;</td>
        <td class="auto-style2">
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
        </td>
        <td class="auto-style1">&nbsp;</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7">
            &nbsp;</td>
        <td class="auto-style2">
            <asp:Label ID="Label2" runat="server" Text="Password" BackColor="White" BorderColor="#FF9900" ForeColor="Black"></asp:Label>
        </td>
        <td class="auto-style1">&nbsp;</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style1">
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7">&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style1">&nbsp;</td>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
