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
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.Aplicacao.Servicos
{
    public class MarcaServico: MarcaServicoInterface
    {
        private readonly MarcaRepositorioInterface _marcaRepositorio;
        private readonly CriarConexaoInterface _criarConexao;

        public MarcaServico(MarcaRepositorioInterface marcaRepositorio, CriarConexaoInterface criarConexao)
        {
            _marcaRepositorio = marcaRepositorio;
            _criarConexao = criarConexao;
        }

        public Resultado2 Verificar(string texto)
        {
            if (texto == "")
            {
                return Resultado2.Falha("Informe uma marca");
            }
            else
            {
                return Resultado2.Sucesso1();
            }
        }

        public async Task<Resultado1<List<MarcaDto>>> PesquisarTudo()
        {
            try
            {
                using (DbConnection conexao = _criarConexao.Conexao())
                {
                    await conexao.OpenAsync();

                    List<MarcaDto> marcas = await _marcaRepositorio.PesquisarTudo(conexao);

                    return Resultado1<List<MarcaDto>>.Sucesso1(marcas);
                }              
            }
            catch (Exception erro)
            {
                return Resultado1<List<MarcaDto>>.Falha(erro.Message);
            }
        }

        public async Task<Resultado1<List<MarcaDto>>> PesquisarMarca(string marca)
        {
            try
            {
                using (DbConnection conexao = _criarConexao.Conexao())
                {
                    await conexao.OpenAsync();

                    List<MarcaDto> marcas = await _marcaRepositorio.PesquisarMarca(marca, conexao);

                    return Resultado1<List<MarcaDto>>.Sucesso1(marcas);
                }
            }
            catch (Exception erro)
            {
                return Resultado1<List<MarcaDto>>.Falha(erro.Message);
            }
        }

        public async Task<Resultado2> InserirMarca(string marca)
        {
            try
            {
                using (DbConnection conexao = _criarConexao.Conexao())
                {
                    await conexao.OpenAsync();

                    if (await _marcaRepositorio.PesquisarMarcaRepetida1(marca, conexao) > 0)
                    {
                        return Resultado2.Falha("Esta marca já está registrada");
                    }
                    else
                    {
                        MarcaModelo marcaInserir = new MarcaModelo(marca); 

                        await _marcaRepositorio.InserirMarca(marcaInserir.Marca1, conexao);

                        return Resultado2.Sucesso1("Nova marca registrada com sucesso");
                    }
                }                   
            }
            catch (Exception erro)
            {
                return Resultado2.Falha(erro.Message);
            }           
        }


        public async Task<Resultado2> AlterarMarca(string marca, int id)
        {
            try
            {
                using (DbConnection conexao = _criarConexao.Conexao())
                {
                    await conexao.OpenAsync();

                    if (await _marcaRepositorio.PesquisarMarcaRepetida2(marca, id, conexao) > 0)
                    {
                        return Resultado2.Falha("Esta marca já está registrada");
                    }
                    else
                    {
                        MarcaModelo marcaAlterar = new MarcaModelo(id, marca);

                        await _marcaRepositorio.AlterarMarca(marcaAlterar.Marca1, marcaAlterar.Id, conexao);

                        return Resultado2.Sucesso1("Marca atualizada com sucesso");
                    }
                }
            }
            catch (Exception erro)
            {
                return Resultado2.Falha(erro.Message);
            }
        }

        public async Task<Resultado2> ExcluirMarca(int id)
        {
            try
            {
                using (DbConnection conexao = _criarConexao.Conexao())
                {
                    await conexao.OpenAsync();

                    await _marcaRepositorio.ExcluirMarca(id, conexao);

                    return Resultado2.Sucesso1("Remoção de registro feita com sucesso");
                }
            }
            catch (SqlException erro)
            {
                if (erro.Number == 547)
                {
                    return Resultado2.Falha("Este registro de cor está sendo usado por pelo menos um registro na tabela de modelos de carro. É necessário removê-los para poder remover esta marca");
                }
                else
                {
                    return Resultado2.Falha(erro);
                }
            }
            catch (Exception erro)
            {
                return Resultado2.Falha(erro.Message);
            }
        }
    }
}
