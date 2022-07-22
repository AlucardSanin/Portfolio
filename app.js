const Cards = [
  {
    id: 1,
    title: 'Batman',   
    description: 'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it 1960s with the releaLorem Ipsum is simply dummy text of the printing and typesetting  ever since the 1500s, when an unknown printer took a galley of type veris lapoa todoe.',
    tags: ['css', 'html', 'bootsrap', 'Ruby'],
    link: 'https://alucardsanin.github.io/Portfolio/',
    source: 'https://github.com/AlucardSanin/Portfolio',
    class: 'card-n',
  },
  {
    id: 2,
    title: 'Superman',    
    description: 'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it 1960s with the releaLorem Ipsum is simply dummy text of the printing and typesetting  ever since the 1500s, when an unknown printer took a galley of type veris lapoa todoe.',
    tags: ['css', 'html', 'bootsrap', 'Ruby'],
    link: 'https://alucardsanin.github.io/Portfolio/',
    source: 'https://github.com/AlucardSanin/Portfolio',
    class: 'card-nr',
  },
  {
    id: 3,
    title: 'Spiderman',    
    description: 'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it 1960s with the releaLorem Ipsum is simply dummy text of the printing and typesetting  ever since the 1500s, when an unknown printer took a galley of type veris lapoa todoe.',
    tags: ['css', 'html', 'bootsrap', 'Ruby'],
    link: 'https://alucardsanin.github.io/Portfolio/',
    source: 'https://github.com/AlucardSanin/Portfolio',
    class: 'card-n',
    },
  {
    id: 4,
    title: 'Ironman',    
    description: 'Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it 1960s with the releaLorem Ipsum is simply dummy text of the printing and typesetting  ever since the 1500s, when an unknown printer took a galley of type veris lapoa todoe.',
    tags: ['css', 'html', 'bootsrap', 'Ruby'],
    link: 'https://alucardsanin.github.io/Portfolio/',
    source: 'https://github.com/AlucardSanin/Portfolio',
    class: 'card-nr',
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
  <img src="Images/Img_Placeholder.png" alt="#" class="my-project-image">
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
<img src="Images/Snapshoot_Portfolio.png" id="Pop_Img" alt="Image description">
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
  <button class="vbutton-live" type="button"><a href="${Cards[i].link}">See Live</a></button>
  <button class="vbutton-source" type="button"><a href="${Cards[i].source}">See Source</a></button>
</div>
`;
body.appendChild(detail);

document.querySelector('.nav-bar').style.display = 'none';

  const close = document.getElementById('close');
  close.addEventListener('click', () => {
  body.removeChild(detail);
  document.querySelector('.nav-bar').style.display = 'flex';
  });
});
}

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

  