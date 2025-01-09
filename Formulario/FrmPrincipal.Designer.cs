namespace Formulario
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlButtom = new System.Windows.Forms.Panel();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picboxUser = new System.Windows.Forms.PictureBox();
            this.picboxCurso = new System.Windows.Forms.PictureBox();
            this.picboxSala = new System.Windows.Forms.PictureBox();
            this.picboxAluno = new System.Windows.Forms.PictureBox();
            this.HoraData = new System.Windows.Forms.Timer(this.components);
            this.picboxFechar = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            this.pnlButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlTop.Controls.Add(this.picboxFechar);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 62);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlButtom
            // 
            this.pnlButtom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlButtom.Controls.Add(this.lblhora);
            this.pnlButtom.Controls.Add(this.lblusuario);
            this.pnlButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtom.Location = new System.Drawing.Point(0, 420);
            this.pnlButtom.Name = "pnlButtom";
            this.pnlButtom.Size = new System.Drawing.Size(800, 30);
            this.pnlButtom.TabIndex = 1;
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(379, 8);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(224, 17);
            this.lblhora.TabIndex = 3;
            this.lblhora.Text = "Data: 00/00/0000 Horas: 00:00:00";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(6, 8);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(65, 17);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "Usuário: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cadastro de Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cadastro de Salas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cadastro de Curso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(561, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cadastro de Usuários";
            // 
            // picboxUser
            // 
            this.picboxUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxUser.Enabled = false;
            this.picboxUser.Image = global::Formulario.Properties.Resources.ico_cadastro_userP;
            this.picboxUser.Location = new System.Drawing.Point(573, 121);
            this.picboxUser.Name = "picboxUser";
            this.picboxUser.Size = new System.Drawing.Size(100, 100);
            this.picboxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxUser.TabIndex = 9;
            this.picboxUser.TabStop = false;
            // 
            // picboxCurso
            // 
            this.picboxCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxCurso.Enabled = false;
            this.picboxCurso.Image = global::Formulario.Properties.Resources.ico_cadastro_cursoP;
            this.picboxCurso.Location = new System.Drawing.Point(411, 121);
            this.picboxCurso.Name = "picboxCurso";
            this.picboxCurso.Size = new System.Drawing.Size(100, 100);
            this.picboxCurso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxCurso.TabIndex = 7;
            this.picboxCurso.TabStop = false;
            // 
            // picboxSala
            // 
            this.picboxSala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxSala.Enabled = false;
            this.picboxSala.Image = global::Formulario.Properties.Resources.ico_cadastro_salaP;
            this.picboxSala.Location = new System.Drawing.Point(251, 121);
            this.picboxSala.Name = "picboxSala";
            this.picboxSala.Size = new System.Drawing.Size(100, 100);
            this.picboxSala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxSala.TabIndex = 5;
            this.picboxSala.TabStop = false;
            // 
            // picboxAluno
            // 
            this.picboxAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxAluno.Enabled = false;
            this.picboxAluno.Image = global::Formulario.Properties.Resources.ico_cadastro_alunoP;
            this.picboxAluno.Location = new System.Drawing.Point(92, 121);
            this.picboxAluno.Name = "picboxAluno";
            this.picboxAluno.Size = new System.Drawing.Size(100, 100);
            this.picboxAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxAluno.TabIndex = 2;
            this.picboxAluno.TabStop = false;
            // 
            // HoraData
            // 
            this.HoraData.Interval = 1000;
            this.HoraData.Tick += new System.EventHandler(this.HoraData_Tick);
            // 
            // picboxFechar
            // 
            this.picboxFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxFechar.Image = global::Formulario.Properties.Resources.ico_cancelar;
            this.picboxFechar.Location = new System.Drawing.Point(755, 13);
            this.picboxFechar.Name = "picboxFechar";
            this.picboxFechar.Size = new System.Drawing.Size(32, 32);
            this.picboxFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxFechar.TabIndex = 0;
            this.picboxFechar.TabStop = false;
            this.picboxFechar.Click += new System.EventHandler(this.picboxFechar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picboxUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picboxCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picboxSala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlButtom);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.picboxAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlButtom.ResumeLayout(false);
            this.pnlButtom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlButtom;
        private System.Windows.Forms.PictureBox picboxAluno;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picboxSala;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picboxCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picboxUser;
        private System.Windows.Forms.Timer HoraData;
        private System.Windows.Forms.PictureBox picboxFechar;
    }
}