insert into associates (associateName, associateLocale, revaPoints) values 
('Ai', 'CA', -20), ('Osiris', 'CA', -20), ('Jacob', 'FL', 50),  ('Janel', 'AZ', 50), ('Colton', 'OK', -180), ('Niles', 'AL', 200), ('Timothy', 'CT', -20), ('Aaron', 'RI', 200);
insert into trainers (trainerName, campus, caffeineLevel) values
('Marielle', 'USF', 60), ('Pushpinder', 'UTA', 50), ('Nick', 'UTA', 75), ('Mark', 'WVU', 16), ('Fred', 'UTA', 25), ('Juniper', 'USF', 197);
insert into batch (associateID, trainerID) values
(25,23), (26,21), (27,23), (29,19),(31, 22), (32,19);

select * from associates;

select count(id), associateLocale
From associates
group by associateLocale
order by count(id) desc;

select * from trainers;

select * from batch

Select * from associates full join batch on associates.id = batch.associateid;

select associatename, trainername from associates cross join trainers;

select trainername, associatename from trainers inner join batch on batch.trainerid = trainers.id inner join associates on batch.associateid = associates.id;

select trainername from trainers
except
select trainername from trainers inner join batch on batch.trainerid= trainers.id

select trainername from trainers
where id not in (select  trainerid from batch);


delete from associates;
delete from trainers;
delete from batch