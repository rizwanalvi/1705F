<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebHRM.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
         <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Text="ROLE"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Admin</asp:ListItem>
            <asp:ListItem>Guest</asp:ListItem>
            <asp:ListItem>Emp</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="Add Data" OnClick="Button1_Click" />
    <div>


    </div>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        
    </div>
    </form>
</body>
</html>
