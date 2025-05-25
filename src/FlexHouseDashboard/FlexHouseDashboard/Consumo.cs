using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CsvHelper;
using CsvHelper.Configuration;
using SATAUiFramework; // Supondo que você tenha um namespace para o SATAFramework

public partial class Consumo :Form
{
    private Dictionary<string, List<ConsumoData>> dadosPorComodo;
    private string[] comodos = { "Cozinha", "Piscina", "Quarto 01", "Quarto 02", "Sala" };
    private int mesAtual = DateTime.Now.Month;
    private int comodoAtual = 0;

    public class ConsumoDataMap : ClassMap<ConsumoData>
    {
        public ConsumoDataMap()
        {
            Map(m => m.Data).TypeConverterOption.Format("dd/MM/yyyy");
            Map(m => m.Sensor);
            Map(m => m.Hora_Ativo);
            Map(m => m.ConsumoWH);
        }
    }

    public Consumo()
    {
        InitializeComponent();
        CarregarDados();
        CriarGrafico();
    }

    private void CarregarDados()
    {
        dadosPorComodo = new Dictionary<string, List<ConsumoData>>();

        foreach (var comodo in comodos)
        {
            var dados = LerDadosCsv(comodo);
            dadosPorComodo[comodo] = dados;
        }
    }

    private List<ConsumoData> LerDadosCsv(string comodo)
    {
        var dados = new List<ConsumoData>();
        string filePath = $"filePath/Ordenado_{comodo}_2025.csv";

        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, new CsvHelper.Configuration.CsvConfiguration(CultureInfo.GetCultureInfo("pt-BR"))
        {
            Delimiter = ";"
        }))
        {
            dados = csv.GetRecords<ConsumoData>().ToList();
        }

        return dados;
    }


    private void CriarGrafico()
    {
        try
        {
            grafico.Series.Clear();

            var serie = new Series(comodos[comodoAtual]);
            serie.ChartType = SeriesChartType.Line;

            var dadosMes = dadosPorComodo[comodos[comodoAtual]]
                .Where(d => d.Data.Month == mesAtual)
                .ToList();

            foreach (var dado in dadosMes)
            {
                serie.Points.AddXY(dado.Data.ToString("dd/MM"), dado.ConsumoWH / 1000);
            }

            grafico.Series.Add(serie);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao criar gráfico:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    

    private void btnMesAnterior_Click(object sender, EventArgs e)
    {
        mesAtual = (mesAtual == 1) ? 12 : mesAtual - 1; // Muda para o mês anterior
        CriarGrafico();
    }

    private void btnProximoComodo_Click(object sender, EventArgs e)
    {
        comodoAtual = (comodoAtual + 1) % comodos.Length; // Muda para o próximo cômodo
        CriarGrafico();
    }

    private void btnComodoAnterior_Click(object sender, EventArgs e)
    {
        comodoAtual = (comodoAtual == 0) ? comodos.Length - 1 : comodoAtual - 1; // Muda para o cômodo anterior
        CriarGrafico();
    }

    private void btnProximoMes_Click(object sender, EventArgs e)
    {
        mesAtual = (mesAtual % 12) + 1; // Muda para o próximo mês
        CriarGrafico();
    }

    private void btnProxComodo_Click(object sender, EventArgs e)
    {
        comodoAtual = (comodoAtual + 1) % comodos.Length; // Muda para o próximo cômodo
        CriarGrafico();
    }

    private void btnMesAnt_Click(object sender, EventArgs e)
    {
        mesAtual = (mesAtual == 1) ? 12 : mesAtual - 1; // Muda para o mês anterior
        CriarGrafico();
    }

    private void btnComodoAnt_Click(object sender, EventArgs e)
    {
        comodoAtual = (comodoAtual == 0) ? comodos.Length - 1 : comodoAtual - 1; // Muda para o cômodo anterior
        CriarGrafico();
    }

    private void btnProxMes_Click(object sender, EventArgs e)
    {
        mesAtual = (mesAtual % 12) + 1; // Muda para o próximo mês
        CriarGrafico();
    }
}

public class ConsumoData
{
    public DateTime Data { get; set; }
    public string Sensor { get; set; }
    public string Hora_Ativo { get; set; }
    public double ConsumoWH { get; set; }
}
