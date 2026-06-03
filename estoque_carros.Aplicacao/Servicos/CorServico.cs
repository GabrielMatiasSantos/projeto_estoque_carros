using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Dominio.Resultados;
using estoque_carros.Aplicacao.Interfaces;
using estoque_carros.Aplicacao.Interfaces.Servicos;
using estoque_carros.Dominio.Interfaces.Repositorios;
using estoque_carros.Entidades;

namespace estoque_carros.Aplicacao.Servicos
{
    public class CorServico: CorServicoInterface
    {
        private readonly CorRepositorioInterface _corRepositorio;
        private readonly CorPesquisarInterface _corPesquisar;
        private readonly CriarLogsInterface _criarLog;

        public CorServico(CorRepositorioInterface corRepositorio, CorPesquisarInterface corPesquisar, CriarLogsInterface criarLog)
        {
            _corRepositorio = corRepositorio;
            _corPesquisar = corPesquisar;
            _criarLog = criarLog;
        }


        public async Task<Resultado1<List<CorDto>>> PesquisarTudo()
        {
            try
            {                 
               List<CorDto> cores = await _corPesquisar.PesquisarTudo();

               return Resultado1<List<CorDto>>.Sucesso1(cores);
                                                                        
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
               List<CorDto> cores = await _corPesquisar.PesquisarCor(cor);

               return Resultado1<List<CorDto>>.Sucesso1(cores);
                                                 
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
               if (await _corRepositorio.PesquisarCorRepetida1(cor) > 0)
               {
                   return Resultado2.Falha("Esta cor já está registrada");
               }
               else
               {
                  CorEntidade corInserir = new CorEntidade(cor);

                   await _corRepositorio.InserirCor(corInserir.Cor1);

                   return Resultado2.Sucesso1("Nova cor inserida com suceeso");
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
               if (await _corRepositorio.PesquisarCorRepetida2(cor, id) > 0)
               {
                  return Resultado2.Falha("Esta cor já está registrada");
               }
               else
               {
                  CorEntidade corAlterar = new CorEntidade(id, cor);

                  await _corRepositorio.AlterarCor(corAlterar.Cor1, corAlterar.Id);

                  return Resultado2.Sucesso1("Cor atualizada com sucesso");
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
               await _corRepositorio.ExcluirCor(id);

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
