const navbar = document.querySelector('#navbar-modal')
const abrirNavbar = document.querySelector('.cabecalho__btn-abrir-navbar')
const fecharNavbar = document.querySelector('.navbar__btn-fechar-navbar')



abrirNavbar.addEventListener('click', function () {
    navbar.showModal();
});

fecharNavbar.addEventListener('click', function () {
    navbar.close();
});


const tel = document.getElementById('tel');

tel.addEventListener('keypress', (e) => mascaraTelefone(e.target.value));
tel.addEventListener('change', (e) => mascaraTelefone(e.target.value));

const mascaraTelefone = (valor) => {
    valor = valor.replace(/\D/g, "")
    valor = valor.replace(/^(\d{2})(\d)/g, "($1) $2")
    valor = valor.replace(/(\d)(\d{4})$/, "$1-$2")
    tel.value = valor
};