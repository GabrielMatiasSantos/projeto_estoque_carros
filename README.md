1. Apresentação do projeto


    .Aplicativo de registro de estoque para uma loja de carros

    .Aplicativo Windows Forms (C#) com banco de dados SQL, sendo a comunicação com o banco de dados feita com ADO.NET









2. Descrição geral do projeto


    .O aplicativo registra o seguinte: cores de carros, marcas de carros, modelos de carros, e os carros da loja em si


    .O aplicativo consiste de uma janela com quatro abas


    .O banco de dados possui quatro tabelas









3. Detalhes e desafios do projeto


    .Todos os campos Textbox foram colocados limitações de caracteres aceitos. Por exemplo, no campo para informar o preço de um carro só é possível informar números


    .Se optou que, para informar a cor e marca de um carro, se selecione o dado em um menu (ComboBox). Mas levou-se em consideração que a opção pode ser de uma cor ou marca incomum. Então os dados destas características do carro serão obtidos pelo banco de dados, com as opções mais usadas já registradas inicialmente, sendo que caso seja necessário o usuário pode registrar mais registros de cor/marca


    .Na primera aba (Cores), o usuário pode registrar mais opções de cores de carro caso seja necessário


    .Na segunda aba (Marcas), o usuário pode registrar mais opções de marcas de carro caso seja necessário


    .Na terceira aba (Modelos), o usuário registra os modelos de carro. São registrados os seguintes detalhes: nome do modelo, marca, número de portas, motor

  
    .Foi observado que nomes de cores, marcas e modelos não podem se repetir


    .Na quarta aba (Estoque - carros), o usuário registra os carros da loja em si.


      -O usuário primeiro deve selecionar a marca

      -Depois, estará disponível no menu (ComboBox) os modelos que foram registrados com a marca selecionada

      -Outros elementos registrados: ano (fabricação/modelo), tipo de combustível, tipo de câmbio, quilometragem, final de placa, preço, opcionais (cada opcional é informado por um elemento CheckBox), observações. Apenas os opcionais e observações podem ficar em branco

      -Visto que não é impossível dois carros possuírem os mesmos detalhes, não se bloqueia o registro de dois carros iguais


    .É possível imprimir a tabela de estoque de carros. Para isto se fez uso da biblioteca 'iText'



    .Estrutura do banco de dados:


      -Tabela 'tb_cores': Registrar as cores de carro

      -Tabela 'tb_marcas': Registrar as marcas de carro

      -Tabela 'tb_modelos': Registrar os modelos de carro. Possui relação com a tabela 'tb_marcas'

      -Tabela 'tb_carros': Registrar os carros da loja. Possui relação com todas as tabelas anteriores

      -Todas as tabelas usam chaves primárias substitutas (identity)


    .Tudo aqui mencionado consta no 'initial commit'









5. Refatorações planejadas no futuro



    .Aplicar o padrão repositório e remover o código de dentro dos eventos [x] (refactor: aplicação de repositórios e serviços)

    .Usar métodos assíncronos em processos que envolvam banco de dados [x] (refactor: aplicação de repositórios e serviços)

    Outros detalhes do commit: Foi aplicado os princípios da arquitetura limpa e desacoplada. Por exemplo, nos repositórios se fez uso de classes de banco     de dados genéricas (DbConnection, DbCommand), sendo que referências ao SQL só existem na classe que fornece o objeto com a informação do banco de          dados. Outro exemplo foi usar uma classe de serviço para intermediar o contato entre as classes de formulário, ou seja, nenhum formulário faz              referência direta a outro formulário. Os eventos dos formulários só contém métodos declarados em Helpers ou em uma partição das classes dos                formulários (partial class)

    .Inserir a criação de arquivos de log em caso de alguma falha (catch) []

