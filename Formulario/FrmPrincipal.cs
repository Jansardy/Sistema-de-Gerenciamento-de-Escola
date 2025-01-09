using CapaDeEntidade;
using CapaDeNegocio;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FrmPrincipal : Form
    {
        ClassEntidade objE = new ClassEntidade();
        ClassNegocio objN = new ClassNegocio();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void HoraData_Tick(object sender, EventArgs e)
        {
            lblhora.Text = "Data: " + DateTime.Now.ToString("dd/MM/yyyy") + " Horas: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            HoraData.Start();
            lblusuario.Text = "Usuário: " + frm_login.usuario_nome + "   Função: " + frm_login.usuario_geral;
            if((frm_login.id_tipo == "T0001") || (frm_login.id_tipo == "T0002"))
            {
                picboxAluno.Enabled = true;
                picboxCurso.Enabled = true;
                picboxSala.Enabled = true;
                picboxUser.Enabled = true;
            }
        }

        private void picboxFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
