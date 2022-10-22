//Palabras del glosario Refactorizar y Evento

function changeBackgroundColorBox() {
    const randomColor = getRandomColor();

    let boxtools = document.querySelector(".btn-dynamic");
    boxtools.style.backgroundColor = randomColor;
    console.log(boxtools);

    let boxtools2 = document.getElementsByClassName("btn-dynamic");
    //boxtools2[0].style.backgroundColor = randomColor;

    //console.log(boxtools2);

    //Cambiar texto del fondo de color
    let textColor = document.querySelector(".box-tools .text-color label");
    textColor.textContent = randomColor;
}

function getRandomColor() {
    let r = getRandom(256);
    let g = getRandom(256);
    let b = getRandom(256);
    let a = Math.random().toFixed(2);

    let color = `rgba(${r}, ${g}, ${b}, ${a})`;
    return color;
}

function getRandom(limit) {
    return Math.floor(Math.random() * limit);
}


/** Evento: addEventListener **/

const btnListener = document.querySelector("#changeBackgroundColorBody");

btnListener.addEventListener("click", changeBackgroundColorBody);

function changeBackgroundColorBody() {
    const randomColor = getRandomColor();
    document.body.style.backgroundColor = randomColor;
}

const inputListener = document.querySelector("#student");

inputListener.addEventListener("keyup", inputOnChange);

function inputOnChange(event) {
    console.log(event);
    let inputResult = document.querySelector(".input-result");
    inputResult.textContent = event.target.value;
}

// inputListener.addEventListener("keyup", (event) =>
// {
//     let inputResult = document.querySelector(".input-result");
//     inputResult.textContent = event.target.value;
// });


// document.querySelector("#student").addEventListener("keyup", (event) =>
// {
//     let inputResult = document.querySelector(".input-result");
//     inputResult.textContent = event.target.value;
// });

/** Eventos de alerta, confirmación y aviso **/

// Alert
function onClickAlert() {
    alert("¡¡Un nuevo virus se ha encontrado!!")
}

// Prompt
const promptListener = document.querySelector("#prompt");

promptListener.addEventListener("click", onClickPrompt);

function onClickPrompt() {
    let value = prompt("Por favor introduce tu contraseña de Crunchyroll: ");
    console.log(value);
    document.querySelector(".prompt-result").textContent = value;
}

// Confirm
document.querySelector("#confirm").addEventListener("click", () => {
    let value = null;
    value = confirm("Confirma si la clase les gusta :)");
    document.querySelector(".confirm-result").textContent = value;
});