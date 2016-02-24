using System;
using System.ComponentModel.DataAnnotations;
using Entidades;
/*
    Create table Empleados(
    idEmpleado integer identity,
    dniEmp varchar(9) Not null,
    nombreEmp varchar(80) not null,
    apellidoEmp varchar(100) not null,
    fechaNac   date not null,
    direccionEmp varchar(150) not null,
    telefonoEmp varchar(12) not null,
    emailEmp varchar(150) not null,
    departamentoEmp integer,
    puestoEmp integer, 
    ciudadEmp integer,
    constraint PK_Empleados primary key(idEmpleado),
	constraint FK_Empleados_Ciudades foreign key (ciudadEmp) references ciudades(idCiudad),
	constraint FK_Empleados_Departamentos foreign key (departamentoEmp) references departamentos(idDepartamento),
	constraint FK_Empleados_Puestos foreign key (puestoEmp) references Puestos(idPuesto)
*/
namespace Entidades
{
    public class Empleado
    {
        #region "Campos privados y propiedades públicas"

        private int _IdEmpleado;
        public int IdEmpleado
        {
            get
            {
                return _IdEmpleado;
            }

            set
            {
                _IdEmpleado = value;
            }
        }

        [StringLength(9)]
        private string _DniEmp; 
        public string DniEmp
        {
            get
            {
                return _DniEmp;
            }

            set
            {
                _DniEmp = value;
            }
        }

        [StringLength(80)]
        private string _NombreEmp;
        public string NombreEmp
        {
            get
            {
                return _NombreEmp;
            }

            set
            {
                _NombreEmp = value;
            }
        }

        [StringLength(100)]
        private string _ApellidoEmp;
        public string ApellidoEmp
        {
            get
            {
                return _ApellidoEmp;
            }

            set
            {
                _ApellidoEmp = value;
            }
        }

        private DateTime _FechaNac;
        public DateTime FechaNac
        {
            get
            {
                return _FechaNac;
            }

            set
            {
                _FechaNac = value;
            }
        }

        [StringLength(150)]
        private string _DireccionEmp;
        public string DireccionEmp
        {
            get
            {
                return _DireccionEmp;
            }

            set
            {
                _DireccionEmp = value;
            }
        }

        [StringLength(12)]
        private string _TelefonoEmp;
        public string TelefonoEmp
        {
            get
            {
                return _TelefonoEmp;
            }

            set
            {
                _TelefonoEmp = value;
            }
        }

        [StringLength(150)]
        private string _EmailEmp;
        public string EmailEmp
        {
            get
            {
                return _EmailEmp;
            }
            set
            {
                _EmailEmp = value;
            }
        }

        private Departamento _DepartamentoEmp;
        public Departamento DepartamentoEmp
        {
            get
            {
                return _DepartamentoEmp;
            }

            set
            {
                _DepartamentoEmp = value;
            }
        }

        private Puesto _PuestoEmp;
        public Puesto PuestoEmp
        {
            get
            {
                return _PuestoEmp;
            }

            set
            {
                _PuestoEmp = value;
            }
        }

        private Ciudad _CiudadEmp;
        public Ciudad CiudadEmp
        {
            get
            {
                return _CiudadEmp;
            } 

            set
            {
                _CiudadEmp = value;
            }    
        }

        #endregion

        #region "Constructores"

        public Empleado() { }

        public Empleado(int idEmpleado, 
                        string dniEmp, 
                        string nombreEmp, 
                        string apellidoEmp, 
                        DateTime fechaNac, 
                        string direccionEmp, 
                        string telefonoEmp, 
                        string emailEmp, 
                        Departamento departamentoEmp,
                        Puesto puestoEmp,
                        Ciudad ciudadEmp)
        {
            _IdEmpleado = idEmpleado;
            _DniEmp = dniEmp;
            _NombreEmp = nombreEmp;
            _ApellidoEmp = apellidoEmp;
            _FechaNac = fechaNac;
            _DireccionEmp = direccionEmp;
            _TelefonoEmp = telefonoEmp;
            _EmailEmp = emailEmp;
            _DepartamentoEmp = departamentoEmp;
            _PuestoEmp = puestoEmp;
            _CiudadEmp = ciudadEmp;
        }

        #endregion
    }
}
