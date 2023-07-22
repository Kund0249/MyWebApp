<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepartmentPage.aspx.cs" Inherits="MyWebApp.PresentationLayer.DepartmentPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <label>Department Name</label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtDepartmentName"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button runat="server" ID="btnSubmit" Text="Save" 
                            OnClick="btnSubmit_Click"/> 
                    </td>
                    <td>
                        <asp:Button runat="server" ID="btnReset" Text="Clear" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
