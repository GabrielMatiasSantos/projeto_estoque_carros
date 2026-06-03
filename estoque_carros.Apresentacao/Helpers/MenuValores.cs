using estoque_carros.Aplicacao.Dtos;
using estoque_carros.Apresentacao.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.CamadaApresentacao.Helpers
{
    public static class MenuValores
    {
        public static List<MenuValoresDto> Portas()
        {
            List<MenuValoresDto> menuValoresDto = new List<MenuValoresDto>()
            {
                new MenuValoresDto(1, "2P"),
                new MenuValoresDto(2, "3P"),
                new MenuValoresDto(3, "4P"),
                new MenuValoresDto(4, "5P"),
                new MenuValoresDto(5, "6+")
            };

            return menuValoresDto;
        }

        public const string motorOutros = "Outros";

        public static List<MenuValoresDto> Motor()
        {
            List<MenuValoresDto> menuValoresDto = new List<MenuValoresDto>()
            {
                new MenuValoresDto(1, "1.0"),
                new MenuValoresDto(2, "1.2"),
                new MenuValoresDto(3, "1.3"),
                new MenuValoresDto(4, "1.4"),
                new MenuValoresDto(5, "1.5"),
                new MenuValoresDto(6, "1.6"),
                new MenuValoresDto(7, "1.8"),
                new MenuValoresDto(8, "2.0"),
                new MenuValoresDto(9, "2.2"),
                new MenuValoresDto(10, "2.4"),
                new MenuValoresDto(11, "2.5"),
                new MenuValoresDto(12, "2.8"),
                new MenuValoresDto(13, "3.0"),
                new MenuValoresDto(14, "3.2"),
                new MenuValoresDto(15, "3.6"),
                new MenuValoresDto(16, "3.8"),
                new MenuValoresDto(17, "4.0"),
                new MenuValoresDto(18, "4.1"),
                new MenuValoresDto(19, "4.4"),
                new MenuValoresDto(20, "4.8"),
                new MenuValoresDto(21, "5.0"),
                new MenuValoresDto(22, "5.7"),
                new MenuValoresDto(23, "6.2"),
                new MenuValoresDto(24, "Elétrico"),
                new MenuValoresDto(25, motorOutros)
            };

            return menuValoresDto;
        }

        public static List<MenuValoresDto> Cambio()
        {
            List<MenuValoresDto> menuValoresDto = new List<MenuValoresDto>()
            {
                new MenuValoresDto(1, "Manual"),
                new MenuValoresDto(2, "Automático"),
                new MenuValoresDto(3, "CVT"),
                new MenuValoresDto(4, "Dupla embreagem"),
                new MenuValoresDto(5, "Automatizado"),
                new MenuValoresDto(6, "Elétrico")
            };

            return menuValoresDto;
        }

        public static List<MenuValoresDto> Combustivel()
        {
            List<MenuValoresDto> menuValoresDto = new List<MenuValoresDto>()
            {
                new MenuValoresDto(1, "Gasolina"),
                new MenuValoresDto(2, "Etanol"),
                new MenuValoresDto(3, "Diesel"),
                new MenuValoresDto(4, "GNV"),
                new MenuValoresDto(5, "Flex"),
                new MenuValoresDto(6, "Flex + GNV"),
                new MenuValoresDto(7, "Gasolina + GNV"),
                new MenuValoresDto(8, "Elétrico"),
                new MenuValoresDto(9, "Híbrido"),
                new MenuValoresDto(10, "Híbrido Plug-in"),
                new MenuValoresDto(11, "Híbrido Leve"),
                new MenuValoresDto(12, "Híbrido Flex"),
                new MenuValoresDto(13, "Hidrogênio"),
                new MenuValoresDto(14, "Biodiesel")
            };

            return menuValoresDto;
        }

        public static List<MenuValoresDto> Placa()
        {
            List<MenuValoresDto> menuValoresDto = new List<MenuValoresDto>()
            {
                new MenuValoresDto(1, "0"),
                new MenuValoresDto(2, "1"),
                new MenuValoresDto(3, "2"),
                new MenuValoresDto(4, "3"),
                new MenuValoresDto(5, "4"),
                new MenuValoresDto(6, "5"),
                new MenuValoresDto(7, "6"),
                new MenuValoresDto(8, "7"),
                new MenuValoresDto(9, "8"),
                new MenuValoresDto(10, "9")
            };

            return menuValoresDto;
        }
    }
}
