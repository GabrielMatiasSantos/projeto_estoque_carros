using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Aplicacao.Dtos.Formularios;
using estoque_carros.Aplicacao.Servicos.Interfaces;
using estoque_carros.CamadaApresentacao.Helpers;
using estoque_carros.Dtos;
using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estoque_carros.CamadaApresentacao.Formularios
{
    public partial class frmMarcaModeloCorAlterarDeletar : Form
    {
        private CorDto cor;
        private MarcaDto marca;
        private ModeloDto modelo;

        public CorDto Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public MarcaDto Marca
        {
            get { return marca; }
            set {  marca = value; }
        }

        public ModeloDto Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private int id;

        private int modeloMarca;

        public enum Aba
        {
            Cor,
            Marca,
            Modelo
        }

        private Aba abaAtual;
       
        public Aba AbaAtual
        {
            get {  return abaAtual; }
            set {  abaAtual = value; }
        }


        private readonly CorServicoInterface _corServico;
        private readonly MarcaServicoInterface _marcaServico;
        private readonly ModeloServicoInterface _modeloServico;
        private readonly CarroServicoInterface _carroServico;


        public frmMarcaModeloCorAlterarDeletar(Formulario1Dto dto, CorServicoInterface corServico)
        {
            InitializeComponent();

            _corServico = corServico;

            FormularioDados(dto);
        }

        public frmMarcaModeloCorAlterarDeletar(Formulario1Dto dto, MarcaServicoInterface marcaServico)
        {
            InitializeComponent();

            _marcaServico = marcaServico;

            FormularioDados(dto);
        }

        public frmMarcaModeloCorAlterarDeletar(Formulario1Dto dto, MarcaServicoInterface marcaServico, ModeloServicoInterface modeloServico, CarroServicoInterface carroServico)
        {
            InitializeComponent();

            _marcaServico = marcaServico;
            _modeloServico = modeloServico;
            _carroServico = carroServico;

            FormularioDados(dto);
        }

        private async void frmMarcaModeloCorAlterarDeletar_Load(object sender, EventArgs e)
        {
            await CarregarFormulario();
        }


        private void txtMarcaModeloCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            CaracteresTextBox(e, txtMarcaModeloCor);
        }

        private async void btnAlterar_Click(object sender, EventArgs e)
        {
            await Alterar();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            await Excluir();
        }
    }
}
