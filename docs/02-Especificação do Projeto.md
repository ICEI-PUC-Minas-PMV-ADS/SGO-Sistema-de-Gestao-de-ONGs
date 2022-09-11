# Especificações do Projeto

Por meio da técnica de observação e brainstorming foram analisadas as necessidades dos usuários do sistema de forma a atender suas demandas. 

A partir das informações coletadas, foram determinadas as personas e histórias de usuários que serão de suma importância para a definição das funcionalidades.

## Personas

As personas, ou seja, os usuários ideais do site foram definidos abaixo: 

 
José 

* 62 anos, mora na Boa Vista, Recife (PE);
* Trabalhava como professor e, atualmente, está aposentado;
* Utiliza poucos recursos do computador e é um pouco leigo com a tecnologia;
* Usava uma folha de papel para registrar os nomes dos voluntários e dos doadores;
* Fundou a ONG Domingo Solidário. 

 

Maria 

* 57 anos, esposa de José;
* Dona de casa;
* Dedica-se aos trabalhos voluntários há muitos anos;
* Sempre pensou que seria mais prático cadastrar os voluntários e doadores em um sistema de gestão;
* Deveria ser algo prático e simples pois José usaria também. 

## Histórias de Usuários

Com a observação do cotidiano das personas e a compreensão de suas necessidades, foram definidas as seguintes histórias de usuários.

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|José                | Cadastrar os voluntários no sistema| Ter uma melhor organização no dia da ação. |
|Maria               | Ter a opção de colocar a função do voluntário na hora do cadastro| Distribuir e localizar mais facilmente as pessoas no dia da ação. |
|José                | Cadastrar os doadores no sistema | Fazer contato com os doadores antes da ação.  |
|Maria                | Visualizar, em forma de lista, os voluntários com as suas respectivas informações de contato | Facilitar a gestão dos voluntários no planejamento das ações da ONG. |
|José                | Visualizar na home uma opção de contato com o suporte | Poder entrar em contato no caso de algum problema com o sistema. |
|José                | Editar a função do voluntário | Para caso alguém queira trocar de função. |
|Maria                | Habilitar ou desabilitar o voluntário de acordo com o mês vigente | Nem todos voluntários tem disponibilidade todos os meses. |
|José                | Visualizar a quantidade de voluntários cadastrados na home | Melhorar a gestão da ONG. |


## Requisitos do Projeto

No projeto, sua estrutura e suas funções são determinadas a partir dos requisitos funcionais e não-funcionais. 

Os requisitos funcionais podem ser definidos como a descrição das funções que os usuários poderão utilizar para satisfazer suas necessidades. Já os requisitos não funcionais são aqueles que descrevem as características de usabilidade e outros aspectos que o site necessita apresentar de maneira geral. 

Portanto, com os estudos das personas e histórias dos usuários identificadas para o projeto, foram definidos os seguintes requisitos. 


### Requisitos Funcionais

Os requisitos funcionais do projeto e seus respectivos níveis de prioridade de entrega são apresentados na tabela a seguir.

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-01| O sistema deve ter uma tela para o gestor logar | ALTA | 
|RF-02| O sistema deve ter uma tela de home com a opção de cadastro de voluntários | ALTA |
|RF-03| A tela de home deve ter um botão para acessar os voluntários cadastrados   | ALTA |
|RF-04| O site deve conter, no momento do cadastro, os campos para preenchimento: Nome, Telefone, E-mail e a função a qual o voluntário deseja no dia da ação: montagem ou distribuição.   | ALTA |
|RF-05| A lista de voluntários é formada pelos campos preenchidos no cadastro dos voluntários.    | MÉDIA |
|RF-06| O sistema deve permitir ao gestor alterar a função do voluntário.    | BAIXA |
|RF-07| A lista com o nome de cada voluntário deve ter a opção de habilitar ou desabilitar para o mês vigente.    | MÉDIA |
|RF-08| A home do sistema deve ter a opção de cadastro de doadores com os seguintes campos: Nome, Telefone e E-mail.     | ALTA |
|RF-09| A tela home deve ter um botão para acessar a lista de doadores cadastrados.    | ALTA |
|RF-10| A lista de doadores é formada pelos campos preenchidos no cadastro dos doadores.     | MÉDIA |
|RF-11| O site deve ter uma opção de contato com o suporte.    | BAIXA |
|RF-12| O site deve ter em sua home a quantidade de voluntários cadastrados.     | MÉDIA |

### Requisitos não Funcionais

Os requisitos não funcionais que a equipe deverá seguir durante o desenvolvimento, como também seus respectivos níveis de prioridade de entrega são apresentados na tabela a seguir.

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-01| O site será responsivo, permitindo seu acesso e visualização em desktop e celulares. | ALTA | 
|RNF-02| O site deverá ter uma disponibilidade 24/7. |  ALTA | 
|RNF-03| O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Opera). |  ALTA |
|RNF-04| A interface deve ser agradável, intuitiva e de fácil utilização para o usuário. |  MÉDIA |
|RNF-05| O site deve ser publicado em um ambiente acessível publicamente na Internet (GitHub Pages). |  ALTA |

## Restrições

A tabela a seguir apresenta as condições que limitam a execução desse projeto. 

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deve ser entregue até dia 11/12/2022. |
|RE-02| A equipe não pode contratar terceiros para o desenvolvimento do projeto.        |
|RE-03| O site deve ser desenvolvido utilizando linguagens de programação Web para front-end, mais especificamente HTML, CSS e JavaScript. A parte de back-end ficará por conta de PHP.        |

## Diagrama de Casos de Uso

Os diagramas são utilizados na documentação e modelagem dos sistemas e de suas funcionalidades, de modo geral, podemos dizer que são essenciais para a construção de um software coeso. 

Em linhas gerais, o diagrama de casos de uso documenta o que o sistema deve fazer do ponto de vista de quem o utiliza, dessa forma, ele apresenta as principais funcionalidades do sistema e a interação dessas com os usuários. 

O diagrama a seguir diz respeito ao projeto em questão:

![Diagrama de Caso de Uso](img/diagrama_gestor.jpeg)
