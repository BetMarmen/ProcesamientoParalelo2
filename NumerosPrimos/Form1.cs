using System.Diagnostics;

namespace NumerosPrimos
{
    public partial class Form1 : Form
    {
        private NumberRepository _repository;

        public Form1()
        {
            InitializeComponent();
            _repository = new NumberRepository();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int start = (int)numInicio.Value;
            int end = (int)numFin.Value;

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var processor = new PrimeNumberProcessor(_repository);
            var primes = processor.FindPrimesInRange(start, end);

            stopwatch.Stop();

            lstNum.Items.Clear();
            foreach (var prime in primes)
            {
                lstNum.Items.Add(prime);
            }

            MessageBox.Show($"Se encontraron {primes.Count} números primos en el rango [{start}, {end}]. Tiempo transcurrido: {stopwatch.ElapsedMilliseconds} ms", "Resultados");
        }
    }
    }

