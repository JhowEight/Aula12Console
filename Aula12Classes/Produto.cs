using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12Classes
{
    internal class Produto
    {
        public string nome_produto;
        public string descricao;
        public int quantidade = 0;
        public double preco = 0;
        public bool status;

        public void mostraProduto()
        {
            Console.WriteLine($"Produto: {nome_produto} \nDescrição: {descricao} \nQuantidade: {quantidade} \nPreço: {preco} \nStatus: {status}\n------------\n");      
        }

        public void desativaProduto()
        {
            quantidade = 0;
            status = false;
        }

    }
}

