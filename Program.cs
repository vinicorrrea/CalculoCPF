using System;

namespace CalculoCPF
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpfCliente;
            string cpf9;
            string cpf10;
            int contagem1=10;
            int contagem2=11;
            int resto=0;
            int rs1=0;
            int rs2=0;
            string cpfFinal;

            cpfCliente = "47835584859";
            cpf9 = cpfCliente.Substring(0,9);
           for(int i=0; i < cpf9.Length;i++)
           {
            rs1 += int.Parse(cpf9[i].ToString())*contagem1; 
            contagem1--;
           }

           resto = rs1 % 11;
           if(resto < 2)
           cpf10 = cpf9+0;
           else
           cpf10 = cpf9+(11-resto);

           //--------------------------------------------------------------------------------------

           for(int i=0; i < cpf10.Length;i++)
           {
            rs2 += int.Parse(cpf10[i].ToString())*contagem2; 
            contagem2--;
           }

           resto = rs2 % 11;
           if(resto < 2)
           cpfFinal = cpf10+0;
           else
           cpfFinal = cpf10+(11-resto);









        }
    }
}
