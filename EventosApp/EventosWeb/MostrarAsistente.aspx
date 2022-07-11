<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MostrarAsistente.aspx.cs" Inherits="EventosWeb.MostrarAsistente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <asp:DropDownList ID="estadoDDL" runat="server" AutoPostBack="true" OnSelectedIndexChanged="estadoDDL_SelectedIndexChanged">
                <asp:ListItem Text="Pagada" Value="Pagada"></asp:ListItem>
                <asp:ListItem Text="Con Deuda" Value="conDeuda"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="row mt-5">
            <asp:GridView 
                CssClass="table table-hover table-bordered"
                ID="grillaAsistente"
                AutoGenerateColumns="false"
                ShowHeaderWhenEmpty="true"
                EmptyDataText="No hay registros"
                runat="server">
                <Columns>
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                    <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                    <asp:BoundField HeaderText="Empresa" DataField="Empresa" />
                    <asp:BoundField HeaderText="Region" DataField="Region" />
                    <asp:BoundField HeaderText="Estado" DataField="Estado" />

                </Columns>
            </asp:GridView>
        </div>

    </div>
</asp:Content>
