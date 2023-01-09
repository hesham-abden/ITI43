window.addEventListener("load",function(){
 box=document.querySelector("div");
 temp=document.createElement("div");
temp.style.top="100px";
temp.style.left="100px";
this.document.body.append(temp);

if((box.style.top=="100px"))
{  console.log("HEHE") }

const boxMovement=function(key){
        
    if(key.key=="ArrowLeft"&&box.offsetLeft>10)
    {
     box.style.left=(box.offsetLeft-1)+"px"; 
     
    }
    if(key.key=="ArrowRight"&&box.offsetLeft<500)
    {
        box.style.left=(box.offsetLeft+1)+"px";
    }
    if(key.key=="ArrowUp"&&box.offsetTop<500)
    {
        box.style.top=(box.offsetTop-1)+"px";
    }
    if(key.key=="ArrowDown"&&box.offsetTop<500)
    {
        box.style.top=(box.offsetTop+1)+"px";
    }

    
}
this.window.addEventListener("keydown",boxMovement);
});