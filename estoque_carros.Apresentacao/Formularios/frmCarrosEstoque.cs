using estoque_carros.Aplicacao.Interfaces;
using estoque_carros.Aplicacao.Interfaces.Servicos;
using estoque_carros.Apresentacao.Interfaces;
using estoque_carros.CamadaApresentacao.Helpers;


namespace estoque_carros.Apresentacao.Formularios
{
    public partial class frmCarrosEstoque : Form
    {        
        private readonly FormulariosMediadorInterface _formulario;
        private readonly CorServicoInterface _corServico;
        private readonly MarcaServicoInterface _marcaServico;
        private readonly ModeloServicoInterface _modeloServico;
        private readonly CarroServicoInterface _carroServico;
        private readonly CriarPdfInterface _criarPdfServico;


        public frmCarrosEstoque(FormulariosMediadorInterface formulario, CorServicoInterface corServico, MarcaServicoInterface marcaServico, ModeloServicoInterface modeloServico, CarroServicoInterface carroServico, CriarPdfInterface criarPdfServico)
        {
            InitializeComponent();
            
            _formulario = formulario;   
            _corServico = corServico;
            _marcaServico = marcaServico;
            _modeloServico = modeloServico;
            _carroServico = carroServico;
            _criarPdfServico = criarPdfServico;
        }     


        private void frmCarrosEstoque_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
        //Aba 'Cores'


        private async void tabCores_Enter(object sender, EventArgs e)
        {
            await EntrarAbaCores();
        }

        private async void btnCorSalvar_Click(object sender, EventArgs e)
        {
            await InserirCor();
        }

        private void txtCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Caracteres.Nome1(e, txtCor.Text);
        }

        private void txtPesquisarCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Caracteres.Nome1(e, txtPesquisarCor.Text);
        }

        private async void txtPesquisarCor_TextChanged(object sender, EventArgs e)
        {
            await PesquisarCor();
        }

        private async void dgvCores_DoubleClick(object sender, EventArgs e)
        {
            await CorDuploClique();
        }


        //Aba ''Marcas'


        private async void tabMarcas_Enter(object sender, EventArgs e)
        {
            await EntrarAbaMarcas();
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Caracteres.Nome1(e, txtMarca.Text);
        }

        private void txtPesquisarMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Caracteres.Nome1(e, txtPesquisarMarca.Text);
        }

        private async void txtPesquisarMarca_TextChanged(object sender, EventArgs e)
        {
            await PesquisarMarca();
        }

        private async void btnMarcaSalvar_Click(object sender, EventArgs e)
        {
            await InserirMarca();
        }

        private async void dgvMarcas_DoubleClick(object sender, EventArgs e)
        {
            await MarcaDuploClique();
        }


        //Aba 'Modelos'


        private async void tabModelos_Enter(object sender, EventArgs e)
        {
            await EntrarAbaModelos();
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Caracteres.Nome2(e, txtModelo.Text);
        }

        private void txtPesquisarModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Caracteres.Nome2(e, txtPesquisarModelo.Text);
        }

        private async void txtPesquisarModelo_TextChanged(object sender, EventArgs e)
        {
            await PesquisarModelo();
        }

        private async void btnModeloSalvar_Click(object sender, EventArgs e)
        {
            await InserirModelo();
        }

        private async void dgvModelos_DoubleClick(object sender, EventArgs e)
        {
            await ModeloDuploClique();
        }


        //Aba 'Carros - estoque'
 
        
        private async void tabEstoqueCarros_Enter(object sender, EventArgs e)
        {
            await EntrarAbaCarros();
        }

        private void txtPesquisarCarro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Caracteres.Nome2(e, txtPesquisarCarro.Text);
        }

        private async void btnInserir_Click(object sender, EventArgs e)
        {
            await InserirCarroAbrirFormulario();
        }

        private async void dgvCarros_DoubleClick(object sender, EventArgs e)
        {
            await CarroDuploClique();
        }

        private async void txtPesquisarCarro_TextChanged(object sender, EventArgs e)
        {
            await PesquisarCarro();
 ;      }

        private async void btnImprimir_Click(object sender, EventArgs e)
        {
            await EstoqueImprimir();
        }
    }
}

