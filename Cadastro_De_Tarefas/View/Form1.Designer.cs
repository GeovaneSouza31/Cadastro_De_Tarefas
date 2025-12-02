namespace Cadastro_De_Tarefas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(897, 92);
            button1.Name = "button1";
            button1.Size = new Size(265, 34);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar Tarefa";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 83);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 3;
            label1.Text = "Tarefa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(251, 86);
            label2.Name = "label2";
            label2.Size = new Size(68, 32);
            label2.TabIndex = 4;
            label2.Text = "Data:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(583, 94);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 6;
            label3.Text = "Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(462, 9);
            label4.Name = "label4";
            label4.Size = new Size(310, 45);
            label4.TabIndex = 7;
            label4.Text = "Cadastro de tarefas";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(325, 92);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 31);
            dateTimePicker1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(672, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(874, 225);
            dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 464);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
    }
}
