console.log( typeof number1);
let number1=3;
number2=2.9;
var number3=0xff;
var firstname=["Hesham"];
//firstname[3]="Z"   // doesn't change anything;

var middlename='Abden';
var lastname=`Abdelmaskoud`;
numbers=[1,2,3,4,5,6,7,8,9];
var flag=true;

console.log(number1+number2);
console.log(number1+numbers);   // concat number1 and the numbers array
console.log(flag+number2);  //flag as '1' 1+2.9;
console.log(firstname+flag);  //concat of firstname and "true" 
console.log(number1+firstname); //concat number and firstname
console.log(number1*flag);  3*1;
console.log(number1/lastname);  //NaN not a number
console.log(firstname+" "+middlename+" "+lastname);
console.log(`${firstname} ${middlename} ${lastname}`);
console.log(numbers);
console.log("This the external JS file");