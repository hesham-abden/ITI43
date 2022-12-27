// console.log(printVariables());
// console.log(localvar);   //error 'function scope' [before calling the function]
// console.log(testingvar);  // error '           [before calling the function]
// console.log(localvar); // error without initialization with keyword (let) 
 let localvar=90;
// console.log(localvar); //local var=90;
function printVariables(value1=999,value2=999,value3=999) //solving the undefinied problem
{   
    // console.log(arguments[3]);  //printing the 3th parameter using arguments;
    console.log(`global declaration=${localvar}`); //undefined because its declared with let on the global scale.
    // localvar=3; //overidding the let declation outside the function;
    var localvar=3;
    testingvar=5;
    console.log(localvar); // localvar=3;
    return [value1,value2,value3];
}

function printprompt(given_name,number1,number2)
{   
  do {
    given_name=prompt("Enter Name");
	  
    
} while (given_name==""||given_name==null);
    number1=prompt("Enter Number 1");
    number2=prompt("Enter Number 2");
    console.log(given_name);
    console.log(`Result= ${parseInt(number1)+parseInt(number2)}`);

}