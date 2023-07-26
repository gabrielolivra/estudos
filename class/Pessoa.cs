using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*public class Pessoa
{
    public string nome;
    public int idade;
    public string cidade;

    public void ListarPessoa()
    {
        Console.WriteLine($"Nome: {nome}\nIdade: {idade}\nCidade: {cidade}");
    }
}*/

public class Pessoa
{
    public void ListarPessoa(string nome, int idade, string cidade)
    {
        Console.WriteLine($"Nome: {nome}\nIdade: {idade}\nCidade: {cidade}");
    }
}