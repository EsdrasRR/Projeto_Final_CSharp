using ModelLibrary;
using System.Collections.Generic;

namespace ControllerLibrary
{
    public interface InterfaceController
    {

        List<Serie> ListaSeries ();
        void Salvar(Serie serie);
        List<Serie> Listar();
        Serie BuscarPorID(int id);
        void Editar(int id, Serie serieAtualizada);


    }
}
