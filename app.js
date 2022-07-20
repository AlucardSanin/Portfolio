document.querySelector('.menu').addEventListener('click',display);

function display(){
    document.querySelector('.mobile-menu').style.display= "block";
    document.getElementById('portf').addEventListener('click',hide);
    document.getElementById('abo').addEventListener('click',hide);
    document.getElementById('cont').addEventListener('click',hide);
    document.getElementById('close').addEventListener('click',hide);
}

function hide(){
document.querySelector('.mobile-menu').style.display= "none";}