create table Customers (
    id serial primary key,
    customerName varchar(100) not null,
    customerLastName varchar(100) not null,
    customerEmail varchar(200) not null,
    customerAddress varchar (150) not null,
    customerState varchar (20) not null,
    customerCountry varchar (20) not null,
    customerZipCode varchar (10) not null,
    customerAreaCode varchar (5) not null,
    customerPhoneNumber int not null,
    customerCardType varchar (30) not null,
    customerSecurityCode int not null,
    customerCardNumber int not null,
    customerExpirationM varchar (39) not null,
    customerExpirationY int not null
);

select * from customers;

ALTER TABLE Customers ALTER COLUMN customerCardNumber TYPE BIGINT
