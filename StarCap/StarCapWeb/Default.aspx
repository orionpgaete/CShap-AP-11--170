<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StarCapWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
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
                            <asp:ListItem Text="Frapuccino" Value="FRAP-01"></asp:ListItem>
                            <asp:ListItem Text="Cafe del dia" Value="CAF-01"></asp:ListItem>
                            <asp:ListItem Text="Té del día" Value="TE-01"></asp:ListItem>
                            <asp:ListItem Text="Té Chai" Value="TE-02"></asp:ListItem>
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
                </div>
            </div>
        </div>
    </div>
</asp:Content>
