<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register src="TableViewer.ascx" tagname="TableViewer" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:TableViewer ID="TableViewer1" runat="server" dataBaseName="Round22" serverName="SIRPC\CRVLSQL" />
    
    </div>
    </form>
</body>
</html>
