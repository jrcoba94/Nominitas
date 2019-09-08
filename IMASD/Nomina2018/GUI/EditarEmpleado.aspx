<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/NominasMP.Master" AutoEventWireup="true" CodeBehind="EditarEmpleado.aspx.cs" Inherits="Nomina2018.GUI.EditarEmpleado" ValidateRequest="true" EnableEventValidation="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card card-header">
        <h5 class="modal-title">Editar Empleado</h5>
    </div>
    <div class="card card-body text-left">
        <div class="form-row">
            <asp:HiddenField ID="txtEmpleadoID" runat="server"/>
            <asp:HiddenField ID="txtEmpleadoEmpresaID" runat="server"/>
            <asp:HiddenField ID="txtFecha" runat="server"/>

            <div class="col-md-4 mb-3">
                <label for="txtNombre">Nombre(s):</label>
                <asp:TextBox ID="txtNombre" runat="server" class="form-control" required="required"></asp:TextBox>
            </div>
            <div class="col-md-4 mb-3">
                <label for="txtApellidoPaterno">Apellido Paterno:</label>
                <asp:TextBox ID="txtApellidoPaterno" runat="server" class="form-control" required="required"></asp:TextBox>
            </div>
            <div class="col-md-4 mb-3">
                <label for="txtApellidoMaterno">Apellido Materno:</label>
                <asp:TextBox ID="txtApellidoMaterno" runat="server" class="form-control" required="required"></asp:TextBox>
            </div>
        </div>
        <div class="form-row">
            <div class="col-md-4 mb-3">
                <label for="txtCorreoelectronico">Correo Electrónico:</label>
                <asp:TextBox ID="txtCorreoElectronico" type="email" runat="server" class="form-control" TextMode="Email" required="required"></asp:TextBox>
            </div>
            <div class="col-md-4 mb-3">
                <label for="txtFechaNacimiento">Fecha Nacimiento:</label>
                <asp:TextBox ID="txtFechaNacimiento" type="date" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="col-md-4 mb-3">
                <label for="txtTelefono1">Teléfono:</label>
                <asp:TextBox ID="txtTelefono1" runat="server" class="form-control" TextMode="Phone" required="required"></asp:TextBox>
            </div>
        </div>
        <div class="form-row">
            <div class="col-md-6 mb-3">
                <label for="txtDireccion">Dirección:</label>
                <asp:TextBox ID="txtDireccion" runat="server" class="form-control" required="required"></asp:TextBox>
            </div>
            <div class="col-md-3 mb-3">
                <label for="txtEstado">Estado:</label>
                <asp:TextBox ID="txtEstado" runat="server" class="form-control" required="required"></asp:TextBox>
            </div>
            <div class="col-md-3 mb-3">
                <label for="txtCiudad">Ciudad:</label>
                <asp:TextBox ID="txtCiudad" runat="server" class="form-control" required="required"></asp:TextBox>
            </div>
            <div class="col-md-4 mb-3">
                <label for="txtCurp">CURP:</label>
                <asp:TextBox ID="txtCurp" runat="server" class="form-control" required="required"></asp:TextBox>
            </div>
        </div>

        <div class="form-row border-top pt-3">
            <div class="col-md-3 mb-3">
                <label for="txtNoEmpleado">Numero Empleado:</label>
                <asp:TextBox ID="txtNoEmpleado" runat="server" class="form-control" required="required"></asp:TextBox>
            </div>
            <div class="col-md-3 mb-3">
                <label for="dpEmpresa">Empresa:</label>
                <asp:DropDownList ID="dpEmpresa" runat="server" class="form-control" required="required" DataValueField="empresaID" DataTextField="nombreempresa" AppendDataBoundItems="True">
                    <asp:ListItem Selected="false" Value="0" Text="-- Seleccione --"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-md-3 mb-3">
                <label for="dpDepartamento">Departamento:</label>
                <asp:DropDownList ID="dpDepartamento" runat="server" class="form-control" required="required" DataValueField="departamentoID" DataTextField="nombredepartamento" AppendDataBoundItems="True">
                    <asp:ListItem Selected="false" Value="0" Text="-- Seleccione --"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-md-3 mb-3">
                <label for="dpPuesto">Puesto:</label>
                <asp:DropDownList ID="dpPuesto" runat="server" class="form-control" required="required" DataValueField="puestoID" DataTextField="nombrepuesto" AppendDataBoundItems="True">
                    <asp:ListItem Selected="false" Value="0" Text="-- Seleccione --"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-md-3 mb-3">
                <label for="txtAntiguedad">Antiguedad:</label>
                <asp:TextBox ID="txtAntiguedad" runat="server" class="form-control" required="required"></asp:TextBox>
            </div>
            <div class="col-md-3 mb-3">
                <label for="txtNoSS">NSS:</label>
                <asp:TextBox ID="txtNoSS" runat="server" class="form-control" required="required"></asp:TextBox>
            </div>
            <div class="col-md-3 mb-3">
                <label for="txtRFC">RFC:</label>
                <asp:TextBox ID="txtRFC" runat="server" class="form-control" required="required"></asp:TextBox>
            </div>
        </div>
    </div>
    <div class="card card-footer">
        <div class="col-12 text-right">
            <a id="r" class="btn btn-secondary btn-sm m-2" href="Empleados.aspx">Cancelar</a>
            <asp:Button runat="server" class="btn btn-primary btn-sm m-2" Text="Guardar" OnClick="btnGuardarEmpleado_Click"/>
        </div>
    </div>
</asp:Content>