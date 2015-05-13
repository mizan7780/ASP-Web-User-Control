<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NoticeDetails.aspx.cs" Inherits="NoticeDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
            width: 145px;
        }
    </style>
    <script type="text/javascript">
        function abc() {
            NoticeService.showNotice(document.getElementById('Text1').value,onsuccess,onerror);
        }
        function onsuccess(data) {
            var str = "";
            for (var i = 0; i < data.length; i++) {
                str += "Message : "+data[i].msg+" <br /><hr />";
            }
            S1.innerHTML = str;
        }
        function onerror() {
            alert('Error!');
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server">
        <Services>           
            <asp:ServiceReference Path="~/NoticeService.svc" />
        </Services>
    </asp:ScriptManagerProxy>
    
    <table style="width:100%;">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Date :</td>
            <td class="auto-style2">
                <input id="Text1" type="text" /></td>
            <td>
                <input id="Button1" type="button" value="Show All Notice" onclick="abc();" /></td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" colspan="3">
                <span id="S1"></span>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

