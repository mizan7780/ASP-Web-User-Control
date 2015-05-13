<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NoticeEntryPage.aspx.cs" Inherits="NoticeEntryPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Notice Date :</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Notice Expire Date :</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Message :</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Height="100px" TextMode="MultiLine" Width="300px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Entry" />
&nbsp;<asp:Literal ID="Literal1" runat="server"></asp:Literal>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

