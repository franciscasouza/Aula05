using System;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Criando a Instituição*/

            Instituicao ie1 = new Instituicao
            {

                Nome = "Ceet Vasco Coutinho",
                Endereco = new Endereco()
                {
                    Rua = "Luciano das Neves",
                    Bairro = "Centro de Vila Velha",
                    Numero = "s/n"
                }

            };

            /*Exibindo dados da Instituição*/
            Console.WriteLine(ie1.Nome);
            Console.WriteLine("Rua: " + ie1.Endereco.Rua);
            Console.WriteLine("Bairro: " + ie1.Endereco.Bairro);
            Console.WriteLine("Numero: " + ie1.Endereco.Numero);

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Departamentos da Instituição: " + ie1.Nome);
            Console.WriteLine();
            Console.ReadKey();

            /*Criando os Departamentos*/

            Departamento d = new Departamento();
            string nomeDpto = "Tecnologia da Informação";
            d.Nome = nomeDpto;

            Departamento d1 = new Departamento();
            string nomeDpto1 = "Gestão e Negocios";
            d1.Nome = nomeDpto1;

            Departamento d2 = new Departamento();
            string nomeDpto2 = "Produção e Moda";
            d2.Nome = nomeDpto2;

            Departamento d3 = new Departamento();
            string nomeDpto3 = "Eventos";
            d3.Nome = nomeDpto3;
            /*Fim criar departamento*/

            /*Registrando para a instituição ie1 os departamentos dela*/
            ie1.RegistrarDepartamento(d);
            ie1.RegistrarDepartamento(d1);
            ie1.RegistrarDepartamento(d2);
            ie1.RegistrarDepartamento(d3);


            /*Listando os departamentos na IE*/

            for (int i = 0; i < ie1.ObterQuantidadeDepartamentos(); i++)
            {
                Console.WriteLine($"==>	{ie1.Departamentos[i].Nome}");

            }


            Console.WriteLine("Cursos do Departamento " + d.Nome);

            Console.ReadKey();

            /*Inserindo os cursos de cada departamento*/

            d.RegistrarCurso(new Curso
            {
                Nome = "Ciência de Dados",
                CargaHoraria = 1200,
            });
            d.RegistrarCurso(new Curso
            {
                Nome = "Informática Báscica",
                CargaHoraria = 200,
            });

            /*Mostrando os cursos inseridos*/
            foreach (var curso in d.Cursos)
            {
                Console.WriteLine($"==>	{curso.Nome}	({curso.CargaHoraria}h)");
            }

            /*Fechar o departamento*/

            d.FecharDepartamento();
            d.Nome = null;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("O	departamento	de	Tecnologia da Informação 	foi	fechado");
            Console.ReadKey();

            /*Mostrar os departamentos com a retirada de um deles*/

            for (int i = 0; i < ie1.ObterQuantidadeDepartamentos(); i++)
            {
                Console.WriteLine($"==>	{ie1.Departamentos[i].Nome}");

            }

            var ctAlimentos = new Curso()
            {
                Nome = "Tecnologia	em	Alimentos",
                CargaHoraria = 2000
            };

            if (!d.Cursos.Contains(ctAlimentos))
                d.RegistrarCurso(ctAlimentos);
            Console.ReadKey();
            /*Mostrando os cursos inseridos*/

            /*Inserindo os cursos de cada departamento*/

            d.RegistrarCurso(new Curso
            {
                Nome = "Ciência de Dados",
                CargaHoraria = 1200,
            });
            d.RegistrarCurso(new Curso
            {
                Nome = "Informática Báscica",
                CargaHoraria = 200,
            });

            /*Mostrando os cursos inseridos*/
            foreach (var curso in d.Cursos)
            {
                Console.WriteLine($"==>	{curso.Nome}	({curso.CargaHoraria}h)");
            }



        }
    }
}
