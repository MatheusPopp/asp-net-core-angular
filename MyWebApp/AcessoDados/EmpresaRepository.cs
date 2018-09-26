using MyWebApp.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace MyWebApp.AcessoDados
{
    public class EmpresaRepository : IEmpresaRepository {
        private readonly MyWebAppContext _myWebAppContext;

        public EmpresaRepository(MyWebAppContext myWebAppContext) {
            _myWebAppContext = myWebAppContext;
            
        }

        public List<Empresa> ListarEmpresas() {
            return _myWebAppContext.Empresas.ToList();

        }

        public Empresa ListarEmpresaById(int id)
        {
            return _myWebAppContext.Empresas.FirstOrDefault(p => p.Id == id);

        }

        public void Salvar(Empresa empresa)
        {
            _myWebAppContext.Empresas.Add(empresa);
            _myWebAppContext.SaveChanges();
        }
    }
}
