using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12Classes
{
    internal class Personagem
    {
        // Variaveis (Atributos) nas classes
       public string nome;
       public string raca;
       public int poder;

        //Funções (Métodos) nas classes
        public void mostra()
        {
            Console.WriteLine($"Seu personagem se chama {nome} \nRaça: {raca} \nPoder: {poder}");
        }

    }
}
