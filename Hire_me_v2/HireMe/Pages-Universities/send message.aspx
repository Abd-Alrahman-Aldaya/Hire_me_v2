<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="send message.aspx.cs" Inherits="Hire_me_v2.HireMe.Pages_Universities.send_message" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form_Send_Message" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="اكتب الرسالة "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="ارسال " />
            
        </div>
        
    </form>
</body>
</html>
