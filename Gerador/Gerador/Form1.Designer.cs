using System.Windows.Forms;

namespace Gerador
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txClasse = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeral = new System.Windows.Forms.TabPage();
            this.txGeral = new System.Windows.Forms.TextBox();
            this.tabController = new System.Windows.Forms.TabPage();
            this.txController = new System.Windows.Forms.TextBox();
            this.tabModel = new System.Windows.Forms.TabPage();
            this.txModel = new System.Windows.Forms.TextBox();
            this.tabDao = new System.Windows.Forms.TabPage();
            this.txDao = new System.Windows.Forms.TextBox();
            this.txCampos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btCriar = new System.Windows.Forms.Button();
            this.txAviso = new System.Windows.Forms.TextBox();
            this.ckGrau = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txNamespace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txTabela = new System.Windows.Forms.TextBox();
            this.tabExe = new System.Windows.Forms.TabPage();
            this.txFields = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabGeral.SuspendLayout();
            this.tabController.SuspendLayout();
            this.tabModel.SuspendLayout();
            this.tabDao.SuspendLayout();
            this.tabExe.SuspendLayout();
            this.SuspendLayout();
            // 
            // txClasse
            // 
            this.txClasse.Location = new System.Drawing.Point(12, 27);
            this.txClasse.Name = "txClasse";
            this.txClasse.Size = new System.Drawing.Size(255, 20);
            this.txClasse.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGeral);
            this.tabControl1.Controls.Add(this.tabModel);
            this.tabControl1.Controls.Add(this.tabController);
            this.tabControl1.Controls.Add(this.tabDao);
            this.tabControl1.Controls.Add(this.tabExe);
            this.tabControl1.Location = new System.Drawing.Point(12, 346);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 265);
            this.tabControl1.TabIndex = 1;
            // 
            // tabGeral
            // 
            this.tabGeral.Controls.Add(this.txGeral);
            this.tabGeral.Location = new System.Drawing.Point(4, 22);
            this.tabGeral.Name = "tabGeral";
            this.tabGeral.Size = new System.Drawing.Size(768, 239);
            this.tabGeral.TabIndex = 4;
            this.tabGeral.Text = "Classe Geral";
            this.tabGeral.UseVisualStyleBackColor = true;
            // 
            // txGeral
            // 
            this.txGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txGeral.Location = new System.Drawing.Point(6, 6);
            this.txGeral.Multiline = true;
            this.txGeral.Name = "txGeral";
            this.txGeral.Size = new System.Drawing.Size(759, 233);
            this.txGeral.TabIndex = 0;
            // 
            // tabController
            // 
            this.tabController.BackColor = System.Drawing.Color.Pink;
            this.tabController.Controls.Add(this.txController);
            this.tabController.Location = new System.Drawing.Point(4, 22);
            this.tabController.Name = "tabController";
            this.tabController.Padding = new System.Windows.Forms.Padding(3);
            this.tabController.Size = new System.Drawing.Size(768, 239);
            this.tabController.TabIndex = 2;
            this.tabController.Text = "Controller";
            // 
            // txController
            // 
            this.txController.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txController.Location = new System.Drawing.Point(6, 6);
            this.txController.Multiline = true;
            this.txController.Name = "txController";
            this.txController.Size = new System.Drawing.Size(756, 227);
            this.txController.TabIndex = 0;
            // 
            // tabModel
            // 
            this.tabModel.BackColor = System.Drawing.Color.Khaki;
            this.tabModel.Controls.Add(this.txModel);
            this.tabModel.Location = new System.Drawing.Point(4, 22);
            this.tabModel.Name = "tabModel";
            this.tabModel.Padding = new System.Windows.Forms.Padding(3);
            this.tabModel.Size = new System.Drawing.Size(768, 239);
            this.tabModel.TabIndex = 0;
            this.tabModel.Text = "Model";
            // 
            // txModel
            // 
            this.txModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txModel.Location = new System.Drawing.Point(6, 6);
            this.txModel.Multiline = true;
            this.txModel.Name = "txModel";
            this.txModel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txModel.Size = new System.Drawing.Size(756, 227);
            this.txModel.TabIndex = 0;
            // 
            // tabDao
            // 
            this.tabDao.BackColor = System.Drawing.Color.Yellow;
            this.tabDao.Controls.Add(this.txDao);
            this.tabDao.Location = new System.Drawing.Point(4, 22);
            this.tabDao.Name = "tabDao";
            this.tabDao.Padding = new System.Windows.Forms.Padding(3);
            this.tabDao.Size = new System.Drawing.Size(768, 239);
            this.tabDao.TabIndex = 1;
            this.tabDao.Text = "DAO";
            // 
            // txDao
            // 
            this.txDao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txDao.Location = new System.Drawing.Point(9, 6);
            this.txDao.Multiline = true;
            this.txDao.Name = "txDao";
            this.txDao.Size = new System.Drawing.Size(753, 227);
            this.txDao.TabIndex = 0;
            // 
            // txCampos
            // 
            this.txCampos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCampos.Location = new System.Drawing.Point(289, 27);
            this.txCampos.Multiline = true;
            this.txCampos.Name = "txCampos";
            this.txCampos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txCampos.Size = new System.Drawing.Size(255, 263);
            this.txCampos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome da Classe:";
            // 
            // btCriar
            // 
            this.btCriar.Location = new System.Drawing.Point(360, 296);
            this.btCriar.Name = "btCriar";
            this.btCriar.Size = new System.Drawing.Size(110, 44);
            this.btCriar.TabIndex = 4;
            this.btCriar.Text = "Criar";
            this.btCriar.UseVisualStyleBackColor = true;
            this.btCriar.Click += new System.EventHandler(this.btCriar_Click);
            // 
            // txAviso
            // 
            this.txAviso.Location = new System.Drawing.Point(566, 27);
            this.txAviso.Multiline = true;
            this.txAviso.Name = "txAviso";
            this.txAviso.ReadOnly = true;
            this.txAviso.Size = new System.Drawing.Size(222, 263);
            this.txAviso.TabIndex = 7;
            // 
            // ckGrau
            // 
            this.ckGrau.AutoSize = true;
            this.ckGrau.Location = new System.Drawing.Point(12, 183);
            this.ckGrau.Name = "ckGrau";
            this.ckGrau.Size = new System.Drawing.Size(123, 17);
            this.ckGrau.TabIndex = 8;
            this.ckGrau.Text = "Model Grau Técnico";
            this.ckGrau.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Diretório do Namespace";
            // 
            // txNamespace
            // 
            this.txNamespace.Location = new System.Drawing.Point(12, 66);
            this.txNamespace.Name = "txNamespace";
            this.txNamespace.Size = new System.Drawing.Size(255, 20);
            this.txNamespace.TabIndex = 10;
            this.txNamespace.Text = "src";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tabela Referente a Classe";
            // 
            // txTabela
            // 
            this.txTabela.Location = new System.Drawing.Point(12, 105);
            this.txTabela.Name = "txTabela";
            this.txTabela.Size = new System.Drawing.Size(255, 20);
            this.txTabela.TabIndex = 12;
            // 
            // tabExe
            // 
            this.tabExe.Controls.Add(this.txFields);
            this.tabExe.Location = new System.Drawing.Point(4, 22);
            this.tabExe.Name = "tabExe";
            this.tabExe.Padding = new System.Windows.Forms.Padding(3);
            this.tabExe.Size = new System.Drawing.Size(768, 239);
            this.tabExe.TabIndex = 5;
            this.tabExe.Text = "Retorno";
            this.tabExe.UseVisualStyleBackColor = true;
            // 
            // txFields
            // 
            this.txFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txFields.Location = new System.Drawing.Point(6, 6);
            this.txFields.Multiline = true;
            this.txFields.Name = "txFields";
            this.txFields.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txFields.Size = new System.Drawing.Size(254, 227);
            this.txFields.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.txTabela);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txNamespace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckGrau);
            this.Controls.Add(this.txAviso);
            this.Controls.Add(this.btCriar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txCampos);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txClasse);
            this.Name = "Form1";
            this.Text = "Gerador de Classes PHP";
            this.tabControl1.ResumeLayout(false);
            this.tabGeral.ResumeLayout(false);
            this.tabGeral.PerformLayout();
            this.tabController.ResumeLayout(false);
            this.tabController.PerformLayout();
            this.tabModel.ResumeLayout(false);
            this.tabModel.PerformLayout();
            this.tabDao.ResumeLayout(false);
            this.tabDao.PerformLayout();
            this.tabExe.ResumeLayout(false);
            this.tabExe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txClasse;
        private TabControl tabControl1;
        private System.Windows.Forms.TabControl T;
        private System.Windows.Forms.TabPage tabModel;
        private System.Windows.Forms.TabPage tabDao;
        private System.Windows.Forms.TextBox txCampos;
        private System.Windows.Forms.TextBox txModel;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btCriar;
        private System.Windows.Forms.TabPage tabController;
        private System.Windows.Forms.TextBox txController;
        private System.Windows.Forms.TextBox txAviso;
        private TabPage tabGeral;
        private TextBox txGeral;
        private CheckBox ckGrau;
        private Label label2;
        private TextBox txNamespace;
        private TextBox txDao;
        private Label label3;
        private TextBox txTabela;
        private TabPage tabExe;
        private TextBox txFields;
    }
}

