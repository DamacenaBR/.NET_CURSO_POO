using System;
using System.Collections.Generic;
using Dio.Series.Interfaces;

namespace Dio.Series
{
    public class SerieRepositorio : IRepositorio<Series>
    {

        private List<Series> listaSerie = new List<Series>();

        public void atualizar(int id, Series entidade)
        {
            listaSerie[id] = entidade;
        }

        public void excluir(int id)
        {
            listaSerie[id].Exlui();
        }

        public void insere(Series entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<Series> Lista()
        {
            return listaSerie;
        }

        public int proximoId()
        {
            return listaSerie.Count;
        }

        public Series RetornarPorId(int id)
        {
            return listaSerie[id];
        }

        public Series ReturnPorID(int id)
        {
            throw new NotImplementedException();
        }
    }
}