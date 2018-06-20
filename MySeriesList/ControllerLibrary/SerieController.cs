using ModelLibrary;
using System.Collections.Generic;
using System;

namespace ControllerLibrary
{
    public class SerieController : ISerieController<Serie>
    {
        private Contexto contexto = new Contexto();

        private List<Serie> listSeries { get; set; }

        public void Adicionar(Serie entity)
        {
            contexto.Series.Add(entity);
            contexto.SaveChanges();        
        }

        public void Atualizar(Serie entity)
        {
            throw new NotImplementedException();
        }

        public Serie BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Serie> ListarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IList<Serie> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
