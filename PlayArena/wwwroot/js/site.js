const searchInput = document.getElementById('searchInput');
const imagemSearchInput = document.getElementById('lupa');
const botaoCompra = document.getElementById('botao');
const botaoAluguel = document.getElementById('botaoAluguel');
const modalCompra = document.getElementById('modalCompraId');
const modalAluguel = document.getElementById('modalAluguelId');

if (searchInput !== null) {
    searchInput.addEventListener('input', (event) => {
        const value = formatString(event.target.value);

        const items = document.querySelectorAll('.cardscatalogo');

        items.forEach(item => {
            if (formatString(item.textContent).indexOf(value) !== -1) {
                item.style.display = 'flex';
            } else {
                item.style.display = 'none';
            }
        })
    });

    searchInput.addEventListener('input', (event) => {
        const value = event.target.value;
        imagemSearchInput.style.display = value.trim() === '' ? 'block' : 'none';
    });

    searchInput.addEventListener('focus', () => {
        imagemSearchInput.style.display = 'none';
    });

    document.addEventListener('click', (event) => {
        if (event.target !== searchInput && searchInput.value.trim() === '') {
            imagemSearchInput.style.display = 'block';
        }
    });
}

function formatString(value) {
    return value.toLowerCase().trim();
}

botaoCompra.onclick = function () {
    modalCompra.showModal()
}

botaoAluguel.onclick = function () {
    modalAluguel.showModal()
}