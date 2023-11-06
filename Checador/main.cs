namespace Checador {
    public partial class Checador : Form {

        public List<Empleado> LISTA_EMPLEADOS = new();

        public Checador() {
            InitializeComponent();
        }

        private void Checador_Load(object sender, EventArgs e) {
            //MessageBox.Show("Bienvenido");
            // Bloquear tamaño de la Ventana
            FormBorderStyle = FormBorderStyle.FixedDialog;

            // Carga los Empleados ya Registrados
            Cargar_txt_de_los_Empleados_a_la_LIST_CLASS();
        }

        public string ObtenerRutaArchivo(string nombre) {
            string rutaDirectorio = @"C:\Users\Diego Mendoza\source\repos\Checador\Checador\bin";
            string nombreconExtension = nombre + ".txt";

            // Combinar la ruta del directorio con el nombre del archivo
            return Path.Combine(rutaDirectorio, nombreconExtension);
        }

        // CARGAR DB DE LOS EMPLEADOS A LA LISTA DE CLASES
        public void Cargar_txt_de_los_Empleados_a_la_LIST_CLASS() {
            string rutaArchivo = ObtenerRutaArchivo("DB");

            if (File.Exists(rutaArchivo)) {
                // Bloque "using" para garantizar que el objeto StreamReader se cierre automáticamente
                using StreamReader ?reader = File.OpenText(rutaArchivo);
                string line;

                while ((line = reader.ReadLine()) != null) {
                    if (line != null) {
                        // Dividir la línea por salto de línea
                        string[] empleados = line.Split(
                        new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (string empleadoData in empleados) {
                            // Dividir la línea del empleado por comas
                            string[] datos = empleadoData.Split(',');

                            if (datos != null && datos.Length == 3) {
                                // Crear objeto Empleado con los datos
                                Empleado emp = new(datos[0], datos[1], datos[2]);

                                // Agregar a la lista
                                LISTA_EMPLEADOS.Add(emp);
                            }
                        }
                    }
                }
            }
            else {
                // El archivo no existe y lo Crea
                File.Create(rutaArchivo).Close();
            }
        }

        public void Guardar_Nuevo_Empleado_en_txt() {
            // Crear un nuevo archivo o sobrescribir si ya existe
            using StreamWriter writer = new(ObtenerRutaArchivo("DB"));

            foreach (Empleado emp in LISTA_EMPLEADOS) {
                // Escribir los datos del empleado en el archivo
                writer.WriteLine(value: $"{emp.Nombre},{emp.Apellido},{emp.NumEmpleado}\n");
            }
        }

        // Timer para Mostrar Hora y Fecha
        private void horafecha_Tick(object sender, EventArgs e) {
            // Mostrar Fecha (lunes, 6 de noviembre de 2023)
            lbl_fecha.Text = DateTime.Now.ToString("D");
            // Mostrar Hora (00:00:00)
            lbl_hora.Text = DateTime.Now.ToString("T");
        }

        // Buscar Empleado en DB
        public Empleado? Buscar_Empleado(String empleado_a_Buscar) {
            if (empleado_a_Buscar == "") {
                MessageBox.Show("INGRESE SU NUMERO DE EMPLEADO", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else {
                foreach (Empleado i in LISTA_EMPLEADOS) {
                    if (empleado_a_Buscar == i.NumEmpleado) {
                        return i;
                    }
                }
            }
            return null;
        }

        // Evento de Click de Botón para Registrar Asistencia
        private void Bt_Registrar_Asistencia_Click(object sender, EventArgs e) {
            String employed = tbox_NumerodeEmpleado.Text;
            Empleado ?i = Buscar_Empleado(employed);

            if (i == null && employed != "") { // No Encontro el Empleado
                MessageBox.Show("Empleado no encontrado en la base de datos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { // Si se Encontro y se Registra Asistencia
                RegistrarAsistencia(Si_Fue: i);
                MessageBox.Show((i.Nombre + " " + i.Apellido), "ASISTENCIA REGISTRADA",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            tbox_NumerodeEmpleado.ResetText();
        }

        private void RegistrarAsistencia(Empleado Si_Fue) {
            // Obtener Directorio del txt de Asistencia del Empleado
            String Ruta_Completa_de_Empleado_Nuevo = ObtenerRutaArchivo(Si_Fue.Nombre + " " + Si_Fue.Apellido);
            
            // Obtener la Fecha y Hora Actual
            string fechaHora = DateTime.Now.ToString("F");

            try {
                // Abrir el archivo en modo de escritura
                using (StreamWriter writer = new(Ruta_Completa_de_Empleado_Nuevo, true)) {
                    // Escribir la fecha y hora de asistencia
                    writer.WriteLine(fechaHora);
                }

            }
            catch {
                MessageBox.Show("Error al registrar la asistencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento de Click de Boton de Modo Admin
        private void pb_Modo_Admin_Click(object sender, EventArgs e) {
            // Crea un Instancia del Form Admin
            Login LOGIN = new();
            // Abrir Form login en Ventana de Dialogo para Interactuar con la misma
            LOGIN.ShowDialog();
        }
    }
}