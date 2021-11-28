
//Working on the news sections

function tick() {
        $('#NewsTickerScroll li:first').slideUp( function() {
            $(this).appendTo($('#NewsTickerScroll')).slideDown();
        });
    } 
    setInterval(function() { tick () }, 5000);
// End of the news section ticker.

// Community post update section

// end of coummunity post update section

// music player section

// end of music player section

// random facts section
function tickRandomFacts() {
    $('#TheList li:first').slideUp( function() {
        $(this).appendTo($('#TheList')).slideDown();
    });
} 
setInterval(function() { tickRandomFacts () }, 5000);
// end random facts section

//Business info (The footer one) ticker in the footer.
function tickBusiness() {
    $('#BizTickerScroll li:first').slideUp( function() {
        $(this).appendTo($('#BizTickerScroll')).slideDown();
    });
} 
setInterval(function() { tickBusiness () }, 10000);
// End of business info (The footer one) section ticker.

/* The game homepage game javascript code here */
var MishubaHomeGame = document.getElementById("MishubaHomeGame");
var block = document.getElementById("block");

function jump(){
    if(MishubaHomeGame.classList != "animate") {
    MishubaHomeGame.classList.add("animate");
    }
    setTimeout(function(){
        MishubaHomeGame.classList.remove("animate");
    },500);
}

//fix the numbers in this section so that the game works.
var checkDead = setInterval(function(){
    var MishubaHomeGameTop =
    parseInt(window.getComputedStyle(MishubaHomeGame).getPropertyValue("top"));
    var blockLeft =
    parseInt(window.getComputedStyle(block).getPropertyValue("left"));
    if(blockLeft<94 && blockleft>100 && MishubaHomeGameTop >= 40) {
        block.style.animation = "none";
        block.style.display = "none";
        alert("you lose.");
    }
},10);

//End of the javascript HomePageGame

// the shopping cart javascript below
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
// end of the shopping cart section