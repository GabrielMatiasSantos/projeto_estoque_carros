using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Aplicacao.Interfaces;
using estoque_carros.Aplicacao.Interfaces.Servicos;
using estoque_carros.Dominio.Interfaces;
using estoque_carros.Dominio.Interfaces.Repositorios;
using estoque_carros.Dominio.Resultados;
using estoque_carros.Entidades;


namespace estoque_carros.Aplicacao.Servicos
{
    public class ModeloServico: ModeloServicoInterface
    {
        private readonly ModeloRepositorioInterface _modeloRepositorio;
        private readonly ModeloPesquisarInterface _modeloPesquisar;
        private readonly CriarLogsInterface _criarLog;

        public ModeloServico(ModeloRepositorioInterface modeloRepositorio, ModeloPesquisarInterface modeloPesquisar, CriarLogsInterface criarLog)
        {
            _modeloRepositorio = modeloRepositorio;
            _modeloPesquisar = modeloPesquisar;
            _criarLog = criarLog;
        }

        
        public async Task<Resultado1<List<ModeloDto>>> PesquisarTudo()
        {
           try
           {
               List<ModeloDto> modelos = await _modeloPesquisar.PesquisarTudo();

               return Resultado1<List<ModeloDto>>.Sucesso1(modelos);
              
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
               List<ModeloDto> modelos = await _modeloPesquisar.PesquisarModelo(modelo);

               return Resultado1<List<ModeloDto>>.Sucesso1(modelos);
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado1<List<ModeloDto>>.Falha(erro);
            }
        }

        public async Task<Resultado1<List<ModeloDto>>> PesquisarModeloMarca1(int marca)
        {
            try
            {            
               List<ModeloDto> modelos = await _modeloPesquisar.PesquisarModeloMarca1(marca);

               return Resultado1<List<ModeloDto>>.Sucesso1(modelos);
            }
            catch(Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado1<List<ModeloDto>>.Falha(erro);
            }
        }

        public async Task<Resultado2> PesquisarModeloMarca2(int marca)
        {
            try
            {
                if (await _modeloRepositorio.PesquisarModeloMarca2(marca) > 0)
                {
                    return Resultado2.Falha("Este registro de marca está sendo usado por pelo menos um registro na tabela de modelos de carro. Remova estes registros para poder remover esta marca");
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

        public async Task<Resultado2> InserirModelo(int marca, string modelo)
        {
            try
            {
               if (await _modeloRepositorio.PesquisarModeloRepetido1(modelo) > 0)
               {
                  return Resultado2.Falha("Este modelo já está registrado");
               }
               else
               {
                  ModeloModelo modeloInserir = new ModeloModelo(marca, modelo);

                   await _modeloRepositorio.InserirModelo(modeloInserir.Marca, modeloInserir.Modelo1);

                   return Resultado2.Sucesso1("Novo modelo inserido com sucesso");
               }               
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado2.Falha(erro);
            }
        }

        public async Task<Resultado2> AlterarModelo(int id, int marca, string modelo)
        {
            try
            {
               if (await _modeloRepositorio.PesquisarModeloRepetido2(id, modelo) > 0)
               {
                  return Resultado2.Falha("Este modelo já está registrado");
               }
               else
               {
                  ModeloModelo modeloAlterar = new ModeloModelo(id, marca, modelo);

                  await _modeloRepositorio.AlterarModelo(modeloAlterar.Id, modeloAlterar.Marca, modeloAlterar.Modelo1);

                  return Resultado2.Sucesso1("Modelo atualizado com sucesso");
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
               await _modeloRepositorio.ExcluirModelo(id);

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
