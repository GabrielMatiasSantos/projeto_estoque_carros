using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Aplicacao.Interfaces;
using estoque_carros.Aplicacao.Interfaces.Servicos;
using estoque_carros.Dominio.Entidades;
using estoque_carros.Dominio.Interfaces.Repositorios;
using estoque_carros.Dominio.Resultados;


namespace estoque_carros.Aplicacao.Servicos
{
    public class CarroServico: CarroServicoInterface
    {
        private readonly CarroRepositorioInterface _carroRepositorio;
        private readonly CarroPesquisarInterface _carroPesquisar;
        private readonly CriarLogsInterface _criarLog;

        public CarroServico(CarroRepositorioInterface carroRepositorio, CarroPesquisarInterface carroPesquisar, CriarLogsInterface criarLog)
        {
            _carroRepositorio = carroRepositorio;
            _carroPesquisar = carroPesquisar;
            _criarLog = criarLog;
        }

       

        public async Task<Resultado1<List<CarroDto>>> PesquisarTudo()
        {
            try
            {
               List<CarroDto> carros = await _carroPesquisar.PesquisarTudo();

               return Resultado1<List<CarroDto>>.Sucesso1(carros);          
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
               List<CarroDto> carros = await _carroPesquisar.PesquisarCarro(carro);

               return Resultado1<List<CarroDto>>.Sucesso1(carros);
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado1<List<CarroDto>>.Falha(erro);
            }
        }

        public async Task<Resultado2> PesquisarCarroCor(int id)
        {
            try
            {
                if (await _carroRepositorio.PesquisarCarroCor(id) > 0)
                {
                    return Resultado2.Falha("Este registro de cor está sendo usado por pelo menos um registro na tabela de carros. Remova estes registros para poder remover esta cor");
                }
                else
                {
                    return Resultado2.Sucesso1();
                }
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado2.Falha(erro);
            }
        }

        public async Task<Resultado2> PesquisarCarroModelo(int modelo)
        {
            try
            {
                if (await _carroRepositorio.PesquisarCarroModelo(modelo) > 0)
                {
                    return Resultado2.Falha("Este registro de modelo está sendo usado por pelo menos um registro na tabela de carros. Remova estes registros para poder remover este modelo de carro");
                }
                else
                {
                    return Resultado2.Sucesso1();
                }
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado2.Falha(erro);
            }
        }

        public async Task<Resultado2> InserirCarro(int modelo, int marca, string ano, int anoFabricacao, int anoModelo, int cor, string cambio, string combustivel, int km, int placaFinal, string opcionais, string opcionaisAbreviacao, string observacoes, decimal preco)
        {
            try
            {                
                CarroEntidade carro = new CarroEntidade(modelo, marca, ano, anoFabricacao, anoModelo, cor, cambio, combustivel, km, placaFinal, opcionais, opcionaisAbreviacao, observacoes, preco);

                 if (carro.VerificarFabricacao() == false)
                 {
                    return Resultado2.Falha("Ano de carro inválido");
                 }
                 else if (carro.VerificarAno() == false)
                 {
                    return Resultado2.Falha("O ano de fabricação do carro deve ser igual ou anterior em um ano em relação ao modelo do carro");
                 }
                 else if (carro.VerificarPreco() == false)
                 {
                    return Resultado2.Falha("Informe um valor válido como preço do carro");
                 }
                 else
                 {
                    await _carroRepositorio.InserirCarro(carro.Modelo, carro.Marca, carro.Ano, carro.Cor, carro.Cambio, carro.Combustivel, carro.Km, carro.Placa, carro.Opcionais, carro.OpcionaisAbreviacao, carro.Observacoes, carro.Preco);

                    return Resultado2.Sucesso1("Novo carro registrado com sucesso");              
                 }                 
                
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado2.Falha(erro);
            }
        }

        public async Task<Resultado2> AlterarCarro(int id, int modelo, int marca, string ano, int anoFabricacao, int anoModelo, int cor, string cambio, string combustivel, int km, int placaFinal, string opcionais, string opcionaisAbreviacao, string observacoes, decimal preco)
        {
            try
            {
              
               CarroEntidade carro = new CarroEntidade(id, modelo, marca, ano, anoFabricacao, anoModelo, cor, cambio, combustivel, km, placaFinal, opcionais, opcionaisAbreviacao, observacoes, preco);

                if (carro.VerificarFabricacao() == false)
                {
                    return Resultado2.Falha("Ano de carro inválido");
                }
                else if (carro.VerificarAno() == false)
                {
                    return Resultado2.Falha("O ano de fabricação do carro deve ser igual ou anterior em um ano em relação ao modelo do carro");
                }
                else if (carro.VerificarPreco() == false)
                {
                    return Resultado2.Falha("Informe um valor válido como preço do carro");
                }
                else
                {
                   await _carroRepositorio.AlterarCarro(carro.Id, carro.Modelo, carro.Marca, carro.Ano, carro.Cor, carro.Cambio, carro.Combustivel, carro.Km, carro.Placa, carro.Opcionais, carro.OpcionaisAbreviacao, carro.Observacoes, carro.Preco);

                   return Resultado2.Sucesso1("Carro atualizado com sucesso");
                } 
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado2.Falha(erro);
            }
        }

        public async Task<Resultado2> AlterarCarroMarca(int marca, int modelo)
        {
            try
            {
                await _carroRepositorio.AlterarCarroMarca(marca, modelo);

                return Resultado2.Sucesso1();
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado2.Falha(erro);
            }
        }

        public async Task<Resultado2> ExcluirCarro(int id)
        {
            try
            {
               await _carroRepositorio.ExcluirCarro(id);

               return Resultado2.Sucesso1("Remoção de registro feita com sucesso");
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado2.Falha(erro);
            }
        }
    }
}
