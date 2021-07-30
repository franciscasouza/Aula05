using System;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Cirar Instituiçao e Criar Departamentos*/

            Instituicao ie1 = new Instituicao();
            string nome, endereco;
            nome = ie1.Nome;
            endereco = ie1.Endereco;

            nome = "Vasco Coutinho";
            endereco = "Luciano das Neves";

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Endereço: {endereco}");

            Departamento d = new Departamento();
            string nomeDpto = "Informatica";
            d.Nome = nomeDpto;

            //Console.WriteLine($"Departamento: {nomeDpto}");
            Departamento d1 = new Departamento();
            string nomeDpto1 = "Redes";
            d1.Nome = nomeDpto1 ;

            Departamento d2 = new Departamento();
            string nomeDpto2 = "Jogos";
            d2.Nome = nomeDpto2;
            Departamento d3 = new Departamento();
            string nomeDpto3 = "RTV";
            d3.Nome = nomeDpto3; 

            ie1.RegistrarDepartamento(d);
            ie1.RegistrarDepartamento(d1);
            ie1.RegistrarDepartamento(d2);
            ie1.RegistrarDepartamento(d3);


            /*Departamentos na IE*/

            for (int i = 0; i < ie1.ObterQuantidadeDepartamentos(); i++)
            {
                Console.WriteLine($"==>	{ie1.Departamentos[i].Nome}");

            }

            Console.WriteLine(ie1.ObterQuantidadeDepartamentos());


    }
    }
}
