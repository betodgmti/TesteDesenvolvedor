### DGM Teste para Desenvolvedor .NET

Esta é uma avaliação básica de código.

O objetivo é conhecer um pouco do seu conhecimento/prática C#.

Recomendamos que você não gaste mais do que 4 - 5 horas.

Faça um fork deste repositório.

Ao finalizar o teste, submeta um pull request para o repositório que nosso time será notificado.

A aplicação deve ser desenvolvida para WEB (de preferencia MVC)

### Tarefas

Com o seguinte diagrama:

CREATE SCHEMA [GESTAO]

CREATE TABLE [GESTAO].[TB_TIPO_CLIENTE](
	[COD_TIPO_CLIENTE] [INT] IDENTITY(1,1) primary key,
	[DSC_TIPO_CLIENTE] [VARCHAR](60) NULL,
	[DT_EXCLUIDO] [DATETIME] NULL
	)


CREATE TABLE [GESTAO].[TB_CLIENTE](
	[COD_CLIENTE] [INT] IDENTITY(1,1) primary key,
	[NOM_USUAL] [VARCHAR](60) NULL,
	[NOM_COMPLETO] [VARCHAR](250) NULL,
	[NRO_CPF] [NUMERIC](11, 0) NULL,
	[DT_EXCLUIDO] [DATETIME] NULL,
	[COD_TIPO_CLIENTE] [INT] REFERENCES [GESTAO].[TB_TIPO_CLIENTE]
	)



Crie um sistema (CRUD)  ações:

- [ ] Views - Visualização Lista e edição

- [ ] Insert - Inserir dados 

- [ ] Update - Atualizar os dados ja cadastrados

- [ ] Delete - Excluir o cliente 


### Requisitos


- [ ] Os clientes podem ser do tipo Interno e Externo

        na tabela TB_TIPO_CLIENTE, 2 registros resolverão. Para isso  deve ser utilizada esta tabela.

- [ ] Uma lista com todos os clientes cadastrados, deverá ser exibida e quando selecionado o item da lista, deverá abrir a tela de edição

        Um cliente pode ser inserido, atualizado e excluído


### Dicas

- Os clientes podem ficar cadastrados em memória, não é necessário persistir os dados
- Se resolver persistir, o banco de dados deverá ser anexado no projeto (script e insert)
