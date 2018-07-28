<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppGudiance.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" Height="17px" Width="155px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="UN_ID" HeaderText="ID" />
                <asp:BoundField DataField="UN_NAME" HeaderText="NAME" />
                <asp:BoundField DataField="PROG_NAME" HeaderText="PROGRAM" />
            </Columns>
        </asp:GridView>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <BR/>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="upload" />
        <br />
        <br />
    </form>
</body>
</html>
