function Grid(reponse, type) {
    debugger
    const array = [];

    const result = TypeGrid(type);

    const div = document.createElement('div');
    div.classList.add('div');
    const table = document.createElement('table');
    table.classList.add('table');
    const trH = document.createElement('tr')

    document.body.appendChild(div);
    div.appendChild(table);
    table.appendChild(trH);

    for (let key in result) {
        const th = document.createElement('th');
        trH.appendChild(th);
        th.appendChild(document.createTextNode(result[key]));
        array.push(key);

    }

    for (let index = 0; index < reponse.length; index++) {
        const trD = document.createElement('tr');
        trD.classList.add('td');
        table.appendChild(trD);

        for (let i = 0; i < array.length; i++) {
            const td = document.createElement('td');
            trD.appendChild(td);
            td.appendChild(document.createTextNode(reponse[index][array[i]]));
        }
    }
}

function TypeGrid(type) {
    switch (type) {
        case 'TrabalhadorGerModel':
            return {
                'codigo': 'Código',
                'nome': 'Nome',
                'descricaoEmpresa': 'Empresa',
                'descricaoCargo': 'Cargo'
            };

        default:
            break;
    }
}
