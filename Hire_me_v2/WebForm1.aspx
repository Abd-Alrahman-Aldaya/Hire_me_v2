<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Hire_me_v2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>

            <asp:DataList ID="DataList1" runat="server">
            </asp:DataList>
            <asp:ListView ID="ListView1" runat="server">
            </asp:ListView>

        </div>
    </form>
</body>
</html>
