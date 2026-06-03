using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Aplicacao.Dtos.Formularios;
using estoque_carros.Aplicacao.Interfaces.Servicos;
using estoque_carros.Apresentacao.Formularios;
using estoque_carros.Apresentacao.Interfaces;
using System.Runtime.Versioning;


namespace estoque_carros.Apresentacao.Mediadores
{
    [SupportedOSPlatform("windows")]

    public class FormulariosMediador : FormulariosMediadorInterface
    {
        public bool AbrirFormularioCor(int id, string cor, CorServicoInterface corServico, CarroServicoInterface carroServico)
        {
            Formulario1Dto formularioDto = new Formulario1Dto(350, "Cor - Alterar/Excluir", "Cor:", false, false, false, false, false, false, 23, 205);

            CorDto corDto = new CorDto(id, cor);
           
           frmMarcaModeloCorAlterarDeletar formularioCor = new frmMarcaModeloCorAlterarDeletar(formularioDto, corServico, carroServico);

            formularioCor.Cor = corDto;

            formularioCor.AbaAtual = frmMarcaModeloCorAlterarDeletar.Aba.Cor;

           DialogResult botao = formularioCor.ShowDialog();  
            
            if (botao == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AbrirFormularioMarca(int id, string marca, MarcaServicoInterface marcaServico, ModeloServicoInterface modeloServico)
        {
            Formulario1Dto formularioDto = new Formulario1Dto(350, "Marca - Alterar/Excluir", "Cor:", false, false, false, false, false, false, 23, 205);
            
            MarcaDto marcaDto = new MarcaDto(id, marca);

            frmMarcaModeloCorAlterarDeletar formularioMarca = new frmMarcaModeloCorAlterarDeletar(formularioDto, marcaServico, modeloServico);

            formularioMarca.Marca = marcaDto;

            formularioMarca.AbaAtual = frmMarcaModeloCorAlterarDeletar.Aba.Marca;

            DialogResult botao = formularioMarca.ShowDialog();

            if (botao == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AbrirFormularioModelo(int id, string marca, string modelo, MarcaServicoInterface marcaServico, ModeloServicoInterface modeloServico, CarroServicoInterface carroServico)
        {
            Formulario1Dto formularioDto = new Formulario1Dto(660, "Modelo - Alterar/Excluir", "Modelo e versão:", true, true, true, true, true, true, 127,405);

            ModeloDto modeloDto = new ModeloDto(id, marca, modelo);

            frmMarcaModeloCorAlterarDeletar formularioModelo = new frmMarcaModeloCorAlterarDeletar(formularioDto, marcaServico, modeloServico, carroServico);

            formularioModelo.Modelo = modeloDto;

            formularioModelo.AbaAtual = frmMarcaModeloCorAlterarDeletar.Aba.Modelo;

            DialogResult botao = formularioModelo.ShowDialog();

            if (botao == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool AbrirFormularioCarro(CorServicoInterface corServico, MarcaServicoInterface marcaServico, ModeloServicoInterface modeloServico, CarroServicoInterface carroServico)
        {
            Formulario2Dto formularioDto = new Formulario2Dto("Carro - Inserir", true, false, false);

            frmCarroInserirAlterarDeletar carroInserir = new frmCarroInserirAlterarDeletar(formularioDto, corServico, marcaServico, modeloServico, carroServico);

            carroInserir.formularioFuncao = frmCarroInserirAlterarDeletar.FormularioFuncao.Inserir;

            DialogResult botao = carroInserir.ShowDialog();

            if (botao == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AbrirFormularioCarro(int id, string modelo, string marca, string ano, string cor, string cambio, string combustivel, string km, int placa_final, string opcionais, string observações, string preco, CorServicoInterface corServico, MarcaServicoInterface marcaServico, ModeloServicoInterface modeloServico, CarroServicoInterface carroServico)
        {
            Formulario2Dto formularioDto = new Formulario2Dto("Carro - Alterar/Excluir", false, true, true);

            CarroDto carroDto = new CarroDto(id, modelo, marca, ano, cor, cambio, combustivel, km, placa_final, opcionais, observações, preco);

            frmCarroInserirAlterarDeletar carroAlterarDeletar = new frmCarroInserirAlterarDeletar(formularioDto, corServico, marcaServico, modeloServico, carroServico);

            carroAlterarDeletar.Carro = carroDto;

            carroAlterarDeletar.formularioFuncao = frmCarroInserirAlterarDeletar.FormularioFuncao.AlterarDeletar;

            DialogResult botao = carroAlterarDeletar.ShowDialog();

            if (botao == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
