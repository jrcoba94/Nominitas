using System;

namespace Nomina2018.BO
{
    public class EmpleadosBO
    {
        public EmpleadosBO() { }

        int empleadoID;
        string nombreempleado;
        string apellidopaterno;
        string apellidomaterno;
        string direccion;
        string correoelectronico;
        string telefono1;
        string telefono2;
        DateTime fechanacimiento;
        string ciudad;
        string estado;
        string curp;

        public int EmpleadoID
        {
            get
            {
                return empleadoID;
            }

            set
            {
                empleadoID = value;
            }
        }

        public string Nombreempleado
        {
            get
            {
                return nombreempleado;
            }

            set
            {
                nombreempleado = value;
            }
        }

        public string Apellidopaterno
        {
            get
            {
                return apellidopaterno;
            }

            set
            {
                apellidopaterno = value;
            }
        }

        public string Apellidomaterno
        {
            get
            {
                return apellidomaterno;
            }

            set
            {
                apellidomaterno = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Correoelectronico
        {
            get
            {
                return correoelectronico;
            }

            set
            {
                correoelectronico = value;
            }
        }

        public string Telefono1
        {
            get
            {
                return telefono1;
            }

            set
            {
                telefono1 = value;
            }
        }

        public string Telefono2
        {
            get
            {
                return telefono2;
            }

            set
            {
                telefono2 = value;
            }
        }

        public DateTime Fechanacimiento
        {
            get
            {
                return fechanacimiento;
            }

            set
            {
                fechanacimiento = value;
            }
        }

        public string Ciudad
        {
            get
            {
                return ciudad;
            }

            set
            {
                ciudad = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string Curp
        {
            get
            {
                return curp;
            }

            set
            {
                curp = value;
            }
        }
    }
}