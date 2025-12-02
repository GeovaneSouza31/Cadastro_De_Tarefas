using Cadastro_De_Tarefas.Controller;

namespace Cadastro_De_Tarefas
{
    public partial class Form1 : Form
    {
        TarefaController controller = new TarefaController();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Pendente");
            comboBox1.Items.Add("Concluído");
            comboBox1.Items.Add("Em andamento");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string nome = txttarefa.Text;
            DateTime data = dateTimePicker1.Value;
            string status = comboBox1.Text.ToString();

            
            controller.AdicionarTarefa(nome, data, status);

            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controller.ObterTarefas();
        }
    }
}
