<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerPunto.aspx.cs" Inherits="MedidoresWeb.VerPunto" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <span>Cargando...</span>
                </ProgressTemplate>
            </asp:UpdateProgress>
            <div class="mt-5">
                <div>
                    <asp:DropDownList ID="tipoDdl" runat="server"
                        AutoPostBack="true"
                        Enabled="false"
                        OnSelectedIndexChanged="tipoDdl_SelectedIndexChanged">
                        <asp:ListItem Value="1" Text="Eléctrico"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Dual"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:CheckBox ID="todosChx" runat="server" Checked="true"
                        AutoPostBack="true" OnCheckedChanged="todosChx_CheckedChanged" Text="Ver Todos" />

                </div>

                <asp:GridView ID="puntosGrid" runat="server"
                    AutoGenerateColumns="false" CssClass="table table-hover text-center" OnRowCommand="puntosGrid_RowCommand"
                    EmptyDataText="No hay estaciones en el sistema">
                    <Columns>
                        <asp:BoundField HeaderText="Id Punto" DataField="Id" />
                        <asp:BoundField HeaderText="Tipo" DataField="TipoTxt" />
                        <asp:BoundField HeaderText="Capacidad Máxima" DataField="CapacidadMaxima" />
                        <asp:BoundField HeaderText="Fecha Vencimiento" DataField="FechaVencimiento" />
                        <asp:TemplateField HeaderText="Acciones">
                            <ItemTemplate>
                                <asp:Button ID="Button1" runat="server" Text="Eliminar" CssClass="btn btn-danger"
                                    CommandName="eliminar"
                                    CommandArgument='<%# Eval("Id")%>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
