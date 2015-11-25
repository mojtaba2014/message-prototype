<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendMessage.aspx.cs" Inherits="Message_Prototype.SendMessage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Send Message</h1>
    <form id="form1" runat="server">
    <div>
        <textarea id="TextArea1" cols="20" name="S1" rows="2" runat ="server"></textarea>
    </div>
        <div>
            <asp:Button ID="btnSend" runat="server" Text="Send" />
        </div>
    </form>
</body>
</html>
