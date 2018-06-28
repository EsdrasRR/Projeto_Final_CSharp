using System.Collections.Generic;

namespace ControllerLibrary
{
    public interface ISerieController<Serie>
    {
		// Testando
		void Adicionar(Serie entity);
        IList<Serie> ListarTodos();
        IList<Serie> ListarPorNome(string nome);
        Serie BuscarPorID(int id);
        void Atualizar(Serie entity);
        void Excluir(int id);

    }
}
