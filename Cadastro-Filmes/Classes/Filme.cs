using Cadastro_Filmes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Filmes.Classes
{
    public class Filme : Entidade
    {
        private string titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private Genero genero { get; set; }

        public Filme(int id, string titulo, string descricao, int ano, Genero genero)
        {
            this.Id = id;
            this.titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.genero = genero;
        }

        public override string ToString()
        {
            String retorno = "";
            retorno += "Gênero: " + this.genero + Environment.NewLine;
            retorno += "Título: " + this.titulo + Environment.NewLine;
            retorno += "Descrição " + this.Descricao + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;

            return retorno;
        }

        public String getTitulo()
        {
            return this.titulo;
        }

        public int getId()
        {
            return this.Id;
        }
    }
}
