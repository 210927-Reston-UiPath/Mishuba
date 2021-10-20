function buy(name){
    debugger;

 let cart = document.querySelector('#cart tbody');
 let newItem = cart.insertRow();

 let itemName = newItem.insertCell(0);
 itemName.innerHTML = name;

 let elementID = '#' + name.replace(' ', '');

 let itemPrice = new Item.insertCell(1);
 itemPrice.innerHTML = document.querySelector(elelmentID+' .price').innerHTML;

 let itemQuantity = new Item.insertCell(2);
 itemQuantity.innerHTML = document.querySelector(elelmentID+'  td .quantity').value;
//resets the shopping cart after the transcation
 document.querySelector(elelmentID+'  td .quantity').value = ' ';


}

function checkout()
{
    doucment.querySelectorAll('#cart tbody tr').forEach(row => );
    
}