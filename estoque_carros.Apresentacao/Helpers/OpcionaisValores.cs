using estoque_carros.Apresentacao.Dtos;


namespace estoque_carros.CamadaApresentacao.Helpers
{
    public static class OpcionaisValores
    {
        public static List<OpcionaisValoresDto> Valores()
        {
            List<OpcionaisValoresDto> valores = new List<OpcionaisValoresDto>()
            {
                new OpcionaisValoresDto(0, "chbDirecaoHidraulica", "Direção hidráulica", "Dir.Hid."),
                new OpcionaisValoresDto(1, "chbDirecaoEletrica", "Direção elétrica", "Dir.Ele."),
                new OpcionaisValoresDto(2, "chbVolanteRegulagemAltura", "Volante com regulagem de altura", "Vol.Reg"),
                new OpcionaisValoresDto(3, "chbTravasEletricas", "Travas elétricas", "Tr.Ele."),
                new OpcionaisValoresDto(4, "chbVidrosEletricos", "Vidros elétricos", "Vi.Ele."),
                new OpcionaisValoresDto(5, "chbArCondicionado", "Ar condicionado", "ArCon."),
                new OpcionaisValoresDto(6, "chbArQuente", "Ar quente", "ArQue."),
                new OpcionaisValoresDto(7, "chbAlarme", "Alarme", "Alm."),
                new OpcionaisValoresDto(8, "chbRetrovisoresEletricos", "Retrovisores elétricos", "Ret.Ele."),
                new OpcionaisValoresDto(9, "chbCentralMultimidia", "Central multimídia", "Cen.Mult."),
                new OpcionaisValoresDto(10, "chbTetoSolar", "Teto solar", "T.Sol."),
                new OpcionaisValoresDto(11, "chbEncostoCabecaTraseiro", "Encosto de cabeça traseiro", "Enc.Cab.Tra."),
                new OpcionaisValoresDto(12, "chbSensorEstacionamento", "Sensor de estacionamento", "Sens.Est"),
                new OpcionaisValoresDto(13, "chbAirBag", "AirBag", "A.Bag"),
                new OpcionaisValoresDto(14, "chbFreioAbs", "Freio ABS", "ABS"),
                new OpcionaisValoresDto(15, "chbGps", "GPS", "GPS"),
                new OpcionaisValoresDto(16, "chbRodasLigaLeve", "Rodas de liga leve", "R.L.Leve"),
                new OpcionaisValoresDto(17, "chbDesembaçadorLimpadorTraseiro", "Desembaçador e limpador traseiro", "Des.Lim.Tras."),
                new OpcionaisValoresDto(18, "chbBancosCouro", "Bancos de couro", "BancoCouro"),
                new OpcionaisValoresDto(19, "chbTracao4x4", "Tração 4X4", "4X4"),
                new OpcionaisValoresDto(20, "chbPinturaMetalizada", "Pintura metalizada", "Pin.Met."),
                new OpcionaisValoresDto(21, "chbParaChoqueCor", "Para-choque na cor do veículo", "Pch.Cor")
            };

            return valores;
        }
    }
}
