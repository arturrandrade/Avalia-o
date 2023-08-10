namespace Avalição
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Correntista correntista = new Correntista(Convert.ToInt32(txtId.Text), txtCPF, txtNome.Text,

                MessageBox.Show("correntista adicionado com sucesso\n(correntista.Id):(correntista.Nome)", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    ));

               
            }
            catch (FormatException ex)

            {
                MessageBox.Show($"{ex.HResult} - Formato inválido!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.HResult} - {ex.Message}");
               
            }


            txtNome.Focus();
            txtId.Focus();
            txtCPF.Focus();
            txtDataNascimento.Focus();
            txtRendaMensal.Focus();








        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}