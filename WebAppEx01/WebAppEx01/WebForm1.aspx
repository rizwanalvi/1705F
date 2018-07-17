<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppEx01.WebForm1" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowEditing="OnRowEditing" Width="100%">
            <Columns>
                <asp:BoundField DataField="StdID" HeaderText="STUDENT ID" ReadOnly="true" />
                <asp:BoundField DataField="StdName" HeaderText="STUDENT NAME" />
                <asp:CheckBoxField DataField="IsAttended" HeaderText="Attendance" />
                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="OnUpdate">Update</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="OnCancel">Cancel</asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit">Edit</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
    </div>
    </form>
</body>
</html>
