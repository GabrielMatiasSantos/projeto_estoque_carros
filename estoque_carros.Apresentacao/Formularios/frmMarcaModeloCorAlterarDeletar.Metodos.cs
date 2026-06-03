using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Aplicacao.Dtos.Formularios;
using estoque_carros.Apresentacao.Dtos;
using estoque_carros.Apresentacao.Helpers;
using estoque_carros.CamadaApresentacao.Helpers;
using estoque_carros.Dominio.Resultados;
using System.Runtime.Versioning;


namespace estoque_carros.Apresentacao.Formularios
{
    [SupportedOSPlatform("windows")]

    public partial class frmMarcaModeloCorAlterarDeletar
    {
        private void CaracteresTextBox(KeyPressEventArgs e, TextBox textBox)
        {
            if (AbaAtual != Aba.Modelo)
            {
                Caracteres.Nome1(e, txtMarcaModeloCor.Text);
            }
            else
            {
                Caracteres.Nome2(e, txtMarcaModeloCor.Text);
            }
        }


        private void FormularioDados(Formulario1Dto dto)
        {
           this.Width = dto.Largura;
           this.Text = dto.Cabecalho;
           this.lblMarcaModeloCor.Text = dto.Rotulo;
           this.lblMarca.Visible = dto.Marca1;
           this.cbMarca.Visible = dto.Marca2;
           this.lblPortas.Visible = dto.Portas1;
           this.cbPortas.Visible = dto.Portas2;
           this.lblMotor.Visible = dto.Motor1;
           this.cbMotor.Visible = dto.Motor2;
           this.btnAlterar.Left = dto.Alterar;
           this.btnExcluir.Left = dto.Excluir;
        }

        private async Task ComboBoxValores()
        {
            Resultado1<List<MarcaDto>> resultado = await _marcaServico!.PesquisarTudo();

            if (resultado.Sucesso)
            {
                cbMarca.DataSource = resultado.Dados;
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Marca";

                List<MenuValoresDto> portasValores = MenuValores.Portas();

                cbPortas.DataSource = portasValores;
                cbPortas.ValueMember = "Id";
                cbPortas.DisplayMember = "Item";

                List<MenuValoresDto> motorValores = MenuValores.Motor();

                cbMotor.DataSource = motorValores;
                cbMotor.ValueMember = "Id";
                cbMotor.DisplayMember = "Item";
            }
            else
            {
                Mensagens.Falha(resultado);
            }        
        }
        
        private async Task CarregarFormulario()
        {
            if (AbaAtual == Aba.Cor)
            {
                id = Cor!.Id;
                txtMarcaModeloCor.Text = Cor.Cor;

                Cor = null;
            }
            else if (AbaAtual == Aba.Marca)
            {
                id = Marca!.Id;
                txtMarcaModeloCor.Text = Marca.Marca;

                Marca = null;
            }
            else
            {
               await ComboBoxValores();
               

               List<MenuValoresDto> menuPortas = MenuValores.Portas();

               string? portasModelo = null;

               foreach (MenuValoresDto portas in menuPortas)
               {
                  if (Modelo!.Modelo.Contains(' ' + portas.Item))
                  {
                      portasModelo = portas.Item;
                      break;
                  }

                  if (portasModelo != null)
                  {
                     break;
                  }
               }

               List<MenuValoresDto> menuMotor = MenuValores.Motor();

               string? motorModelo = null;

               foreach (MenuValoresDto motor in menuMotor)
               {
                   if (Modelo!.Modelo.Contains(' ' + motor.Item + ' '))
                   {
                       motorModelo = motor.Item;
                       break;
                   }

                   if (motorModelo != null)
                   {
                      break;
                   }
               }

               id = Modelo!.Id;

               cbMarca.Text = Modelo.Marca;

                modeloMarca = Convert.ToInt32(cbMarca.SelectedValue);

               if (motorModelo == null)
               {
                   txtMarcaModeloCor.Text = Modelo.Modelo.Remove(Modelo.Modelo.IndexOf(' ' + portasModelo));

                   cbMotor.Text = MenuValores.motorOutros;
               }
               else
               {
                   txtMarcaModeloCor.Text = Modelo.Modelo.Remove(Modelo.Modelo.IndexOf(' ' + motorModelo));

                   cbMotor.Text = motorModelo;
               }

               cbPortas.Text = portasModelo;
            }

            Modelo = null;
        }

        private async Task Alterar()
        {
            if (AbaAtual == Aba.Cor)
            {
                Resultado2 verificar = Verificacao.VerificarCor(txtMarcaModeloCor.Text);

                if (verificar.Sucesso)
                {
                    DialogResult botao = Mensagens.Confirmar("Confirmar alteração de registro?");

                    if (botao == DialogResult.Yes)
                    {
                        Resultado2 resultado = await _corServico!.AlterarCor(txtMarcaModeloCor.Text, id);

                        ResultadoOperacao.Resultado(this, resultado);
                    }
                }
                else
                {
                    Mensagens.Falha(verificar);
                }
            }
            else if (AbaAtual == Aba.Marca)
            {
                Resultado2 verificar = Verificacao.VerificarMarca(txtMarcaModeloCor.Text);

                if (verificar.Sucesso)
                {
                    DialogResult botao = Mensagens.Confirmar("Confirmar alteração de registro?");

                    if (botao == DialogResult.Yes)
                    {
                        Resultado2 resultado = await _marcaServico!.AlterarMarca(txtMarcaModeloCor.Text, id);

                        ResultadoOperacao.Resultado(this, resultado);
                    }
                }
                else
                {
                    Mensagens.Falha(verificar);
                }
            }
            else
            {
                Resultado2 verificar = Verificacao.VerificarModelo(cbMarca.Text, txtMarcaModeloCor.Text, cbMotor.Text, cbPortas.Text);

                if (verificar.Sucesso)
                {
                    DialogResult botao = Mensagens.Confirmar("Confirmar alteração de registro?");
                    
                    if (botao == DialogResult.Yes)
                    {
                       Resultado2 resultado = await _modeloServico!.AlterarModelo(id, Convert.ToInt32(cbMarca.SelectedValue), ManipularTexto.Modelo(txtMarcaModeloCor.Text, cbMotor.Text, cbPortas.Text));

                       if (Convert.ToInt32(cbMarca.SelectedValue) != modeloMarca)
                       {
                          Resultado2 resultado2 = await _carroServico!.AlterarCarroMarca(Convert.ToInt32(cbMarca.SelectedValue), id);

                          if (resultado2.Sucesso == false)
                          {
                             Mensagens.Falha(resultado2);
                          }
                       }

                       ResultadoOperacao.Resultado(this, resultado);
                    }                   
                }
                else
                {
                    Mensagens.Falha(verificar);
                }
            }
        }

        private async Task Excluir()
        {
            DialogResult botao = Mensagens.Confirmar("Confirmar remoção de registro?");

            if (botao == DialogResult.Yes)
            {
               if (AbaAtual == Aba.Cor)
               {
                   Resultado2 verificar = await _carroServico!.PesquisarCarroCor(id);
                   
                   if (verificar.Sucesso)
                   {
                        Resultado2 resultado = await _corServico!.ExcluirCor(id);

                        ResultadoOperacao.Resultado(this, resultado);
                   }
                   else
                   {
                        Mensagens.Falha(verificar);
                   }                      
               }
               else if (AbaAtual == Aba.Marca)
               {
                  Resultado2 verificar = await _modeloServico!.PesquisarModeloMarca2(id);

                    if (verificar.Sucesso)
                    {
                        Resultado2 resultado = await _marcaServico!.ExcluirMarca(id);

                        ResultadoOperacao.Resultado(this, resultado);
                    }
                    else
                    {
                        Mensagens.Falha(verificar);
                    }                 
               }
               else
               {
                  Resultado2 verificar = await _carroServico!.PesquisarCarroModelo(id);

                  if (verificar.Sucesso)
                  {
                        Resultado2 resultado = await _modeloServico!.ExcluirModelo(id);

                        ResultadoOperacao.Resultado(this, resultado);
                  }
                  else
                  {
                     Mensagens.Falha(verificar);
                  }                
               }
            }
        }
    }
}
