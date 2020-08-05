<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterCourse.aspx.cs" Inherits="Lab6.RegisterCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Course Resgitration</title>
    <link href="App_Themes/SiteStyles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 422px; width: 1457px">
            <h1>Algonquin College Course Resgitration</h1>
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow>
                    <asp:TableCell>Student Name:  <asp:TextBox ID="TextBox1" runat="server" CssClass="input"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem ID="full" runat="server">Full Time</asp:ListItem>
                            <asp:ListItem ID="part" runat="server">Part Time</asp:ListItem>
                            <asp:ListItem ID="coop" runat="server">Coop</asp:ListItem>
                        </asp:RadioButtonList>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <h3><asp:Panel ID="pnlAlert" runat="server" CssClass="error">You must enter a name!
            </asp:Panel></h3>
            <h3><asp:Panel ID="fulltimeAlert" runat="server" CssClass="error">Your selection excceeds the maximum weekly hours: 16.
            </asp:Panel></h3>
            <h3><asp:Panel ID="parttimeAlert" runat="server" CssClass="error">Your selection excceeds the maximum number of courses: 3.
            </asp:Panel></h3>
            <h3><asp:Panel ID="coopAlert1" runat="server" CssClass="error">Your selection excceeds the maximum number of courses: 2.
            </asp:Panel></h3>
            <h3><asp:Panel ID="coopAlert2" runat="server" CssClass="error">Your selection excceeds the maximum weekly hours: 4.
            </asp:Panel></h3>
            <h4><asp:label ID="txtchange" runat="server">Following courses are currently avalable for registation</asp:label></h4>
            <asp:CheckBoxList ID="courseList1" runat="server">
            </asp:CheckBoxList>
            <asp:Button ID="Button" runat="server" Text="Submit" CssClass="button" OnClick="Button_Click" />
            <asp:Table ID="table2" runat="server" CssClass="table" >
                <asp:TableRow>
                    <asp:TableHeaderCell>Course Code</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Course Title</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Weekly Hours</asp:TableHeaderCell>
                </asp:TableRow>
                
            </asp:Table>
        </div>
    </form>
</body>
</html>
