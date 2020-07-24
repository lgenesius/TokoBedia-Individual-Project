<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProductForGuest.aspx.cs" Inherits="TokoBedia_Project.View.ViewProductForGuest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 463px;
        }
    </style>
</head>
<body style="height: 468px">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:Label ID="Label1" runat="server" Text="TokoBedia's Product" Font-Size="30px"></asp:Label>
    
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back to Home" />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
