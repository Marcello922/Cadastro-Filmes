using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Filmes.Classes
{
    public class FilmeRepositorio
    {
        private List<Filme> filmes = new List<Filme>();

        public void update(int id, Filme filme)
        {
            filmes[id] = filme;
        }

        public void delete(int id){
            filmes.RemoveAt(id);
        }

        public void add(Filme filme)
        {
            filmes.Add(filme);
        }

        public List<Filme> getLista()
        {
            return filmes;
        }

        public Filme getFilme(int id)
        {
            return filmes[id];
        }

        public int nextId()
        {
            return filmes.Count;        
        }
    }
}
