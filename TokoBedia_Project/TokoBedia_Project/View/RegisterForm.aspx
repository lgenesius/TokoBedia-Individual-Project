<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterForm.aspx.cs" Inherits="TokoBedia_Project.View.RegisterForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 334px;
        }
    </style>
</head>
<body style="height: 385px">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:Label ID="Label1" runat="server" Text="Register Form"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Email : "></asp:Label>
        <asp:TextBox ID="registerEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="requiredRegisterEmail" runat="server" ControlToValidate="registerEmail" ErrorMessage="Email perlu diisi"></asp:RequiredFieldValidator>
        <br />
        Name :
        <asp:TextBox ID="registerName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="requiredRegisterName" runat="server" ControlToValidate="registerName" ErrorMessage="Nama perlu diisi"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Password : "></asp:Label>
        <asp:TextBox ID="registerPassword" type="Password" runat="server" Width="168px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="requiredRegisterPassword" runat="server" ControlToValidate="registerPassword" ErrorMessage="Password perlu diisi"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Confirm Password : "></asp:Label>
        <asp:TextBox ID="confirmPassword" type="Password" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="requiredConfirmPassword" runat="server" ControlToValidate="confirmPassword" ErrorMessage="Confirm Password jangan lupa"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Gender : "></asp:Label>
        <asp:DropDownList ID="DDLGender" runat="server">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:DropDownList>
    
        <asp:RequiredFieldValidator ID="requiredRegisterGender" runat="server" ControlToValidate="DDLGender" ErrorMessage="Gender perlu diisi"></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click"/>
&nbsp;&nbsp;
        <br />
        <asp:Label ID="LblError2" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="goBack" runat="server" ForeColor="Blue" TabIndex="5" Text="Go to Login" NavigateUrl="~/View/LoginForm.aspx"></asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
