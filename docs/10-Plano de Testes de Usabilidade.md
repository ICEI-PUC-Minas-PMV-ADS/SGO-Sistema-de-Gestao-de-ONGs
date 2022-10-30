# Plano de Testes de Usabilidade

Os testes de usabilidade têm como finalidade avaliar a qualidade da interface, identificar problemas e possíveis melhorias na aplicação, verificando suas funcionalidades através da experiência do usuário.

O objetivo, portanto, é verificar se o usuário enfrenta dificuldades no fluxo de navegação entre as telas, se há clareza nos textos e nas mensagens e, por fim, apontar a satisfação do usuário ao utilizar o sistema.  

Serão selecionados 5 participantes, sendo eles voluntários que se encaixam no perfil de persona apresentados neste documento.

Os testes serão realizados de forma online. Os voluntários serão orientados a acessar a aplicação em um computador ou dispositivo móvel e executar as tarefas descritas nos casos de testes a seguir e darão um feedback sobre as dificuldades encontradas e sua satisfação com o produto.

|CASO DE TESTE| CT-01 – Prevenir erros |
| :--------------------: | :------------------------------------ |
| Requisitos Associados | RNF-04 - A interface deve ser agradável, intuitiva e de fácil utilização para o usuário e deve ser organizado de tal maneira que os erros dos usuários sejam minimizados.  |
| Objetivo do Teste | Verificar a existência de mensagens de confirmação de ação.  |
| Passos | Apresentar ao usuário uma mensagem para validar a remoção.  |
| Critérios de Êxito |"Você tem certeza que deseja excluir o cadastro?" com as opções de escolha: “Deletar” ou “Voltar”. |

|CASO DE TESTE| CT-02 – Fornecer feedbacks informativos e marcar o final dos diálogos |
| :--------------------: | :------------------------------------ |
| Requisitos Associados | RNF-06 - O sistema deverá retornar ao usuário mensagem ao término de uma tarefa.  |
| Objetivo do Teste | Verificar a existência de caixas de mensagens de fim.  |
| Passos | Na ação do usuário a aplicação deve prover uma resposta informativa e deixar claro quando uma ação foi concluída com êxito. |
| Critérios de Êxito | "Cadastro realizado com sucesso!" |

|CASO DE TESTE| CT-03 – Usuário reconhecer, diagnosticar e recuperar seus erros  |
| :--------------------: | :------------------------------------ |
| Requisitos Associados | RNF-07 - Os formulários devem informar ao usuário quais são os campos de preenchimento obrigatório.  |
| Objetivo do Teste | Ajudar o usuário a reparar um erro.  |
| Passos | Informar ao usuário os campos obrigatórios, apresentar aviso de formulários. |
| Critérios de Êxito | (*) Campo de preenchimento obrigatório; Mensagem informando o tipo do campo que deve ser preenchido, por exemplo no campo Telefone mostrar o texto “Insira seu número de Telefone”. |

|CASO DE TESTE| CT-04 – Reconhecer, em vez de recordar  |
| :--------------------: | :------------------------------------ |
| Requisitos Associados | RNF-08 - Utilizar símbolo e ícone para ajudar no entendimento e conseguir uma associação imediata sobre aplicações de reconhecimento.  |
| Objetivo do Teste | Verificar se a aplicação possui ícones que apenas olhando o símbolo já reconhece o que significa.  |
| Passos | Prover interação por meio da imagem que significa o item que pretende representar. |
| Critérios de Êxito | "Editar" com o ícone de um lápis. |

|CASO DE TESTE| CT-05 – Acessibilidade  |
| :--------------------: | :------------------------------------ |
| Requisitos Associados | RNF-09 - A aplicação ou parte dela deve ser acessível por pessoas com certo tipo de deficiência ou outra necessidade específica.  |
| Objetivo do Teste | Verificar se todas as imagens apresentam informação de descrição.  |
| Passos | Conferir se em todas as imagens, foi atribuído um texto alternativo, para que se por algum motivo a imagem não for carregada ou o usuário esteja utilizando leitor de tela ele consiga entender do que se trata. |
| Critérios de Êxito | O atributo “alt” do HTML deve apresentar texto referente a exibição. |
