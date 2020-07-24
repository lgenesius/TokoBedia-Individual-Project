<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProductType.aspx.cs" Inherits="TokoBedia_Project.View.ViewProductType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 496px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:Label ID="Label1" runat="server" Text="View Product Type" Font-Size="30px"></asp:Label>
    
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back to Home" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
&nbsp;<asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Pilih Nama Product Type yang mau di Delete : "></asp:Label>
        <asp:TextBox ID="TBDelete" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete" />
        <br />
        <br />
    
    <asp:Label ID="LblError" runat="server" ForeColor="Red" Text="[Error Message]"></asp:Label></div>
    </form>
</body>
</html>
