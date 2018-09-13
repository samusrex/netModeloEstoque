namespace Dominio
{
    public class Produto : IItem
    {
        public enum Categoria {

            GAMES,
            CELULARES,
            INFORMATICA,
            ELETRÔNICOS


        }

        

        public int ProdutoId { get; set; }

        public string Nome { get; set; }

        public double  Preco { get; set; }

        public Categoria Tipo { get; set; }

        private int qtde;

        public int GetQtde()
        {
            return qtde;
        }

        public void SetQtde(int value)
        {
            qtde = value;
        }
    }
}