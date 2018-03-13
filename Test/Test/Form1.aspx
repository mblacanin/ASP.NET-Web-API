<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form1.aspx.cs" Inherits="Test.Form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 648px">
    <form id="form1" runat="server">
        <div>

        </div>
        Indeks<p>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        </p>
        <p>
            Upisan</p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <p>
            Ime</p>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <p>
            Mesto</p>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <p>
            Sifra smera</p>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <p style="height: 89px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Post" Width="55px" />
            &nbsp &nbsp
            <asp:Button ID="Button2" runat="server" Text="Put" OnClick="Button2_Click" Width="55px"/>
            &nbsp &nbsp
            <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
        </p>
        <p style="height: 89px">
            &nbsp;</p>
    </form>
</body>
</html>
