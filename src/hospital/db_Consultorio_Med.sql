use master;

drop database db_consultorio_med;


create database db_consultorio_med;

use db_consultorio_med;
go

create table tblCadAtendente(
	id_atendente int primary key,
	nome varchar(40),
	endereco nvarchar(40),
	cidade varchar(30),
	estado char(2),
	cpf char(11),
	fone char(15)
);

create table tblCadMedico(
	id_medico int primary key,
	crm int,
	nome varchar(40),
	endereco nvarchar(40),
	cidade varchar(30),
	estado char(2),
	cpf char(11),
	fone char(15)
);

create table tblCadEspecialidade(
	id_especialidade int primary key,
	especialidade varchar(20)
);

create table tblMedEspecialidade(
	id_medEspecialidade int primary key,
	id_especialidade int,
	id_medico int
	CONSTRAINT FK_id_Med FOREIGN KEY (id_medico)
	REFERENCES tblCadMedico(id_medico),
	CONSTRAINT FK_id_especialidade FOREIGN KEY (id_especialidade)
	REFERENCES tblCadEspecialidade(id_especialidade)
);

create table tblCadPaciente(
	id_paciente int primary key,
	nome varchar(40),
	endereco nvarchar(40),
	cidade varchar(30),
	estado char(2),
	cpf char(11),
	fone char(15)
);

create table tblConsultas(
	id_consulta int primary key,
	id_paciente int,
	id_medico int,
	id_especialidade int,
	data date,
	hora time,
	status varchar(300),
	CONSTRAINT FK_idPaciente FOREIGN KEY (id_paciente)
    REFERENCES tblCadPaciente(id_paciente),
    CONSTRAINT FK_id_medico FOREIGN KEY (id_medico)
    REFERENCES tblCadMedico(id_medico),
    CONSTRAINT FK_id_especialidade_Consu FOREIGN KEY (id_especialidade)
    REFERENCES tblCadEspecialidade(id_especialidade)
);

create table tblHistorico(
	id_historico int primary key,
	id_paciente int,
	id_medico int,
	id_consulta int,
	observacoes nvarchar(600),
	CONSTRAINT FK_id_paciente_historico FOREIGN KEY (id_paciente)
    REFERENCES tblCadPaciente(id_paciente),
    CONSTRAINT FK_id_medico_historico FOREIGN KEY (id_medico)
    REFERENCES tblCadMedico(id_medico),
    CONSTRAINT FK_id_consulta_historico FOREIGN KEY (id_consulta)
    REFERENCES tblConsultas(id_consulta)
);

create table tblAgendaMedEspecialidade(
	id_agenda int primary key,
	id_especialidade int,
	diasSemana nvarchar(11),
	HoraInicial time,
	HoraFinal time,
	id_medico int,
	CONSTRAINT FK_id_especialidade2 FOREIGN KEY (id_especialidade)
    REFERENCES tblCadEspecialidade(id_especialidade),
    CONSTRAINT FK_id_medico2 FOREIGN KEY (id_medico)
    REFERENCES tblCadMedico(id_medico)
);


create table tblCadTipoUsuario(
	id_tipo_user int primary key,
	tipo_user varchar(15)
);

create table tblUsuario(
	id_user int primary key,
	id_tipo_user int,
	id_paciente int,
	id_medico int,
	id_atendente int,
	id_super int,
	login varchar(20),
	senha nvarchar(25),
	CONSTRAINT FK_id_tipo_user FOREIGN KEY (id_tipo_user)
	REFERENCES tblCadTipoUsuario(id_tipo_user),
	CONSTRAINT FK_usuario_id_paciente FOREIGN KEY (id_paciente)
	REFERENCES tblCadPaciente(id_paciente),
	CONSTRAINT FK_usuario_id_medico FOREIGN KEY (id_medico)
	REFERENCES tblCadMedico(id_medico),
	CONSTRAINT FK_usuario_id_atendente FOREIGN KEY (id_atendente)
	REFERENCES tblCadAtendente(id_atendente),

);


go 

select * from tblCadAtendente;
select * from tblCadMedico;
select * from tblCadEspecialidade;
select * from tblCadPaciente;
select * from tblConsultas;
select * from tblAgendaMedEspecialidade;
