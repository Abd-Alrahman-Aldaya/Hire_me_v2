<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="recive_message.aspx.cs" Inherits="Hire_me_v2.HireMe.Pages_Graduates.recive_message" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lab_text" runat="server" Text="الرسالة الواردة "></asp:Label> :
            <asp:Label ID="lab_message" runat="server" Text="Label"></asp:Label> بتاريخ<asp:Label ID="lab_Mdate" runat="server" Text="Label"></asp:Label><br />
            <asp:Button ID="btn_ok" runat="server" Text="تم" OnClick="btn_ok_Click" /><br />
            <asp:Button ID="btn_edite" runat="server" Text="اعادة ادخال بيانات" OnClick="btn_edite_Click" /><br />

        </div>
    </form>
</body>
</html>
