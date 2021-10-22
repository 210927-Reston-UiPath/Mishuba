create table Customers (
    id serial primary key,
    customerName varchar(100) not null,
    customerEmail varchar(200) not null,
    customerAddress varchar (150) not null
);

insert into Customers (customerName, customerEmail, CustomerAddress) values
('Ackma', 'ackma.email.com', 'the village'), ('Duwen', 'duwen.email.com', 'the earth'), ('Halu', 'halu.email.com', 'the parrell');

select * from Customers;
