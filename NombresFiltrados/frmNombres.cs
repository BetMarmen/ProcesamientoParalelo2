using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NombresFiltrados
{
    public partial class frmNombres : Form
    {
        private StringRepository _repository;

        public frmNombres()
        {
            InitializeComponent();
            _repository = new StringRepository();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string inputName = txtNames.Text.Trim();
            if (!string.IsNullOrEmpty(inputName))
            {
                _repository.Add(inputName);
                lstNombres.Items.Add(inputName);
                txtNames.Clear();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var processor = new StringProcessor(_repository);
            var namesWithE = processor.FilterStartingWithE();

            stopwatch.Stop();

            lstNombres.Items.Clear();
            foreach (var name in namesWithE)
            {
                lstNombres.Items.Add(name);
            }

            MessageBox.Show($"Se encontraron {namesWithE.Count} nombres que empiezan con 'E'. Tiempo transcurrido: {stopwatch.ElapsedMilliseconds} ms", "Resultados");
        }
    }
    }

