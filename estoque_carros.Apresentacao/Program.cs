using estoque_carros.Aplicacao.CriarArquivos;
using estoque_carros.Aplicacao.Interfaces;
using estoque_carros.Aplicacao.Interfaces.Servicos;
using estoque_carros.Aplicacao.Servicos;
using estoque_carros.Apresentacao.Formularios;
using estoque_carros.Apresentacao.Interfaces;
using estoque_carros.Apresentacao.Mediadores;
using estoque_carros.Dominio.Interfaces;
using estoque_carros.Dominio.Interfaces.Repositorios;
using estoque_carros.Infraestrutura;
using estoque_carros.Infraestrutura.CriarArquivos;
using estoque_carros.Infraestrutura.Interfaces;
using estoque_carros.Infraestrutura.Repositorios;
using System.Runtime.Versioning;


namespace estoque_carros.Apresentacao
{
    [SupportedOSPlatform("windows")]

    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StringConexaoInterface stringConexao = new StringConexao();
            CriarConexaoInterface criarConexao = new CriarConexao(stringConexao);
            CriarLogsInterface criarLog = new CriarLogs();


            CorRepositorio cor = new CorRepositorio(criarConexao);
            CorRepositorioInterface corRepositorio = cor;
            CorPesquisarInterface corPesquisar = cor;

            MarcaRepositorio marca = new MarcaRepositorio(criarConexao);
            MarcaRepositorioInterface marcaRepositorio = marca;
            MarcaPesquisarInterface marcaPesquisar = marca;
            
            ModeloRepositorio modelo = new ModeloRepositorio(criarConexao);
            ModeloRepositorioInterface modeloRepositorio = modelo;
            ModeloPesquisarInterface modeloPesquisar= modelo;

            CarroRepositorio carro = new CarroRepositorio(criarConexao);
            CarroRepositorioInterface carroRepositorio = carro;
            CarroPesquisarInterface carroPesquisar = carro;

            
            FormulariosMediadorInterface formulario = new FormulariosMediador();

            CorServicoInterface corServico = new CorServico(corRepositorio, corPesquisar, criarLog);
            MarcaServicoInterface marcaServico = new MarcaServico(marcaRepositorio, marcaPesquisar, criarLog);
            ModeloServicoInterface modeloServico = new ModeloServico(modeloRepositorio, modeloPesquisar, criarLog);
            CarroServicoInterface carroServico = new CarroServico(carroRepositorio, carroPesquisar, criarLog);
            CriarPdfInterface criarPdfServico = new CriarPdf(carroPesquisar, criarConexao, criarLog);
            
            Application.Run(new frmCarrosEstoque(formulario, corServico, marcaServico, modeloServico, carroServico, criarPdfServico));                            
        }
    }
}
