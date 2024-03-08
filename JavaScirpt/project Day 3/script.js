


//Task 1
function clicked(event) {
    let value = event.which;
    alert(value)
}




// //Task 2

function clockStarted() {
    alert("clock start");
    var dev = document.getElementById("dev");
    st = window.setInterval(dateconter, 1000);
    function dateconter() {
        var date = new Date();
        document.getElementById("dev").innerHTML = date.toLocaleTimeString();
    }
}

function stop(e) {
    if (e.altKey && e.code == "KeyW")
        window.clearInterval(st);
}


// //Task 3

var counter = 0;
document.getElementById('1').addEventListener("click", counter2);
document.getElementById('2').addEventListener("click", counter2);
document.getElementById('3').addEventListener("click", counter2);
document.getElementById('1').addEventListener("click", alertCounter);
document.getElementById('2').addEventListener("click", alertCounter);
document.getElementById('3').addEventListener("click", alertCounter);

function counter2() {
    counter++;
    console.log(counter);
}
function alertCounter() {
    alert(counter);
}

window.setTimeout(gameOver, 10000);
function gameOver() {
    document.getElementById('1').removeEventListener("click", alertCounter);
    document.getElementById('2').removeEventListener("click", alertCounter);
    document.getElementById('3').removeEventListener("click", alertCounter);
    alert("Game Over");
}




// //Task 4

function addNewWindow() {
    let name = document.getElementById('uname');
    var win = window.open("", "_blank", "width=500,height=500");
    win.document.write("<h1> Welcome " + name.value + "</h1>");
}




// //Task 5



function openNewPage(e) {
    e.preventDefault();
    setTimeout(time, 3000);
}

function time() {
    newWindow = window.open("", "_blank", "width=500,height=500");
    newWindow.document.write("<h1> You can use the overflow property when you want to have better control of the layout.</h1>")

}

function closeNewPage(e) {
    e.preventDefault();
    newWindow.close();

}


// //Task 7

var letters = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"];

function checkkey(e) {

    if (e.which < 65 || e.which > 90 ) {
        e.preventDefault()
    }


    // if (!letters.includes(e.key)) {
    //     e.preventDefault()
    // }


}