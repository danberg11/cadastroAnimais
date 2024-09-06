using cadastroAnimal.Controller;
using cadastroAnimal.Model;

namespace cadastroAnimais
{
    public partial class TelaCadastroAnimais : Form
    {
        public TelaCadastroAnimais()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animais.Nome = tbx_name.Text;
            Animais.Raca = tbx_Raca.Text;
            Animais.Porte = cbx_Porte.Text;

            ControllerAnimais controllerAnimais = new ControllerAnimais();
            controllerAnimais.EnviarBanco();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
