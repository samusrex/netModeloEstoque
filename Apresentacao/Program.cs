using Dominio;
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

            locacao.RealizaPagamento(20.80);



            var novosProdutos = new List<IItem>()
            {
                new Produto(){ ProdutoId = 1, Nome="X BOX ONE X", Preco=2500.00,Tipo = Produto.Categoria.GAMES },
                new Produto(){ ProdutoId = 2, Nome="X BOX ONE S", Preco=1500.00,Tipo = Produto.Categoria.GAMES },
                new Produto(){ ProdutoId = 3, Nome="PS4 PRO",     Preco=1900.00,Tipo = Produto.Categoria.GAMES },
                new Produto(){ ProdutoId = 4, Nome="PS4",         Preco=1500.00,Tipo = Produto.Categoria.GAMES },

            };

            IEstoque estoqueDaLoja = new CentroDistribuicao();

            foreach (var item in novosProdutos) {

                estoqueDaLoja.Adicione(item);

            }


            Loja compra = new Loja(estoqueDaLoja);

            //Adiciona o X Box One X
            compra.AdicionaItens(novosProdutos[0]);
            //Retira o X Box One X
            compra.RetiraItens(novosProdutos[0]);

            compra.AdicionaItens(novosProdutos[3]);

            compra.Totalizar();

            compra.RealizaPagamento(2000);







            Console.ReadKey();










        }
    }
}
