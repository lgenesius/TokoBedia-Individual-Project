<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertTypePage.aspx.cs" Inherits="TokoBedia_Project.View.InsertTypePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 367px;
        }
    </style>
</head>
<body style="height: 369px">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:Label ID="Label1" runat="server" Text="Insert Product Type Page" Font-Size="30px"></asp:Label>
    
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Product Type Name : "></asp:Label>
        <asp:TextBox ID="TBProductTypeName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TBProductTypeName" ErrorMessage="Isi Product Name nya!"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Product Description : "></asp:Label>
        <asp:TextBox ID="TBProductDesc" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TBProductDesc" ErrorMessage="Isi Product Description nya!"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="goBack" runat="server" ForeColor="Blue" NavigateUrl="~/View/ViewProductType.aspx" TabIndex="5" Text="Back to View Product Type"></asp:HyperLink>
    
        <br />
        <br />
        <asp:Label ID="LblErrorInsert" runat="server" ForeColor="Red" Text="[Error Message]"></asp:Label>
    
    </div>
    </form>
</body>
</html>
