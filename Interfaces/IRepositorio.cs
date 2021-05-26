using System.Collections.Generic;

namespace Interface
{
  public interface IRepositorio<T>
  {
    List<T> Lista();
    T RetornarPorId(int id);
    void Excluir(int id);
    void Inserir(T entidade);
    void Atualizar(int id, T entidade);
    int ProximoId();
  }
}