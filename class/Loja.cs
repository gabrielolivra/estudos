using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Loja {
   public string NomeLoja;
   public string EnderecoLoja;
   public string UserLoja;


    public void ListarLoja()
    {
        Console.WriteLine($"A loja {NomeLoja} está localizada no endereço {EnderecoLoja} procurar por {UserLoja}");
    }

}