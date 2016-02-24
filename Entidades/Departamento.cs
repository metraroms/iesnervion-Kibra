using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  Create table Departamentos(
	idDepartamento integer identity,
	nombreDep varchar(80) not null,
	descDep varchar(150) not null,
	telefono varchar(12) not null,
	CONSTRAINT PK_Departamentos PRIMARY KEY (idDepartamento))
*/
namespace Entidades
{
    public class Departamento
    {
        public Departamento() { }

        public Departamento(int idDep, String nomDep, String descDep, String telDep)
        {
            _IdDepartamento = idDep;
            _NombreDep = nomDep;
            _DescDep = descDep;
            _Telefono = telDep;
        }

        private int _IdDepartamento;
        public int IdDepartamento
        {
            get
            {
                return _IdDepartamento;
            }
            set
            {
                _IdDepartamento = value;
            }
        }

        [StringLength(80)]
        private String _NombreDep;
        public String NombreDep
        {
            get
            {
                return _NombreDep;
            }
            set
            {
                _NombreDep = value;
            }
        }

        [StringLength(150)]
        private String _DescDep;
        public String DescDep
        {
            get
            {
                return _DescDep;
            }
            set
            {
                _DescDep = value;
            }
        }

        [StringLength(12)]
        private String _Telefono;
        public String Telefono
        {
            get
            {
                return _Telefono;
            }
            set
            {
                _Telefono = value;
            }
        }
    }
}
