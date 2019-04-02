<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="practical10.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="lblA" runat="server" Text="A"></asp:Label>
&nbsp;
    <asp:TextBox ID="txba" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rd1" runat="server" ControlToValidate="txba" 
        ErrorMessage="enter the value of A" ForeColor="Red" 
        ToolTip="enter the value of B">*</asp:RequiredFieldValidator>
    <br />
    <br />
    <div>
    
        <asp:Label ID="lblB" runat="server" Text="B"></asp:Label>
&nbsp;
        <asp:TextBox ID="txbb" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rd2" runat="server" ControlToValidate="txbb" 
            ErrorMessage="enter the value of B" ForeColor="Red" 
            ToolTip="enter the value of B">*</asp:RequiredFieldValidator>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnp" runat="server" onclick="btnp_Click" Text="+" />
&nbsp;
        <asp:Button ID="btnm" runat="server" onclick="btnm_Click" Text="-" />
&nbsp;
        <asp:Button ID="btnd" runat="server" onclick="btnd_Click" Text="/" />
&nbsp;
        <asp:Button ID="btnmul" runat="server" onclick="btnmul_Click" Text="*" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblre" runat="server" Text="Result"></asp:Label>
    
    </div>
    </form>
</body>
</html>
