<%@ Page Title="" Language="C#" MasterPageFile="~/PG/PG_Maestra/PG_maestra.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="sitio_web.PG.PG_No_Logeada.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container">
	<form runat="server">
		<div class="form-group">
			<label for="exampleInputEmail1">Email</label>
			<input type="email" class="form-control" name="txtRut" id="txtRut" aria-describedby="emailHelp" placeholder="Rut" runat="server">
			<small id="emailHelp" class="form-text text-muted">prueba de login </small>
		</div>
		<div class="form-group">
			<label for="exampleInputPassword1">Clave</label>
			<input type="password" class="form-control" name="txtClave" id="txtClave" placeholder="Clave" runat="server" >
		</div>		
		<asp:Button type="submit" class="btn submit-btn" name="btnLogin_1" ID="btnLogin" Text="Login"  OnClick="btnLogin_" runat="server"/>
	</form>
	</div>


</asp:Content>
