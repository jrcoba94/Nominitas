namespace Nomina2018.BO
{
    public class PuestoBO
    {
        int puestoID;
        string nombrepuesto;
        string clave;
        int nivel;
        double sueldo;

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

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
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
    }
}