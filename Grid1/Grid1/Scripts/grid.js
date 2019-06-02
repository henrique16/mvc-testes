let _data = null;
let _dic = null;
let _idDiv = null;

class Grid {
    constructor(data, dic, idDiv) {
        debugger
        _data = JSON.parse(data);
        _dic = JSON.parse(dic);
        _idDiv = idDiv;
        this.Method();
    }

    Method() {
        debugger
        new MontaTabela();
    }
}

class Helper {
    constructor(data, dic, array) {
        debugger
        _data = JSON.parse(data);
        _dic = JSON.parse(dic);
        this._array = array;
        this.Method();
    }

    _array;

    Method() {

    }
}

class MontaTabela {
    constructor() {
        this.Method();
    }

    Method() {
        debugger
        const array = [];
        const div = document.getElementById(_idDiv);
        const table = document.createElement('table');
        table.classList.add('table');
        const trH = document.createElement('tr')

        div.appendChild(table);
        table.appendChild(trH);

        for (let key in _dic) {
            const th = document.createElement('th');
            trH.appendChild(th);
            th.appendChild(document.createTextNode(_dic[key]));
            array.push(key);

        }

        for (let index = 0; index < _data.length; index++) {
            const trD = document.createElement('tr');
            trD.addEventListener('click', this.RowEvenet);
            trD.classList.add('tr');
            table.appendChild(trD);

            for (let i = 0; i < array.length; i++) {
                const td = document.createElement('td');
                trD.appendChild(td);
                td.appendChild(document.createTextNode(_data[index][array[i]]));
            }
        }
    }
}

//let vResponse = null;
//let vType = null;

//function Grid(reponse, type, id) {
//    debugger
//    vResponse = reponse;
//    vType = type;

//    const array = [];

//    const result = TypeGrid(type);

//    const div = document.getElementById(id);
//    const table = document.createElement('table');
//    table.classList.add('table');
//    const trH = document.createElement('tr')

//    document.body.appendChild(div);
//    div.appendChild(table);
//    table.appendChild(trH);

//    for (let key in result) {
//        const th = document.createElement('th');
//        trH.appendChild(th);
//        th.appendChild(document.createTextNode(result[key]));
//        array.push(key);

//    }

//    for (let index = 0; index < reponse.length; index++) {
//        const trD = document.createElement('tr');
//        trD.addEventListener('click', this.RowEvenet);
//        trD.classList.add('td');
//        table.appendChild(trD);

//        for (let i = 0; i < array.length; i++) {
//            const td = document.createElement('td');
//            trD.appendChild(td);
//            td.appendChild(document.createTextNode(reponse[index][array[i]]));
//        }
//    }
//}

//function TypeHelper(type, index) {
//    debugger
//    switch (type) {
//        case 'TrabalhadorGerModel':
//            const array =
//                [
//                    vResponse[index].codigo,
//                    vResponse[index].nome
//                ];
//            return array;

//        default:
//            break;
//    }
//}

//function RowEvenet(event) {
//    debugger
//    const tr = event.target.parentNode;
//    const table = tr.parentNode;
//    const div = table.parentNode;

//    if (div.id === 'grid') {

//    }
//    else {
//        const rowIndex = event.currentTarget.rowIndex - 1;
//        const result = TypeHelper(vType, rowIndex);
//        const btn = document.getElementById(window.btnId);
//        const input = btn.previousElementSibling;
//        const span = btn.nextElementSibling;
//        if (span.childNodes.length > 0)
//            span.childNodes[0].remove();

//        const textSpan = document.createTextNode(result[1]);

//        input.value = result[0];
//        span.appendChild(textSpan);

//        div.remove();

//    }
//}
