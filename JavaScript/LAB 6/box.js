window.addEventListener("load",function(){
box1=document.querySelectorAll("div")[0];
box2=document.querySelectorAll("div")[1];
box3=document.querySelectorAll("div")[2];


const clickable=function(){
if(!this.classList.contains("button")){  //condition for already pressed elements
    
newbox=document.createElement("div");
newbox.classList.add(this.classList[0]);
newbox.addEventListener("click",clickable);
this.classList.add("button");
document.body.append(newbox);}}
box1.addEventListener("click",clickable); 
box2.addEventListener("click",clickable);
box3.addEventListener("click",clickable);
});