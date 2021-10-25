select customers.customername, customers.customeraddress, shoppinglist.customeritems, shoppinglist.customeritemquantity from customers inner join shoppinglist on shoppinglist.customerid=customers.id;

select customers.customername, customers.customeremail, expensetotal.totalamount from customers inner join expensetotal on expensetotal.customerid=customers.id;

select customers.customername, customers.customeremail, unavailableitems.itemnotfound from customers inner join unavailableitems on unavailableitems.customerid=customers.id;