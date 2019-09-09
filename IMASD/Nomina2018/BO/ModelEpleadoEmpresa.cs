using System;

namespace Nomina2018.BO
{
    public class ModelEpleadoEmpresa
    {
        int empleadoempresaID;

        int empresaID;
        string nombreempresa;

        int empleadoID;
        string nombreempleado;
        string apellidopaterno;
        string apellidomaterno;
        string correoelectronico;
        string telefono1;
        string curp;

        int departamentoID;
        string nombredepartamento;

        int puestoID;
        string nombrepuesto;
        int nivel;
        double sueldo;

        DateTime fechaingreso;
        DateTime fechasalida;
        int antiguedad;
        string nss;
        string rfc;
        int numeroempleado;
        int estatus;

        public int EmpleadoempresaID
        {
            get
            {
                return empleadoempresaID;
            }

            set
            {
                empleadoempresaID = value;
            }
        }

        public int EmpresaID
        {
            get
            {
                return empresaID;
            }

            set
            {
                empresaID = value;
            }
        }

        public string Nombreempresa
        {
            get
            {
                return nombreempresa;
            }

            set
            {
                nombreempresa = value;
            }
        }

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

        public int DepartamentoID
        {
            get
            {
                return departamentoID;
            }

            set
            {
                departamentoID = value;
            }
        }

        public string Nombredepartamento
        {
            get
            {
                return nombredepartamento;
            }

            set
            {
                nombredepartamento = value;
            }
        }

        public int PuestoID
        {
            get
            {
                return puestoID;
            }

            set
            {
                puestoID = value;
            }
        }

        public string Nombrepuesto
        {
            get
            {
                return nombrepuesto;
            }

            set
            {
                nombrepuesto = value;
            }
        }

        public int Nivel
        {
            get
            {
                return nivel;
            }

            set
            {
                nivel = value;
            }
        }

        public double Sueldo
        {
            get
            {
                return sueldo;
            }

            set
            {
                sueldo = value;
            }
        }

        public DateTime Fechaingreso
        {
            get
            {
                return fechaingreso;
            }

            set
            {
                fechaingreso = value;
            }
        }

        public DateTime Fechasalida
        {
            get
            {
                return fechasalida;
            }

            set
            {
                fechasalida = value;
            }
        }

        public int Antiguedad
        {
            get
            {
                return antiguedad;
            }

            set
            {
                antiguedad = value;
            }
        }

        public string Nss
        {
            get
            {
                return nss;
            }

            set
            {
                nss = value;
            }
        }

        public string Rfc
        {
            get
            {
                return rfc;
            }

            set
            {
                rfc = value;
            }
        }

        public int Numeroempleado
        {
            get
            {
                return numeroempleado;
            }

            set
            {
                numeroempleado = value;
            }
        }

        public int Estatus
        {
            get
            {
                return estatus;
            }

            set
            {
                estatus = value;
            }
        }
    }
}