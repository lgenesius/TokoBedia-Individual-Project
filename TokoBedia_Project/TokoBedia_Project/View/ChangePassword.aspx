<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="TokoBedia_Project.View.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 471px;
        }
    </style>
</head>
<body style="height: 472px">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:Label ID="Label1" runat="server" Text="Change Password Page" Font-Size ="30px"></asp:Label>
    
        <br />
        <asp:Button ID="btnGoProfile" runat="server" OnClick="btnGoProfile_Click" Text="Back" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Old Password : "></asp:Label>
        <asp:TextBox ID="TBOldPass" TextMode="Password" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="New Password : "></asp:Label>
        <asp:TextBox ID="TBNewPass" TextMode="Password" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Confirm Password : "></asp:Label>
        <asp:TextBox ID="TBConfPass" TextMode="Password" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnChangePass" runat="server" OnClick="btnChangePass_Click" Text="Submit" />
        <br />
        <br />
    
    <asp:Label ID="LblError" runat="server" ForeColor="Red" Text="[Error Message]"></asp:Label>
    
    </div>
    </form>
</body>
</html>
