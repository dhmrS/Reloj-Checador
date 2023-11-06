namespace Checador {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        readonly string User = "a";
        readonly string Pass = "1";

        private void Login_Load(object sender, EventArgs e) {

        }

        private void pb_Ingresar_Click(object sender, EventArgs e) {
            // Cerrar Ventana "login"
            Close();

            if (tbox_Usuario.Text == User && tbox_Contraseña.Text == Pass) {
                // Le da Acceso de Admin
                Administrador ad = new();
                // Muestra Dicha Ventana
                ad.Show();
            }
            else {
                MessageBox.Show("No tiene Permisos para Modificar la Base de Datos", "Acceso Denegado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Declarar a null Campos de "login"
            tbox_Usuario.ResetText();
            tbox_Contraseña.ResetText();
        }
    }
}
