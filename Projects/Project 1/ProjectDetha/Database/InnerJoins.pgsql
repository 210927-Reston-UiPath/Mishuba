select customers.customername, customers.customeraddress, shoppinglist.customeritems, shoppinglist.customeritemquantity from customers inner join shoppinglist on shoppinglist.customerid=customers.id;

select customers.customername, customers.customeremail, expensetotal.totalamount from customers inner join expensetotal on expensetotal.customerid=customers.id;

select customers.customername, customers.customeremail, unavailableitems.itemnotfound from customers inner join unavailableitems on unavailableitems.customerid=customers.id;

select customername, customeraddress, customeritems, customeritemquantity, totalamount from customers, expensetotal, shoppinglist;

create table shoppingcart (
    id serial primary key,
    CustomersID int references Customers(id) join shoppinglist on shoppinglist.customerid=customerid,
    customersitems varchar (100) references shoppinglist(customeritems)
    customerQuantity int references shoppinglist(customeritemquantity),
    ExpensesTotal int references expensetotal (TotalAmount)
);
