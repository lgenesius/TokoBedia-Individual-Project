<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="TokoBedia_Project.View.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 245px">
    
        <asp:Label ID="Label1" runat="server" Text="Login Form"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Email : "></asp:Label>
        <asp:TextBox ID="TBEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="requiredEmail" runat="server" ControlToValidate="TBEmail" ErrorMessage="Email perlu diisi"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Password : "></asp:Label>
        &nbsp;<asp:TextBox ID="TBPassword" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="requiredPassword" runat="server" ControlToValidate="TBPassword" ErrorMessage="Password perlu diisi"></asp:RequiredFieldValidator>
        <br />
        Not registered ? Register
        <asp:HyperLink ID="LinkRegister" runat="server" ForeColor="Blue" NavigateUrl="~/View/RegisterForm.aspx" TabIndex="5">here</asp:HyperLink>
&nbsp;now!<br />
        <asp:CheckBox ID="CBRememberMe" runat="server" TabIndex="3" Text="Remember Me"/>
        <br />
        <br />
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
    
         &nbsp;&nbsp;&nbsp;
    
         <asp:HyperLink ID="HyperLinkBack" runat="server" ForeColor="Blue" NavigateUrl="~/View/Home1.aspx" TabIndex="5">Back as a Guest</asp:HyperLink>
    
        <br />
        <br />
        <asp:Label ID="LblError" runat="server" ForeColor="Red" Text="[Error Message]"></asp:Label>
    
    </div>
    </form>
</body>
</html>
