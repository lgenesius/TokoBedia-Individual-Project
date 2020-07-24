<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateTypePage.aspx.cs" Inherits="TokoBedia_Project.View.UpdateTypePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 443px;
        }
    </style>
</head>
<body style="height: 445px">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:Label ID="Label1" runat="server" Text="Update Product Type Page" Font-Size="30px"></asp:Label>
    
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Product Type Name : "></asp:Label>
        <asp:TextBox ID="TBProductTypeName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TBProductTypeName" ErrorMessage="Isi Product Type Name nya!"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Product Description : "></asp:Label>
        <asp:TextBox ID="TBProductDescription" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TBProductDescription" ErrorMessage="Isi Product Deskripsinya !"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="goBack" runat="server" ForeColor="Blue" NavigateUrl="~/View/ViewProductType.aspx" TabIndex="5" Text="Back to View Product Type Page"></asp:HyperLink>
    
        <br />
        <br />
        <asp:Label ID="LblErrorUpdate" runat="server" ForeColor="Red" Text="[Error Message]"></asp:Label>
    
    </div>
    </form>
</body>
</html>
