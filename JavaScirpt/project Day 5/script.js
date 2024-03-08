
// Task 1 , 2 , 6

function save() {

    if (document.getElementById("remember").checked) {
        localStorage.name = document.getElementById("name").value;
        localStorage.password = document.getElementById("pass").value;
        sessionStorage.name = document.getElementById("name").value;
        sessionStorage.password = document.getElementById("pass").value;
        var date = new Date();
        date.setDate(date.getDate()+1);
        var UserText = document.getElementById("name").value;
        var UserPssword = document.getElementById("pass").value;
        document.cookie = "name=" + UserText + "; expires=" + date.toUTCString();
        document.cookie = "Password=" + UserPssword + "; expires=" + date.toUTCString();

    }
    else {
        localStorage.removeItem("name");
        localStorage.removeItem("password");
        sessionStorage.removeItem("name");
        sessionStorage.removeItem("password");

    }
}

window.onload = function () {
    if (localStorage.name && localStorage.password) {

        document.getElementById("name").value = localStorage.name;
        document.getElementById("pass").value = localStorage.password;

    }


};



/// Task 3 , 4



var Student = [
    { "ID": 1, "Name": "Sarah", "Age": 25, "Address": "Minia", "Skills": ["Coding", "listening"], "IsLeader": "true" },
    { "ID": 2, "Name": "Hassan", "Age": 28, "Address": "Sahog", "Skills": ["Design", "listening"], "IsLeader": "false" },
    { "ID": 3, "Name": "Hussein", "Age": 21, "Address": null, "Skills": ["Coding", "Design"], "IsLeader": "true" }
]


for (let i in Student) {
    document.getElementById("print").innerHTML += "<h1>Name : " + Student[i].Name + " | Skills : " + Student[i].Skills[0] + " , " + Student[i].Skills[1] + " | Address : " + Student[i].Address + " </h1><br>"
}



///Task 5

function GetData() {
    var XHR = new XMLHttpRequest();

    XHR.open("get", "https://reqres.in/api/users/1", true);

    XHR.onreadystatechange = function () {
        if (XHR.readyState == 4 && XHR.status == 200) {
            var ResponseData = JSON.parse(XHR.responseText)
            document.getElementById("AJAX").innerHTML = "<h1> Frist Name : " + ResponseData.data.first_name + " | Last Name : " + ResponseData.data.last_name + " </h1><br>"

            let myimg = new Image();
            myimg.src = ResponseData.data.avatar;
            myimg.height = '100'
            myimg.width = '100'
            document.getElementById('AJAX').appendChild(myimg);
        }
    }
    XHR.send();


}


function GetAllData() {

    var userid = document.getElementById("userID").value;

    var XHR = new XMLHttpRequest();
    XHR.open("get", "https://reqres.in/api/users/"+userid, true);

    XHR.onreadystatechange = function () {
        if (XHR.readyState == 4 && XHR.status == 200 && userid.length != 0) {
            var ResponseData = JSON.parse(XHR.responseText).data
            


            document.getElementById("AJAX2").innerHTML = "<h1> Frist Name : " + ResponseData.first_name + " | Last Name : " + ResponseData.last_name + " </h1><br>"
            let myimg = new Image();
            myimg.src = ResponseData.avatar;
            myimg.height = '100'
            myimg.width = '100'
            document.getElementById('AJAX2').appendChild(myimg);
        }
        else {
            document.getElementById('AJAX2').innerHTML = "User not found";
        }

    }
    XHR.send();

}

