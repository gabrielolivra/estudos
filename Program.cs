using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace estudos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Banco banco1 = new Banco();
            banco1.Nome = "Gabriel";
            banco1.Depositar(430);
            banco1.StatusConta();

            Banco banco2 = new Banco();
            banco2.Nome = "Joao";
            banco2.StatusConta();

            Banco banco3 = new Banco();

            banco3.StatusConta();


            Loja lojaJoao = new Loja();
            lojaJoao.EnderecoLoja = "Rua do centro";
            lojaJoao.NomeLoja = "Loja de tenis";
            lojaJoao.UserLoja = "Joao";
            lojaJoao.ListarLoja();*/


            /* Conta c = new Conta();

             c.saldo = 1400;
             c.titular = "Gabriel";
             c.Estrato();
             c.Sacar(1300);
             c.Estrato();
             c.informacoesTitular();


             Conta conta1 = new Conta();
             */


            /*Conta conta1 = new Conta(1, "Gabriel", 140);

            Console.WriteLine(conta1.Saldo);
            conta1.Saldo = conta1.Saldo + 190;
            Console.WriteLine(conta1.Saldo);*/


           /* Pessoa gb = new Pessoa();
            gb.nome = "Gabriel";
            gb.idade = 25;
            gb.cidade = "Crato";
            gb.ListarPessoa();*/


            Pessoa gb = new Pessoa();

            gb.ListarPessoa("Gabriel", 25, "Crato");
        }
    }

    public class House
    {
        public string Endereco;
        public string Cor;

        public void LigarLuz() {

            Console.WriteLine("Luzes ligadas");

        }

        public void DesligarLuz() {
            
            Console.WriteLine("Luzes desligadas");
        }
    }

    public class Banco
    {
        public string Nome;
        public string Balanco;

        public void Depositar(decimal money)
        {
            Balanco += money;
        }


        public void StatusConta()
        {
            if (Balanco == null)
            {
                Console.WriteLine($"A conta de {Nome} está zerada");
            }
            else
            {
                Console.WriteLine($"A conta de {Nome} possui um valor de {Balanco} R$");
            }
        }
    }
}
