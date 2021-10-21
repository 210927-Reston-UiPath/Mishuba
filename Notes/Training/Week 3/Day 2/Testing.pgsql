create table Customers (
    id serial primary key,
    customerName varchar(100) not null,
    customerEmail varchar(200) not null,
    customerAddress varchar (150) not null
);

create table Items (
    customersId int references Customers(id) primary key,
    customerItem varchar (100) not null,
    customerItemQuantity int not null
);

insert into Customers (customerName, customerEmail, CustomerAddress) values
('Ackma', 'ackma.email.com', 'the village'), ('Duwen', 'duwen.email.com', 'the earth'), ('Halu', 'halu.email.com', 'the parrell');


insert into Items (CustomersId, customerItem, customerItemQuantity) values
(1, 'Fruit', 7), (1, 'Clothes', 14), (1, 'Music', 2), (2, 'Skateboard', 1), (2, 'Movies', 3), (2, 'computer', 1), (3, 'gloves', 2), (3, 'hair accessories', 30), (3, 'pet food', 100);
