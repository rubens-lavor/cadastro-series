using System;
using System.Collections.Generic;
using Interface;

namespace ProjetoDIO.Series
{
  public class SerieRepositorio : IRepositorio<Serie>
  {
    private List<Serie> listaSerie = new List<Serie>();
    public void Atualizar(int id, Serie entidade)
    {
      listaSerie[id] = entidade;
    }

    public void Excluir(int id)
    {
      listaSerie[id].excluirRegistro();
    }

    public void Inserir(Serie entidade)
    {
      listaSerie.Add(entidade);
    }

    public List<Serie> Lista()
    {
      return listaSerie;
    }

    public int ProximoId()
    {
      return listaSerie.Count;
    }

    public Serie RetornarPorId(int id)
    {
      return listaSerie[id];
    }
  }
}