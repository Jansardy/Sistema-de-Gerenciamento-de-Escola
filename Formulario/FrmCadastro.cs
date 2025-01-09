using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeEntidade;
using CapaDeNegocio;

namespace Formulario
{
    public partial class frm_login : Form
    {
        ClassNegocio ClsUser = new ClassNegocio();
        ClassEntidade ClsEntidade = new ClassEntidade();

        public static string usuario_nome;
        public static string id_tipo;
        public static string usuario_geral;
        public static string usuario_Codigo;

        FrmPrincipal frmPrincipal = new FrmPrincipal();
        public frm_login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }
        private void Limpar()
        {
            TxtBox_user.Text = "";
            TxtBox_password.Text = "";
        }
        private void form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CapaDeNegocio.ClassNegocio negocio = new CapaDeNegocio.ClassNegocio();

                ClassEntidade entidade = new ClassEntidade
                {
                    user = TxtBox_user.Text.Trim(),
                    passe = TxtBox_password.Text.Trim()
                };

                DataTable dt = negocio.N_Login(entidade);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login bem-sucedido! " + dt.Rows[0][0].ToString().ToUpper(), "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usuario_nome = dt.Rows[0][0].ToString();
                    id_tipo = dt.Rows[0][1].ToString();
                    usuario_geral = dt.Rows[0][2].ToString();
                    usuario_Codigo = dt.Rows[0][3].ToString();
                    this.Hide();
                    frmPrincipal.ShowDialog();
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
