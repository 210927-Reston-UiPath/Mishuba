create table ExpenseTotal (
    id serial primary key,
    customerId int references Customers(id),
    totalAmount int not null
);

insert into ExpenseTotal () values
(), (), ();

Select * from ExpenseTotal;



