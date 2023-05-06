using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json.Serialization;
using w.OrientacaoObjeto;
using WindowsFormExemplo.OrientacaoObjeto;

namespace WindowsFormExemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            int quantidadeHoras = Convert.ToInt32 (textBoxQuantidadeHoras.Text);
            double valorHora = Convert.ToDouble(textBoxValorHora.Text);

            FolhaPagamento folhaPagamento = new FolhaPagamento();
            folhaPagamento.NomeColaborador = nome;
            folhaPagamento.QuantidadeHoras = quantidadeHoras;
            folhaPagamento.ValorHora = valorHora;

            MessageBox.Show($@"Folha Pagamento: {folhaPagamento.NomeColaborador}
            Sálario Bruto: {folhaPagamento.CalcularSalarioBruto()}
            Desconto INSS: {folhaPagamento.CalcularInss()}");

            string jsonFolhaPagamento = JsonConverter.SerializeObject(folhaPagamento);
            File.WriteAllText("C:\\Users\\71780\\Desktop\\Arquivo.json", jsonFolhaPagamento);
        }
    }
}