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

            return clsdados.DLogin(obje);
        }
    }
}
