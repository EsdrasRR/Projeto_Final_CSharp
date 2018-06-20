using ModelLibrary;
using System.Collections.Generic;
using System;
using System.Linq;


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
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public Serie BuscarPorID(int id)
        {
            return contexto.Series.Find(id);
        }

        public void Excluir(int id)
        {
            Serie s = BuscarPorID(id);
            if (s != null)
            {
                contexto.Series.Remove(s);
                contexto.SaveChanges();
            }
        }

        public IList<Serie> ListarPorNome(string nome)
        {
            return contexto.Series.Where(s => s.Nome.ToLower() == nome.ToLower()).ToList();
        }

        public IList<Serie> ListarTodos()
        {
            return contexto.Series.ToList();
        }
    }
}
