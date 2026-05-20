using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Aplicacao.Servicos.Interfaces;
using estoque_carros.Dominio;
using estoque_carros.Dominio.Resultados;
using estoque_carros.Repositórios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.Aplicacao.Servicos
{
    internal class CorServico: CorServicoInterface
    {
        private readonly CorRepositorioInterface _corRepositorio;
        private readonly CriarConexaoInterface _criarConexao;
        private readonly CriarLogServicoInterface _criarLog;

        public CorServico(CorRepositorioInterface corRepositorio, CriarConexaoInterface criarConexao, CriarLogServicoInterface criarLog)
        {
            _corRepositorio = corRepositorio;
            _criarConexao = criarConexao;
            _criarLog = criarLog;
        }


        public Resultado2 Verificar(string texto)
        {
            if (texto == "")
            {
                return Resultado2.Falha("Informe uma cor");
            }
            else
            {
                return Resultado2.Sucesso1();
            }
        }

        public async Task<Resultado1<List<CorDto>>> PesquisarTudo()
        {
            try
            {   
               using (DbConnection conexao = _criarConexao.Conexao())
               {
                    await conexao.OpenAsync();

                    List<CorDto> cores = await _corRepositorio.PesquisarTudo(conexao);

                    return Resultado1<List<CorDto>>.Sucesso1(cores);
               }                                                          
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado1<List<CorDto>>.Falha(erro);
            }
        }


        public async Task<Resultado1<List<CorDto>>> PesquisarCor(string cor)
        {
            try
            {
                using (DbConnection conexao = _criarConexao.Conexao())
                {
                    await conexao.OpenAsync();

                    List<CorDto> cores = await _corRepositorio.PesquisarCor(cor, conexao);

                    return Resultado1<List<CorDto>>.Sucesso1(cores);
                }                                 
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado1<List<CorDto>>.Falha(erro);
            }           
        }

        public async Task<Resultado2> InserirCor(string cor)
        {
            try
            {               
               using (DbConnection conexao = _criarConexao.Conexao())
               {
                    await conexao.OpenAsync();

                    if (await _corRepositorio.PesquisarCorRepetida1(cor, conexao) > 0)
                    {
                        return Resultado2.Falha("Esta cor já está registrada");
                    }
                    else
                    {
                        CorModelo corInserir = new CorModelo(cor);

                        await _corRepositorio.InserirCor(corInserir.Cor1, conexao);

                        return Resultado2.Sucesso1("Nova cor inserida com suceeso");
                    }
                }              
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado2.Falha(erro);
            }           
        }

        public async Task<Resultado2> AlterarCor(string cor, int id)
        {
            try
            {
               using (DbConnection conexao = _criarConexao.Conexao())
               {
                    await conexao.OpenAsync();

                    if (await _corRepositorio.PesquisarCorRepetida2(cor, id, conexao) > 0)
                    {
                        return Resultado2.Falha("Esta cor já está registrada");
                    }
                    else
                    {
                        CorModelo corAlterar = new CorModelo(id, cor);

                        await _corRepositorio.AlterarCor(corAlterar.Cor1, corAlterar.Id, conexao);

                        return Resultado2.Sucesso1("Cor atualizada com sucesso");
                    }
                }                            
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado2.Falha(erro);
            }            
        }


        public async Task<Resultado2> ExcluirCor(int id)
        {
            try
            {
                using (DbConnection conexao = _criarConexao.Conexao())
                {
                    await conexao.OpenAsync();

                    await _corRepositorio.ExcluirCor(id, conexao);

                    return Resultado2.Sucesso1("Remoção de registro feita com sucesso");
                }                               
            }
            catch (SqlException erro)
            {
                if (erro.Number == 547)
                {
                    return Resultado2.Falha("Este registro de cor está sendo usado por pelo menos um registro na tabela de estoque de carros. É necessário removê-los para poder remover esta cor");
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
