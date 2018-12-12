<%@ Page Title="" Language="C#" MasterPageFile="~/PG/PG_logeadas/PG_Maestra_Login/PG_maestra_login.Master" AutoEventWireup="true" CodeBehind="PG_color.aspx.cs" Inherits="sitio_web.PG.PG_sot.PG_color" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	  <form id="form1" runat="server">
      <div>
        <div class="row">
          <div class="col-6 col-md-4">

          </div>
          <div class="col-6 col-md-4" style="padding-top:200px">
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                    <asp:TextBox ID="TextBox1" class="form-control" placeholder="Id"  runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                    <asp:TextBox ID="TextBox2" class="form-control" placeholder="Nombre"  runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="Button1" class="btn btn-success" runat="server" OnClick="Button1_Click" Text="Agregar" />
                    <asp:Button ID="Button2" class="btn btn-primary" runat="server" OnClick="Button2_Click" Text="Editar" />
                    <asp:Button ID="Button3" class="btn btn-danger" runat="server" OnClick="Button3_Click" Text="Eliminar" />
          
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
            </div>
              
            <div class="col-6 col-md-4">

            </div>
        </div>
      </div>
    </form>
</asp:Content>
