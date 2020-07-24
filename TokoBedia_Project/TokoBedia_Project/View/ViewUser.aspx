<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="TokoBedia_Project.View.ViewUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 465px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:Label ID="Label1" runat="server" Text="User's Role &amp; Status" Font-Size="30px"></asp:Label>
    
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Label ID="Label2" runat="server" Text="User's Email : "></asp:Label>
        <asp:TextBox ID="TBEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TBEmail" ErrorMessage="Isi Email dulu !"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label3" runat="server" Text="User's Role : "></asp:Label>
        <asp:TextBox ID="TBRole" runat="server"></asp:TextBox>
        &nbsp;<asp:Label ID="Label5" runat="server" Text="(1 = Admin, 2 = Member)"></asp:Label>
&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TBRole" ErrorMessage="Isi Role nya dulu !"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label4" runat="server" Text="User's Status : "></asp:Label>
        <asp:TextBox ID="TBStatus" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TBStatus" ErrorMessage="Isi Status dulu !"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
&nbsp;
        <asp:HyperLink ID="goBack" runat="server" ForeColor="Blue" NavigateUrl="~/View/Home2.aspx" TabIndex="5" Text="Back to Home"></asp:HyperLink>
        <br />
        <br />
    
    <asp:Label ID="LblError" runat="server" ForeColor="Red" Text="[Error Message]"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
