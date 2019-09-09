<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/NominasMP.Master" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="Nomina2018.GUI.Empleados" ValidateRequest="true" EnableEventValidation="true" %>

<asp:Content ID="Content_Empleados" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-left row">
        <div class="card card-header col-md-12 text-right">
            <a class="btn btn-success btn-sm col-1" href="AgregarEmpleado.aspx">Añadir</a>
        </div>
        <div class="card card-body col-12">
            <div class="form-row">
                <div class="col-md-3 mb-3">
                    <div class="input-group">
                        <input runat="server" id="txtBuscar" class="form-control form-control-sm" placeholder="Buscar"/>
                        <button runat="server" type="button" class="btn btn-primary btn-sm input-group-prepend" onserverclick="txtDepartamento_OnTextChanged">
                            <i class="fa fa-search"></i>
                        </button>
                    </div>
                </div>
            </div>

            <asp:GridView ID="gvEmpleados" HorizontalAlign="Justify" runat="server" class="table table-responsive-md table-striped table-bordered table-hover table-sm" AutoGenerateColumns="false" Width="505px" GridLines="None" DataKeyNames="empleadoID" OnRowCommand="gvEmpleados_OnRowCommand" OnSelectedIndexChanged="gvEmpleados_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" />
                <Columns>

                    <asp:ButtonField ButtonType="Image" ImageUrl="~/Content/icons/pencil (6).png" ControlStyle-Height="32" ControlStyle-Width="32" Text="Editar" CommandName="Editar" CausesValidation="false" />
                    <asp:ButtonField ButtonType="Image" ImageUrl="~/Content/icons/garbage (6).png" ControlStyle-Height="32" ControlStyle-Width="32" Text="Eliminar" CommandName="Eliminar" CausesValidation="false" />

                    <asp:BoundField DataField="Numeroempleado" HeaderText="DNI"></asp:BoundField>
                    <asp:BoundField DataField="Nombreempleado" HeaderText="Nombre"></asp:BoundField>
                    <asp:BoundField DataField="Apellidopaterno" HeaderText="Ap. Pat."></asp:BoundField>
                    <asp:BoundField DataField="Apellidomaterno" HeaderText="Ap. Mat."></asp:BoundField>
                    <asp:BoundField DataField="Nombredepartamento" HeaderText="Dep."></asp:BoundField>
                    <asp:BoundField DataField="Nombrepuesto" HeaderText="Puesto"></asp:BoundField>
                    <asp:BoundField DataField="Sueldo" HeaderText="Sueldo"></asp:BoundField>
                    <asp:BoundField DataField="Fechaingreso" HeaderText="Entrada"></asp:BoundField>
                    <asp:BoundField DataField="Antiguedad" HeaderText="Ant."></asp:BoundField>
                    <asp:BoundField DataField="Nss" HeaderText="NSS"></asp:BoundField>
                    <asp:BoundField DataField="Rfc" HeaderText="RFC"></asp:BoundField>

                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
