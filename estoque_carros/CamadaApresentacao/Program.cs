using estoque_carros.CamadaApresentacao.Formularios;
using estoque_carros.Aplicacao.Servicos;
using estoque_carros.Aplicacao.Servicos.Interfaces;
using estoque_carros.Repositórios;
using estoque_carros.Repositórios.Interfaces;
using estoque_carros.Serviços;
using estoque_carros.Serviços.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using estoque_carros.Infraestrutura;
using estoque_carros.Dominio;

namespace estoque_carros
{
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

            StringConexaoInterface stringConexao = new StringConexaoServico();
            CriarConexaoInterface criarConexao = new CriarConexao(stringConexao);
            

            CorRepositorioInterface corRepositorio = new CorRepositorio();
            MarcaRepositorioInterface marcaRepositorio = new MarcaRepositorio();
            ModeloRepositorioInterface modeloRepositorio = new ModeloRepositorio();
            CarroRepositorioInterface carroRepositorio = new CarroRepositorio();

            
            AbrirFormularioInterface formulario = new AbrirFormulárioServico();

            CorServicoInterface corServico = new CorServico(corRepositorio, criarConexao);
            MarcaServicoInterface marcaServico = new MarcaServico(marcaRepositorio, criarConexao);
            ModeloServicoInterface modeloServico = new ModeloServico(modeloRepositorio, criarConexao);
            CarroServicoInterface carroServico = new CarroServico(carroRepositorio, criarConexao);
            CriarPdfServicoInterface criarPdfServico = new CriarPdfServico(carroRepositorio, criarConexao);
            
            Application.Run(new frmCarrosEstoque(formulario, corServico, marcaServico, modeloServico, carroServico, criarPdfServico));                            
        }
    }
}
