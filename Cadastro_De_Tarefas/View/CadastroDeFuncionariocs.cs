using Cadastro_De_Tarefas.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_De_Tarefas.View
{
    public partial class CadastroDeFuncionariocs : Form
    {
        FuncionarioController controller = new FuncionarioController();
        public CadastroDeFuncionariocs()
        {
            InitializeComponent();
        }

        private void CadastroDeFuncionariocs_Load(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string nome = TxtNome.Text;
            DateTime data = dtm.Value;
            string email = txtEmail.Text;
            int Id = Convert.ToInt32(txtID);

        }
    }
}
