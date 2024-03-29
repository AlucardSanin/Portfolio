const Cards = [
  {
    id: 1,
    title: 'A view to the past: LBA Game',   
    description: 'A game from my birth year 1994. Little Big Adventure represents my childhood, not just as a game but my first sigh of falling in love with softwares.',
    tags: ['css', 'html', 'javascript', 'Figma Template' ],
    link: 'https://alucardsanin.github.io/First_Capstone/index.html',
    source: 'https://github.com/AlucardSanin/First_Capstone',
    class: 'card-n',
    image: './Images/Captura.jpg',
  },
  {
    id: 2,
    title: 'Retink Task Page',    
    description: 'Web Application created with React and plain CSS.',
    tags: ['css', 'html', 'bootsrap', 'Git Flow'],
    link: 'https://retink-intern.netlify.app/',
    source: 'https://github.com/AlucardSanin/retink_presale_page',
    class: 'card-nr',
    image: './Images/CapturaRetink.jpg',
  },
  {
    id: 3,
    title: 'SpaceHub Travellers',    
    description: 'Web App developed with React & Redux fetching data from the SpaceX API to display and reserve Rockets & Missions. Tailwind CSS for Styling.',
    tags: ['css', 'html', 'tailwind', 'Git Flow'],
    link: 'https://spacehubtrav.netlify.app/',
    source: 'https://github.com/AlucardSanin/SpaceHub',
    class: 'card-n',
    image: './Images/CapturaSpaceHub.jpg',
    },
  {
    id: 4,
    title: 'Meals Database API',    
    description: 'Simple web app that fetch data from an API to display different types of meals.',
    tags: ['css', 'html', 'javascript', 'API'],
    link: 'https://alucardsanin.github.io/MealsDB/',
    source: 'https://github.com/rebel216/Capstone_Javascript',
    class: 'card-nr',
    image: './Images/CapturaMeals.jpg',
  },
];

const body = document.querySelector('body');
const Grid = document.createElement('div');
Grid.classList.add('grid-container');

const Footer = document.querySelector('.footer');
body.insertBefore(Grid, Footer);

for (let i=0; i<Cards.length; i++)
{
  const card = document.createElement('div');   
  card.classList.add(Cards[i].class);  
  Grid.appendChild(card);     
  card.innerHTML=`
  <img src="${Cards[i].image}" alt="#" class="my-project-image">
  <div id="content">
  <h3 class="my-work-title">${Cards[i].title}</h3>    
  <p class="my-work-description">${Cards[i].description}</p>
  <ul class="my-work-tools">
    <li>${Cards[i].tags[0]}</li>          
    <li>${Cards[i].tags[1]}</li>          
    <li>${Cards[i].tags[2]}</li>          
    <li>${Cards[i].tags[3]}</li>
  </ul>
  <button class="visualize-button" type="button">See Project</button>
  </div> 
  `;
}

const open = document.querySelectorAll('.visualize-button');
for (let i = 0; i < Cards.length; i ++) {
open[i].addEventListener('click', () => {
const detail = document.createElement('div');
detail.classList.add('details'); 
body.appendChild(detail); 
detail.innerHTML=`
<div id="head">
<h2>${Cards[i].title}</h2>
<img id="close" src="Images/x.svg" alt="Close">
</div>
<img src="${Cards[i].image}" alt="#" class="modal-image">
<p>${Cards[i].description}</p>
<div id="Cwt">
  <ul class="my-work-tools">
    <li>${Cards[i].tags[0]}</li>          
    <li>${Cards[i].tags[1]}</li>          
    <li>${Cards[i].tags[2]}</li>          
    <li>${Cards[i].tags[3]}</li>
  </ul>  
</div>
<div id="Buttons">
  <button class="vbutton-live" type="button"><a href="${Cards[i].link}" target="_blank">See Live</a></button>
  <button class="vbutton-source" type="button"><a href="${Cards[i].source}" target="_blank">See Source</a></button>
</div>
`;
body.appendChild(detail);

document.querySelector('.main-header').style.display = 'none';

  const close = document.getElementById('close');
  close.addEventListener('click', () => {
  body.removeChild(detail);
  document.querySelector('.main-header').style.display = 'flex';
  });
});
}

  const mail = document.getElementById('email');
  var mailformat = /^[a-z\-0-9\.\*\#\$\!\~\%\^\&\-\+\?\|]+@+[a-z\-0-9]+(.com)$/;
  const form = document.getElementById('Submit');
  const submit = document.getElementById('submit_btn');


  form.addEventListener('submit', function (event) {
  if (mail.value.match(mailformat)) {
    document.getElementById('Val_Err').style.display = 'none';  
    mail.setCustomValidity("Way to go!");
    mail.reportValidity(); 
      
  } else {
    event.preventDefault();
    document.getElementById('Val_Err').style.display = 'block';    
  }
});

function hide() {
  document.querySelector('.mobile-menu').style.display= 'none';  
}

function display() {
  document.querySelector('.mobile-menu').style.display = 'block';
  document.getElementById('portf').addEventListener('click', hide);
  document.getElementById('abo').addEventListener('click', hide);
  document.getElementById('cont').addEventListener('click', hide);
  document.getElementById('close_menu').addEventListener('click', hide);
}
  document.querySelector('.menu').addEventListener('click', display);

  