Select * from customers
Select * From Customers order by customers.id asc;

Select * from Shoppinglist;

Select * from ExpenseTotal;

Select * from UnavailableItems;

-- use this for UiPath Loop.
Select customers.id, customername, customerlastname, customeremail, customeraddress, customerstate, customercountry, customerzipcode, customerareacode, customerphonenumber, customeritems, customeritemquantity, customercardtype, customersecuritycode, customercardnumber, customerexpirationm, customerexpirationy from customers join shoppinglist on shoppinglist.customerid=customers.id order by customerid asc;

delete from expensetotal;

Update Customers set customercardtype = 'Visa' where customers.id = 2

