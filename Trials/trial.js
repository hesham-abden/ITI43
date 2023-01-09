window.addEventListener("load",function(){
let calc=this.document.querySelector("div");
let btn5=document.getElementById("btn5");
let i=0;
count=document.createElement("div")
document.body.append(count);
btn5.addEventListener("click",function(){
let temp=btn8.innerText;
btn8.innerText=btn9.innerText;
btn9.innerText=btn6.innerText;
btn6.innerText=btn3.innerText;
btn3.innerText=btn2.innerText;
btn2.innerText=btn1.innerText;
btn1.innerText=btn4.innerText;
btn4.innerText=btn7.innerText;
btn7.innerText=temp;


count.innerText=`${++i}`

})

// setInterval(function(){btn5.click()},500)
})

const tester=function(){console.log("A")}
    
