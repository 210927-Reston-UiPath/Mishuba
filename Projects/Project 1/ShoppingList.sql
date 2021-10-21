create table ShoppingList (
    id serial primary key,
    customerId references Customers(id),
    customerItems varchar(100) not null,
    customerItemQuantity int not null
);

insert into ShoppingList (customersId, customerItems, customerItemQuantity) values
(), (), ();

select * from ShoppingList;