create table UnavailableItems (
    id serial primary key,
    customerId references Customers(id),
    itemNotFound varchar (100)
);

insert into UnavailableItems () values
(), (), ();

Select * from UnavailableItems;
