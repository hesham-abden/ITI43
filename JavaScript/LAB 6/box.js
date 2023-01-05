window.addEventListener("load",function(){
let box1=document.querySelectorAll("div")[0];
let box2=document.querySelectorAll("div")[1];
let box3=document.querySelectorAll("div")[2];
box1.addEventListener("click",clickable); 
box2.addEventListener("click",clickable);
box3.addEventListener("click",clickable);
});
const clickable=function(){
newbox=document.createElement("div");
newbox.classList.add(this.classList[0]);
newbox.addEventListener("click",clickable);
document.body.append(newbox);
this.removeEventListener("click",clickable)
};
