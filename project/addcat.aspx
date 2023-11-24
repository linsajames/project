<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="addcat.aspx.cs" Inherits="project.addcat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 419px;
        }
        .auto-style6 {
            height: 22px;
            width: 419px;
        }
        .auto-style10 {
            width: 73px;
        }
        .auto-style11 {
            height: 22px;
            width: 73px;
        }
        .auto-style13 {
            height: 22px;
            width: 89px;
        }
        .auto-style15 {
            width: 194px;
        }
        .auto-style16 {
            width: 152px;
        }
        .auto-style17 {
            width: 89px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style15">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6"></td>
            <td class="auto-style11"></td>
            <td class="auto-style13">
                <asp:Label ID="Label1" runat="server" Text="ADD CATEGORY"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style15">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style10">
                <asp:Label ID="Label2" runat="server" Text="Category name"></asp:Label>
            </td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style16">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style15">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style10">
                <asp:Label ID="Label3" runat="server" Text="Image"></asp:Label>
            </td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style16">
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
            <td class="auto-style15">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style10">
                <asp:Label ID="Label4" runat="server" Text="Description"></asp:Label>
            </td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style16">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td class="auto-style15">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style10">
                <asp:Label ID="Label5" runat="server" Text="Status"></asp:Label>
            </td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style16">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>available</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style15">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style15">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style17">
                <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            </td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style15">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style15">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style17">
                &nbsp;</td>
            <td class="auto-style16">
                <asp:GridView ID="GridView1" runat="server" DataKeyNames="cat_id" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" />
                        <asp:CommandField ShowEditButton="True" />
                        <asp:ImageField DataImageUrlField="cat_image" HeaderText="image">
                            <ControlStyle Height="200px" Width="250px" />
                        </asp:ImageField>
                    </Columns>
                </asp:GridView>
            </td>
            <td class="auto-style15">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style15">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
