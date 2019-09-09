<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/NominasMP.Master" AutoEventWireup="true" CodeBehind="Nominas.aspx.cs" Inherits="Nomina2018.GUI.Nominas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-left row">
        <div class="border pt-3 mt-1 col-md-12 text-right">
            <asp:HiddenField runat="server" ID="txtEmpleadoEmpresaID" />
            <div class="col-md-12 m-0">
                <div class="form-row text-left">
                    <div class="col-md-4 mb-3">
                        <label>Fecha Pago:</label>
                        <asp:TextBox ID="txtFechaPago" runat="server" type="date" CssClass="form-control" required="required"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="card card-group text-right">
                <%-- Datos empleado --%>
                <div class="card card-columns col-md-12 p-3">
                    <div class="form-row">
                        <div class="col-md-12 mb-3">
                            <div class="input-group">
                                <label class="sr-only" for="txtBuscar">Nombre</label>
                                <input runat="server" id="txtBuscar" class="form-control form-control-sm" placeholder="Nombre Empleado" />
                                <button runat="server" type="button" class="btn btn-primary btn-sm input-group-prepend" onserverclick="BuscarEmpleado_OnClick">
                                    <i class="fa fa-search"></i>
                                </button>
                            </div>
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="col-md-12 mb-3">
                            <asp:TextBox ID="txtNombreEmpleado" runat="server" class="form-control form-control-sm" placeholder="Nombre(s)" ReadOnly="true"></asp:TextBox>
                        </div>
                        <div class="col-md-6 mb-3">
                            <asp:TextBox ID="txtApellidoPaterno" runat="server" class="form-control form-control-sm" placeholder="A. Paterno" ReadOnly="true"></asp:TextBox>
                        </div>
                        <div class="col-md-6 mb-3">
                            <asp:TextBox ID="txtApellidoMaterno" runat="server" class="form-control form-control-sm" placeholder="A. Materno" ReadOnly="true"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-row">
                        <div class="col-md-6 mb-3">
                            <asp:TextBox ID="txtDepartamento" runat="server" class="form-control form-control-sm" placeholder="Departamento" ReadOnly="true"></asp:TextBox>
                        </div>
                        <div class="col-md-6 mb-3">
                            <asp:TextBox ID="txtPuesto" runat="server" class="form-control form-control-sm" placeholder="Puesto" ReadOnly="true"></asp:TextBox>
                        </div>
                        <div class="col-md-6 mb-3">
                            <asp:TextBox ID="txtSalario" runat="server" class="form-control form-control-sm" placeholder="Sueldo" ReadOnly="true"></asp:TextBox>
                        </div>
                        <div class="col-md-6 mb-3">
                            <asp:TextBox ID="txtDiasTrj" runat="server" class="form-control form-control-sm" placeholder="Días Trabajados"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <%-- Percepciones --%>
                <div class="card card-columns col-md-12 p-3">
                    <div class="form-group row text-left">
                        <label class="col-6 col-form-label">Sueldo Diario:</label>
                        <div class="col-6">
                            <asp:TextBox ID="txtSueldoDiario" runat="server" class="form-control form-control-sm"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row text-left">
                        <label class="col-6 col-form-label">Sueldo Quincenal:</label>
                        <div class="col-6">
                            <asp:TextBox ID="txtSueldoQuincenal" runat="server" class="form-control form-control-sm"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row text-left">
                        <label class="col-6 col-form-label">Bono Asistencia:</label>
                        <div class="col-6">
                            <asp:TextBox ID="txtBonoAsistencia" runat="server" class="form-control form-control-sm"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row text-left">
                        <label class="col-6 col-form-label">Bono Puntualidad:</label>
                        <div class="col-6">
                            <asp:TextBox ID="txtBonoPuntualidad" runat="server" class="form-control form-control-sm"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row text-left">
                        <label class="col-6 col-form-label">Despensa:</label>
                        <div class="col-6">
                            <asp:TextBox ID="txtDespensa" runat="server" class="form-control form-control-sm"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row text-left">
                        <label class="col-6 col-form-label">Total Percepciones:</label>
                        <div class="col-6">
                            <asp:TextBox ID="txtTotalPercepciones" runat="server" class="form-control form-control-sm"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <%-- Deducciones --%>
                <div class="card card-columns col-md-12 p-3">
                    <div class="form-group row text-left">
                        <label class="col-6 col-form-label">Seguro Social:</label>
                        <div class="col-6">
                            <asp:TextBox ID="txtIMSS" runat="server" class="form-control form-control-sm"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row text-left">
                        <label class="col-6 col-form-label">Impuesto Sobre Renta:</label>
                        <div class="col-6">
                            <asp:TextBox ID="txtISR" runat="server" class="form-control form-control-sm"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row text-left">
                        <label class="col-6 col-form-label">Prestamo Crediticio:</label>
                        <div class="col-6">
                            <asp:TextBox ID="txtPrestamoCrd" runat="server" class="form-control form-control-sm"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row text-left">
                        <label class="col-6 col-form-label">INFONAVIT:</label>
                        <div class="col-6">
                            <asp:TextBox ID="txtCreditoInfonavit" runat="server" class="form-control form-control-sm"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row text-left">
                        <label class="col-6 col-form-label">Total Deducciones:</label>
                        <div class="col-6">
                            <asp:TextBox ID="txtTotalDeducciones" runat="server" class="form-control form-control-sm"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-12 mt-3 mb-3">
                <a class="btn btn-sm btn-secondary ml-1" href="Nominas.aspx">Cancelar</a>
                <button runat="server" type="button" class="btn btn-sm btn-success mr-1" onserverclick="btnGuardarNomina_OnClick"><i class="fa fa-save"></i> Guardar</button>
            </div>
        </div>

        <div class="card card-body col-12">
            <div class="form-row">
                <div class="col-md-3 mb-3">
                    <div class="input-group">
                        <input runat="server" id="txtBuscarD" class="form-control form-control-sm" placeholder="Buscar" />
                        <button runat="server" type="button" class="btn btn-primary btn-sm input-group-prepend" onserverclick="txtBuscarD_OnClick">
                            <i class="fa fa-search"></i>
                        </button>
                    </div>
                </div>
            </div>

            <asp:GridView runat="server" ID="gvNominas" CellPadding="4" CssClass="table table-striped table-bordered table-hover table-sm responsive-table" GridLines="None"
                DataKeyNames="nominasID" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" ShowHeader="true">
                <Columns>
                    <asp:BoundField DataField="fechapago" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Fecha Pago" />
                    <asp:BoundField DataField="nombreempleado" HeaderText="Nombre" />
                    <asp:BoundField DataField="apellidopaterno" HeaderText="A. Paterno" />
                    <asp:BoundField DataField="nombredepartamento" HeaderText="Departamento" />
                    <asp:BoundField DataField="nombrepuesto" HeaderText="Puesto" />
                    <asp:BoundField DataField="sueldo" DataFormatString="{0:C2}" HeaderText="Sueldo" />
                    <asp:BoundField DataField="sueldodiario" DataFormatString="{0:C2}" HeaderText="S. Diario" />
                    <asp:BoundField DataField="sueldoquincenal" DataFormatString="{0:C2}" HeaderText="S. Quincenal" />
                    <asp:BoundField DataField="totalpercepcion" DataFormatString="{0:C2}" HeaderText="T. Percepcion" />
                    <asp:BoundField DataField="totaldeduccion" DataFormatString="{0:C2}" HeaderText="T. Deduccion" />
                    <asp:BoundField DataField="totalsueldo" DataFormatString="{0:C2}" HeaderText="T. Sueldo" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
