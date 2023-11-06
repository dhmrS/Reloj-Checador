using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Checador {
    public partial class Nuevo : Form {
        public Nuevo() {
            InitializeComponent();
        }

        private void Nuevo_Load(object sender, EventArgs e) {

        }

        private void pb_Guardar_Nuevo_Empleado_Click(object sender, EventArgs e) {
            //Crear Nueva Clase con Empleado
            Empleado nuevoEmpleado = new(tbox_Nombre.Text, tbox_Apellido.Text, tbox_Numero_de_Empleado.Text);

            // Obtener referencia al formulario main creando un instancia del mismo
            Checador frmMain = (Checador)Application.OpenForms["Checador"];

            // Agregar empleado a la lista
            frmMain.LISTA_EMPLEADOS.Add(nuevoEmpleado);

            // Actualiza el txt por el Registro del Nuevo Empleado
            frmMain.Guardar_Nuevo_Empleado_en_txt();

            // Generar txt de Empleado
            //Obtiene el Directorio que sera el nombre
            String Directorio = frmMain.ObtenerRutaArchivo(nuevoEmpleado.Nombre + " " + nuevoEmpleado.Apellido);

            // Comprueba si el archivo ya existe
            if (!File.Exists(Directorio)) {
                try {
                    // Si no existe, crea un nuevo archivo
                    File.Create(Directorio).Close();
                }
                catch {
                    MessageBox.Show("Ingrese un Nombre Valido");
                }
            }
            else {
                MessageBox.Show("El Usuario ya se Encuentra Registrado en la DB");
            }


            // Mensaje de Empleado Guardado en DB
            MessageBox.Show("EMPLEADO REGISTRADO EN DB", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            // Cerrar esta ventana
            Close();
        }
    }
}
