<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="wfUsuarios.aspx.cs" Inherits="wfUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <section class="content-header">
        <h1>
            <asp:Label ID="lblTitulo" Text="" runat="server" >Listado de Clientes:</asp:Label>
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Home</a></li>
            <li class="active">Clientes</li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
         <%-- crud Clientes--%>       
                <div class="col-md-12" id="divClientes" runat="server">
                    <div class="box box-primary">
                        <div class="box-header with-border">
                            <h3 class="box-title">Clientes</h3>
                        </div>
                        <!-- /.box-header -->
                        <!-- form start -->
                        <div class="form-horizontal">
                            <div class="box-body">
                                <div id="Div4" class="dataTables_wrapper form-inline dt-bootstrap" runat="server">
                                    <div class="row">
                                        <div class="col-md-12"> <div class="table-responsive">
                                            <asp:Repeater Id="rr" runat="server"></asp:Repeater>
                                                <asp:Repeater ID="rptClientes" runat="server" OnItemDataBound="rptClientes_ItemDataBound">
                                                    <HeaderTemplate>
                                                        <table class="table table-striped tblClientes" id="tblClientes">
                                                            <thead>
                                                                <tr>
                                                                    <th>Rol</th>
                                                                    <th>#</th>
                                                                    <th>Nombre</th>
                                                                    <th>Apellido</th>
                                                                    <th>Correo</th>

                                                                </tr>
                                                            </thead>
                                                            <tbody>
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <tr>
                                                            <td>
                                                                <asp:Label ID="lblRol" runat="server" Text="-"></asp:Label></td>
                                                            <td>
                                                                <asp:Label ID="lblcodigo" runat="server" Text="-"></asp:Label></td>
                                                            <td>
                                                                <asp:Label ID="lblNombre" runat="server" Text="-"></asp:Label></td>
                                                            <td>
                                                                <asp:Label ID="lblApellido" runat="server" Text="-"></asp:Label></td>
                                                            <td>
                                                                <asp:Label ID="lblCorreo" runat="server" Text="-"></asp:Label></td>

                                                        </tr>
                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        </tbody>
                                            </table>
                                                    </FooterTemplate>
                                                </asp:Repeater>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- /.box-body -->
                        <div class="box box-footer">
                        </div>


                    </div>
                </div>
            </div>
            </section>

        <div class="modal fade" tabindex="-1" role="dialog" id="modalClientes">
            <div class="modal-dialog" role="document" id="divmodalClientes">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title" id="tituloModalAddEditTipoCobro">Reporte Cliente <small id="malClientes">    </small></h4>
                    </div>
                    <div class="modal-body" style="max-height: calc(100vh - 210px); overflow-y: auto;">
                        <div class="row">
                            <div class="col-sm-8  col-xs-12">
                                <label class="control-label">Cliente</label>
                            </div>
                            <%-- para el reporte --%>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentScript" Runat="Server">
    <script>


        oTable = $('#tblClientes').dataTable({
            "fnDrawCallback": function (oSettings) {
                if (oSettings.aiDisplay.length == 0) {
                    return;
                }

                var nTrs = $('#tblClientes tbody tr');
                var iColspan = nTrs[0].getElementsByTagName('td').length;
                var sLastGroup = "";
                for (var i = 0; i < nTrs.length; i++) {
                    var iDisplayIndex = oSettings._iDisplayStart + i;
                    var sGroup = oSettings.aoData[oSettings.aiDisplay[iDisplayIndex]]._aData[0];
                    if (sGroup != sLastGroup) {
                        var nGroup = document.createElement('tr');
                        var nCell = document.createElement('td');
                        nCell.colSpan = iColspan;
                        nCell.className = "group";
                        nCell.innerHTML = sGroup;
                        nGroup.appendChild(nCell);
                        nTrs[i].parentNode.insertBefore(nGroup, nTrs[i]);
                        sLastGroup = sGroup;
                    }
                }
            },
            "aoColumnDefs": [{ "bVisible": false, "aTargets": [0] }],
            "aaSortingFixed": [[0, 'asc']],
            "aaSorting": [[1, 'asc']],
            //"sDom": 'lfr<"giveHeight"t>ip',
            "sDom": '<"top"fi>',
            "bPaginate": false,
            "oLanguage": {
                "sSearch": "Buscar:",
                "sZeroRecords": "No se encontraron registros que mostrar",
                "sInfo": "Total registros mostrados: _TOTAL_",
                "sInfoFiltered": " - filtrados de _MAX_ registros"
            }
        });
    </script>
</asp:Content>


