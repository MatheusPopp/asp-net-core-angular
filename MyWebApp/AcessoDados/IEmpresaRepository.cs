using System.Collections.Generic;
using MyWebApp.Entidades;

namespace MyWebApp.AcessoDados {
    public interface IEmpresaRepository {
        List<Empresa> ListarEmpresas();
        Empresa ListarEmpresaById(int id);
        void Salvar(Empresa empresa);
    }
}