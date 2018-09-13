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

            foreach (var item in novosFilmes) {

                Netflix.Adicione(item);
            }


            LocadoraFilmes locacao = new LocadoraFilmes(Netflix);

            locacao.AdicionaItens(novosFilmes[0]);
            locacao.AdicionaItens(novosFilmes[1]);

            locacao.Totalizar();

            locacao.RealizaPagamento(20.80);

            Console.ReadKey();










        }
    }
}
