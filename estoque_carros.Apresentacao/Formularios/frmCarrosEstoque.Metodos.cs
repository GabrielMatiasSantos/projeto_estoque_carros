using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Apresentacao.Dtos;
using estoque_carros.Apresentacao.Helpers;
using estoque_carros.CamadaApresentacao.Helpers;
using estoque_carros.Dominio.Resultados;
using System.Runtime.Versioning;


namespace estoque_carros.Apresentacao.Formularios
{
    [SupportedOSPlatform("windows")]

    public partial class frmCarrosEstoque 
    {
        //Aba 'Cores'

        private async Task TabelaAbaCores()
        {            
          Resultado1<List<CorDto>> resultado = await _corServico.PesquisarTudo();

          if (resultado.Sucesso)
          {
             dgvCores.DataSource = resultado.Dados;

             dgvCores.Columns[0].Visible = false;

             dgvCores.Columns[1].HeaderText = "Cor";

             dgvCores.Columns[1].Width = 150;
          }
          else
          {
             Mensagens.Falha(resultado);
          }            
        }

        private async Task EntrarAbaCores()
        {
            if (dgvCores.DataSource == null && txtPesquisarCarro.Text == "")
            {
                await TabelaAbaCores();
            }            

            txtCor.Select();
        }

        public async Task CorDuploClique()
        {
            if (dgvCores.SelectedRows.Count == 1)
            {
                bool atualizarDeletar = _formulario.AbrirFormularioCor(Convert.ToInt32(dgvCores.SelectedRows[0].Cells[0].Value), dgvCores.SelectedRows[0].Cells[1].Value.ToString()!, _corServico, _carroServico);

                if (atualizarDeletar)
                {
                    await TabelaAbaCores();
                }
            }
        }

        private async Task InserirCor()
        {
            Resultado2 verificar = Verificacao.VerificarCor(txtCor.Text);

            if (verificar.Sucesso)
            {
                DialogResult botao = Mensagens.Confirmar("Inserir uma nova cor?");

                if (botao == DialogResult.Yes)
                {
                    Resultado2 resultado = await _corServico.InserirCor(txtCor.Text);

                    if (resultado.Sucesso)
                    {
                        Mensagens.Sucesso(resultado);

                        txtCor.Clear();

                        await TabelaAbaCores();
                    }
                    else
                    {
                        Mensagens.Falha(resultado);                                  
                    }
                }
            }
            else
            {
                Mensagens.Falha(verificar);
            }            
        }

        private async Task PesquisarCor()
        {
            if (txtPesquisarCor.Text == "")
            {
                await TabelaAbaCores();
            }
            else
            {
                Resultado1<List<CorDto>> resultado = await _corServico.PesquisarCor(txtPesquisarCor.Text);

                if (resultado.Sucesso)
                {                 
                    dgvCores.DataSource = resultado.Dados;                   
                }
                else
                {
                    Mensagens.Falha(resultado);
                }
            }
        }


        //Aba 'Marcas'


        private async Task TabelaAbaMarcas()
        {
            Resultado1<List<MarcaDto>> resultado = await _marcaServico.PesquisarTudo();

            if (resultado.Sucesso)
            {
               dgvMarcas.DataSource = resultado.Dados;

               dgvMarcas.Columns[0].Visible = false;

               dgvMarcas.Columns[1].HeaderText = "Marca";

               dgvMarcas.Columns[1].Width = 150;
        
            }
            else
            {
                Mensagens.Falha(resultado);
            }
        }

        private async Task EntrarAbaMarcas()
        {
            if (dgvMarcas.DataSource == null && txtPesquisarMarca.Text == "")
            {
                await TabelaAbaMarcas();
            }

            txtMarca.Select();
        }

        private async Task InserirMarca()
        {
            Resultado2 verificar = Verificacao.VerificarMarca(txtMarca.Text);

            if (verificar.Sucesso)
            {
                DialogResult botao = Mensagens.Confirmar("Inserir uma nova marca?");

                if (botao == DialogResult.Yes)
                {
                    Resultado2 resultado = await _marcaServico.InserirMarca(txtMarca.Text);

                    if (resultado.Sucesso)
                    {
                        Mensagens.Sucesso(resultado);

                        txtMarca.Clear();

                        await TabelaAbaMarcas();

                        if (cbModeloMarca.DataSource != null)
                        {
                            await BuscarMarcas();

                            cbModeloMarca.SelectedIndex = -1;
                        }
                    }
                    else
                    {
                        Mensagens.Falha(resultado);
                    }
                }                
            }
            else
            {
                Mensagens.Falha(verificar);
            }
        }

        private async Task MarcaDuploClique()
        {
            if (dgvMarcas.SelectedRows.Count == 1)
            {
                bool atualizarDeletar = _formulario.AbrirFormularioMarca(Convert.ToInt32(dgvMarcas.SelectedRows[0].Cells[0].Value), dgvMarcas.SelectedRows[0].Cells[1].Value.ToString()!, _marcaServico, _modeloServico);

                if (atualizarDeletar)
                {
                    await TabelaAbaMarcas();
                }
            }
        }

        private async Task PesquisarMarca()
        {
            if (txtPesquisarMarca.Text == "")
            {
                await TabelaAbaMarcas();
            }
            else
            {
                Resultado1<List<MarcaDto>> resultado = await _marcaServico.PesquisarMarca(txtPesquisarMarca.Text);

                if (resultado.Sucesso)
                {                   
                   dgvMarcas.DataSource = resultado.Dados;        
                }
                else
                {
                    Mensagens.Falha(resultado);
                }
            }
        }


        //Aba 'Modelos'

        
        private async Task TabelaAbaModelos()
        {
            Resultado1<List<ModeloDto>> resultado = await _modeloServico.PesquisarTudo();

            if (resultado.Sucesso)
            {              
               dgvModelos.DataSource = resultado.Dados;

               dgvModelos.Columns[0].Visible = false;

               dgvModelos.Columns[1].HeaderText = "Modelo e versão";
               dgvModelos.Columns[2].HeaderText = "Marca";

               dgvModelos.Columns[1].Width = 200;
               dgvModelos.Columns[2].Width = 130;

               dgvModelos.Columns[1].DisplayIndex = 0;
               dgvModelos.Columns[2].DisplayIndex = 1;
            }
            else
            {
                Mensagens.Falha(resultado);
            }
        }

        private async Task BuscarMarcas()
        {
            Resultado1<List<MarcaDto>> resultado = await _marcaServico.PesquisarTudo();

            if (resultado.Sucesso)
            {
                cbModeloMarca.DataSource = resultado.Dados;
                cbModeloMarca.ValueMember = "Id";
                cbModeloMarca.DisplayMember = "Marca";
            }
            else
            {
                Mensagens.Falha(resultado);
            }
        }

        private async Task EntrarAbaModelos()
        {
            if (dgvModelos.DataSource == null && txtPesquisarModelo.Text == "")
            {
                await TabelaAbaModelos();
            }

            if (cbModeloMarca.DataSource == null)
            {
                await BuscarMarcas();

                cbModeloMarca.SelectedIndex = -1;
            }

            if (cbModeloMotor.DataSource == null)
            {
                List<MenuValoresDto> comboBoxDto = MenuValores.Motor();

                cbModeloMotor.DataSource = comboBoxDto;
                cbModeloMotor.ValueMember = "Id";
                cbModeloMotor.DisplayMember = "Item";

                cbModeloMotor.SelectedIndex = -1;
            }

            if (cbModeloPortas.DataSource == null)
            {
                List<MenuValoresDto> comboBoxDto = MenuValores.Portas();

                cbModeloPortas.DataSource = comboBoxDto;
                cbModeloPortas.ValueMember = "Id";
                cbModeloPortas.DisplayMember = "Item";

                cbModeloPortas.SelectedIndex = -1;
            }

            txtModelo.Select();
        }

        private async Task InserirModelo()
        {
            Resultado2 verificar = Verificacao.VerificarModelo(cbModeloMarca.Text, txtModelo.Text, cbModeloMotor.Text, cbModeloPortas.Text);

            if (verificar.Sucesso)
            {
                DialogResult botao = Mensagens.Confirmar("Inserir uma nova marca?");

                if (botao == DialogResult.Yes)
                {
                    Resultado2 resultado = await _modeloServico.InserirModelo(Convert.ToInt32(cbModeloMarca.SelectedValue), ManipularTexto.Modelo(txtModelo.Text, cbModeloMotor.Text, cbModeloPortas.Text));

                    if (resultado.Sucesso)
                    {
                        Mensagens.Sucesso(resultado);

                        txtModelo.Clear();
                        cbModeloMarca.SelectedIndex = -1;
                        cbModeloMotor.SelectedIndex = -1;
                        cbModeloPortas.SelectedIndex = -1;

                        await TabelaAbaModelos();
                    }
                    else
                    {
                        Mensagens.Falha(resultado);
                    }
                }                
            }
            else
            {
                Mensagens.Falha(verificar);
            }
        }

        private async Task ModeloDuploClique()
        {
            if (dgvModelos.SelectedRows.Count == 1)
            {
                bool atualizarDeletar = _formulario.AbrirFormularioModelo(Convert.ToInt32(dgvModelos.SelectedRows[0].Cells[0].Value), dgvModelos.SelectedRows[0].Cells[2].Value.ToString()!, dgvModelos.SelectedRows[0].Cells[1].Value.ToString()!, _marcaServico, _modeloServico, _carroServico);

                if (atualizarDeletar)
                {
                    await TabelaAbaModelos();

                    if (cbModeloMarca != null)
                    {
                        await BuscarMarcas();

                        cbModeloMarca.SelectedIndex = -1;
                    }

                    await TabelaAbaCarros();
                }
            }          
        }

        private async Task PesquisarModelo()
        {
            if (txtPesquisarModelo.Text == "")
            {
                await TabelaAbaModelos();
            }
            else
            {
                Resultado1<List<ModeloDto>> resultado = await _modeloServico.PesquisarModelo(txtPesquisarModelo.Text);

                if (resultado.Sucesso)
                {
                    dgvModelos.DataSource = resultado.Dados;
                }
                else
                {
                    Mensagens.Falha(resultado);
                }
            }
        }


        //Aba 'Carros'

        
        private async Task TabelaAbaCarros()
        {
            Resultado1<List<CarroDto>> resultado = await _carroServico.PesquisarTudo();

            if (resultado.Sucesso)
            {
                dgvCarros.DataSource = resultado.Dados;

                dgvCarros.Columns[0].Visible = false;

                dgvCarros.Columns[1].HeaderText = "Modelo e versão";
                dgvCarros.Columns[2].HeaderText = "Marca";
                dgvCarros.Columns[3].HeaderText = "Ano";
                dgvCarros.Columns[4].HeaderText = "Cor";
                dgvCarros.Columns[5].HeaderText = "Câmbio";
                dgvCarros.Columns[6].HeaderText = "Combustível";
                dgvCarros.Columns[7].HeaderText = "Quilometragem";
                dgvCarros.Columns[8].HeaderText = "Final de placa";
                dgvCarros.Columns[9].HeaderText = "Opcionais";
                dgvCarros.Columns[10].HeaderText = "Observações";
                dgvCarros.Columns[11].HeaderText = "Preço";

                dgvCarros.Columns[1].Width = 200;
                dgvCarros.Columns[2].Width = 130;
                dgvCarros.Columns[3].Width = 100;
                dgvCarros.Columns[4].Width = 120;
                dgvCarros.Columns[5].Width = 100;
                dgvCarros.Columns[6].Width = 100;
                dgvCarros.Columns[7].Width = 120;
                dgvCarros.Columns[8].Width = 120;
                dgvCarros.Columns[9].Width = 2200;
                dgvCarros.Columns[10].Width = 300;
                dgvCarros.Columns[11].Width = 85;

                dgvCarros.Columns[1].DisplayIndex = 0;
                dgvCarros.Columns[2].DisplayIndex = 1;
                dgvCarros.Columns[3].DisplayIndex = 2;
                dgvCarros.Columns[4].DisplayIndex = 3;
                dgvCarros.Columns[5].DisplayIndex = 4;
                dgvCarros.Columns[6].DisplayIndex = 5;
                dgvCarros.Columns[7].DisplayIndex = 6;
                dgvCarros.Columns[8].DisplayIndex = 7;
                dgvCarros.Columns[9].DisplayIndex = 8;
                dgvCarros.Columns[10].DisplayIndex = 9;
                dgvCarros.Columns[11].DisplayIndex = 10;
            }
            else
            {
                Mensagens.Falha(resultado);
            }
        }

        private async Task EntrarAbaCarros()
        {
            if (dgvCarros.DataSource == null)
            {
                await TabelaAbaCarros();
            }
        }

        private async Task InserirCarroAbrirFormulario()
        {
            bool inserir = _formulario.AbrirFormularioCarro(_corServico, _marcaServico, _modeloServico, _carroServico);

            if (inserir)
            {
                await TabelaAbaCarros();
            }
        }

        private async Task CarroDuploClique()
        {
            if (dgvCarros.SelectedRows.Count == 1)
            {
                bool alterarDeletar = _formulario.AbrirFormularioCarro(Convert.ToInt32(dgvCarros.SelectedRows[0].Cells[0].Value), dgvCarros.SelectedRows[0].Cells[1].Value.ToString()!, dgvCarros.SelectedRows[0].Cells[2].Value.ToString()!, dgvCarros.SelectedRows[0].Cells[3].Value.ToString()!, dgvCarros.SelectedRows[0].Cells[4].Value.ToString()!, dgvCarros.SelectedRows[0].Cells[5].Value.ToString()!, dgvCarros.SelectedRows[0].Cells[6].Value.ToString()!, dgvCarros.SelectedRows[0].Cells[7].Value.ToString()!, Convert.ToInt32(dgvCarros.SelectedRows[0].Cells[8].Value), dgvCarros.SelectedRows[0].Cells[9].Value.ToString()!, dgvCarros.SelectedRows[0].Cells[10].Value.ToString()!, dgvCarros.SelectedRows[0].Cells[11].Value.ToString()!, _corServico, _marcaServico, _modeloServico, _carroServico);

                if (alterarDeletar)
                {
                    await TabelaAbaCarros();
                }
            }
        }

        private async Task PesquisarCarro()
        {
            if (txtPesquisarCarro.Text == "")
            {
                await TabelaAbaCarros();
            }
            else
            {
                Resultado1<List<CarroDto>> resultado = await _carroServico.PesquisarCarro(txtPesquisarCarro.Text);

                if (resultado.Sucesso)
                {
                    dgvCarros.DataSource = resultado.Dados;
                }
                else
                {
                    Mensagens.Falha(resultado);
                }
            }
        }

        private async Task EstoqueImprimir()
        {
            if (dgvCarros.Rows.Count > 0)
            {
                Resultado2 resultado = await _criarPdfServico.EstoqueImprimir();

                if (resultado.Sucesso == false)
                {
                    Mensagens.Falha(resultado);
                }
            }
        }
    }
}
