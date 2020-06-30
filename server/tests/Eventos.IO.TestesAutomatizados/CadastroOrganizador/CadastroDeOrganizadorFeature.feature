Funcionalidade: Cadastro de Organizador
	Um organizador fará seu cadastro pelo site
	para poder gerenciar seus próprios eventos
	Ao terminar o cadastro receberá uma notificação
	de sucesso ou de falha.

@TesteAutomatizadoCadastroDeOrganizadorComSucesso

Cenário: Cadastro de Organizador com Sucesso
	Dado que o Organizador está no site, na página inicial
	E clica no link de registro
	E Preenche os campos com os valores
		| Campo           | Valor								|
		| nome            | Patrizia Mastrodonato				|
		| cpf             | 06231550010							|
		| email           | patrizia.mastrodonato@apeoesp.br	|
		| password        | Teste@123							|
		| confirmPassword | Teste@123							|
	Quando clicar no botão registrar
	Então Será registrado e redirecionado com sucesso
