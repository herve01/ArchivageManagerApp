create database gestion_archivage_db;
use gestion_archivage_db;

create table service
(
	id varchar(32),
    designation varchar(32),
	constraint pk_service primary key(id)
);
create table agent
(
	id varchar(32),
    nom varchar(30),
    postnom varchar(30),
    prenom varchar(30),
    sexe varchar(10),
    mail varchar(100),
    telephone varchar(13),
    photo mediumtext,
    grade varchar(50),
    fonction varchar(50),
	constraint pk_agent primary key(id)
);
create table document
(
	id varchar(32),
    libelle varchar(50),
    extension enum('PDF', 'IMAGE') default 'PDF',
    mot_cle varchar(50),
    fichier longblob,
	constraint pk_document primary key(id)
);
create table affectation
(
	id varchar(32),
	agent_id varchar(32),
	old_service_id varchar(32),
    service_id varchar(32),
	date datetime,
	constraint pk_affectation primary key(id),
    constraint fk_affectation_agent foreign key(agent_id) references agent(id),
    constraint fk_affectation_old_service foreign key(old_service_id) references service(id),
	constraint fk_affectation_service foreign key(service_id) references service(id)
);
create table user
(
	id varchar(32),
	agent_id varchar(32),
    username varchar(32),
    passwd varchar(32),
    salt varchar(32),
	constraint pk_user primary key(id),
    constraint fk_user_agent foreign key(agent_id) references agent(id)
);
create table archive
(
	id varchar(32),
	user_id varchar(32),
    document_id varchar(32),
    date datetime,
	constraint pk_archive primary key(id),
    constraint fk_archive_user foreign key(user_id) references user(id),
    constraint fk_archive_document foreign key(document_id) references document(id)
);
