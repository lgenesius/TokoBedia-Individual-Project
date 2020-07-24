<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="TokoBedia_Project.View.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 477px;
        }
    </style>
</head>
<body style="height: 475px">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:Label ID="Label1" runat="server" Text="Your Profile" Font-Size="30px"></asp:Label>
    
        <br />
        <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Button ID="btnUpdateProfile" runat="server" OnClick="btnUpdateProfile_Click" Text="Update Profile" />
        <br />
        <br />
        <asp:Button ID="btnChangePass" runat="server" OnClick="btnChangePass_Click" Text="Change Password" />
    
    </div>
    </form>
</body>
</html>
