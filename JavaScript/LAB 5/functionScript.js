document.getElementsByClassName("fake");
document.images[0];
document.images[1];
document.querySelectorAll(".fake");
document.querySelectorAll("img")
document.querySelectorAll("form")
console.log(document.querySelector("option[value='1']")); //Mansoura
console.log(document.querySelector("option[value='2']"));   //Cairo
console.log(document.querySelector("option[value='3']"));   //Alexandria
document.querySelectorAll(".bPink td");
document.querySelectorAll(".bGrey",".fontBlue"); //fontBlue and bGrey
setInterval(()=>{let newtime=new Date;document.title=newtime.toLocaleString()}); 
let newimg=new Array;
for(let i=0;i<8;i++)
{
newimg[i]=new Image;
newimg[i].src=`images/${i+1}.jpg`
}

let StartSliding=function(ObjIMG)
{ 
let count=0;
intervalID=setInterval(()=>{count++;if(count>100) count=1;

  document.images[0].src=ObjIMG[0].src;
  moveLeft(count*5);console.log(document.images[0].offsetParent);

},50); 
// console.log(document.images[0].offsetLeft);

    return intervalID;
   }
   let StopSliding=function(IntervalID)
   {
    clearInterval(IntervalID);
   }

const moveLeft=function(pixel){
  document.querySelector("img").style.top=pixel+"px";
}