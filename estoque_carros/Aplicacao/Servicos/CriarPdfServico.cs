using estoque_carros.Aplicacao.Servicos.Interfaces;
using estoque_carros.Dominio;
using estoque_carros.Dominio.Resultados;
using estoque_carros.Dtos;
using estoque_carros.Repositórios.Interfaces;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_carros.Aplicacao.Servicos
{
    public class CriarPdfServico: CriarPdfServicoInterface
    {
        private readonly CriarConexaoInterface _criarConexao;
        private readonly CarroRepositorioInterface _carroRepositorio;
        private readonly CriarLogServicoInterface _criarLog;

        public CriarPdfServico(CarroRepositorioInterface carroRepositorio, CriarConexaoInterface criarConexao, CriarLogServicoInterface criarLog)
        {
            _carroRepositorio = carroRepositorio;
            _criarConexao = criarConexao;
            _criarLog = criarLog;
        }

        public async Task<Resultado2> EstoqueImprimir()
        {
            try
            {
                string local = AppDomain.CurrentDomain.BaseDirectory;

                string pasta = System.IO.Path.Combine(local, "PDF");

                if (Directory.Exists(pasta) == false)
                {
                    Directory.CreateDirectory(pasta);
                }

                string caminho = System.IO.Path.Combine(pasta, "carros_estoque.pdf");


                using (PdfWriter pdf = new PdfWriter(caminho))
                {
                    using (PdfDocument documentoPdf = new PdfDocument(pdf))
                    {
                        using (Document documento = new Document(documentoPdf, PageSize.A4))
                        {
                            Paragraph cabecalho = new Paragraph("Matias Veículos - estoque");
                            cabecalho.SetTextAlignment(TextAlignment.CENTER);
                            cabecalho.SetFontSize(16);

                            documento.Add(cabecalho);

                            Table tabela = new Table(UnitValue.CreatePercentArray(new float[] { 10, 6, 6, 4, 6, 8, 8, 4, 30, 12, 6 }));
                            tabela.SetWidth(UnitValue.CreatePercentValue(100));

                            Paragraph cabecalhoModelo = new Paragraph("Modelo e versão");
                            cabecalhoModelo.SetFontSize(6);

                            tabela.AddCell(cabecalhoModelo);

                            Paragraph cabecalhoMarca = new Paragraph("Marca");
                            cabecalhoMarca.SetFontSize(6);

                            tabela.AddCell(cabecalhoMarca);

                            Paragraph cabecalhoAno = new Paragraph("Ano");
                            cabecalhoAno.SetFontSize(6);

                            tabela.AddCell(cabecalhoAno);

                            Paragraph cabecalhoCor = new Paragraph("Cor");
                            cabecalhoCor.SetFontSize(6);

                            tabela.AddCell(cabecalhoCor);

                            Paragraph cabecalhoCambio = new Paragraph("Câmbio");
                            cabecalhoCambio.SetFontSize(6);

                            tabela.AddCell(cabecalhoCambio);

                            Paragraph cabecalhoCombustivel = new Paragraph("Combustível");
                            cabecalhoCombustivel.SetFontSize(6);

                            tabela.AddCell(cabecalhoCombustivel);

                            Paragraph cabecalhoKm = new Paragraph("Quilometragem");
                            cabecalhoKm.SetFontSize(6);

                            tabela.AddCell(cabecalhoKm);

                            Paragraph cabecalhoPlaca = new Paragraph("Placa");
                            cabecalhoPlaca.SetFontSize(6);

                            tabela.AddCell(cabecalhoPlaca);

                            Paragraph cabecalhoOpcionais = new Paragraph("Opcionais");
                            cabecalhoOpcionais.SetFontSize(6);

                            tabela.AddCell(cabecalhoOpcionais);

                            Paragraph cabecalhoObservacoes = new Paragraph("Observações");
                            cabecalhoObservacoes.SetFontSize(6);

                            tabela.AddCell(cabecalhoObservacoes);

                            Paragraph cabecalhoPreco = new Paragraph("Preço");
                            cabecalhoPreco.SetFontSize(6);

                            tabela.AddCell (cabecalhoPreco);

                            using (DbConnection conexao = _criarConexao.Conexao())
                            {
                                await conexao.OpenAsync();

                                List<CarroDto> carros = await _carroRepositorio.EstoqueImprimir(conexao);

                                foreach (CarroDto carro in carros)
                                {
                                    Paragraph modelo = new Paragraph(carro.Modelo);
                                    modelo.SetFontSize(5);

                                    tabela.AddCell(modelo);

                                    Paragraph marca = new Paragraph(carro.Marca);
                                    marca.SetFontSize(5);

                                    tabela.AddCell(marca);

                                    Paragraph ano = new Paragraph(carro.Ano);
                                    ano.SetFontSize(5);

                                    tabela.AddCell(ano);

                                    Paragraph cor = new Paragraph(carro.Cor);
                                    cor.SetFontSize(5);

                                    tabela.AddCell(cor);

                                    Paragraph cambio = new Paragraph(carro.Cambio);
                                    cambio.SetFontSize(5);

                                    tabela.AddCell(cambio);

                                    Paragraph combustivel = new Paragraph(carro.Combustivel);
                                    combustivel.SetFontSize(5);

                                    tabela.AddCell(combustivel);

                                    Paragraph km = new Paragraph(carro.Km);
                                    km.SetFontSize(5);

                                    tabela.AddCell(km);

                                    Paragraph placa = new Paragraph(carro.Placa.ToString());
                                    placa.SetFontSize(5);

                                    tabela.AddCell(placa);

                                    Paragraph opcionais = new Paragraph(carro.Opcionais);
                                    opcionais.SetFontSize(5);

                                    tabela.AddCell(opcionais);

                                    Paragraph observacoes = new Paragraph(carro.Observacoes);
                                    observacoes.SetFontSize(5);

                                    tabela.AddCell(observacoes);

                                    Paragraph preco = new Paragraph(carro.Preco);
                                    preco.SetFontSize(5);

                                    tabela.AddCell(preco);
                                }
                            }
                            documento.Add(tabela);
                        }
                    }
                }

                System.Diagnostics.Process.Start(caminho);

                return Resultado2.Sucesso1();
            }
            catch (IOException)
            {
                return Resultado2.Falha("O documento para impressão já foi criado e está aberto");
            }
            catch (Exception erro)
            {
                _criarLog.CriarLog(erro);

                return Resultado2.Falha(erro);
            }
        }
    }
}
