using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checador {
    public partial class borrar : Form {
        public borrar() {
            InitializeComponent();
        }

        private void pb_Eliminar_Empleado_Click(object sender, EventArgs e) {
            // Obtener referencia al formulario main creando un instancia del mismo
            Checador Principal = (Checador)Application.OpenForms["Checador"];

            // Buscar Empleado Solicitado en la Lista de Clases y lo Asigna a un Nueva Clase
            Empleado? empleado_a_ELIMINAR = Principal.Buscar_Empleado(tbox_num_emple_p_elminar.Text);

            if (empleado_a_ELIMINAR == null) {// Ve si se encuentra en la lista de Clases
                MessageBox.Show("EMPLEADO NO ENCONTRADO");
            }
            else { // Si encontro al Empleado
                if (Principal.LISTA_EMPLEADOS.Contains(empleado_a_ELIMINAR)) {// Ve si se encuentra el empleado
                    // Elimina su txt Personal de Asistencia
                    // Obtiene la ruta completa del archivo
                    String DirectorioCompleto = Principal.ObtenerRutaArchivo(empleado_a_ELIMINAR.Nombre + " " + empleado_a_ELIMINAR.Apellido);
                    // Si Existe lo Elimina
                    if (File.Exists(DirectorioCompleto)){
                        File.Delete(DirectorioCompleto);
                    }
                    // Elimina el Empleado de la lista de Clases
                    Principal.LISTA_EMPLEADOS.Remove(empleado_a_ELIMINAR);
                    // Actualizar Base de Datos de Empleados en el DB.txt
                    Principal.Guardar_Nuevo_Empleado_en_txt();
                    // Mensaje de Eliminado
                    MessageBox.Show("EMPLEADO ELIMINADO");

                    Close();
                }
                else {
                    MessageBox.Show("EMPLEADO NO ENCONTRADO");
                    tbox_num_emple_p_elminar.ResetText();
                }
            }
            


        }
    }
}
