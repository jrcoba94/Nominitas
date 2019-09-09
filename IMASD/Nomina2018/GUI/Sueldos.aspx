<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/NominasMP.Master" AutoEventWireup="true" CodeBehind="Sueldos.aspx.cs" Inherits="Nomina2018.GUI.Sueldos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-left row">
        <div class="border pt-3 mt-1 col-md-12 text-right">
            <asp:HiddenField runat="server" ID="txtpuestoID" />

            <div class="text-left">
                <div class="col-md-12 p-3">
                    <div class="form-row">
                        <div class="col-md-4 mb-3">
                            <label>Nombre Puesto:</label>
                            <asp:TextBox ID="txtNombrePuesto" runat="server" class="form-control form-control-sm"></asp:TextBox>
                        </div>
                        <div class="col-md-2 mb-3">
                            <label>Nivel:</label>
                            <asp:TextBox ID="txtNivel" runat="server" class="form-control form-control-sm"></asp:TextBox>
                        </div>
                        <div class="col-md-2 mb-3">
                            <label>Sueldo:</label>
                            <asp:TextBox ID="txtSueldo" runat="server" class="form-control form-control-sm"></asp:TextBox>
                        </div>
                        <div class="col-md-4 mb-3 pt-4">
                            <a class="btn btn-sm btn-secondary mt-2" href="Sueldos.aspx">Cancelar</a>
                            <button runat="server" type="button" class="btn btn-sm btn-success mt-2" onserverclick="btnGuardarPuesto_OnClick"><i class="fa fa-save"></i>Guardar</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="card card-body col-12">
            <asp:GridView ID="gvPuestos" HorizontalAlign="Justify" runat="server" class="table table-responsive-md table-striped table-bordered table-hover table-sm" AutoGenerateColumns="false" Width="505px" GridLines="None" DataKeyNames="puestoID" OnRowCommand="gvPuestos_OnRowCommand">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:ButtonField ButtonType="Image" ImageUrl="~/Content/icons/pencil (6).png" ControlStyle-Height="32" ControlStyle-Width="32" Text="Editar" CommandName="Editar" CausesValidation="false" />
                    <asp:BoundField DataField="nombrepuesto" HeaderText="Puesto"></asp:BoundField>
                    <asp:BoundField DataField="nivel" HeaderText="Nivel"></asp:BoundField>
                    <asp:BoundField DataField="sueldo" DataFormatString="{0:C2}" HeaderText="Sueldo"></asp:BoundField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
