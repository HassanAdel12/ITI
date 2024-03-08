

/// Task 1

function welcome (){
    alert("Welcome to my Page") 
    var name=prompt( "Enter your Name", );
    document.write("<h1>Welcome "+name+"</h1>");
    
}

/// Task 2

var num1,num2
function collect(){
    getnum()
    var result=sum(num1,num2)
    showSum(result)
}



function getnum (){
    num1=parseInt(prompt("First Number:"))
    num2=parseInt(prompt("Second Number:"))
   
}


function sum (number1,number2){

    if(isFinite(number1)==true && isFinite(number2)==true){
        return number1+number2;
    }
    else{
        alert("please Enter number")
    }
    
}

function showSum (result){
    document.write("<h1>"+result+"</h1>")
}

/// Task 3


function temperature(){
    var Temp=parseInt(prompt("Temperature is :"));
    alert(Temp>=30?"Hot":"Cold");
}


///  Task 4

function temperature2(){
    var Temp=parseInt(prompt("Temperature is :"));
    if (Temp <= 30 && Temp >= 25) {
        document.write("<h1>normal</h1>")
    }
    else if (Temp < 25) {
        document.write("<h1>Cold</h1>")
    }
    else if (Temp > 30) {
        document.write("<h1>Hot</h1>")
    }
    else
    {
        document.write("<h1>Ambiguous, can’t detect</h1>")
    }
        
}

/// Task 5

function faculty(){
    var faculty=prompt("Faculty :")
    switch (faculty){
        case "FCI":    
            document.write("<h1>You’re eligible to Programing tracks</h1>")
            break;
        case "Engineering":
            document.write("<h1>You’re eligible to Network and Embedded tracks</h1>")
            break;
        case "Commerce":
            document.write("<h1>You’re eligible to ERP and Social media tracks</h1>")
            break;
        default:
            document.write("<h1>You’re eligible to SW fundamentals track</h1>")            
    }
}

// Task 6

function odd(){
    var start=parseInt(prompt("Start Number :"));
    var end=parseInt(prompt("End Number :"));
    if(start<=end){
        for(let i=start; i<=end; i++){
            if(i%2==1){
                document.write(i+"<br>");
            }
            else{
                continue
            }
        }
    }
    else{
        for(let i=start; i>=end; i--){
            if(i%2==1){
                document.write(i+"<br>");
            }
            else{
                continue
            }
        }
    }      
}

/// Task 7

function expression(){
    var exp=prompt("Expression :")
    var result=eval(exp)
    alert(result)
}

/// Task 8

function contact (){
    for(let i=1; i<=50; i++){
        var name=prompt("Enter your Name :")
        if(isNaN(name)){
            break
        }
        else{
            continue
        }
    }
    for(let i=1; i<=50; i++){
        var birth=prompt("Enter your birth year :")
        if(isFinite(birth) && birth <= 2010 && birth > 1800){
            break
        }
        else{
            continue
        }
    }
    var age = 2023-birth
    document.write("<h1>Name : "+name+"</h1>")
    document.write("<h1>Birth year : "+birth+"</h1>")
    document.write("<h1>Age : "+age+"</h1>")
}

/// Task 9


function debuggers (){
    debugger
    console.log("Hello world");
    console.log("Hassan Adel");
    console.log("age : 25");
    console.log("Birth year : 1998");
}

/// Task 10

function foo() {
    var x;
    x = 5;
    y = 6;    
    return x+y;
}

console.log(foo());


var y;	
y=10; 
x = 5; 
console.log(x); 
console.log(y); 
var x; 



var x = 5; 
console.log(x); 
console.log(y); 
var y = 7; 


function test(){
	for (var i = 0; i < 10; i++) {
  		alert(i);
		
		let x=10;
        alert (x);
	}
    console.log(i);
}






//Bonus Assignments:


/// Bonus 1


function header (){
    for(let i=1; i<=6; i++){
        document.write("<h"+i+">welcome to my page</h"+i+">")
    }
}


//// Bonus 2

function table (){
    for(let i=1; i<=50; i++){
        var name=prompt("Enter your Name :")
        if(isNaN(name)){
            break
        }
        else{
            continue
        }
    }
    for(let i=1; i<=50; i++){
        var birth=prompt("Enter your birth year :")
        if(isFinite(birth) && birth <= 2010 && birth > 1800){
            break
        }
        else{
            continue
        }
    }
    var age = 2023-birth
    console.table([{"Name":name , "birth year":birth , "Age":age}])
}


