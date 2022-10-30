# Plano de Testes de Software

O requisito abordado pelo grupo para a realização dos testes:
- Site publicado na Internet
- Navegador da Internet - Chrome, Firefox ou Edge

O grupo identificou, inicialmente, a necessidade do teste de navegabilidade descrito a seguir:

|CASO DE TESTE| CT-01 –  Login |
| :--------------------: | :------------------------------------ |
| Requisitos Associados | RF – 01 - O sistema deve ter uma tela para o gestor realizar login, com os seguintes campos de preenchimento: E-mail e senha.  |
| Objetivo do Teste | Efetuar o login após preencher os campos corretamente e ser redirecionado para a homepage.  |
| Passos | 1) Acessar o Navegador; |
||2) Informar o endereço do Site;
||3) Visualizar a página de Login;
||4) Inserir os dados corretamente;
||5) Acionar a opção “Acessar”;
| Critérios de Êxito | 1) O login deverá ser efetuado apenas após preenchidos os campos E-mail e senha de forma correta;   |
||2) Ao clicar em “Acessar”, o gestor deverá ser redirecionado para a Homepage.  

|CASO DE TESTE| CT-02 – Cadastro de voluntários |
| :--------------------: | :------------------------------------ |
| Requisitos Associados | RF – 02 - O sistema deve ter uma tela de home com a opção de cadastro de voluntários e doadores.  |
||RF – 04 - O site deve conter, no momento do cadastro dos voluntários, os campos para preenchimento: Nome, Telefone, E-mail, disponibilidade para atuação no mês e função a qual o voluntário deseja no dia da ação: montagem ou distribuição.  
| Objetivo do Teste | Efetuar, com êxito, o cadastro de um novo voluntário.   |
| Passos | 1) Acessar o Navegador; |
||2) Informar o endereço do site;
||3) Visualizar a página de Login;
||4) Efetuar o login, preenchendo os dados corretamente;
||5) Visualizar a Homepage;
||6) Acionar o botão "Cadastrar voluntário";  
||7) Preencher todos os campos obrigatórios corretamente;  
||8) Acionar o botão "Cadastrar" ao finalizar o preenchimento dos campos.  
| Critérios de Êxito | 1) Todos os campos do cadastro deverão ser preenchidos corretamente;   |
||2) Ao clicar em "Cadastrar" deverá ser redirecionado para a Lista de Voluntários e os dados do voluntário deverão constar na lista;

|CASO DE TESTE| CT-03 – Cadastro de doadores |
| :--------------------: | :------------------------------------ |
| Requisitos Associados | RF – 02 - O sistema deve ter uma tela de home com a opção de cadastro de voluntários e doadores.  |
||RF – 08 – A tela de cadastro de doadores deve conter os seguintes campos para preenchimento: nome, telefone e E-mail.  
| Objetivo do Teste | Efetuar, com êxito, o cadastro de um novo doador.   |
| Passos | 1) Acessar o Navegador; |
||2) Informar o endereço do site;
||3) Visualizar a página de Login;
||4) Efetuar o login, preenchendo os dados corretamente;
||5) Visualizar a Homepage;
||6) Acionar o botão "Cadastrar doador";  
||7) Preencher todos os campos obrigatórios corretamente;  
||8) Acionar o botão "Cadastrar" ao finalizar o preenchimento dos campos.  
| Critérios de Êxito | 1) Todos os campos do cadastro deverão ser preenchidos corretamente;   |
||2) Ao clicar em "Cadastrar" deverá ser redirecionado para a Lista de Doadores e os dados do doador deverão constar na lista; 
 

|CASO DE TESTE| CT-04 – Acessar lista de voluntários cadastrados |
| :--------------------: | :------------------------------------ |
| Requisitos Associados | RF – 03 – A tela de home deve ter um botão para acessar a lista de voluntários e a lista de doadores cadastrados.   |
||RF – 05 – A lista de voluntários é formada pelos campos preenchidos no cadastro de voluntários e conterá um botão para edição, exclusão e visualização dos detalhes dos dados cadastrados.
| Objetivo do Teste | Acessar a lista de voluntários cadastrados no sistema, visualizando as informações de cada um.    |
| Passos | 1) Acessar o Navegador; |
||2) Informar o endereço do site;
||3) Visualizar a página de Login;
||4) Efetuar o login, preenchendo os dados corretamente;
||5) Visualizar a Homepage;
||6) Acionar o botão "Listagem de voluntários".  
| Critérios de Êxito | 1) Ao clicar em “Listagem de Voluntários”, deverá ser redirecionado para a lista de voluntários.

|CASO DE TESTE| CT-05 – Acessar lista de doadores cadastrados |
| :--------------------: | :------------------------------------ |
| Requisitos Associados | RF – 03 – A tela de home deve ter um botão para acessar a lista de voluntários e a lista de doadores cadastrados.   |
||RF – 09 – A lista de doadores é formada pelos campos preenchidos no cadastro de doadores e conterá um botão para edição, exclusão e visualização dos detalhes dos dados cadastrados.
| Objetivo do Teste | Acessar a lista de doadores cadastrados no sistema, visualizando as informações de cada um.    |
| Passos | 1) Acessar o Navegador; |
||2) Informar o endereço do site;
||3) Visualizar a página de Login;
||4) Efetuar o login, preenchendo os dados corretamente;
||5) Visualizar a Homepage;
||6) Acionar o botão "Listagem de doadores".  
| Critérios de Êxito | 1) Ao clicar em “Listagem de doadores”, deverá ser redirecionado para a lista de doadores.

|CASO DE TESTE| CT-06 – Editar as informações de cadastro do voluntário |
| :--------------------: | :------------------------------------ |
| Requisitos Associados | RF-06 – O sistema deve permitir ao gestor alterar os dados cadastrais do voluntário.
| Objetivo do Teste | Efetuar, com êxito, a edição das informações de cadastro dos voluntários.    |
| Passos | 1) Acessar o Navegador; |
||2) Informar o endereço do site;
||3) Visualizar a página de Login;
||4) Efetuar o login, preenchendo os dados corretamente;
||5) Visualizar a Homepage;
||6) Acionar o botão "Listagem de Voluntários";  
||7) Na lista dos voluntários, acionar o botão “Editar” na linha correspondente ao voluntário que terá os dados alterados;  
||8) Preencher corretamente os dados que deseja editar;
||9) Acionar o botão “Salvar” ao finalizar o preenchimento dos campos alterados.
| Critérios de Êxito | 1) Ao clicar em “Editar”, deverá ser redirecionado para a tela de edição;    |
||2) Os campos a serem editados devem ser preenchidos corretamente;  
||3) Ao clicar em “Salvar” deverá ser redirecionado para a lista de voluntários;
||4) Efetuada a edição, os novos dados deverão constar na lista de voluntários.  

|CASO DE TESTE| CT-07 – Editar as informações de cadastro do doador |
| :--------------------: | :------------------------------------ |
| Requisitos Associados | RF-10 – O sistema deve permitir ao gestor alterar os dados cadastrais do doador.
| Objetivo do Teste | Efetuar, com êxito, a edição das informações de cadastro dos doadores.    |
| Passos | 1) Acessar o Navegador; |
||2) Informar o endereço do site;
||3) Visualizar a página de Login;
||4) Efetuar o login, preenchendo os dados corretamente;
||5) Visualizar a Homepage;
||6) Acionar o botão "Listagem de doadores";  
||7) Na lista dos doadores, acionar o botão “Editar” na linha correspondente ao doador que terá os dados alterados;  
||8) Preencher corretamente os dados que deseja editar;
||9) Acionar o botão “Salvar” ao finalizar o preenchimento dos campos alterados.
| Critérios de Êxito | 1) Ao clicar em “Editar”, deverá ser redirecionado para a tela de edição;    |
||2) Os campos a serem editados devem ser preenchidos corretamente;  
||3) Ao clicar em “Salvar” deverá ser redirecionado para a lista de doadores;
||4) Efetuada a edição, os novos dados deverão constar na lista de doadores.  

|CASO DE TESTE| CT-08 – Excluir voluntário |
| :--------------------: | :------------------------------------ |
| Requisitos Associados | RF-07 – O sistema deve permitir ao gestor excluir o voluntário cadastrado.
| Objetivo do Teste | Efetuar, com êxito, a exclusão do voluntário do sistema.     |
| Passos | 1) Acessar o Navegador; |
||2) Informar o endereço do site;
||3) Visualizar a página de Login;
||4) Efetuar o login, preenchendo os dados corretamente;
||5) Visualizar a Homepage;
||6) Acionar o botão "Listagem de voluntários";  
||7) Na lista dos voluntários, acionar o botão “Excluir”, na linha correspondente ao voluntário que será excluído;
||8) Após o redirecionamento para a tela de exclusão, acionar o botão “Excluir”;
| Critérios de Êxito | 1) Ao clicar em “Excluir” deverá ser redirecionado para a lista de voluntários;   |
||2) Efetuada a exclusão, o voluntário excluído não poderá constar na lista.

|CASO DE TESTE| CT-09 – Excluir doador |
| :--------------------: | :------------------------------------ |
| Requisitos Associados | RF-11 – O sistema deve permitir ao gestor excluir o doador cadastrado.
| Objetivo do Teste | Efetuar, com êxito, a exclusão do doador do sistema.    |
| Passos | 1) Acessar o Navegador; |
||2) Informar o endereço do site;
||3) Visualizar a página de Login;
||4) Efetuar o login, preenchendo os dados corretamente;
||5) Visualizar a Homepage;
||6) Acionar o botão "Listagem de doadores";  
||7) Na lista dos doadores, acionar o botão “Excluir”, na linha correspondente ao doador que será excluído;
||8) Após o redirecionamento para a tela de exclusão, acionar o botão “Excluir”;
| Critérios de Êxito | 1) Ao clicar em “Excluir” deverá ser redirecionado para a lista de doadores;   |
||2) Efetuada a exclusão, o doador excluído não poderá constar na lista.

|CASO DE TESTE| CT-10 – Acesso a tela de suporte técnico   |
| :--------------------: | :------------------------------------ |
| Requisitos Associados | RF-12 – O sistema deve ter uma tela com opções para contactar o suporte técnico.
| Objetivo do Teste | Visualizar a tela de suporte técnico.      |
| Passos | 1) Acessar o Navegador; |
||2) Informar o endereço do site;
||3) Visualizar a página de Login;
||4) Efetuar o login, preenchendo os dados corretamente;
||5) Visualizar a Homepage;
||6) )Clicar no menu hamburguer para acesso a barra de navegação;  
||7) Acionar o botão "Suporte".  
| Critérios de Êxito | 1)Ao clicar em “Suporte” deverá ser redirecionado para a tela correspondente.

|CASO DE TESTE| CT-11 – Visualização da quantidade de doadores e voluntários na homepage     |
| :--------------------: | :------------------------------------ |
| Requisitos Associados | RF – 13 - O site deve ter em sua home a quantidade de voluntários e doadores cadastrados.
| Objetivo do Teste | Visualizar no conteúdo da Homepage, o número de doadores e voluntários cadastrados no sistema.        |
| Passos | 1) Acessar o Navegador; |
||2) Informar o endereço do site;
||3) Visualizar a página de Login;
||4) Efetuar o login, preenchendo os dados corretamente;
||5) Visualizar a Homepage.
| Critérios de Êxito | 1)Visualizar os números na Homepage.  |
