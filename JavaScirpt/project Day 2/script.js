


//Task 1
function random(){
    var arr=["hassan","adel","hussein","Ahmed"]
    var random = Math.floor(Math.random() * arr.length);
    console.log(arr[random])
}


//Task 2

function date(){
    var date = new Date();
    document.write(date.toLocaleString())
}


//Task 3

function vaild () {

    var gmail=prompt("Enter Your Gmail :")
    if(gmail.indexOf('@') !== 0 && gmail.lastIndexOf('@') !== gmail.length-1 && gmail.includes('@')){
        alert("Gamil is Vaild")
    }
    else{
        alert("Gamil is not Vaild")
    }

}




//Task 4

function regular(){
    var nameRegex = new RegExp(/^[a-z]{3,}(\s[a-z]{3,})*$/ig);
    do{
        var Name=prompt("Enter Full Name:");
    }while(!nameRegex.test(Name))



    var gmailRegex = new RegExp(/^[a-z0-9._%$&]+@[a-z]+\.[a-z]{3}\.(eg)$/gi);
    do{
        var gmail = prompt("Enter Gmail:");
    }while(!gmailRegex.test(gmail))

}




//Task 6


function sort(){
    var studentDegree =[60,100,10,15,85];

    var sortDegree=studentDegree.sort(
    function(a,b){
    return b-a;
    });

    for (let item in sortDegree){
        document.write(sortDegree[item]+"<br>")
    }

    let highest = sortDegree.find((item) => item <= 100);
    console.log(highest);

    const result = sortDegree.filter((degree) => degree >= 60);
    console.log(result);

}



//Task 7


function student(){

    var student=[{
        studentName: "Hassan",
        studentDegree : 95
        },
       {
        studentName: "Ahmed",
        studentDegree: 40}]
    student.push({studentName: "Hussein",studentDegree : 70})
    student.push({studentName: "Aya",studentDegree : 50})
    student.push({studentName: "Samar",studentDegree : 98})

    let highest = student.find(({studentDegree}) =>  studentDegree > 90 && studentDegree <= 100);
    console.log(highest.studentName);
    console.log("filter elements")
    let result = student.filter(({studentDegree}) => studentDegree < 60);
    for (let item in result){
        console.log(result[item].studentName)
    }
    console.log("all elements of the array")
    student.push({studentName: "Hossem",studentDegree : 84})
    for (let item in student){
        console.log(student[item])
    }
    console.log("all elements of the array")
    student.pop()
    for (let item in student){
        console.log(student[item])
    }

    student.sort(function(a, b){
        let x = a.studentName;
        let y = b.studentName;
        if (x < y) {return -1;}
        if (x > y) {return 1;}
        return 0;
      });
    console.log("Sort of the array")
    for (let item in student){
        console.log(student[item])
    }

    student.splice(2, 0, {studentName: "Karem",studentDegree : 80}, {studentName: "Sarah",studentDegree : 60});

    console.log("the new array")
    for (let item in student){
        console.log(student[item])
    }


    student.splice(3, 1);

    console.log("the new array")
    for (let item in student){
        console.log(student[item])
    }

}




//Task 8


function birth(){
   
    var birthDate=prompt("Enter birth date in the format (DD  MM  YYYY):");
    if(birthDate.charAt(2)!=='-' || birthDate.charAt(5)!=='-'|| birthDate.length !=10 ){
        alert("Wong Date Format")
    }
    else{
        alert(birthDate.substring(6,10)+"-"+birthDate.substring(3,5)+"-"+ birthDate.substring(0,2))
    }



}



