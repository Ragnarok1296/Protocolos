<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Certificado._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Punto de Venta</title>

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>


    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <link rel="stylesheet" href="~/Content/StyleCert.css" type="text/css" />

    <link href='https://fonts.googleapis.com/css?family=Open+Sans:400,300,300italic,400italic,600' rel='stylesheet' type='text/css' />
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    

</head>
<body class="back">

    <div class="row">
        <form runat="server" class="login">

            <asp:ScriptManager runat="server">
                <Scripts>
                    <%--To learn more about bundling scripts in ScriptManager see https://go.microsoft.com/fwlink/?LinkID=301884 --%>
                    <%--Framework Scripts--%>
                    <asp:ScriptReference Name="MsAjaxBundle" />
                    <asp:ScriptReference Name="jquery" />
                    <asp:ScriptReference Name="bootstrap" />
                    <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                    <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                    <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                    <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                    <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                    <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                    <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                    <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                    <asp:ScriptReference Name="WebFormsBundle" />
                    <%--Site Scripts--%>
                </Scripts>
            </asp:ScriptManager>
     
            <div class="container">
                <h1>Datos</h1>
                <br />
                <div class="row">

                    <div class="form-group">
                        <div class="col-sm-5" style="background-color: white;">
                        
                            <br />

                            <div class="form-group row">
                                <label for="Nombre" class="col-sm-4 col-form-label">Nombre *</label>
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtbNombre" runat="server" type="text" class="form-control" name="Nombre" placeholder="Introduzca su(s) nombre(s)" MaxLength="50" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="Apellidos" class="col-sm-4 col-form-label">Apellidos *</label>
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtbApellidos" runat="server" type="text" class="form-control" name="Apellidos" placeholder="Introduzca sus apellidos" MaxLength="50" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="Telefono" class="col-sm-4 col-form-label">Telefono *</label>
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtbTelefono" runat="server" type="text" class="form-control" name="Telefono" placeholder="Numero de celular" MaxLength="10" TextMode="Phone" AutoCompleteType="Disabled"></asp:TextBox>
                                </div>
                            </div>

                            <br />
                            <center>
                                <div class="form-group row">
                                    <asp:Button ID="btnInsertar" runat="server" Text="Certificar" class="btn btn-success" center-align="true" OnClick="btnInsertar_Click" />
                                    <asp:Button ID="btnImprimirLlaves" runat="server" Text="Obtener llave" class="btn btn-primary" center-align="true" OnClick="btnImprimir_Click" Visible="false" />   
                                </div>
                            </center>
                        </div>
                    </div>
                </div>
            </div>
        </form>
    </div>

</body>
</html>