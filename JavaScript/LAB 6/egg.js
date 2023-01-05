
//Press enter to start it;

window.addEventListener("load",function(){
this.alert("Press Enter to start the game")
let eggSpeed=10;
let score=0;
let egg=this.document.querySelector("img");
let basket=document.querySelectorAll("img")[1];
egg.style.left=Math.floor(((Math.random()*500)+1))+"px";
eggDrop=function(){ 
    let count=0;
    intervalID=setInterval(()=>{
        count++;
        
    // console.log(this.basket.offsetTop)
        if(egg.offsetTop==document.querySelectorAll("img")[1].offsetTop)
        {   
            if(egg.offsetLeft<=basket.offsetLeft+40&&egg.offsetLeft>basket.offsetLeft-40)
            {
                egg.classList.add("hidden");
                score++;
                eggSpeed-=1;    
            }
            else
            {
                egg.src="images/Uovo_sorridente.png";
                score--;    
            }
            this.document.querySelector("h2").innerText=`Score=${score}`;
            clearInterval(intervalID);  
        }

    egg.style.top=count+"px";
    },eggSpeed);
 
    return(egg)  
}
    const basketMovement=function(key){
        
        if(key.key=="ArrowLeft"&&basket.offsetLeft>10)
        {
            basket.style.left=(basket.offsetLeft-10)+"px";  
        }
        if(key.key=="ArrowRight"&&basket.offsetLeft<500)
        {basket.style.left=(basket.offsetLeft+10)+"px";}
        if(key.key=="Enter")
        {   
          let tempegg=eggDrop();
            tempegg.classList.remove("hidden");
            tempegg.src="images/newegg.png";
            egg.style.left=Math.floor(((Math.random()*500)+1))+"px";
        }
        }
this.window.addEventListener("keydown",basketMovement);
})
   











