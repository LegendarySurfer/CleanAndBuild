using Domain;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Presentation
{
    public partial class Ventana
    {
        public static bool PanelContraido = true;
        public static FormWindowState estadoAnterior;

        public static void Salir()
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public static Panel SideBar(Panel MenuVertical)
        {
            PanelContraido = MenuVertical.Width != 333; //esta contraido
            MenuVertical.Width = PanelContraido ? 333 : 70;
            return MenuVertical;
        }
    
        public static void Historial()
        {
            var historial = new Historial();
            historial.MenuVertical2.Width = PanelContraido ? 333 : 70;
            historial.Show();
        }   

        public static void Opciones()
        {
            var opciones = new Ajustes();
            opciones.MenuVertical2.Width = PanelContraido ? 333 : 70;
            opciones.Show();
        }
        
        public static void RepararSistema()
        {
            var reparar = new RepararSistema();
            reparar.MenuVertical2.Width = PanelContraido ? 333 : 70;
            reparar.Show();
        }

        public static void ActualziarAplicaciones()
        {
            var actualizar = new ActualizarAplicacion();
            actualizar.MenuVertical2.Width = PanelContraido ? 333 : 70;
            actualizar.Show();
        }

        public static void DesfragmentarDisco()
        {
            var desfragmentar = new DesfragmentarDisco();
            desfragmentar.MenuVertical2.Width = PanelContraido ? 333 : 70;
            desfragmentar.Show();
        }

        public static void LimpiarSistema()
        {
            var limpiar = new LimpiarSistema();
            limpiar.MenuVertical2.Width = PanelContraido ? 333 : 70;
            limpiar.Show();
        }

        public static void LiberarEspacio()
        {
            var liberar = new LiberarEspacio();
            liberar.MenuVertical2.Width = PanelContraido ? 333 : 70;
            liberar.Show();
        }

        public static void Antivirus(Button btnAntivirus, DropDownMenu dropDownMenu1)
        {
            dropDownMenu1.Show(btnAntivirus, btnAntivirus.Width,0);

        }

        public static void Emisoft()
        {
            string pathToBatchFile = Path.Combine(Application.StartupPath, @"..\..\..\scripts\ClamWin\ClamWinPortable.exe");
            Process p = new Process();
            p.StartInfo.FileName = pathToBatchFile;
            p.Start();

            //guardamos en la BBDD
            UserModel userModel = new UserModel();
            userModel.GuardarComando("Emisoft", "ClamWinPortable");
            userModel.GuardarEnHistorial(Presentation.MenuPrincipal.username);
        }

        public static void EscanerRapido()
        {
            string pathToBatchFile = Path.Combine(Application.StartupPath, @"..\..\..\scripts\escanerRapido.bat");
            Process p = new Process();
            p.StartInfo.FileName = pathToBatchFile;
            p.Start();

            //guardamos en la BBDD
            UserModel userModel = new UserModel();
            userModel.GuardarComando("Escaneo Rapido", "escanerRapido");
            userModel.GuardarEnHistorial(Presentation.MenuPrincipal.username);

        }

        public static void InstalarAplicaciones()
        {
            var instalar = new InstalarAplicaciones();
            instalar.MenuVertical2.Width = PanelContraido ? 333 : 70;
            instalar.Show();
        }

        public static void MenuPrincipal()
        {
            MenuPrincipal a = new MenuPrincipal(Presentation.MenuPrincipal.username);
            a.MenuVertical2.Width = PanelContraido ? 333 : 70;
            a.Show();
        }

        public static void CambiarBtnAntivirus(Button btnAntivirus, Panel MenuVertical2,DropDownMenu dropDownMenu1)
        {
            dropDownMenu1.IsMainMenu = true;
            // Ajustar el ancho del botón según el ancho del panel
            btnAntivirus.Width = MenuVertical2.Width;
            btnAntivirus.Text = MenuVertical2.Width < 333 ? "" : "Antivirus";

            // Suscribirse al evento SizeChanged del panel para actualizar el ancho del botón
            MenuVertical2.SizeChanged += (sender, e) =>
            {
                btnAntivirus.Width = MenuVertical2.Width;
                btnAntivirus.Text = MenuVertical2.Width < 333 ? "" : "Antivirus";
            };
        }

        public static FormWindowState CompuebaEstadoVentana()
        {
            return estadoAnterior == FormWindowState.Normal ? FormWindowState.Normal : FormWindowState.Maximized;
        }
    
        public static void MostrarComandosCreados(Button btnOtros, DropDownMenu ddm_comando)
        {
            UserModel datos = new UserModel();
            DataSet comandos = datos.ObtenerComandosCreados();

            if (comandos != null && comandos.Tables.Count > 0 && comandos.Tables[0].Rows.Count > 0)
            {
                ddm_comando.Items.Clear();
                foreach (DataRow row in comandos.Tables[0].Rows)
                {
                    string nombreComando = row["nombre_comando"].ToString().Trim();
                    ddm_comando.Items.Add(nombreComando);
                }
                ddm_comando.Show(btnOtros, btnOtros.Width, 0);
            }
        }
    }
}
