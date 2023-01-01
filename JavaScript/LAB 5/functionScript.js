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
let count=0;
let StartSliding=function(ObjIMG)
{ 
intervalID=setInterval(()=>{count++;if(count>6) count=1;

  document.images[0].src=ObjIMG[count-1].src;
  document.images[1].src=ObjIMG[count].src
  document.images[2].src=ObjIMG[count+1].src},500);

    return intervalID;
   }
   let StopSliding=function(IntervalID)
   {
    clearInterval(IntervalID);
   }

