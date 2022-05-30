<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StarCapWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Clientes</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="nombreTxt">Nombre: </label>
                        <asp:TextBox ID="nombreTxt" CssClass="form-control" runat="server"></asp:TextBox> 
                    </div>
                    <div class="form-group">
                        <label for="rutTxt"> Rut: </label>
                        <asp:TextBox ID="Rut" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="bebidaDAL">Bebida Favorita</label>
                        <asp:DropDownList runat="server" ID="bebidaDdl" CssClass="form-control">
                       
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="nivelRbl">Nivel</label>
                        <asp:RadioButtonList runat="server" ID="nivelRbl">
                            <asp:ListItem Selected="True" Value="1" Text="Silver"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Gold"></asp:ListItem>
                            <asp:ListItem Value="3" Text="Platinum"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" Text="Agregar" CssClass="btn btn-primary" OnClick="agregarBtn_Click"/>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
