namespace MyWebApp.Entidades
{
    public class Empresa
    {
        private string nome;
        private int id;
        private User usuario;

        public string Nome { get { return nome; }
            set { nome = value; } }
        public int Id {
            get { return id; }
            set { id = value; }
        }
        public User Usuario{
            get { return usuario; }
            set { usuario = value; }
        }

        
    }
}
