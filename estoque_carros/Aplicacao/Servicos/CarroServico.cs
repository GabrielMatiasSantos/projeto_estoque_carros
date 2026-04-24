using estoque_carros.Aplicacao.Servicos.Interfaces;
using estoque_carros.Dominio;
using estoque_carros.Dominio.Resultados;
using estoque_carros.Dtos;
using estoque_carros.Repositórios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.Aplicacao.Servicos
{
    public class CarroServico: CarroServicoInterface
    {
        private readonly CriarConexaoInterface _criarConexao;
        private readonly CarroRepositorioInterface _carroRepositorio;

        public CarroServico(CarroRepositorioInterface carroRepositorio, CriarConexaoInterface criarConexao)
        {
            _carroRepositorio = carroRepositorio;
            _criarConexao = criarConexao;
        }

        public Resultado2 Verificar(int modelo, int marca, string ano, int cor, string cambio, string combustivel, string km, string placaFinal, string preco)
        {
            if (modelo < 0 || marca < 0 || cor < 0 || cambio == "" || combustivel == "" || km == "" || placaFinal == "" || preco == "")
            {
                return Resultado2.Falha("Apenas os campos 'Opcionais' e 'Observações' podem ficar sem informações. Os demais devem ser preenchidos");
            }
            else if (ano.Length < 9)
            {
                return Resultado2.Falha("Preencha o campo 'Ano (fabricação e modelo)' corretamente");
            }
            else
            {
                string[] anoParte = ano.Split('/');

                if (Convert.ToInt32(anoParte[0]) < 1960 || Convert.ToInt32(anoParte[0]) > 2099)
                {
                    return Resultado2.Falha("Ano de fabricação inválido");
                }
                else if (Convert.ToInt32(anoParte[1]) != Convert.ToInt32(anoParte[0]) && Convert.ToInt32(anoParte[1]) != Convert.ToInt32(anoParte[0]) + 1)
                {
                    return Resultado2.Falha("Ano de modelo de carro inválido");
                }
                else
                {
                    return Resultado2.Sucesso1();
                }
            }
        }

        public async Task<Resultado1<List<CarroDto>>> PesquisarTudo()
        {
            try
            {
                using (DbConnection conexao = _criarConexao.Conexao())
                {
                    await conexao.OpenAsync();

                    List<CarroDto> carros = await _carroRepositorio.PesquisarTudo(conexao);

                    return Resultado1<List<CarroDto>>.Sucesso1(carros);
                }
            }
            catch (Exception erro)
            {
                return Resultado1<List<CarroDto>>.Falha(erro);  
            }
        }

        public async Task<Resultado1<List<CarroDto>>> PesquisarCarro(string carro)
        {
            try
            {
                using (DbConnection conexao = _criarConexao.Conexao())
                {
                    await conexao.OpenAsync();

                    List<CarroDto> carros = await _carroRepositorio.PesquisarCarro(carro, conexao);

                    return Resultado1<List<CarroDto>>.Sucesso1(carros);
                }
            }
            catch (Exception erro)
            {
                return Resultado1<List<CarroDto>>.Falha(erro);
            }
        }

        public async Task<Resultado2> InserirCarro(int modelo, int marca, string ano, int cor, string cambio, string combustivel, int km, int placaFinal, string opcionais, string opcionaisAbreviacao, string observacoes, decimal preco)
        {
            try
            {
                using (DbConnection conexao = _criarConexao.Conexao())
                {
                    await conexao.OpenAsync();

                    CarroModelo carroInserir = new CarroModelo(modelo, marca, ano, cor, cambio, combustivel, km, placaFinal, opcionais, opcionaisAbreviacao, observacoes, preco);

                    await _carroRepositorio.InserirCarro(carroInserir.Modelo, carroInserir.Marca, carroInserir.Ano, carroInserir.Cor, carroInserir.Cambio, carroInserir.Combustivel, carroInserir.Km, carroInserir.Placa, carroInserir.Opcionais, carroInserir.OpcionaisAbreviacao, carroInserir.Observacoes, carroInserir.Preco, conexao);

                    return Resultado2.Sucesso1("Novo carro registrado com sucesso");
                }
            }
            catch (Exception erro)
            {
                return Resultado2.Falha(erro);
            }
        }

        public async Task<Resultado2> AlterarCarro(int id, int modelo, int marca, string ano, int cor, string cambio, string combustivel, int km, int placaFinal, string opcionais, string opcionaisAbreviacao, string observacoes, decimal preco)
        {
            try
            {
                using (DbConnection conexao = _criarConexao.Conexao())
                {
                    await conexao.OpenAsync();

                    CarroModelo carroAlterar = new CarroModelo(id, modelo, marca, ano, cor, cambio, combustivel, km, placaFinal, opcionais, opcionaisAbreviacao, observacoes, preco);

                    await _carroRepositorio.AlterarCarro(carroAlterar.Id, carroAlterar.Modelo, carroAlterar.Marca, carroAlterar.Ano, carroAlterar.Cor, carroAlterar.Cambio, carroAlterar.Combustivel, carroAlterar.Km, carroAlterar.Placa, carroAlterar.Opcionais, carroAlterar.OpcionaisAbreviacao, carroAlterar.Observacoes, carroAlterar.Preco, conexao);

                    return Resultado2.Sucesso1("Carro atualizado com sucesso");
                }
            }
            catch (Exception erro)
            {
                return Resultado2.Falha(erro);
            }
        }

        public async Task<Resultado2> AlterarCarroMarca(int marca, int modelo)
        {
            try
            {
                using (DbConnection conexao = _criarConexao.Conexao())
                {
                    await conexao.OpenAsync();

                    await _carroRepositorio.AlterarCarroMarca(marca, modelo, conexao);

                    return Resultado2.Sucesso1();
                }
            }
            catch (Exception erro)
            {
                return Resultado2.Falha(erro);
            }
        }

        public async Task<Resultado2> ExcluirCarro(int id)
        {
            try
            {
                using (DbConnection conexao = _criarConexao.Conexao())
                {
                    await conexao.OpenAsync();

                    await _carroRepositorio.ExcluirCarro(id, conexao);

                    return Resultado2.Sucesso1("Remoção de registro feita com sucesso");
                }
            }
            catch (Exception erro)
            {
                return Resultado2.Falha(erro);
            }
        }
    }
}
