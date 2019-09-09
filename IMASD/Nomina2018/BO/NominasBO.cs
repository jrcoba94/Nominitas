using System;

namespace Nomina2018.BO
{
    public class NominasBO
    {
        int nominasID;
        DateTime fechainicio;
        DateTime fechacierre;
        DateTime fechapago;
        int empleadoempresaID;
        int diastrabajados;
        double sueldodiario;
        double sueldoquincenal;
        double bonoasistencia;
        double bonopuntualidad;
        double despensa;
        double imss;
        double isr;
        double prestamocrediticio;
        double creditoinfonavit;
        double totalpercepcion;
        double totaldeduccion;
        double totalsueldo;

        public int NominasID
        {
            get
            {
                return nominasID;
            }

            set
            {
                nominasID = value;
            }
        }

        public DateTime Fechainicio
        {
            get
            {
                return fechainicio;
            }

            set
            {
                fechainicio = value;
            }
        }

        public DateTime Fechacierre
        {
            get
            {
                return fechacierre;
            }

            set
            {
                fechacierre = value;
            }
        }

        public DateTime Fechapago
        {
            get
            {
                return fechapago;
            }

            set
            {
                fechapago = value;
            }
        }

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

        public int Diastrabajados
        {
            get
            {
                return diastrabajados;
            }

            set
            {
                diastrabajados = value;
            }
        }

        public double Sueldodiario
        {
            get
            {
                return sueldodiario;
            }

            set
            {
                sueldodiario = value;
            }
        }

        public double Sueldoquincenal
        {
            get
            {
                return sueldoquincenal;
            }

            set
            {
                sueldoquincenal = value;
            }
        }

        public double Bonoasistencia
        {
            get
            {
                return bonoasistencia;
            }

            set
            {
                bonoasistencia = value;
            }
        }

        public double Bonopuntualidad
        {
            get
            {
                return bonopuntualidad;
            }

            set
            {
                bonopuntualidad = value;
            }
        }

        public double Despensa
        {
            get
            {
                return despensa;
            }

            set
            {
                despensa = value;
            }
        }

        public double Imss
        {
            get
            {
                return imss;
            }

            set
            {
                imss = value;
            }
        }

        public double Isr
        {
            get
            {
                return isr;
            }

            set
            {
                isr = value;
            }
        }

        public double Prestamocrediticio
        {
            get
            {
                return prestamocrediticio;
            }

            set
            {
                prestamocrediticio = value;
            }
        }

        public double Creditoinfonavit
        {
            get
            {
                return creditoinfonavit;
            }

            set
            {
                creditoinfonavit = value;
            }
        }

        public double Totalpercepcion
        {
            get
            {
                return totalpercepcion;
            }

            set
            {
                totalpercepcion = value;
            }
        }

        public double Totaldeduccion
        {
            get
            {
                return totaldeduccion;
            }

            set
            {
                totaldeduccion = value;
            }
        }

        public double Totalsueldo
        {
            get
            {
                return totalsueldo;
            }

            set
            {
                totalsueldo = value;
            }
        }
    }

    public class ModelNominas
    {
        int nominasID;
        DateTime fechainicio;
        DateTime fechacierre;
        DateTime fechapago;
        int empleadoempresaID;
        string nombreempresa;
        string nombreempleado;
        string apellidopaterno;
        string apellidomaterno;
        string correoelectronico;
        string nombredepartamento;
        string nombrepuesto;
        double sueldo;
        int antiguedad;
        string nss;
        string rfc;
        int numeroempleado;
        int diastrabajados;
        double sueldodiario;
        double sueldoquincenal;
        double bonoasistencia;
        double bonopuntualidad;
        double despensa;
        double imss;
        double isr;
        double prestamocrediticio;
        double creditoinfonavit;
        double totalpercepcion;
        double totaldeduccion;
        double totalsueldo;


        public int NominasID
        {
            get
            {
                return nominasID;
            }

            set
            {
                nominasID = value;
            }
        }

        public DateTime Fechainicio
        {
            get
            {
                return fechainicio;
            }

            set
            {
                fechainicio = value;
            }
        }

        public DateTime Fechacierre
        {
            get
            {
                return fechacierre;
            }

            set
            {
                fechacierre = value;
            }
        }

        public DateTime Fechapago
        {
            get
            {
                return fechapago;
            }

            set
            {
                fechapago = value;
            }
        }

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

        public int Diastrabajados
        {
            get
            {
                return diastrabajados;
            }

            set
            {
                diastrabajados = value;
            }
        }

        public double Sueldodiario
        {
            get
            {
                return sueldodiario;
            }

            set
            {
                sueldodiario = value;
            }
        }

        public double Sueldoquincenal
        {
            get
            {
                return sueldoquincenal;
            }

            set
            {
                sueldoquincenal = value;
            }
        }

        public double Bonoasistencia
        {
            get
            {
                return bonoasistencia;
            }

            set
            {
                bonoasistencia = value;
            }
        }

        public double Bonopuntualidad
        {
            get
            {
                return bonopuntualidad;
            }

            set
            {
                bonopuntualidad = value;
            }
        }

        public double Despensa
        {
            get
            {
                return despensa;
            }

            set
            {
                despensa = value;
            }
        }

        public double Imss
        {
            get
            {
                return imss;
            }

            set
            {
                imss = value;
            }
        }

        public double Isr
        {
            get
            {
                return isr;
            }

            set
            {
                isr = value;
            }
        }

        public double Prestamocrediticio
        {
            get
            {
                return prestamocrediticio;
            }

            set
            {
                prestamocrediticio = value;
            }
        }

        public double Creditoinfonavit
        {
            get
            {
                return creditoinfonavit;
            }

            set
            {
                creditoinfonavit = value;
            }
        }

        public double Totalpercepcion
        {
            get
            {
                return totalpercepcion;
            }

            set
            {
                totalpercepcion = value;
            }
        }

        public double Totaldeduccion
        {
            get
            {
                return totaldeduccion;
            }

            set
            {
                totaldeduccion = value;
            }
        }

        public double Totalsueldo
        {
            get
            {
                return totalsueldo;
            }

            set
            {
                totalsueldo = value;
            }
        }
    }
}