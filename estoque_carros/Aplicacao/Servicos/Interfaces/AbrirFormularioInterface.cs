using estoque_carros.Aplicacao.Dtos.Formularios;
using estoque_carros.Aplicacao.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estoque_carros.Serviços.Interfaces
{
    public interface AbrirFormularioInterface
    {
        bool AbrirFormularioCor(int id, string cor, CorServicoInterface corServico);

        bool AbrirFormularioMarca(int id, string marca, MarcaServicoInterface marcaServico);

        bool AbrirFormularioModelo(int id, string marca, string modelo, MarcaServicoInterface marcaServico, ModeloServicoInterface modeloServico, CarroServicoInterface carroServico);

        bool AbrirFormularioCarro(CorServicoInterface corServico, MarcaServicoInterface marcaServico, ModeloServicoInterface modeloServico, CarroServicoInterface carroServico);

        bool AbrirFormularioCarro(int id, string modelo, string marca, string ano, string cor, string cambio, string combustivel, string km, int placa_final, string opcionais, string observações, string preco, CorServicoInterface corServico, MarcaServicoInterface marcaServico, ModeloServicoInterface modeloServico, CarroServicoInterface carroServico);
    }
}
