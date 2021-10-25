Select * From Customers;

Select * from Shoppinglist;

Select * from ExpenseTotal;

Select * from UnavailableItems;

select customers.customername, customers.customeraddress, shoppinglist.customeritems, shoppinglist.customeritemquantity from customers inner join shoppinglist on shoppinglist.customerid=customers.id;