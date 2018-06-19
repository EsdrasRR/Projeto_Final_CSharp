using ModelLibrary;
using System.Collections.Generic;
using System;

namespace ControllerLibrary
{
    public class Controller : InterfaceController
    {
        // Lista
        public List<Serie> ListaSeries { get; set; }

        // Salvar
        public void Salvar(Serie serie)
        {
            ListaSeries.Add(serie);
        }

        // Listar
        public List<Serie> Listar()
        {
            return ListaSeries;
        }

        // Buscar por ID
        public Serie BuscarPorID(int id)
        {
            foreach (Serie a in ListaSeries)
            {
                if (a.ID_Serie == id)
                {
                    return a;
                }
            }
            return null;
        }

        // Editar 
        public void Editar(int id, Serie serieAtualizada)
        {
            Serie serieAntiga = BuscarPorID(id);

            if (serieAntiga != null)
            {

                serieAntiga.Nome = serieAtualizada.Nome;
                serieAntiga.status = serieAtualizada.status;
                serieAntiga.Nota = serieAtualizada.Nota;
                serieAntiga.Ep_Atual = serieAtualizada.Ep_Atual;
                serieAntiga.Tot_Ep = serieAtualizada.Tot_Ep;
                serieAntiga.Observacao = serieAtualizada.Observacao;
                serieAntiga.Genero1 = serieAtualizada.Genero1;
                serieAntiga.Genero2 = serieAtualizada.Genero2;
                serieAntiga.Genero3 = serieAtualizada.Genero3;

            }
        }

        List<Serie> InterfaceController.ListaSeries()
        {
            throw new NotImplementedException();
        }
    }
}
