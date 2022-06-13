<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerClientes.aspx.cs" Inherits="StarCapWeb.VerClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Clientes</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for ="nivelDdl"> Filtrar por Nivel: </label>
                        <asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="nivelDdl_SelectedIndexChanged" runat="server" ID="nivelDdl">
                            <asp:ListItem Value="1" Text="Silver"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Gold"></asp:ListItem>
                            <asp:ListItem Value="3" Text="Platinum"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
  
                    <asp:GridView CssClass="table table-hover table-bordered mt-5" 
                        OnRowCommand="grillaClientes_RowCommand"
                        EmptyDataText="No hay Clientes" ShowHeader="true"
                        AutoGenerateColumns="false" runat="server" ID="grillaClientes">
                       <Columns>
                           <asp:BoundField DataField="Rut" HeaderText="Rut Cliente" />
                           <asp:BoundField DataField="Nombre" HeaderText="Nombre del Cliente" />
                           <asp:BoundField DataField="NivelTxt" HeaderText="Nivel Rewards" />
                           <asp:BoundField DataField="BebidaFavorita.Nombre" HeaderText="Favorita" />
                           <asp:TemplateField>
                               <ItemTemplate>
                                   <asp:Button CommandName="eliminar" 
                                       CommandArgument='<%# Eval("Rut") %>'
                                       runat="server" 
                                       CssClass="btn btn-danger" Text="Eliminar" />
                               </ItemTemplate>
                           </asp:TemplateField>
                       </Columns>
                    </asp:GridView>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
