using Cadastro_Filmes.Classes;
using Cadastro_Filmes.Enums;
using System;

namespace Cadastro_Filmes
{
    class Program
    {
        static FilmeRepositorio filmerep = new FilmeRepositorio();

        public static void Main(string[] args)
        {
			string op = ObterOpcaoUsuario();
			while(op != "X")
            {
                switch (op)
                {
					case "1":
						listaFilme();
						break;
					case "2":
						adicionaFilme();
						break;
					case "3":
						atualizaFilme();
						break;
					case "4":
						excluiFilme();
						break;
					case "5":
						visualizaFilme();
						break;
					case "C":
						Console.Clear();
						break;
					default:
						throw new ArgumentOutOfRangeException();
						break;
				}
				op = ObterOpcaoUsuario();
            }
        }

		private static void listaFilme()
        {
			var lista = filmerep.getLista();

			if(lista.Count == 0)
            {
				Console.WriteLine("Nenhum filme registrado!");
				return;
            }
            else
            {
				foreach(var item in lista)
                {
                    Console.WriteLine("#ID {0}: - {1}", item.getId(), item.getTitulo());
                }
            }
        }

		private static void adicionaFilme()
        {
			Console.WriteLine("Digite uma das opções abaixo referente ao gênero do filme:");
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			int opgenero = int.Parse(Console.ReadLine());
			Console.WriteLine("Digite o título do filme: ");
			String titulo = Console.ReadLine();
			Console.WriteLine("Digite o ano de lançamento: ");
			int ano = int.Parse(Console.ReadLine());
			Console.WriteLine("Digite a descrição do filme: ");
			String descricao = Console.ReadLine();

			Filme filme = new Filme(id: filmerep.nextId(),titulo,descricao,ano,(Genero)opgenero);
			filmerep.add(filme);
		}

		private static void excluiFilme()
        {
			Console.WriteLine("Digite o id do filme a ser excluido:");
			int id = int.Parse(Console.ReadLine());
			if(id != null)
            {
				filmerep.delete(id);
            }
        }

		private static void visualizaFilme()
        {
			Console.WriteLine("Digite o id do filme:");
			int id = int.Parse(Console.ReadLine());
			var filme = filmerep.getFilme(id);
			Console.WriteLine(filme);
        }

		private static void atualizaFilme()
        {
			Console.WriteLine("Digite o id do filme: ");
			int id = int.Parse(Console.ReadLine());
            if (filmerep.getFilme(id) != null)
            {
				Console.WriteLine("Digite uma das opções abaixo referente ao gênero do filme:");
				foreach (int i in Enum.GetValues(typeof(Genero)))
				{
					Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
				}
				int opgenero = int.Parse(Console.ReadLine());
				Console.WriteLine("Digite o título do filme: ");
				String titulo = Console.ReadLine();
				Console.WriteLine("Digite o ano de lançamento: ");
				int ano = int.Parse(Console.ReadLine());
				Console.WriteLine("Digite a descrição do filme: ");
				String descricao = Console.ReadLine();

				Filme filme = new Filme(id: filmerep.nextId(), titulo, descricao, ano, (Genero)opgenero);
				filmerep.update(id,filme);
			}		
		}

		private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar filmes");
			Console.WriteLine("2- Adicionar filme");
			Console.WriteLine("3- Atualizar filme");
			Console.WriteLine("4- Excluir filme");
			Console.WriteLine("5- Visualizar filme");
			Console.WriteLine("C- Limpar tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}

	}

	}
