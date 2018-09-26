using System;
using System.Collections.Generic;

namespace MyWebApp.Entidades
{
    public class User
    {
        private string nome;
        private int id;
        private char sexo;
        private DateTime data_nasc;
        private ICollection<Empresa> empresas;


        public string Nome {
            get { return nome; }
            set { nome = value; } }
        public int Id {
            get { return id; }
            set { id = value; }
        }
        public char Sexo {
            get { return sexo; }
            set { sexo = value; }
        }

        public DateTime Data_nasc {
            get { return data_nasc; }
            set { data_nasc = value; }
        }

        public ICollection<Empresa> Empresas {
            get { return empresas; }
            set { empresas = value; }
        }

        
    }
}
