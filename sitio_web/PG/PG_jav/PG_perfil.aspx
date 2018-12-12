<%@ Page Title="" Language="C#" MasterPageFile="~/PG/PG_logeadas/PG_Maestra_Login/PG_maestra_login.Master" AutoEventWireup="true" CodeBehind="PG_perfil.aspx.cs" Inherits="sitio_web.PG.PG_logeadas.PG_perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<div class="container-fluid">
		 <div class="row">
  		<div class="col-sm-10"><h1>User name</h1></div>
    	<div class="col-sm-2"><a href="/users" class="pull-right"><img title="profile image" class="img-circle img-responsive" src=""></a></div>
    </div>
	<div class="row">
	  		<div class="col-sm-3"><!--left col-->
              

      <div class="text-center">
        <img src="" class="avatar img-circle img-thumbnail" alt="avatar">
        <h6>Upload a  photo...</h6>
        <input type="file" class="text-center center-block file-upload">
      </div></hr><br>

               
          <div class="panel panel-default">
            <div class="panel-heading">Website <i class="fa fa-link fa-1x"></i></div>
            <div class="panel-body"><a href="http://bootnipets.com">bootnipets.com</a></div>
          </div>
          
          
          <ul class="list-group">
            <li class="list-group-item text-muted">Activity <i class="fa fa-dashboard fa-1x"></i></li>
            <li class="list-group-item text-right"><span class="pull-left"><strong>Shares</strong></span> 125</li>
            <li class="list-group-item text-right"><span class="pull-left"><strong>Likes</strong></span> 13</li>
            <li class="list-group-item text-right"><span class="pull-left"><strong>Posts</strong></span> 37</li>
            <li class="list-group-item text-right"><span class="pull-left"><strong>Followers</strong></span> 78</li>
          </ul> 
               
          <div class="panel panel-default">
            <div class="panel-heading">Social Media</div>
            <div class="panel-body">
            	<i class="fa fa-facebook fa-2x"></i> <i class="fa fa-github fa-2x"></i> <i class="fa fa-twitter fa-2x"></i> <i class="fa fa-pinterest fa-2x"></i> <i class="fa fa-google-plus fa-2x"></i>
            </div>
          </div>
          
        </div><!--/col-3-->
	

	<div class="col-sm-9">
  <form>
  <div class="form-row">
    <div class="form-group col-md-6">
      <label for="inputEmail4">Email</label>
      <input type="email" class="form-control" name="txtRut" id="txtRut">
    </div>
    <div class="form-group col-md-6">
      <label for="inputPassword4">Password</label>
      <input type="password" class="form-control"  name="txtNonbre" id="txtNombre">
    </div>
  </div>
  <div class="form-group">
    <label for="inputAddress">Address</label>
    <input type="text" class="form-control" name="txtApP" id="txtApP" >
  </div>
  <div class="form-group">
    <label for="inputAddress2">Address 2</label>
    <input type="text" class="form-control" name="txtApM" id="txtApM">
  </div>  
 <div class="form-group">
    <label for="inputAddress3">Address 2</label>
    <input type="text" class="form-control" name="txtCorreo" id="txtCorreo">
  </div>  
<div class="form-group">
    <label for="inputAddress3">Address 2</label>
    <input type="text" class="form-control" name="txtTelefono" id="txtTelefono">
  </div> 
  
  <button type="submit" class="btn btn-primary">Guardar</button>
</form>
</div>
	</div>

</div>
</asp:Content>
