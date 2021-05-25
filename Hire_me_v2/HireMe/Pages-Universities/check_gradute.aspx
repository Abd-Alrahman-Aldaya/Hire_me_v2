

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="check_gradute.aspx.cs" Inherits="Hire_me_v2.HireMe.Pages_Universities.check_gradute" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="Label6" runat="server" Text="الرقم الوطني"></asp:Label>
            <asp:Label ID="lab_id_number_grdute" runat="server" Text=": "></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server" Text="الاسم الاول"></asp:Label>
            <asp:Label ID="lab_name_gradute" runat="server" Text=": "></asp:Label>
            <br />
             <asp:Label ID="Label2" runat="server" Text="اسم العائلة"></asp:Label>
            <asp:Label ID="lab_last_gradute" runat="server" Text=":"></asp:Label>
            <br />
             <asp:Label ID="Label3" runat="server" Text="اسم الاب"></asp:Label>
            <asp:Label ID="lab_father_name" runat="server" Text="Label"></asp:Label>
            <br />
             <asp:Label ID="Label4" runat="server" Text="اسم الام "></asp:Label>
            <asp:Label ID="lab_mather_name" runat="server" Text="Label"></asp:Label>
            <br /> 
            <asp:Label ID="Label5" runat="server" Text="المعدل"></asp:Label>
            <asp:Label ID="lab_avg" runat="server" Text="Label"></asp:Label>
            <br />
             <asp:Label ID="Label7" runat="server" Text="تاريخ الولادة "></asp:Label>
            <asp:Label ID="lab_date_gra" runat="server" Text="Label"></asp:Label>
            <br /> 
            <asp:Label ID="Label8" runat="server" Text=" الاختصاص"></asp:Label>
            <asp:Label ID="lab_prof" runat="server" Text="Label"></asp:Label>
            <br />

            <asp:Button ID="btn_yes" runat="server" Text="قبول" OnClick="btn_yes_Click" />
             <asp:Button ID="btn_no" runat="server" Text="رفض" OnClick="btn_no_Click" />
            <br />

        </div>
    </form>
</body>
</html>
