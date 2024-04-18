using System.Diagnostics;

namespace FactorialNumeros
{
    public partial class Form1 : Form
    {
        private NumberRepository _repository;
        public Form1()
        {
            InitializeComponent();
            _repository = new NumberRepository();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtNums.Text, out number))
            {
                _repository.Add(number);
                lstNums.Items.Add(number);
                txtNums.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número entero válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFactoriales_Click(object sender, EventArgs e)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var calculator = new FactorialCalculator(_repository);
            var factorials = calculator.CalculateFactorials();

            stopwatch.Stop();

            lstFactoriales.Items.Clear();
            foreach (var factorial in factorials)
            {
                lstFactoriales.Items.Add(factorial);
            }

            MessageBox.Show($"Se calcularon los factoriales de {factorials.Count} números en paralelo. Tiempo transcurrido: {stopwatch.ElapsedMilliseconds} ms", "Resultados");
        }
    }
    }

