create table ShoppingList (
    id serial primary key,
    customerId int references Customers(id),
    customerItems varchar(100) not null,
    customerItemQuantity int not null
);

insert into ShoppingList (customerId, customerItems, customerItemQuantity) values
(1, 'pizza', 2), (1, 'music', 3), (1, 'video games', 10), (2, 'Ice cream', 3), (2, 'soda', 2), (2, 'jewelry', 10), (3, 'Apples', 5), (3, 'Movies', 1), (3, 'Shoes', 2);

select * from ShoppingLIst;
