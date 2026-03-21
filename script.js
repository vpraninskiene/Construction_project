const docBody = document.getElementsByTagName("body")[0];
const navToggle = document.querySelector(".navbar_toggle");
const navLinks = document.querySelectorAll(".nav-link");
const links = document.querySelector(".menu-wrapper");
const card = document.querySelector(".cards-container");

const servicesButtons = document.querySelectorAll(".services-btn");

const servicesBtnOne = document.querySelector("#services-1-btn");
const servicesBtnTwo = document.querySelector("#services-2-btn");
const servicesBtnTree = document.querySelector("#services-3-btn");
const servicesBtnFour = document.querySelector("#services-4-btn");
const modal = document.querySelector(".modal");
const modalCloseBtn = document.querySelector(".close-modal-btn");
const closeModalBtnX = document.querySelector(".close-modal-btn-x");
const containerOverlay = document.querySelector("#overlay");
const list = document.querySelector(".list");

const showDescription = document.querySelectorAll(".description");
const galleryModal = document.querySelectorAll(".gallery-modal");
const galleryCloseModalBtnX = document.querySelectorAll(
  ".gallery-close-modal-btn-x",
);
const swiperSlider1 = document.querySelector("#slide-1");
const swiperSlider2 = document.querySelector("#slide-2");
const swiperSlider3 = document.querySelector("#slide-3");

const form = document.querySelector("#form");
const inputName = document.querySelector("#name");
const inputPhone = document.querySelector("#phone");
const inputMessage = document.querySelector("#message");
const nameError = document.querySelector("#nameError");
const phoneError = document.querySelector("#phoneError");
const messageError = document.querySelector("#messageError");

// Function to remove all AOS animations on mobile
function disableAOSOnMobile() {
  const mobileWidth = 768; //
  if (window.innerWidth <= mobileWidth) {
    document.querySelectorAll("[data-aos]").forEach((el) => {
      el.removeAttribute("data-aos");
    });
  }
}

function initAOSDesktop() {
  const mobileWidth = 600;
  if (window.innerWidth > mobileWidth) {
    AOS.init({
      duration: 800,
      once: true,
    });
  }
}
window.addEventListener("DOMContentLoaded", () => {
  disableAOSOnMobile();
  initAOSDesktop();
});

window.addEventListener("resize", () => {
  disableAOSOnMobile();
  if (window.innerWidth > 600) {
    AOS.refreshHard(); // re-evaluate AOS elements
  }
});

// menu

navToggle.addEventListener("click", function () {
  links.classList.toggle("show_nav");
});

for (let i = 0; i < navLinks.length; ++i) {
  navLinks[i].addEventListener("click", () => {
    if (links.classList.contains("show_nav")) {
      links.classList.remove("show_nav");
    }
  });
}

//scroll

links.addEventListener("click", function (e) {
  e.preventDefault();
  if (e.target.classList.contains("nav-link")) {
    const id = e.target.getAttribute("href");
    document.querySelector(id).scrollIntoView({ behavior: "smooth" });
  }
});

// cards

const cards = [
  {
    img: "./img/svg/safety.svg",
    title: "Patikimumas",
    text: "lorem ispum lorem lorem dolor lorem",
  },
  {
    img: "./img/svg/flex.svg",
    title: "Lankstumas",
    text: "lorem ispum lorem lorem dolor lorem",
  },
  {
    img: "./img/svg/experience.svg",
    title: "Patirtis",
    text: "lorem ispum lorem lorem dolor lorem",
  },
  {
    img: "./img/svg/quality.svg",
    title: "Kokybė",
    text: "lorem ispum lorem lorem dolor lorem",
  },
];

for (let i = 0; i < cards.length; i++) {
  const { img, title, text } = cards[i];
  const cardItem = document.createElement("div");
  const cardImgEl = document.createElement("img");
  const cardTitleEl = document.createElement("h4");
  const cardTextEl = document.createElement("p");
  card.appendChild(cardItem);
  cardItem.appendChild(cardImgEl);
  cardImgEl.src = img;
  cardItem.appendChild(cardTitleEl);
  cardTitleEl.textContent = title;
  cardItem.appendChild(cardTextEl);
  cardTextEl.textContent = text;
  cardItem.classList.add("card-style");
}

// services modal

const servicesList = [
  {
    id: 1,
    services: [
      "ispum dolor lorem",
      "lorem ispum dolor ",
      "lo ispu dolor lorem ipsum",
      "lorem ispum dolor lorem",
    ],
  },
  {
    id: 2,
    services: [
      "ispum dolor lorem",
      "lorem ispum dolor ",
      "lo ispu dolor lorem ipsum",
      "lorem ispum dolor lorem",
    ],
  },
  {
    id: 3,
    services: [
      "ispum dolor lorem",
      "lorem ispum dolor ",
      "lo ispu dolor lorem ipsum",
      "lorem ispum dolor lorem",
    ],
  },
  {
    id: 4,
    services: [
      "ispum dolor lorem",
      "lorem ispum dolor ",
      "lo ispu dolor lorem ipsum",
      "lorem ispum dolor lorem",
    ],
  },
];

const openModal = function (id) {
  list.innerHTML = ""; // clear previous items

  const selectedService = servicesList.find(
    (service) => service.id === Number(id),
  );

  selectedService.services.forEach((text) => {
    const li = document.createElement("li");
    li.textContent = text;
    list.appendChild(li);
  });

  modal.classList.remove("hidden");
  containerOverlay.classList.add("overlay");
  docBody.classList.add("stopScroll");
};

servicesButtons.forEach((button) => {
  button.addEventListener("click", function () {
    const id = this.dataset.id;
    openModal(id);
  });
});

const closeServicesModal = function () {
  modal.classList.add("hidden");
  containerOverlay.classList.remove("overlay");
  docBody.classList.remove("stopScroll");
  modal.classList.remove("modal-position-2");
  modal.classList.remove("modal-position-3");
  list.textContent = "";
};

modalCloseBtn.addEventListener("click", closeServicesModal);
closeModalBtnX.addEventListener("click", closeServicesModal);

// gallery

for (let i = 0; i < showDescription.length; i++) {
  showDescription[i].addEventListener("mouseover", function () {
    showDescription[i].classList.add("show");
  });
  showDescription[i].addEventListener("mouseout", function () {
    showDescription[i].classList.remove("show");
  });
}

for (let i = 0; i < showDescription.length; i++) {
  showDescription[i].addEventListener("click", function () {
    galleryModal[i].classList.remove("hidden");
    containerOverlay.classList.add("overlay");
    docBody.classList.add("stopScroll");
  });
}

for (let i = 0; i < galleryCloseModalBtnX.length; i++) {
  galleryCloseModalBtnX[i].addEventListener("click", function () {
    galleryModal[i].classList.add("hidden");
    containerOverlay.classList.remove("overlay");
    docBody.classList.remove("stopScroll");
  });
}

// swiper

const swiper = new Swiper(".swiper", {
  direction: "horizontal",

  pagination: {
    el: ".swiper-pagination",
  },

  // Navigation arrows
  rewind: true,
  navigation: {
    nextEl: ".swiper-button-next",
    prevEl: ".swiper-button-prev",
  },
});

// form validation

const submitForm = function (e) {
  const phoneno = /^[+]*[(]{0,1}[0-9]{1,3}[)]{0,1}[-\s\./0-9]*$/g;

  if (inputName.value === "" || inputName.value == null) {
    e.preventDefault();
    nameError.style.display = "block";
  } else {
    nameError.style.display = "none";
  }

  if (!inputPhone.value.match(phoneno)) {
    e.preventDefault();
    phoneError.style.display = "block";
  } else {
    phoneError.style.display = "none";
  }

  if (inputMessage.value === "" || inputMessage.value == null) {
    e.preventDefault();
    messageError.style.display = "block";
  } else {
    messageError.style.display = "none";
  }
};

form.addEventListener("submit", submitForm);
