<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="TokoBedia_Project.View.ViewProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 470px;
        }
    </style>
</head>
<body style="height: 466px">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:Label ID="Label1" runat="server" Text="TokoBedia's Product" Font-Size="30px"></asp:Label>
    
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back to Home" />
&nbsp;
    
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    
        <br />
        <asp:Button ID="btnGoInsert" runat="server" OnClick="btnGoInsert_Click" Text="Insert" />
&nbsp;<asp:Button ID="btnGoUpdate" runat="server" OnClick="btnGoUpdate_Click" Text="Update" />
&nbsp;<br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Pilih Nama Product yang ingin di Delete : "></asp:Label>
        <asp:TextBox ID="TBDeleteProduct" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnGoDelete" runat="server" Text="Delete" OnClick="btnGoDelete_Click" />
        <br />
        <br />
    
    <asp:Label ID="LblErrorDelete" runat="server" ForeColor="Red" Text="[Error Message]"></asp:Label></div>
    </form>
    <p>
&nbsp;</p>
</body>
</html>
