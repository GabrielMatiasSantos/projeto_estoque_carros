1. Apresentação do projeto

  
    .Aplicativo para registrar o estoque de uma loja de carros

    .Aplicativo Windows Forms (C#) com banco de dados SQL, sendo a comunicação com o banco de dados feita com ADO.NET





2. Descrição geral do projeto


    .O aplicativo funciona da seguinte maneira: o usuário primeiro registra o modelo e versão do carro, para depois registrar o carro no estoque.  

    .O aplicativo consiste de uma janela com quatro abas

    .O banco de dados possui quatro tabelas





3. Detalhes e desafios do projeto


    .Para registrar um carro, foi determinado que a cor e a marca serão selecionados em um menu (combobox). Mas visto que há a possibilidade de uma cor ou     marca que o usuário queira informar não estar registrada em um dos items do menu, se tomou a seguinte medida: Estas informações terão como                 fonte o banco de dados, e as cores e marcas mais comuns já vão vir registradas de início, porém o usuário poderá adicionar outras caso seja                necessário

    .Todos os campos Textbox foram colocados limitações de caracteres aceitos. Por exemplo, no campo para informar o modelo do carro só serão aceitos          letras, números e espaços, e nos campos para informar valores monetários só são aceitos valores numéricos

    .Na primeira aba (Cores) o usuário pode registrar mais cores de carro caso seja necessário

    .Na segunda aba (Marcas) o usuário pode registrar mais marcas de carro caso seja necessário

    .Na terceira aba (Modelos) é a primeira etapa do registro de um carro. Deve se informar o modelo, versão, marca, número de portas e a cilindrada do        motor

    .Na quarta aba (Carros - estoque) é a segunda e final etapa do registro de um carro. O registro ocorre da seguinte maneira:


      -Primeiro deve-se informar a marca do veículo

      -Depois deve-se informar o modelo do veículo. Estarão disponíveis no menu os carros registrados na aba 'Modelos' que foram registrados com a marca         selecionada no menu anterior

      -Após isto deve-se informar os demais dados: ano (fabricação e modelo), cor, tipo de câmbio, tipo de combustível, quilometragem, final da placa,           opcionais (uma série de elementos 'Checkbox'),              observações, e preço

      -Apenas os campos 'Opcionais' e 'Observações' podem ficar sem informação



    .As informações sobre os opcionais de um carro são salvos de duas maneiras no banco de dados: com todos os nomes dos opcionais completos e com os          nomes abreviados. Os opcionais com os nomes completos      são exibidos no DatagridView e com os nomes abreviados são exibidos na impressão da tabela.     Isto foi feito para que seja economizado espaço nas folhas sulfite A4, que são as mais usadas

    .Em todos os registros de todas as abas, é possível alterá-los e deletá-los. Para isto, basta fazer um duplo clique no registro no DataGridView que        irá abrir outra janela que fornecerá uma opção para      alterar ou deletar o registro

    .Em todas as abas é possível fazer uma busca nas informações registradas

    .É possível o usuário imprimir o estoque de carros. Para isto se fez uso da biblioteca 'iText'

    .Estrutura do banco de dados:


      -Tabela 'tb_cores': Registrar cores de carros. Já vem inicialmente registrado com as cores mais comuns

      -Tabela 'tb_marcas': Registrar marcas de carros. Já vem inicialmente registrado com as marcas mais comuns

      -Tabela 'tb_modelos': Registrar os modelos dos carros. Possui relação com a tabela 'tb_marcas'

      -Tabela 'tb_carros': Registrar o estoque de carros da loja. Possui relação com todas as tabelas anteriores

      -Todas as tabelas usam chaves primárias substitutas (identity)



    .Tudo aqui mencionado consta no 'commit 1'






5. Refatorações planejadas no futuro



    .Aplicar o padrão repositório e remover o código de dentro dos eventos []

    .Usar métodos assíncronos em processos que envolvam banco de dados []

    .Inserir a criação de arquivos de log em caso de alguma falha (catch) [] 

