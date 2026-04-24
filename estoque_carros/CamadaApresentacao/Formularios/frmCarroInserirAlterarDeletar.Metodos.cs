using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Aplicacao.Dtos.Formularios;
using estoque_carros.CamadaApresentacao.Helpers;
using estoque_carros.Dominio;
using estoque_carros.Dominio.Resultados;
using estoque_carros.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estoque_carros.CamadaApresentacao.Formularios
{
    public partial class frmCarroInserirAlterarDeletar
    {
        private void CheckBoxValores()
        {
            List<OpcionaisValoresDto> checkBoxValores = OpcionaisValores.Valores();

            int contador = 0;


            foreach (Control control in this.Controls)
            {
                if (control is CheckBox)
                {
                    int indice = this.Controls.GetChildIndex(control);

                    if (indice != checkBoxValores[contador].Indice)
                    {
                        this.Controls.SetChildIndex(control, checkBoxValores[contador].Indice);
                    }

                    contador++;
                }
            }

            contador = 0;


            foreach (Control control in this.Controls)
            {
                if (control is CheckBox)
                {
                    if (control.Name != checkBoxValores[contador].Nome)
                    {
                        control.Name = checkBoxValores[contador].Nome;
                    }

                    if (control.Text != checkBoxValores[contador].Valor)
                    {
                        control.Text = checkBoxValores[contador].Valor;
                    }

                    control.Tag = new OpcionaisValoresDto(checkBoxValores[contador].Valor, checkBoxValores[contador].ValorAbreviado);

                    contador++;
                }
            }
        }

        private void KmFormatar()
        {
            if (txtKm.Text != "")
            {
                int cursor = txtKm.SelectionStart;

                int quantidade = txtKm.Text.Length;

                txtKm.Text = Convert.ToDecimal(txtKm.Text).ToString("N0");

                int quantidade2 = txtKm.Text.Length;

                if (quantidade2 > quantidade && txtKm.Text.Contains('.'))
                {
                    txtKm.SelectionStart = cursor + 1;
                }
                else
                {
                    txtKm.SelectionStart = cursor;
                }
            }
        }

        private void PrecoFormatar()
        {
            if (txtPreco.Text != "")
            {
                int cursor = txtPreco.SelectionStart;

                int quantidade = txtPreco.Text.Length;

                txtPreco.Text = Convert.ToDecimal(txtPreco.Text).ToString("N");

                int quantidade2 = txtPreco.Text.Length;

                if (quantidade2 > quantidade && txtPreco.Text.Contains('.'))
                {
                    txtPreco.SelectionStart = cursor + 1;
                }
                else
                {
                    txtPreco.SelectionStart = cursor;
                }
            }
        }

        private async Task ComboBoxCores()
        {
            Resultado1<List<CorDto>> resultado = await _corServico.PesquisarTudo();

            if (resultado.Sucesso)
            {
                cbCor.ValueMember = "Id";
                cbCor.DisplayMember = "Cor";
                cbCor.DataSource = resultado.Dados;
            }
            else
            {
                Mensagens.Falha(resultado);
            }
        }

        private async Task ComboBoxMarcas()
        {
            Resultado1<List<MarcaDto>> resultado = await _marcaServico.PesquisarTudo();

            if (resultado.Sucesso)
            {
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Marca";
                cbMarca.DataSource = resultado.Dados;
            }
            else
            {
                Mensagens.Falha(resultado);
            }
        }

        private async Task ComboBoxModelos()
        {
            Resultado1<List<ModeloDto>> resultado = await _modeloServico.PesquisarModeloMarca(Convert.ToInt32(cbMarca.SelectedValue));

            if (resultado.Sucesso)
            {
               cbModelo.ValueMember = "Id";
               cbModelo.DisplayMember = "Modelo";
               cbModelo.DataSource = resultado.Dados;
            }
            else
            {
               Mensagens.Falha(resultado);
            }
           
        }

        private void ComboBoxCambioCombustivelPlaca()
        {
            List<MenuValoresDto> cambio = MenuValores.Cambio();

            cbCambio.ValueMember = "Id";
            cbCambio.DisplayMember = "Item";
            cbCambio.DataSource = cambio;         

            List<MenuValoresDto> combustivel = MenuValores.Combustivel();

            cbCombustivel.ValueMember = "Id";
            cbCombustivel.DisplayMember = "Item";
            cbCombustivel.DataSource = combustivel;
            
            List<MenuValoresDto> placa = MenuValores.Placa();

            cbPlaca.ValueMember = "Id";
            cbPlaca.DisplayMember = "Item";
            cbPlaca.DataSource = placa;
        }


        public void CheckBoxDirecaoHidraulica()
        {
            if (chbDirecaoHidraulica.Checked)
            {
                chbDirecaoEletrica.Checked = false;
            }
        }

        private void CheckBoxDirecaoEletrica()
        {
            if (chbDirecaoEletrica.Checked)
            {
                chbDirecaoHidraulica.Checked = false;
            }
        }
       
        private  void FormularioDados(Formulario2Dto dto)
        {
            if (formularioFuncao == FormularioFuncao.Inserir)
            {
                CheckBoxValores();

                this.Text = dto.Cabecalho;
                this.btnSalvar.Visible = dto.Salvar;
                this.btnAlterar.Visible = dto.Alterar;
                this.btnExcluir.Visible = dto.Excluir;
            }
        }

        private async Task CarregarFormulario()
        {
            await ComboBoxCores();

            await ComboBoxMarcas();

            ComboBoxCambioCombustivelPlaca();

            if (formularioFuncao == FormularioFuncao.Inserir)
            {
                cbMarca.SelectedIndex = -1;
                cbCor.SelectedIndex = -1;
                cbCambio.SelectedIndex = -1;
                cbCombustivel.SelectedIndex = -1;
                cbPlaca.SelectedIndex = -1;
            }
            else
            {
                id = Carro.Id;
                cbMarca.Text = Carro.Marca;

                await ComboBoxModelos();

                cbModelo.Text = Carro.Modelo;
                mtbAno.Text = Carro.Ano;
                cbCor.Text = Carro.Cor;
                cbCambio.Text = Carro.Cambio;
                cbCombustivel.Text = Carro.Combustivel;
                txtKm.Text = Carro.Km;
                cbPlaca.Text = Carro.Placa.ToString();
                txtPreco.Text = Carro.Preco;
                txtObservacoes.Text = Carro.Observacoes;

                OpcionaisValoresDto opcionaisValores;
                CheckBox checkBox;

                foreach (Control control in this.Controls)
                {
                    if (control is CheckBox)
                    {
                        checkBox = control as CheckBox;

                        opcionaisValores = checkBox.Tag as OpcionaisValoresDto;

                        if (Carro.Opcionais.Contains(opcionaisValores.Valor))
                        {
                            checkBox.Checked = true;
                        }
                    }
                }

                Carro = null;
            }
        }

        private string[] CheckBoxValoresSalvar()
        {
            string opcionais = null;
            string opcionaisAbreviacao = null;
            OpcionaisValoresDto opcionaisValores;
            CheckBox checkBox;

            foreach (Control control in this.Controls)
            {
                if (control is CheckBox)
                {
                    checkBox = control as CheckBox;

                    if (checkBox.Checked)
                    {
                        opcionaisValores = checkBox.Tag as OpcionaisValoresDto;

                        if (opcionais != null)
                        {
                            opcionais += ", ";
                            opcionaisAbreviacao += ", ";
                        }

                        opcionais += opcionaisValores.Valor;
                        opcionaisAbreviacao += opcionaisValores.ValorAbreviado;
                    }
                }
            }

            if (opcionais == null)
            {
                opcionais = "Básico";
                opcionaisAbreviacao = "Básico";
            }

            string[] opcionais2 = {opcionais, opcionaisAbreviacao};

            return opcionais2;
        }

        private void Resultado(Resultado2 resultado)
        {
            if (resultado.Sucesso)
            {
                Mensagens.Sucesso(resultado);

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            else
            {
                Mensagens.Falha(resultado);
            }
        }

        private async Task InserirCarro()
        {
            Resultado2 verificar = _carroServico.Verificar(Convert.ToInt32(cbModelo.SelectedIndex), Convert.ToInt32(cbMarca.SelectedIndex), mtbAno.Text, Convert.ToInt32(cbCor.SelectedIndex), cbCambio.Text, cbCombustivel.Text, txtKm.Text, cbPlaca.Text, txtPreco.Text);

            if (verificar.Sucesso)
            {
                DialogResult botao = Mensagens.Confirmar("Inserir novo carro?");

                if (botao == DialogResult.Yes)
                {
                    string[] opcionais = CheckBoxValoresSalvar();

                    Resultado2 resultado = await _carroServico.InserirCarro(Convert.ToInt32(cbModelo.SelectedValue), Convert.ToInt32(cbMarca.SelectedValue), mtbAno.Text, Convert.ToInt32(cbCor.SelectedValue), cbCambio.Text, cbCombustivel.Text, Convert.ToInt32(txtKm.Text.Remove(txtKm.Text.IndexOf('.'), 1)), Convert.ToInt32(cbPlaca.Text), opcionais[0], opcionais[1], txtObservacoes.Text, Convert.ToDecimal(txtPreco.Text.Remove(txtPreco.Text.IndexOf('.'), 1)));

                    Resultado(resultado);
                }
            }
            else
            {
                Mensagens.Falha(verificar);
            }
        }

        private async Task AlterarCarro()
        {
            Resultado2 verificar = _carroServico.Verificar(Convert.ToInt32(cbModelo.SelectedIndex), Convert.ToInt32(cbMarca.SelectedIndex), mtbAno.Text, Convert.ToInt32(cbCor.SelectedIndex), cbCambio.Text, cbCombustivel.Text, txtKm.Text, cbPlaca.Text, txtPreco.Text);

            if (verificar.Sucesso)
            {
                DialogResult botao = Mensagens.Confirmar("Confirmar alteração de registro?");

                if (botao == DialogResult.Yes)
                {              
                    string[] opcionais = CheckBoxValoresSalvar();

                    Resultado2 resultado = await _carroServico.AlterarCarro(id, Convert.ToInt32(cbModelo.SelectedValue), Convert.ToInt32(cbMarca.SelectedValue), mtbAno.Text, Convert.ToInt32(cbCor.SelectedValue), cbCambio.Text, cbCombustivel.Text, Convert.ToInt32(txtKm.Text.Remove(txtKm.Text.IndexOf('.'), 1)), Convert.ToInt32(cbPlaca.Text), opcionais[0], opcionais[1], txtObservacoes.Text, Convert.ToDecimal(txtPreco.Text.Remove(txtPreco.Text.IndexOf('.'), 1)));

                    Resultado(resultado);
                }
            }
            else
            {
                Mensagens.Falha(verificar);
            }
        }

        private async Task ExcluirCarro()
        {
            DialogResult botao = Mensagens.Confirmar("Confirmar remoção de registro?");

            if (botao == DialogResult.Yes)
            {
                Resultado2 resultado = await _carroServico.ExcluirCarro(id);

                Resultado(resultado);
            }
        }
    }
}
