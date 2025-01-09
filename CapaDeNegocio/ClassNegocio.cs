using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDados;
using CapaDeEntidade;

namespace CapaDeNegocio
{
    public class ClassNegocio
    {
        ClasseDados clsdados = new ClasseDados();
        public DataTable N_Login(ClassEntidade obje)
        {
            if (obje.user.Length > 20 || obje.passe.Length > 10)
                throw new Exception("Usuário ou senha excedem o limite permitido.");

            return clsdados.D_Login(obje);
        }

        public DataTable N_Buscar(ClassEntidade obje)
        {
            if (string.IsNullOrEmpty(obje.nome)) 
                throw new Exception("O nome não pode ser nulo ou vazio.");
            if (obje.nome.Length > 50) 
                throw new Exception("O nome excede o limite de 50 caracteres.");
            return clsdados.D_Buscar(obje);
        }

        public DataTable N_Listar(ClassEntidade obje)
        {
            return clsdados.D_Listar();
        }

        public String N_Procurar(ClassEntidade obje)
        {
            return clsdados.D_Procurar(obje);
        }
    }
}
