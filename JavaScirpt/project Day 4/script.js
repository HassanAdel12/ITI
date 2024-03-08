
// Task 1 , 2 , 3 , 4 
var conter
function add(event) {
    if (conter == 0) {
        var newWindow = window.open("", "", "width=700,height=700");
        var fName = document.getElementById("fName").value;
        newWindow.document.write("Thank you, " + fName + " for registering in our website")
    } else {
        event.preventDefault()
    }

}

function ChangeBorder(element) {
    element.style.border = "solid 3px blue"
    element.style.backgroundColor = "gray"
}

function ValidateName(fName) {
    fName.style.border = "solid 1px black"
    if (fName.value.length < 3 || fName.value.length == 0) {
        fName.focus();
        fName.select();
        document.getElementById("nameValid").innerHTML = "<b style='color:red'> invalid name </b>"
        let img = new Image();
        img.src = 'image/notvalid.jpg';
        img.height = '20'
        img.width = '20'
        document.getElementById('nameValid').appendChild(img);
        fName.style.backgroundColor = "gray"
        conter++
    }
    else {

        document.getElementById("nameValid").innerHTML = ""
        let img2 = new Image();
        img2.src = 'image/valid.jpg';
        img2.height = '20'
        img2.width = '20'
        document.getElementById('nameValid').appendChild(img2);
        fName.style.backgroundColor = "white"
        conter = 0
    }
}



function ValidatePassword(password) {
    if (document.getElementById("rPassword").value != document.getElementById("password").value) {
        password.focus();
        document.getElementById("passwordValid").innerHTML = "<b style='color:red'> password and repeat password should be the same. </b>"
        let img = new Image();
        img.src = 'image/notvalid.jpg';
        img.height = '20'
        img.width = '20'
        document.getElementById('passwordValid').appendChild(img);
        password.style.backgroundColor = "gray"
        document.getElementById("password").style.backgroundColor = "gray"
        conter++;

    }
    else {

        document.getElementById("passwordValid").innerHTML = ""
        let img2 = new Image();
        img2.src = 'image/valid.jpg';
        img2.height = '20'
        img2.width = '20'
        document.getElementById('passwordValid').appendChild(img2);
        password.style.backgroundColor = "white"
        document.getElementById("password").style.backgroundColor = "white"
        conter = 0
    }
}





///Task 5

var images = ["image/1.jpg", "image/2.jpg", "image/3.jpg", "image/4.jpg"]
var index = 0

function play() {
    st = setInterval(next, 500)
}

function stop() {
    clearInterval(st)
}

function next() {
    if (index < images.length - 1) {
        index++
    } else {
        index = 0
    }
    document.getElementById("image").src = images[index]

}

function previous() {
    if (index > 0) {
        index--
    } else {
        index = images.length - 1
    }
    document.getElementById("image").src = images[index]

}



//// Task 6

function decreases(e) {

    e.style = "opacity:0.3"

}

function increases(e) {
    e.style = "opacity:1"
}



//// task 7




let newimage = document.createElement('img');
newimage.setAttribute('src', 'image/2.jpg');
newimage.setAttribute('alt', 'NewImage');
newimage.setAttribute('height', 350);
newimage.setAttribute('width', 550);
document.getElementById('Dom').appendChild(newimage);
console.log(document.getElementById("Dom").childNodes.length)
//document.getElementById('Dom').removeChild(newimage);



//// Bouns 2


var stars = 0
var conter = 1

function change(e) {

    if (conter != 0) {
        for (let index = 1; index <= e.id; index++) {
            document.getElementById(index).src = "image/Filled_star.png"
        }

        conter++
    }

}

function changeclick(e) {
    stars = parseInt(e.id);
    for (let index = 1; index <= stars; index++) {
        document.getElementById(index).src = "image/Filled_star.png"
    }
    for (let index = stars + 1; index <= 5; index++) {
        document.getElementById(index).src = "image/empty_star.png"
    }
    conter = 0
    document.getElementById("rate").innerHTML = "Rating : " + stars
}

function before(e) {
    if (conter != 0) {
        for (let index = 1; index <= e.id; index++) {
            document.getElementById(index).src = "image/empty_star.png"
        }

    }
}




