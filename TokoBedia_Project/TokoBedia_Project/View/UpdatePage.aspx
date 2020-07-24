<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePage.aspx.cs" Inherits="TokoBedia_Project.View.UpdatePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 685px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:Label ID="Label1" runat="server" Text="Update Page" Font-Size="30px"></asp:Label>
    
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Update Product Name : "></asp:Label>
        <asp:TextBox ID="TBProductName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TBProductName" ErrorMessage="Perlu Isi Product Name!"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Update Product Stock : "></asp:Label>
        <asp:TextBox ID="TBProductStock" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TBProductStock" ErrorMessage="Perlu isi Product Stock!"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Update Product Price : "></asp:Label>
        <asp:TextBox ID="TBProductPrice" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TBProductPrice" ErrorMessage="Perlu isi Product Price!"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
&nbsp;
    
    <asp:HyperLink ID="goBack" runat="server" ForeColor="Blue" TabIndex="5" Text="Back to View Product" NavigateUrl="~/View/ViewProduct.aspx"></asp:HyperLink>
        <br />
        <br />
        <asp:Label ID="LblErrorUpdate" runat="server" ForeColor="Red" Text="[Error Message]"></asp:Label></div>
    </form>
</body>
</html>
