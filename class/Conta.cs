using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Conta
{


    private int numero;
    private string titular;
    private double saldo;

    

    public Conta(int numero, string titular, double saldo) { 
        
        this.numero = numero;
        this.titular = titular;
        this.saldo = saldo;
    }


    public int Numero
    {
        get { return numero; }
    }

    public string Titular
    {
        get { return titular; }
        
    }
    
    public double Saldo
    {
        get { return saldo; }
        set { saldo = value; }
    }
}


