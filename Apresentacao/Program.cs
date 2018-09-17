using Dominio;
using Gestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao
{
    class Program
    {
        static void Main(string[] args)
        {

            var novosFilmes = new List<IItem>()
            {
                new Filme(){ Categoria = Filme.Genero.AÇÃO , Nome ="Duro de Matar",Preco=10, FilmeId =1 },
                new Filme(){ Categoria = Filme.Genero.ANIME , Nome="Dragon Ball Super",Preco=7.90 ,FilmeId =2},
                new Filme(){ Categoria = Filme.Genero.ANIME , Nome="Dragon Ball Z",Preco=3.90 , FilmeId =3},
                new Filme(){ Categoria = Filme.Genero.ANIME , Nome="Dragon Ball GT",Preco=5.90 , FilmeId =4},
            };


            IEstoque Netflix = new AcervoFilmes();

            foreach (var item in novosFilmes)
            {

                Netflix.Adicione(item);
            }


            LocadoraFilmes locacao = new LocadoraFilmes(Netflix);

            locacao.AdicionaItens(novosFilmes[0]);
            locacao.AdicionaItens(novosFilmes[1]);


            locacao.Totalizar();
            Console.WriteLine("----------NetFlix------------");
            locacao.RealizaPagamento(20.80);

            foreach (Filme item in locacao.Compras())
            {
                Console.WriteLine("Filmes {0}  Preço: {1}", item.Nome, item.Preco);
            }



            var novosProdutos = new List<IItem>()
            {
                new Produto(){ ProdutoId = 1, Nome="X BOX ONE X", Preco=2500.00,Tipo = Produto.Categoria.GAMES },
                new Produto(){ ProdutoId = 2, Nome="X BOX ONE S", Preco=1500.00,Tipo = Produto.Categoria.GAMES },
                new Produto(){ ProdutoId = 3, Nome="PS4 PRO",     Preco=1900.00,Tipo = Produto.Categoria.GAMES },
                new Produto(){ ProdutoId = 4, Nome="PS4",         Preco=1500.00,Tipo = Produto.Categoria.GAMES },

            };

            IEstoque estoqueDaLoja = new CentroDistribuicao();

            foreach (var item in novosProdutos)
            {
                estoqueDaLoja.Adicione(item);
            }

            Loja compra = new Loja(estoqueDaLoja);
            //Adiciona o X Box One X
            compra.AdicionaItens(novosProdutos[0]);
            //Retira o X Box One X
            compra.RetiraItens(novosProdutos[0]);

            compra.AdicionaItens(novosProdutos[3]);

            compra.Totalizar();

            Console.WriteLine("----------Loja de Produtos------------");
            foreach (Produto item in compra.Compras())
            {
                Console.WriteLine("Items: {0} Preço: {1}", item.Nome, item.Preco);
            }



            compra.RealizaPagamento(2000);

            Console.WriteLine("----------------------");
            //Console.ReadKey();



            Console.WriteLine("------------------Contar a Receber------------------");



            var cliente = new Cliente()
            {
                Nome = "Halyson",
                Sobrenome = "Mendonca",
                Cpf = "008.505.503.21",
                Cartao = "100-80"
            };

            var dup1 = new DuplicataReceber() { Id = 1, Cliente = cliente, Valor = 10, Vencimento = Convert.ToDateTime("2018/09/10") , Sigla ="DP" };
            var dup2 = new DuplicataReceber() { Id = 2, Cliente = cliente, Valor = 20.20, Vencimento = Convert.ToDateTime("2018/09/10") , Sigla = "DP" };
            var dup3 = new DuplicataReceber() { Id = 3, Cliente = cliente, Valor = 10.20, Vencimento = Convert.ToDateTime("2018/09/20") , Sigla = "DP" };
            var dup4 = new DuplicataReceber() { Id = 4, Cliente = cliente, Valor = 2, Vencimento = Convert.ToDateTime("2018/09/18") , Sigla = "DP" };

            var nota1 = new NotaPromissoriaReceber() { Id = 4, Cliente = cliente, Valor = 2, Vencimento = Convert.ToDateTime("2018/09/18") };

            //Valor a parcelar
            var dup5 = new DuplicataReceber() { Id = 5, Cliente = cliente, Valor = 2000, Vencimento = Convert.ToDateTime("2018/09/17") , Sigla="NP"};

            ITituloReceber rec = new TituloReceber();
            rec.Adicionar(dup1);
            rec.Adicionar(dup2);
            rec.Adicionar(dup3);
            rec.Adicionar(dup4);
            rec.Adicionar(dup5);

            //ParcelarPrimeiraVez
            rec.Parcelar(dup5, 4);


            var listar = rec.ObterPorCliente(cliente);

            foreach (DuplicataReceber item in listar)
            {
                if (item.Referencia != null)
                {
                    Console.WriteLine("Id:{0} {1} {2} {3} Ref:{4}", item.Id, item.Cliente.Nome, item.Valor, item.Vencimento.ToShortDateString(), item.Referencia.Id);

                }
                else
                {
                    Console.WriteLine("Id:{3} {0} {1} {2}", item.Cliente.Nome, item.Valor, item.Vencimento.ToShortDateString(), item.Id);
                }
            }

            //tentar parcelar novamente.
            rec.Parcelar(dup5, 3);

            



            Console.ReadKey();












        }
    }
}
