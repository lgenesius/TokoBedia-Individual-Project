<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="TokoBedia_Project.View.UpdateProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 486px;
        }
    </style>
</head>
<body style="height: 490px">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:Label ID="Label1" runat="server" Text="Update Profile Page" Font-Size ="30px"></asp:Label>
    
        <br />
        <br />
        Update Your Email : <asp:TextBox ID="TBEmail" runat="server" OnTextChanged="btnUpdate_Click"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TBEmail" ErrorMessage="Isi Emailnya!"></asp:RequiredFieldValidator>
        <br />
        Update Your Name :
        <asp:TextBox ID="TBName" runat="server" OnTextChanged="btnUpdate_Click"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TBName" ErrorMessage="Isi Namanya!"></asp:RequiredFieldValidator>
        <br />
        Update Your Gender : <asp:DropDownList ID="TBGender" runat="server" OnTextChanged="btnUpdate_Click">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
&nbsp;
        <asp:HyperLink ID="goBack" runat="server" ForeColor="Blue" NavigateUrl="~/View/Profile.aspx" TabIndex="5" Text="Back to Profile"></asp:HyperLink>
        <br />
        <br />
    
    <asp:Label ID="LblError" runat="server" ForeColor="Red" Text="[Error Message]"></asp:Label>
    
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
