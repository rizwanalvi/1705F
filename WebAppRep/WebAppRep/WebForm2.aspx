<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebAppRep.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                 <table border="1" style="width:100%">
            <tr>
                 <th ></th>
                <th>NAME</th>
                <th>COUNTRY</th>
                <th>MODIFY</th>
            </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                     <td> 
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("CustomerId") %>' Visible="false"></asp:Label>
                    
                </td>
                <td> 
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("Name") %>' Visible="false"></asp:TextBox>
                </td>
                <td><asp:Label ID="Label2" runat="server" Text='<%# Eval("Country") %>'></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Eval("Country") %>' Visible="false"></asp:TextBox>
                    <asp:DropDownList ID="DropDownList1" runat="server" Visible="false">
                        <asp:ListItem>Pakistan</asp:ListItem>
                        <asp:ListItem>Russia</asp:ListItem>
                        <asp:ListItem>China</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="OnEditing">Edit</asp:LinkButton>
                     <asp:LinkButton ID="LinkButton2" runat="server" OnClick="OnDeleting">Delete</asp:LinkButton>
                     <asp:LinkButton ID="LinkButton3" runat="server" OnClick="OnCancel" Visible="false">Cancel</asp:LinkButton>
                     <asp:LinkButton ID="LinkButton4" runat="server" OnClick="OnUpdating"  Visible="false" >Update</asp:LinkButton>
                </td>
            </tr>
            </ItemTemplate>
            <FooterTemplate>
                 </table>
            </FooterTemplate>
        </asp:Repeater>


<!-- 
        <table border="1" style="width:100%">
            <tr>
                <th>NAME</th>
                <th>COUNTRY</th>
                <th>MODIFY</th>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
                <td><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
                <td>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="OnEditing">Edit</asp:LinkButton>
                     <asp:LinkButton ID="LinkButton2" runat="server" OnClick="OnDeleting">Delete</asp:LinkButton>
                     <asp:LinkButton ID="LinkButton3" runat="server" OnClick="OnCancel" Visible="false">Cancel</asp:LinkButton>
                     <asp:LinkButton ID="LinkButton4" runat="server" OnClick="OnUpdating"  Visible="false" >Update</asp:LinkButton>
                </td>
            </tr>
        </table>
    -->
    </div>
    </form>
</body>
</html>
