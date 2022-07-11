<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AgregarAsistente.aspx.cs" Inherits="EventosWeb.AgregarAsistente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6">
            <div class="card">
                <div class="card-header bg-black text-white">
                    <h3>Agregar Asistente</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="rutTxt">Rut</label>
                        <asp:TextBox ID="rutTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="rutTxt" CssClass="text-danger" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Debe ingresar el Rut"></asp:RequiredFieldValidator>

                    </div>
                    <div class="form-group">
                        <label for="nombreTxt">Nombre</label>
                        <asp:TextBox ID="nombreTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="apellidoTxt">Apellido</label>
                        <asp:TextBox ID="apellidoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="edadTxt">Edad</label>
                        <asp:TextBox ID="edadTxt" TextMode="Number" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RangeValidator ControlToValidate="edadTxt" CssClass="text-danger"  ID="RangeValidator1" runat="server" Type="Integer" ErrorMessage="Debe ingresar una edad mayor a 18" MinimumValue="18" MaximumValue="99"></asp:RangeValidator>
                    </div>
                    <div class="form-group">
                        <label for="empresaTxt">Empresa</label>
                         <asp:TextBox ID="empresaTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="estadoRbl">Estado</label>
                        <asp:RadioButtonList ID="estadoRbl" runat="server">
                            <asp:ListItem Text="Pagada" Selected="True" Value="Pagada"></asp:ListItem>
                            <asp:ListItem Text="Con Deuda" Value="conDeuda"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div class="form_group">
                        <label for="regionDDL">Region</label>
                        <asp:DropDownList ID="regionDDL" runat="server"></asp:DropDownList>
                    </div>
                    <asp:Button runat="server" CssClass="btn btn-secondary" OnClick="ingresarBtn_Click" ID="ingresarBtn" Text="Ingresar" />
                    
                </div>
            </div>
        </div>
    </div>
</asp:Content>
