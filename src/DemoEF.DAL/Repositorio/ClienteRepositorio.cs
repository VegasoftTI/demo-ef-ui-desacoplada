using System;
using System.Linq;
using System.Collections.Generic;

namespace DemoEF.DAL.Repositorio
{
    public class ClienteRepositorio : IDisposable
    {
        private readonly DAL.Contexto.CadCliContexto _ctx;
        public ClienteRepositorio()
        {
            _ctx = new Contexto.CadCliContexto();
        }


        public IList<Entidade.Cliente> ObterTodosClientes()
        {
            return _ctx.Clientes.ToList();
        }

        public Entidade.Cliente ObterPorId(int id)
        {
            return _ctx.Clientes.Find(id);
        }

        public void Adicionar(Entidade.Cliente cliente)
        {
            _ctx.Clientes.Add(cliente);
            _ctx.SaveChanges();
        }

        public void Editar(Entidade.Cliente cliente)
        {
            var obj = _ctx.Entry(cliente);
            obj.State = System.Data.Entity.EntityState.Modified;
            _ctx.SaveChanges();
        }

        public void Excluir(Entidade.Cliente cliente)
        {
            var obj = _ctx.Entry(cliente);
            obj.State = System.Data.Entity.EntityState.Deleted;
            _ctx.SaveChanges();
        }
        
        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
