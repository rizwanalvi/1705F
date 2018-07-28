<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApprEVISION.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="INSERT" Width="120px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="SHOW" />
        <br />
        <asp:Image ID="Image1" runat="server" Height="138px" />
    
    </div>
    </form>
</body>
</html>
