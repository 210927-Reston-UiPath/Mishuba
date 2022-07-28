create table associates (
    associateName varchar(100) not null,
    associateLocale varchar(2) not null,
    revaPoints int not null,
    id serial primary key
);

create table trainers (
    id serial primary key,
    trainerName varchar(100) not null,
    campus varchar (3) not null,
    caffeineLevel int not null
);

create table batch (
    id serial primary key,
    associateID int references associates(id),
    trainerID int references trainers(id)
);

-- this is a COMMENT
-- it only works for one line
-- each line requires another --