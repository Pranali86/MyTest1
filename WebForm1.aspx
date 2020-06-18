<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="crudmvc.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="https://www.tutorialsteacher.com/linq/why-linq" onclick="return confirm('Are sure wants to delete?');">abc</a>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button"  OnClick="Button1_Click"/>
        <asp:Button ID="Button2" runat="server" Text="Delegates" OnClick="Button2_Click" />
    </form>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script>

        $(document).ready(function () {
            debugger
            Confirm();
        });
        function Confirm() {
            debugger
            var confirm_value = document.createElement("INPUT");
            confirm_value.type = "hidden";
            confirm_value.name = "confirm_value";
            if (confirm("Do you want to save data?")) {
                debugger
                confirm_value.value = "Yes";
            } else {
                debugger
                confirm_value.value = "No";
            }
            document.forms[0].appendChild(confirm_value);
        }

    </script>
</body>
</html>
