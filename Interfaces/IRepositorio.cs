using System.Collections.Generic;

namespace Dio.Series.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();
         T RetornarPorId(int id);
         void insere(T entidade);
         void excluir(int id);
         void atualizar(int id, T entidade);
         int proximoId();

         T ReturnPorID(int id);
    }
}