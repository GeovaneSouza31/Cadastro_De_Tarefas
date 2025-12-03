namespace Cadastro_De_Tarefas.View
{
    partial class CadastroDeFuncionariocs
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtm = new DateTimePicker();
            label6 = new Label();
            txtID = new TextBox();
            TxtNome = new TextBox();
            txtEmail = new TextBox();
            btncadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(422, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(319, 42);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Funcionários";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(343, 270);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(33, 23);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(313, 311);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(205, 347);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(171, 23);
            label4.TabIndex = 3;
            label4.Text = "Data de Nascimento:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(317, 386);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 23);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // dtm
            // 
            dtm.Location = new Point(384, 347);
            dtm.Margin = new Padding(4, 4, 4, 4);
            dtm.Name = "dtm";
            dtm.Size = new Size(284, 29);
            dtm.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(312, 184);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(509, 25);
            label6.TabIndex = 6;
            label6.Text = "Insira os dados do para fazer o cadastro do funcionário:";
            // 
            // txtID
            // 
            txtID.Location = new Point(384, 270);
            txtID.Name = "txtID";
            txtID.Size = new Size(202, 29);
            txtID.TabIndex = 7;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(384, 311);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(387, 29);
            TxtNome.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(384, 386);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(202, 29);
            txtEmail.TabIndex = 9;
            // 
            // btncadastrar
            // 
            btncadastrar.BackColor = SystemColors.HotTrack;
            btncadastrar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncadastrar.ForeColor = SystemColors.ButtonHighlight;
            btncadastrar.Location = new Point(384, 448);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(214, 35);
            btncadastrar.TabIndex = 10;
            btncadastrar.Text = "Cadastrar";
            btncadastrar.UseVisualStyleBackColor = false;
            // 
            // CadastroDeFuncionariocs
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 867);
            Controls.Add(btncadastrar);
            Controls.Add(txtEmail);
            Controls.Add(TxtNome);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(dtm);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "CadastroDeFuncionariocs";
            Text = "CadastroDeFuncionariocs";
            Load += CadastroDeFuncionariocs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtm;
        private Label label6;
        private TextBox txtID;
        private TextBox TxtNome;
        private TextBox txtEmail;
        private Button btncadastrar;
    }
}