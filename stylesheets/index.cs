* {
  margin: 0;
  padding: 0;
  font-family: "Roboto", sans-serif;
}

.container {
  width: 100%;
}
.container header {
  position: fixed;
  left: 0;
  top: 0;
  width: 100%;
  z-index: 1;
}
.container header .contacts-social {
  display: flex;
  flex-direction: column;
  justify-content: space-around;
  align-items: center;
  background: url(/img/jpg/wall-2.jpg);
  padding: 10px;
  gap: 10px;
}
.container header .contacts-social .social {
  display: flex;
  gap: 5px;
}
.container header .contacts-social .social .facebook {
  background: url(/img/svg/square-facebook.svg);
  height: 1.2rem;
  width: 1.2rem;
  background-repeat: no-repeat;
}
.container header .contacts-social .social .linkedin {
  background: url(/img/svg/linkedin.svg);
  height: 1.15rem;
  width: 1.15rem;
  background-repeat: no-repeat;
  background-size: cover;
  border-radius: 3px;
}
.container header .contacts-social .contacts {
  display: flex;
  flex-direction: column;
  color: white;
}
.container header .contacts-social .contacts .phone,
.container header .contacts-social .contacts .email {
  display: flex;
  flex-direction: row;
  justify-content: center;
  align-items: center;
  font-size: 1rem;
  gap: 5px;
}
.container header .contacts-social .contacts .phone-icon,
.container header .contacts-social .envelope-icon {
  width: 1rem;
  height: 1rem;
}
.container header .contacts-social .contacts .phone-icon {
  background: url(/img/svg/phone-solid.svg);
  background-repeat: no-repeat;
  background-size: cover;
}
.container header .contacts-social .contacts .envelope-icon {
  background: url(/img/svg//envelope-solid.svg);
  background-repeat: no-repeat;
  background-size: cover;
}
.container header .navbar {
  width: 100%;
  display: flex;
  flex-direction: column;
  background-color: rgb(35, 34, 48);
  text-align: center;
}
.container header .navbar .logo {
  display: none;
}
.container header .navbar .logo .logo-img {
  background: url(/img/jpg/img-2.png);
  background-size: cover;
  background-repeat: no-repeat;
  width: 65px;
  height: 65px;
  color: white;
}
.container header .navbar .logo p {
  color: white;
  margin: 0;
  font-size: 0.5rem;
  font-family: "Bruno Ace SC";
}
.container header .navbar .logo span {
  color: #f0542d;
  font-family: "Bruno Ace SC";
  margin: 0;
  font-size: 0.5rem;
}
.container header .menu-wrapper {
  display: none;
}
.container header .menu-wrapper li {
  font-size: 1.2rem;
  text-align: center;
  list-style: none;
}
.container header .menu-wrapper a {
  text-decoration: none;
  color: #f4eee3;
  margin: 10px;
  padding: 5px 0;
  display: block;
  text-align: center;
  position: relative;
}
.container header .menu-wrapper a::before {
  content: "";
  position: absolute;
  background-color: #ffb003;
  bottom: 0;
  left: 0;
  height: 1.5px;
  width: 0;
}
.container header .menu-wrapper a:hover::before {
  transition: width 0.5s;
  transition-timing-function: ease;
  width: 100%;
}
.container header .menu-wrapper .menu-list {
  padding-bottom: 15px;
}
.container header .show_nav {
  display: flex;
  width: 100vw;
  flex-direction: column;
  justify-content: center;
  background-color: rgb(35, 34, 48);
}
.container header .navbar_toggle {
  text-align: center;
  background-color: rgb(35, 34, 48);
  border: none;
  outline: none;
  padding: 10px;
}
.container header header .menu img {
  height: 20px;
  width: 30px;
}
.container .section {
  height: 100vh;
}
.container main {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  width: 100vw;
  background: url(/img/jpg/img-1.jpg);
  background-size: cover;
  background-repeat: no-repeat;
}
.container main .hero-text {
  background: rgba(35, 34, 48, 0.5);
  padding: 80px;
  text-align: center;
}
.container main .hero-text h1 {
  color: #f4eee3;
  font-size: 50px;
  overflow: hidden;
  line-height: 1;
  padding-bottom: 10px;
}
.container main .hero-text span {
  display: block;
  animation: reveal 1.8s ease 0.5s;
}
.container main .hero-text p {
  color: #f4eee3;
  font-size: 20px;
  animation: reveal 1.8s ease 0.5s;
  overflow: hidden;
  line-height: 1;
}
@keyframes reveal {
  0% {
    transform: translate(0, 100%);
    opacity: 0.1;
  }
  25% {
    opacity: 0.25;
  }
  50% {
    opacity: 0.5;
  }
  75% {
    opacity: 0.75;
  }
  100% {
    transform: translate(0, 0);
    opacity: 1;
  }
}
.container .about {
  padding: 80px 0;
  text-align: center;
  width: 100vw;
}
.container .about h2 {
  padding-bottom: 50px;
  font-size: 25px;
}
.container .about .about-description {
  display: flex;
  flex-direction: column;
  padding-bottom: 40px;
}
.container .about .about-description .about-images {
  display: flex;
}
.container .about .about-description .about-images .about-img {
  width: 50%;
  height: 250px;
}
.container .about .about-description .about-images #about-img-1 {
  background: url(/img/jpg/about.jpg);
  background-size: cover;
  background-repeat: no-repeat;
}
.container .about .about-description .about-images #about-img-2 {
  background: url(/img/jpg/about-2.jpg);
  background-size: cover;
  background-repeat: no-repeat;
}
.container .about .about-description .about-text {
  text-align: center;
  font-size: 16px;
  padding: 0 20px 20px 20px;
}
.container .cards-container {
  width: 100vw;
  display: grid;
  grid-template-columns: 1fr 1fr;
  text-align: center;
  background-color: #ffb003;
  gap: 10px;
}
.container .cards-container .card-style {
  place-self: center;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  gap: 10px;
  border: 2px solid #f4eee3;
  border-radius: 15px;
  width: 140px;
  height: 80px;
  font-size: 16px;
  color: #f4eee3;
  margin: auto;
}
.container .services {
  width: 100vw;
  display: flex;
  flex-direction: column;
  align-items: center;
  background-color: rgb(35, 34, 48);
  color: #f4eee3;
  padding: 40px 0 40px 0;
  position: relative;
}
.container .services .services-container {
  text-align: center;
}
.container .services h2 {
  font-size: 25px;
  padding-bottom: 40px;
}
.container .services .services-btn {
  padding: 10px;
  font-size: 18px;
  width: 250px;
  background-color: #ffb003;
  color: #f4eee3;
  border: none;
  margin: auto;
  border-radius: 15px;
}
.container .services .all-services {
  display: flex;
  flex-direction: column;
  font-size: 20px;
  gap: 30px;
  padding: 0 20px;
}
.container .services .all-services .service-item {
  display: flex;
  flex-direction: column;
  gap: 25px;
}
.container .services .all-services .service-img {
  width: 100%;
  height: 250px;
  overflow: hidden;
}
.container .services .all-services #img-1 {
  background: url("/img/jpg/internal.jpg");
  background-repeat: no-repeat;
  background-size: cover;
}
.container .services .all-services #img-2 {
  background: url("/img/jpg/external.jpg");
  background-repeat: no-repeat;
  background-size: cover;
}
.container .services .all-services #img-3 {
  background: url("/img/jpg/external-2.jpg");
  background-repeat: no-repeat;
  background-size: cover;
}
.container .services .modal {
  position: absolute;
  color: #232230;
  background-color: #f4eee3;
  text-align: right;
}
.container .services .modal-content {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  width: 350px;
  height: 300px;
  font-size: 16px;
  margin: auto;
}
.container .services .modal-content h3 {
  padding-bottom: 30px;
}
.container .services .modal-content .close-modal-btn {
  padding: 10px;
  font-size: 16px;
  width: 150px;
  background-color: #ffb003;
  color: #f4eee3;
  border: none;
  margin-top: 40px;
  border-radius: 15px;
}
.container .services .close-modal-btn-x {
  border: none;
  padding: 20px;
  font-size: 16px;
  background-color: #f4eee3;
}
.container .hidden {
  display: none;
}
.container .overlay {
  opacity: 0.3;
}
.container .modal-position-2 {
  top: 380px;
}
.container .modal-position-3 {
  top: 740px;
}
.container .gallery {
  margin-top: 150px;
  text-align: center;
  /* Hide the images by default */
  /* Next & previous buttons */
  /* Position the "next button" to the right */
  /* On hover, add a black background color with a little bit see-through */
  /* The dots/bullets/indicators */
  /* Fading animation */
}
.container .gallery h2 {
  text-align: center;
  font-size: 25px;
  padding-bottom: 70px;
}
.container .gallery p {
  padding-bottom: 30px;
  font-size: 20px;
  width: 80%;
  margin: auto;
}
.container .gallery .slideshow-container {
  max-width: 700px;
  position: relative;
  margin: auto;
}
.container .gallery .slide {
  display: none;
}
.container .gallery .slide .slide-image-1 {
  background: url(/img/jpg/gallery-1.jpg);
  height: 500px;
  width: 100%;
  background-size: cover;
}
.container .gallery .slide .slide-image-2 {
  background: url(/img/jpg/gallery-2.jpg);
  height: 500px;
  width: 100%;
  background-size: cover;
}
.container .gallery .slide .slide-image-3 {
  background: url(/img/jpg/gallery-3.jpg);
  height: 500px;
  width: 100%;
  background-size: cover;
}
.container .gallery .prev,
.container .gallery .next {
  cursor: pointer;
  position: absolute;
  top: 50%;
  width: auto;
  margin-top: -22px;
  padding: 16px;
  color: white;
  font-weight: bold;
  font-size: 18px;
  transition: 0.6s ease;
  border-radius: 0 3px 3px 0;
  user-select: none;
}
.container .gallery .next {
  right: 0;
  border-radius: 3px 0 0 3px;
}
.container .gallery .prev:hover,
.container .gallery .next:hover {
  background-color: rgba(35, 34, 48, 0.8);
}
.container .gallery .dot {
  cursor: pointer;
  height: 15px;
  width: 15px;
  margin: 0 2px;
  background-color: #f4eee3;
  border-radius: 50%;
  display: inline-block;
  transition: background-color 0.6s ease;
}
.container .gallery .active,
.container .gallery .dot:hover {
  background-color: #ffb003;
}
.container .gallery .fade {
  animation-name: fade;
  animation-duration: 1.5s;
}
.container .contact-form {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  background-color: rgb(35, 34, 48);
}
.container .contact-form h2 {
  color: #f4eee3;
  font-size: 25px;
  padding: 30px;
}
.container .contact-form form {
  width: 50vw;
  display: flex;
  flex-direction: column;
  align-items: left;
  justify-content: center;
  font-size: 16px;
}
.container .contact-form form label {
  color: #f4eee3;
}
.container .contact-form form input {
  width: 100%;
  height: 40px;
}
.container .contact-form form textarea {
  width: 100%;
  height: 180px;
}
.container .contact-form form .submit-btn {
  margin: auto;
  padding: 15px 30px;
  border-radius: 5px;
  border: none;
  background-color: #ffb003;
  color: #f4eee3;
  font-size: 18px;
}
.container .contact-form form span {
  color: red;
}
.container .reserved {
  width: 100vw;
  background: url(/img/jpg/wall-2.jpg);
  padding: 10px;
  color: #f4eee3;
  text-align: center;
}

@media screen and ((min-width: 769px) and (max-width: 1024px)) {
  .container header .contacts-social {
    flex-direction: row;
    gap: 20px;
  }
  .container header .contacts-social .contacts {
    flex-direction: row;
    gap: 20px;
  }
  .container header .menu-wrapper .logo {
    display: block;
    padding-bottom: 10px;
  }
  .container header .logo p {
    font-size: 0.7rem;
  }
  .container header .logo span {
    font-size: 0.7rem;
  }
  .container header .logo .logo-img {
    width: 75px;
    height: 75px;
    margin: auto;
  }
  .container header .navbar_toggle {
    display: none;
  }
  .container header .menu-wrapper {
    display: flex;
    flex-direction: row;
    align-items: center;
    justify-content: space-around;
    border-bottom: 2px solid #ffb003;
  }
  .container header .menu-wrapper .menu-list {
    padding-bottom: 0;
  }
  .container header .menu-wrapper .menu-list li {
    font-size: 1.2rem;
    display: inline-block;
  }
  .container .about .about-text {
    width: 80%;
  }
  .container .about .cards-container {
    width: 90%;
    display: flex;
    flex-direction: row;
    justify-content: space-around;
  }
  .container .about .about-text {
    padding: 40px 10px;
  }
  .container .services h2 {
    padding-bottom: 50px;
  }
  .container .services .all-services {
    flex-direction: row;
    gap: 100px;
  }
  .container .services .modal-content {
    width: 500px;
    height: 350px;
  }
  .container .slideshow-container .slide img {
    height: 500px;
  }
}
@media only screen and (min-width: 1025px) {
  .container header .contacts-social {
    flex-direction: row;
    gap: 20px;
  }
  .container header .contacts-social .contacts {
    flex-direction: row;
    gap: 20px;
  }
  .container header .menu-wrapper .logo {
    display: block;
    padding-bottom: 10px;
  }
  .container header .logo p {
    font-size: 0.7rem;
  }
  .container header .logo span {
    font-size: 0.7rem;
  }
  .container header .logo .logo-img {
    width: 75px;
    height: 75px;
    margin: auto;
  }
  .container header .navbar_toggle {
    display: none;
  }
  .container header .menu-wrapper {
    display: flex;
    flex-direction: row;
    align-items: center;
    justify-content: space-around;
    border-bottom: 2px solid #ffb003;
  }
  .container header .menu-wrapper .menu-list {
    padding-bottom: 0;
  }
  .container header .menu-wrapper .menu-list li {
    font-size: 1.2rem;
    display: inline-block;
  }
  .container .hero h1 {
    font-size: 70px;
  }
  .container .about {
    padding-top: 180px;
    margin: auto;
  }
  .container .about h2 {
    padding-bottom: 100px;
    font-size: 30px;
  }
  .container .about .about-description {
    display: flex;
    flex-direction: row;
    align-items: flex-start;
    justify-content: center;
    gap: 40px;
  }
  .container .about .about-description .about-text {
    display: flex;
    flex-direction: column;
    gap: 20px;
    font-size: 20px;
    width: 80vw;
    padding-top: 20px;
  }
  .container .about .about-description .about-text span {
    font-size: 40px;
  }
  .container .about .about-description .about-images {
    display: flex;
    justify-content: left;
    align-items: left;
    width: 100vw;
    height: 70vh;
    position: relative;
  }
  .container .about .about-description .about-images .about-img {
    width: 500px;
    height: 350px;
  }
  .container .about .about-description .about-images #about-img-2 {
    position: absolute;
    top: 200px;
    right: 50px;
  }
  .container .cards-container {
    display: flex;
    justify-content: space-around;
    padding: 40px 0;
  }
  .container .cards-container .card-style {
    height: 90px;
  }
  .container .services h2 {
    padding-bottom: 50px;
  }
  .container .services .all-services {
    flex-direction: row;
    justify-content: space-around;
    width: 95vw;
  }
  .container .services .all-services .service-item {
    width: 30%;
    height: 350px;
  }
  .container .services .modal {
    top: 50px;
  }
  .container .services .modal .modal-content {
    width: 500px;
    height: 350px;
  }
  .container .slideshow-container .slide img {
    height: 500px;
  }
}

/*# sourceMappingURL=index.cs.map */
