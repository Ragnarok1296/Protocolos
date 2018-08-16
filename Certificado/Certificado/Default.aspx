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
    <link rel="stylesheet" href="~/Content/loginStyles.css" type="text/css" />

    <link href='https://fonts.googleapis.com/css?family=Open+Sans:400,300,300italic,400italic,600' rel='stylesheet' type='text/css' />
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    

</head>
<body >

    <div class="row">
        <form runat="server">

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
                        
                          
                            <div class="form-group row">
                                <label for="RazonSocial" class="col-sm-4 col-form-label">Razon social *</label>
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtbRazonSocial" runat="server" type="text" class="form-control" name="RazonSocial" placeholder="Nombre de la empresa" MaxLength="50" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="DireccionFiscal" class="col-sm-4 col-form-label">Direccion fiscal *</label>
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtbDireccionFiscal" runat="server" type="text" class="form-control" name="DireccionFiscal" placeholder="Direccion fiscal de la empresa" MaxLength="100" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="DireccionUbicacion" class="col-sm-4 col-form-label">Ubicacion fisica *</label>
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtbDireccionUbicacion" runat="server" type="text" class="form-control" name="DireccionUbicacion" placeholder="Direccion ubicacion de la empresa" MaxLength="100" TextMode="SingleLine" AutoCompleteType="Disabled"></asp:TextBox>
                                </div>
                            </div>

                            <div class="form-group row">
                                <asp:Button ID="btnInsertar" runat="server" Text="" class="btn btn-success" center-align="true" OnClick="btnInsertar_Click" />
                                <asp:Button ID="btnImprimirLlaves" runat="server" Text="" class="btn btn-success" center-align="true" OnClick="btnImprimir_Click" Visible="false"/>   
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </form>
    </div>

</body>
</html>