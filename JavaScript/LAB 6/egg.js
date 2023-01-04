
//Press enter to start it;

window.addEventListener("load",function(){
    this.alert("Press Enter to start the game")
    let eggSpeed=10;
    let score=0;
egg=this.document.querySelector("img");
basket=document.querySelectorAll("img")[1];
let basketPosition=window.basket.offsetLeft;
egg.style.left=Math.floor(((Math.random()*500)+1))+"px";
eggDrop=function(basketPosition){
    
 let count=0;
 

 intervalID=setInterval(()=>{
    count++;
    // console.log(this.basket.offsetTop)
    if(egg.offsetTop==this.basket.offsetTop)
    {   
        if(egg.offsetLeft<=this.basketPosition+40&&egg.offsetLeft>this.basketPosition-40)
        {
            egg.classList.add("hidden");
            score++;
            eggSpeed-=1;
            
        }
        else{
            egg.src="images/Uovo_sorridente.png";
            score--;

            
        }
        this.document.querySelector("h2").innerText=`Score=${score}`;
        clearInterval(intervalID);
        
    }

 egg.style.top=count+"px";

//  console.log(this.basketPosition+40,egg.offsetLeft,this.basketPosition-40);
 if(egg.offsetLeft<=this.basketPosition+40&&egg.offsetLeft>this.basketPosition-40&&egg.offsetTop==this.basket.offsetTop)
 {
    
 }
 },eggSpeed);
 
  return(egg)  }
    const basketMovement=function(key){
        // console.log(basket);
        let basketPosition1=window.basket.offsetLeft
        if(key.key=="ArrowLeft"&&basketPosition1>10)
        {
            basket.style.left=(basketPosition1-10)+"px";  
        }
        if(key.key=="ArrowRight"&&basketPosition1<500)
        {basket.style.left=(basketPosition1+10)+"px";}
        if(key.key=="Enter")
        {   
        //    egg.style.left=Math.floor(((Math.random()*500)+1))+"px";
          let tempegg=eggDrop(basketPosition);
            tempegg.classList.remove("hidden");
            tempegg.src="images/newegg.png";
            egg.style.left=Math.floor(((Math.random()*500)+1))+"px";
        }

        window.basketPosition=basketPosition1;
        }

        

this.window.addEventListener("keydown",basketMovement);
})
   











