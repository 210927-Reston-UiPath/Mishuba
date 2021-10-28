function buy(name) {
    let cart = document.querySelector('#cart tbody');

    let newItem = cart.insertRow();
    let itemName = newItem.insertCell(0);
    itemName.innerHTML = name;

    let elementID = '#' + name.replaceAll(' ', '');

    let itemPrice = newItem.insertCell(1);
    itemPrice.innerHTML = document.querySelector(elementID + ' .price').innerHTML;

    let itemQuantity = newItem.insertCell(2);
    itemQuantity.innerHTML = document.querySelector(elementID + ' td .quantity').value;

    document.querySelector(elementID + ' td .quantity').value = '';
}

function checkout() 
{
    document.querySelectorAll('#cart tbody tr').forEach(row => row.remove());
}