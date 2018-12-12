<%@ Page Title="" Language="C#" MasterPageFile="~/PG/PG_Maestra/PG_maestra.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="sitio_web.PG.PG_No_Logeada.Registrarse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="content">
		<form runat="server">
			<div class="row">
				<div class="col">
					<input type="text" id="txtRut" name="txtRut" class="form-control" placeholder="Rut" runat="server" >
				</div>
				<div class="col">
					<input type="text" id="txtNombre" name="txtNombre" class="form-control" placeholder="Nombre" runat="server" >
				</div>
			</div>
			<div class="row">
				<div class="col">
					<input type="text" id="txtApPaterno" name="txtApPaterno" class="form-control" placeholder="Apellido paterno" runat="server" >
				</div>
				<div class="col">
					<input type="text" id="txtApMaterno" name="txtApMaterno" class="form-control" placeholder="Apellido materno" runat="server" >
				</div>
			</div>
			<div class="row">
				<div class="col">
					<input type="text" id="txtCorreo" name="txtCorreo" class="form-control" placeholder="Correo" runat="server" >
				</div>
				<div class="col">
					<input type="text" id="txtTelefono" name="txtTelefono" class="form-control" placeholder="Telefono" runat="server" >
				</div>
			</div>
			<div class="row">
				<div class="col">
					<input type="text" id="txtClave" name="txtClave" class="form-control" placeholder="Correo" runat="server" >
				</div>
				<div class="col">
					<input type="text" id="txtClave2" name="txtClave2" class="form-control" placeholder="Telefono" runat="server" >
				</div>
			</div>
			<asp:Button class="btn btn-primary" style="margin-bottom: 0" ID="Button1" Text="Agregar" OnClick="BtnAgregar" runat="server"  />

		</form>

	</div>




</asp:Content>

