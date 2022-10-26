const navbar = document.querySelector('#navbar-modal')
const abrirNavbar = document.querySelector('.cabecalho__btn-abrir-navbar')
const fecharNavbar = document.querySelector('.navbar__btn-fechar-navbar')


abrirNavbar.addEventListener('click', function () {
    navbar.showModal();
});

fecharNavbar.addEventListener('click', function () {
    navbar.close();
});