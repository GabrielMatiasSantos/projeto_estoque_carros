using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Aplicacao.Dtos.Formularios;
using estoque_carros.Aplicacao.Interfaces.Servicos;
using estoque_carros.CamadaApresentacao.Helpers;


namespace estoque_carros.Apresentacao.Formularios
{
    public partial class frmCarroInserirAlterarDeletar : Form
    {
        private CarroDto? carro;

        public CarroDto? Carro
        {
            get { return carro; }
            set { carro = value; }
        }

        public enum FormularioFuncao
        {
            Inserir,
            AlterarDeletar
        }

        public FormularioFuncao formularioFuncao;

        private int id;

        private readonly CorServicoInterface _corServico;
        private readonly MarcaServicoInterface _marcaServico;
        private readonly ModeloServicoInterface _modeloServico;
        private readonly CarroServicoInterface _carroServico;

        public frmCarroInserirAlterarDeletar(Formulario2Dto dto, CorServicoInterface corServico, MarcaServicoInterface marcaServico, ModeloServicoInterface modeloServico, CarroServicoInterface carroServico)
        {
            InitializeComponent();

            _corServico = corServico;
            _marcaServico = marcaServico;
            _modeloServico = modeloServico;
            _carroServico = carroServico;

            FormularioDados(dto);
        }

        private async void frmCarroInserirAlterarDeletar_Load(object sender, EventArgs e)
        {
            await CarregarFormulario();
        }

        private void txtKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Caracteres.Km(e);
        }

        private void txtKm_TextChanged(object sender, EventArgs e)
        {
            KmFormatar();
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Caracteres.Preco(e, txtPreco);
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            PrecoFormatar();
        }

        private void txtObservacoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Caracteres.Texto(e, txtObservacoes.Text);
        }

        private void chbDirecaoHidraulica_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxDirecaoHidraulica();
        }

        private void chbDirecaoEletrica_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxDirecaoEletrica();
        }

        private async void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            await ComboBoxModelos();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            await InserirCarro();
        }

        private async void btnAlterar_Click(object sender, EventArgs e)
        {
            await AlterarCarro();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            await ExcluirCarro();
        }
    }
}
