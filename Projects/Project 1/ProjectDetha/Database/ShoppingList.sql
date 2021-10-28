create table ShoppingList (
    id serial primary key,
    customerId int references Customers(id),
    customerItems varchar(100) not null,
    customerItemQuantity int not null
);


select * from shoppinglist