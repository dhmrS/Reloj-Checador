using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checador {
    public partial class Administrador : Form {
        public Administrador() {
            InitializeComponent();
        }

        private void Administrador_Load(object sender, EventArgs e) {

        }

        private void Bt_nuevo_empleado_Click(object sender, EventArgs e) {
            // Mostrar Ventana para Ingresar Empleado Nuevo
            Nuevo Ventana_Nuevo_Empleado = new();
            //Cerrar Ventana de "login.cs" para Abrir la del Usuario
            //empleado.FormClosed += (sender, e) => Close();
            Ventana_Nuevo_Empleado.Show();
        }

        private void pb_Eliminar_Click(object sender, EventArgs e) {
            borrar bay = new();
            bay.Show();
        }
    }
}
