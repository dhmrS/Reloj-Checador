using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checador {
    public class Empleado {
        public Empleado(String _nombre, String _Apellido, String _NumEmpleado) {
            Nombre = _nombre;
            Apellido = _Apellido;
            NumEmpleado = _NumEmpleado;
        }

        private String nombre = "";
        private String apellido = "";
        private String numEmpleado = "";

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string NumEmpleado { get => numEmpleado; set => numEmpleado = value; }
    }
}
