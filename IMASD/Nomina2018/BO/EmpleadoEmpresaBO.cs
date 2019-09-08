using System;

namespace Nomina2018.BO
{
    public class EmpleadoEmpresaBO
    {
        int empleadoempresaID;
        int empresaID;
        int empleadoID;
        int departamentoID;
        int puestoID;
        DateTime fechaingreso;
        DateTime fechasalida;
        string antiguedad;
        string nss;
        string rfc;
        int numeroempleado;
        byte estatus;

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

        public string Antiguedad
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

        public byte Estatus
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