using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Aplicacao.Servicos.Interfaces;
using estoque_carros.CamadaApresentacao.Helpers;
using estoque_carros.Dominio;
using estoque_carros.Dominio.Resultados;
using estoque_carros.Dtos;
using estoque_carros.Infraestrutura;
using estoque_carros.Repositórios;
using estoque_carros.Repositórios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estoque_carros.Aplicacao.Servicos
{
    public class ModeloServico: ModeloServicoInterface
    {
        private readonly ModeloRepositorioInterface _modeloRepositorio;
        private readonly CriarConexaoInterface _criarConexao;
        private readonly CriarLogServicoInterface _criarLog;

        public ModeloServico(ModeloRepositorioInterface modeloRepositorio, CriarConexaoInterface criarConexao, CriarLogServicoInterface criarLog)
        {
            _modeloRepositorio = modeloRepositorio;
            _criarConexao = criarConexao;
            _criarLog = criarLog;
        }

        public Resultado2 Verificar(int marca, string modelo, string portas, string motor)
        {
            if (marca < 0 || modelo == "" || modelo == "" || motor == "")
            {
                return Resultado2.Falha("Preencha todos os campos");
            }
            else
            {
                string[] modeloVerificar = modelo.Split(' ');

                List<MenuValoresDto> listaPortas = MenuValores.Portas();

                bool verificar = false;

                foreach (string modeloParte in modeloVerificar)
                {
                    foreach (MenuValoresDto listaValor in listaPortas)
                    {
                        if (modeloParte.Equals(listaValor.Item, StringComparison.OrdinalIgnoreCase))
                        {
                            verificar = true;
                            break;
                        }

                        if (verificar)
                        {
                            break;
                        }
                    }
                }

                if (verificar)
                {
                    return Resultado2.Falha("Não informe o número de portas na área de informar o modelo");
                }
                else
                {
                    verificar = false;

                    List<MenuValoresDto> listaMotor = MenuValores.Motor();


                    foreach (string modeloParte in modeloVerificar)
                    {
                        foreach (MenuValoresDto listaValor in listaMotor)
                        {
                            if (modeloParte.Equals(listaValor.Item))
                            {
                                verificar = true;
                                break;
                            }
                        }

                        if (verificar)
                        {
                            break;
                        }
                    }

                    if (verificar)
                    {
                        return Resultado2.Falha("Não informe o motor na área de informar o modelo");
                    }
                    else
                    {
                        return Resultado2.Sucesso1();
                    }
                }
            }
        }

        public async Task<Resultado1<List<ModeloDto>>> PesquisarTudo()
        {
           try
           {
              using (DbConnection conexao = _criarConexao.Conexao())
              {
                    await conexao.OpenAsync();

                    List<ModeloDto> modelos = await _modeloRepositorio.PesquisarTudo(conexao);

                    return Resultado1<List<ModeloDto>>.Sucesso1(modelos);
              }
           }
           catch (Exception erro)
           {
                _criarLog.CriarLog(erro);

                return Resultado1<List<ModeloDto>>.Falha(erro);
           }
        }

        public async Task<Resultado1<List<ModeloDto>>> PesquisarModelo(string modelo)
        {
            try
            {
                using (DbConnection conexao = _criarConexao.Conexao())
                {
                    await conexao.OpenAsync();

                    List<ModeloDto> modelos = await _modeloRepositorio.PesquisarModelo(modelo, conexao);

                    return Resultado1<List<ModeloDto>>.Sucesso1(modelos);
                }
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado1<List<ModeloDto>>.Falha(erro);
            }
        }

        public async Task<Resultado1<List<ModeloDto>>> PesquisarModeloMarca(int marca)
        {
            try
            {
                using (DbConnection conexao = _criarConexao.Conexao())
                {
                    await conexao.OpenAsync();

                    List<ModeloDto> modelos = await _modeloRepositorio.PesquisarModeloMarca(marca, conexao);

                    return Resultado1<List<ModeloDto>>.Sucesso1(modelos);
                }
            }
            catch(Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado1<List<ModeloDto>>.Falha(erro);
            }
        }

        public async Task<Resultado2> InserirModelo(int marca, string modelo, string motor, string portas)
        {
            try
            {
                string modeloCompleto;

                if (motor == MenuValores.motorOutros)
                {
                    modeloCompleto = $"{modelo} {portas}";
                }
                else
                {
                    modeloCompleto = $"{modelo} {motor} {portas}";
                }

                using (DbConnection conexao = _criarConexao.Conexao())
                {
                    await conexao.OpenAsync();

                    if (await _modeloRepositorio.PesquisarModeloRepetido1(modeloCompleto, conexao) > 0)
                    {
                        return Resultado2.Falha("Este modelo já está registrado");
                    }
                    else
                    {
                        ModeloModelo modeloInserir = new ModeloModelo(marca, modeloCompleto);

                        await _modeloRepositorio.InserirModelo(modeloInserir.Marca, modeloInserir.Modelo1, conexao);

                        return Resultado2.Sucesso1("Novo modelo inserido com sucesso");
                    }
                }
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado2.Falha(erro);
            }
        }

        public async Task<Resultado2> AlterarModelo(int id, int marca, string modelo, string motor, string portas)
        {
            try
            {
                string modeloCompleto;

                if (motor == MenuValores.motorOutros)
                {
                    modeloCompleto = $"{modelo} {portas}";
                }
                else
                {
                    modeloCompleto = $"{modelo} {motor} {portas}";
                }

                using (DbConnection conexao = _criarConexao.Conexao())
                {
                    await conexao.OpenAsync();

                    if (await _modeloRepositorio.PesquisarModeloRepetido2(id, modeloCompleto, conexao) > 0)
                    {
                        return Resultado2.Falha("Este modelo já está registrado");
                    }
                    else
                    {
                        ModeloModelo modeloAlterar = new ModeloModelo(id, marca, modeloCompleto);

                        await _modeloRepositorio.AlterarModelo(modeloAlterar.Id, modeloAlterar.Marca, modeloAlterar.Modelo1, conexao);

                        return Resultado2.Sucesso1("Modelo atualizado com sucesso");
                    }
                }
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado2.Falha(erro);
            }
        }

        public async Task<Resultado2> ExcluirModelo(int id)
        {
            try
            {
                using (DbConnection conexao = _criarConexao.Conexao())
                {
                    await conexao.OpenAsync();

                    await _modeloRepositorio.ExcluirModelo(id, conexao);

                    return Resultado2.Sucesso1("Remoção de registro feita com sucesso");
                }
            }
            catch (SqlException erro)
            {
                if (erro.Number == 547)
                {
                    return Resultado2.Falha("Este registro de modelo de carro está sendo usado por pelo menos um registro na tabela de estoque de carros. É necessário removê-los para poder remover este modelo");
                }
                else
                {
                    _criarLog.CriarLog(erro);

                    return Resultado2.Falha(erro);
                }
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado2.Falha(erro);
            }
        }
    }
}
