using System;
using Dio.Series;

namespace Dio.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSeries();
                        break;
                    case "3":
                        AtualizarSeries();
                        break;
                    case "4":
                        ExcluirSeries();
                        break;
                    case "5":
                        VisualizarSeries();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

        }


        private static string ObterOpcaoUsuario()
        {

            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            String opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar Séries");

            var lista = repositorio.Lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada");
                return;
            }
            foreach(var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                Console.WriteLine("#ID {0}: - {1} - {2}", serie.retornaIdId(), serie.retornaIdTitulo(), (excluido ? "Excluido" : "Ativo"));
            }
        }

        private static void InserirSeries()
        {
            Console.WriteLine("Inserir nova série");

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o gênero entre as opção acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("DIgite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            string entradaAno = Console.ReadLine();

            Console.Write("Digite a Descricão da Série: ");
            string entradaDescricao = Console.ReadLine();

            Series novaSerie = new Series(
                                            Id: repositorio.proximoId(),
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descrecao: entradaDescricao);
            
            repositorio.insere(novaSerie);

        }

        private static void AtualizarSeries()
        {
            Console.WriteLine("Digitar nova série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o gênero entre as opção acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("DIgite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            string entradaAno = Console.ReadLine();

            Console.Write("Digite a Descricão da Série: ");
            string entradaDescricao = Console.ReadLine();

            Series atualizarSerie = new Series(
                                            Id: indiceSerie,
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descrecao: entradaDescricao);
            
            repositorio.atualizar(indiceSerie, atualizarSerie);
        }

        private static void ExcluirSeries()
        {
            Console.Write("Digite o id da série: ");
            int indeceSerie = int.Parse(Console.ReadLine());

            repositorio.excluir(indeceSerie);
        }

        private static void VisualizarSeries()
        {
            Console.Write("Digite o id da série: ");
            int indeceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornarPorId(indeceSerie);
            Console.WriteLine(serie);
        }

    }

    
}
