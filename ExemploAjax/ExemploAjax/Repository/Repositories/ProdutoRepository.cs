using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private SystemContext context;
        public ProdutoRepository()
        {
            context = new SystemContext();
        }
        public bool Alterar(Produto produto)
        {
            var produtoOriginal = context.Produtos.FirstOrDefault(x => x.Id == produto.Id);
            if (produtoOriginal == null)
                return false;

            produtoOriginal.Nome = produto.Nome;
            produtoOriginal.Quantidade = produto.Quantidade;
            produtoOriginal.Valor = produto.Valor;
            int quantidadeAfetada = context.SaveChanges();
            return quantidadeAfetada == 1;

        }

        public bool Apagar(int id)
        {
            var venda = context.Produtos.FirstOrDefault(x => x.Id == id);
            if (venda == null)
                return false;

            venda.RegistroAtivo = false;
            int quantidadeAfetada = context.SaveChanges();
            return quantidadeAfetada == 1;
        }

        public int Inserir(Produto produto)
        {
            context.Produtos.Add(produto);
            context.SaveChanges();
            return produto.Id;
        }

        public Produto ObterPeloId(int id)
        {
            return context.Produtos.FirstOrDefault(X => X.Id == id);
        }

        public List<Produto> ObterProdutosPeloIdVenda(int idVenda)
        {
            return context.Produtos.Where(x => x.IdVenda == idVenda).ToList();
        }

    }
}
