create table ExpenseTotal (
    id serial primary key,
    customerId references Customers(id),
    TotalAmount int not null
);

insert into ExpenseTotal () values
(), (), ();

Select * from ExpenseTotal;



