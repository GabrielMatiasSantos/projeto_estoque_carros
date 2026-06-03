using estoque_carros.Aplicacao.Interfaces.Servicos;


namespace estoque_carros.Apresentacao.Interfaces
{
    public interface FormulariosMediadorInterface
    {
        bool AbrirFormularioCor(int id, string cor, CorServicoInterface corServico, CarroServicoInterface carroServico);

        bool AbrirFormularioMarca(int id, string marca, MarcaServicoInterface marcaServico, ModeloServicoInterface modeloServico);

        bool AbrirFormularioModelo(int id, string marca, string modelo, MarcaServicoInterface marcaServico, ModeloServicoInterface modeloServico, CarroServicoInterface carroServico);

        bool AbrirFormularioCarro(CorServicoInterface corServico, MarcaServicoInterface marcaServico, ModeloServicoInterface modeloServico, CarroServicoInterface carroServico);

        bool AbrirFormularioCarro(int id, string modelo, string marca, string ano, string cor, string cambio, string combustivel, string km, int placa_final, string opcionais, string observações, string preco, CorServicoInterface corServico, MarcaServicoInterface marcaServico, ModeloServicoInterface modeloServico, CarroServicoInterface carroServico);
    }
}
