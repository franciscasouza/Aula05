using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05
{
    public class Instituicao
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        /*Criar a associação entre Instituição e Departamento*/

        public Departamento[] Departamentos { get; } = new Departamento[10];


        /**Variável Privada*/

        private int quantidadeDepartamentos = 0;

        public void RegistrarDepartamento(Departamento d)
        {
            if  (quantidadeDepartamentos < 10)
                Departamentos[quantidadeDepartamentos++] = d;
        }

        public int ObterQuantidadeDepartamentos()
        {
            return quantidadeDepartamentos;
        }

    }
}
