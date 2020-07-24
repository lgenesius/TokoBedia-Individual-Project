<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertPage.aspx.cs" Inherits="TokoBedia_Project.View.InsertPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 674px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:Label ID="Label1" runat="server" Text="INSERT PAGE" Font-Size="30px"></asp:Label>
    
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Product Name : "></asp:Label>
        <asp:TextBox ID="TBProductName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TBProductName" ErrorMessage="Isi Nama Product!"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Product Stock : "></asp:Label>
        <asp:TextBox ID="TBProductStock" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TBProductStock" ErrorMessage="Isi Stock Product!"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Product Price : "></asp:Label>
        <asp:TextBox ID="TBProductPrice" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TBProductPrice" ErrorMessage="Isi Harga Product!"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Product Type Id : "></asp:Label>
        <asp:TextBox ID="TBProductTypeId" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TBProductTypeId" ErrorMessage="Isi Id Tipe Produk!"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Pilih nomor Type Id yang sesuai dari tabel berikut!"></asp:Label>
&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="goBack" runat="server" ForeColor="Blue" TabIndex="5" Text="Back to View Product" NavigateUrl="~/View/ViewProduct.aspx"></asp:HyperLink>
        <br />
        <br />
    
    <asp:Label ID="LblErrorInsert" runat="server" ForeColor="Red" Text="[Error Message]"></asp:Label></div>
    </form>
</body>
</html>
