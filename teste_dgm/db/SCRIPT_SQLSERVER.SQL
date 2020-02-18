use GESTAO

CREATE TABLE TB_TIPO_CLIENTE( 
             COD_TIPO_CLIENTE INT IDENTITY(1,1), 
             DSC_TIPO_CLIENTE VARCHAR(80) NULL, 
             DT_EXCLUIDO DATETIME NULL,
             
             PRIMARY KEY ( COD_TIPO_CLIENTE ),
)


CREATE TABLE TB_CLIENTE( 
              COD_CLIENTE INT IDENTITY(1,1), 
              NOM_USUAL VARCHAR(80) NULL, 
              NOM_COMPLETO VARCHAR(120) NULL, 
              NRO_CPF NUMERIC(11, 0) NULL, 
              DT_EXCLUIDO DATETIME NULL, 
              COD_TIPO_CLIENTE INT NULL,
              
              PRIMARY KEY ( COD_CLIENTE ),
    
              CONSTRAINT FK_COD_TIPO_CLIENTE FOREIGN KEY ( COD_TIPO_CLIENTE )
                         REFERENCES TB_TIPO_CLIENTE ( COD_TIPO_CLIENTE )
               )


create procedure AddClient 
(
              @NOM_USUAL VARCHAR(80) = NULL, 
              @NOM_COMPLETO VARCHAR(120) = NULL, 
              @NRO_CPF NUMERIC(11, 0) = NULL, 
              @DT_EXCLUIDO DATETIME = NULL, 
              @COD_TIPO_CLIENTE INT = NULL
)
as
begin
     insert into TB_CLIENTE( 
              NOM_USUAL, 
              NOM_COMPLETO , 
              NRO_CPF , 
              DT_EXCLUIDO,
   			  COD_TIPO_CLIENTE )
     values ( @NOM_USUAL, 
              @NOM_COMPLETO , 
              @NRO_CPF , 
              null,
              @COD_TIPO_CLIENTE )
end


create procedure GetAllClient 
as
begin
      select  cli.COD_CLIENTE, 
              cli.NOM_USUAL, 
              cli.NOM_COMPLETO, 
              cli.NRO_CPF, 
              cli.DT_EXCLUIDO, 
              cli.COD_TIPO_CLIENTE,
			  tpcli.DSC_TIPO_CLIENTE
   	         from TB_CLIENTE as cli
	    inner join TB_TIPO_CLIENTE as tpcli on
		    cli.COD_TIPO_CLIENTE = tpcli.COD_TIPO_CLIENTE
end



create procedure GetClientByID
(
    @COD_CLIENTE INT
)
as
begin
      select cli.COD_CLIENTE, 
              cli.NOM_USUAL, 
              cli.NOM_COMPLETO, 
              cli.NRO_CPF, 
              cli.DT_EXCLUIDO, 
              cli.COD_TIPO_CLIENTE,
			  tpcli.DSC_TIPO_CLIENTE
   	         from TB_CLIENTE as cli
	    inner join TB_TIPO_CLIENTE as tpcli on
		    cli.COD_TIPO_CLIENTE = tpcli.COD_TIPO_CLIENTE
	    where cli.COD_CLIENTE = @COD_CLIENTE
end


create procedure UpdateClient 
(
              @COD_CLIENTE INT,
              @NOM_USUAL VARCHAR(80) = NULL, 
              @NOM_COMPLETO VARCHAR(120) = NULL, 
              @NRO_CPF NUMERIC(11, 0) = NULL, 
              @COD_TIPO_CLIENTE INT = NULL
)
as
begin
     update TB_CLIENTE set
              NOM_USUAL        = @NOM_USUAL, 
              NOM_COMPLETO     = @NOM_COMPLETO, 
              NRO_CPF          = @NRO_CPF, 
              COD_TIPO_CLIENTE = @COD_TIPO_CLIENTE
     where COD_CLIENTE = @COD_CLIENTE
end


create procedure DeleteClient
(
    @COD_CLIENTE INT
)
as
begin
      delete from TB_CLIENTE
	  where COD_CLIENTE = @COD_CLIENTE
end

