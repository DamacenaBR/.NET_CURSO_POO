using Dio.Series;
using System;

namespace Dio.Series
{
    public class Series : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descrecao { get; set; }
        private String Ano { get; set; }

        private bool Excluido {get; set; }

        public Series(int Id, Genero genero, string titulo, string descrecao, string ano)
        {
            this.Id = Id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descrecao = descrecao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descrecao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string retornaIdTitulo()
        {
            return this.Titulo;
        }

        public int retornaIdId()
        {
            return this.Id;
        }

        public void Exlui(){
            this.Excluido = true;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }


    }
}