<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="WebForm1.aspx.cs" Inherits="FebWeb.WebForms.WebForm1" Async="True" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Form</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <script type="text/javascript" src="../scripts/jquery-1.9.1.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="text-center">
    <h1>Working with Data Scraping</h1>
        <div>
            <p>
                This page work with the data scraping with the C# using the HtmlAgilityPack nuget packet.<br />
                
            </p>
        </div>
    </div>
        <asp:GridView ID="GridView1" cssClass="active center-block table table-hover" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
