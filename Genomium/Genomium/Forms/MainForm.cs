using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genomium
{
    public partial class MainForm : Form
    {
        List<Organismo> Organismos = new List<Organismo>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "CSV|*.csv|txt (*.txt)|*.txt|All files (*.*)|*.*", ValidateNames = true, Multiselect = false })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                        ProcessarCSV(openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ProcessarCSV(string caminho)
        {
            try
            {
                string[] linhas = System.IO.File.ReadAllLines(caminho);

                //le o arquivo por partes
                Parallel.ForEach(linhas, new ParallelOptions() { MaxDegreeOfParallelism = 8 }, linha =>
                        {
                            string[] dados = linha.Split(';');
                            Organismos.Add(new Organismo(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7]));

                        });

                this.gvDados.AutoGenerateColumns = false;

                this.gvDados.DataSource = Organismos;


                //List<Organismo> ll = new List<Organismo>();
                //    ll =  Organismos.OrderBy(x => x.Gene).ThenBy(x => x.Nome).ToList();

                //this.gvDados.DataSource = ll;
            }
            catch (AggregateException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        //public void Ordenar(List<Organismo> organismo)
        //{
        //    Task<List<Organismo>> ordenarPorGene = Task.Factory.StartNew(() =>
        //    {
        //        organismo.OrderBy(o => o.Gene).ToList();

        //        return organismo;
        //    });


        //    //await ordenarPorGene.ContinueWith();

        //    Task<List<Organismo>> ordenarPorNome = ordenarPorGene.ContinueWith(ordenarPorGene , ) =>  {
        //        return organismo.OrderBy(o => o.Nome).ToList();
        //    });

        //}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void lblAlunos_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string title = "Sobre";
            string texto = "Trabalho de Fundamentos de Sistemas Operacionais\n" +
                "Alunos :  Bruno Jonatha Orlandy\n" +
                "Jessica Da Silva Pavan\n" +
                "Vinicius Molon Toigo\n" +
                "Codigo fonte :https://github.com/BrunoOrlandy/Genoma-fundamentos-SO";
            MessageBox.Show(texto, title);
        }

        private void gvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv|txt (*.txt)|*.txt";
            sfd.FileName = "OutputGenoma.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Os dados serão exportados e você será notificado quando estiver pronto.");
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Não foi possível gravar os dados no disco." + ex.Message);
                    }
                }

                var query = (from organimo in Organismos.AsParallel()
                             orderby organimo.Gene
                             select new { Details = organimo.Nome }).AsSequential().Take(5);

                DataGridView dt = new DataGridView();
                //  dt.DataSource =  Organismos.OrderBy(x => x.Gene).ThenBy(x => x.Nome).ToArray();
                dt.DataSource = query;

                int columnCount = gvDados.ColumnCount;
                string columnNames = "";
                string[] output = new string[gvDados.RowCount + 1];
                for (int i = 0; i < columnCount; i++)
                {
                    columnNames += gvDados.Columns[i].Name.ToString() + ";";
                }
                output[0] += columnNames;
                for (int i = 1; (i - 1) < gvDados.RowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        //output[i] += dataGridView.Rows[i - 1].Cells[j].Value.ToString() + ",";
                        if (gvDados.Rows[i - 1].Cells[j].Value != null) output[i] += gvDados.Rows[i - 1].Cells[j].Value.ToString() + ";";
                    }
                }
                System.IO.File.WriteAllLines(sfd.FileName, output, System.Text.Encoding.UTF8);
                MessageBox.Show("Arquivo foi gerado e está pronto para uso.");

                this.gvDados.DataSource = new List<Organismo>();
            }
        }
    }
}
