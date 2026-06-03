using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Aplicacao.Interfaces;
using estoque_carros.Aplicacao.Interfaces.Servicos;
using estoque_carros.Dominio.Interfaces.Repositorios;
using estoque_carros.Dominio.Resultados;
using estoque_carros.Entidades;


namespace estoque_carros.Aplicacao.Servicos
{
    public class MarcaServico: MarcaServicoInterface
    {
        private readonly MarcaRepositorioInterface _marcaRepositorio;
        private readonly MarcaPesquisarInterface _marcaPesquisar;
        private readonly CriarLogsInterface _criarLog;

        public MarcaServico(MarcaRepositorioInterface marcaRepositorio, MarcaPesquisarInterface marcaPesquisar, CriarLogsInterface criarLog)
        {
            _marcaRepositorio = marcaRepositorio;
            _marcaPesquisar = marcaPesquisar;
            _criarLog = criarLog;
        }

    
        public async Task<Resultado1<List<MarcaDto>>> PesquisarTudo()
        {
            try
            {
               List<MarcaDto> marcas = await _marcaPesquisar.PesquisarTudo();

               return Resultado1<List<MarcaDto>>.Sucesso1(marcas);                            
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado1<List<MarcaDto>>.Falha(erro);
            }
        }

        public async Task<Resultado1<List<MarcaDto>>> PesquisarMarca(string marca)
        {
            try
            {
               List<MarcaDto> marcas = await _marcaPesquisar.PesquisarMarca(marca);

               return Resultado1<List<MarcaDto>>.Sucesso1(marcas);              
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado1<List<MarcaDto>>.Falha(erro);
            }
        }

        public async Task<Resultado2> InserirMarca(string marca)
        {
            try
            {
               if (await _marcaRepositorio.PesquisarMarcaRepetida1(marca) > 0)
               {
                  return Resultado2.Falha("Esta marca já está registrada");
               }
               else
               {
                  MarcaEntidade marcaInserir = new MarcaEntidade(marca); 

                  await _marcaRepositorio.InserirMarca(marcaInserir.Marca1);

                  return Resultado2.Sucesso1("Nova marca registrada com sucesso");
               }                                 
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado2.Falha(erro);
            }           
        }


        public async Task<Resultado2> AlterarMarca(string marca, int id)
        {
            try
            {
               if (await _marcaRepositorio.PesquisarMarcaRepetida2(marca, id) > 0)
               {
                  return Resultado2.Falha("Esta marca já está registrada");
               }
               else
               {
                  MarcaEntidade marcaAlterar = new MarcaEntidade(id, marca);

                  await _marcaRepositorio.AlterarMarca(marcaAlterar.Marca1, marcaAlterar.Id);

                  return Resultado2.Sucesso1("Marca atualizada com sucesso");
               }                
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado2.Falha(erro.Message);
            }
        }

        public async Task<Resultado2> ExcluirMarca(int id)
        {
            try
            {
               await _marcaRepositorio.ExcluirMarca(id);

               return Resultado2.Sucesso1("Remoção de registro feita com sucesso");             
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado2.Falha(erro.Message);
            }
        }
    }
}
