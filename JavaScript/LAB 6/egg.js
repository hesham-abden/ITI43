
//Press enter to start it;

window.addEventListener("load",function(){
    this.alert("Press Enter to start the game")
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
            alert("Sucessful Attempt");
        }
        else{
            egg.src="images/Uovo_sorridente.png";
            alert("Failed Attempt");
        }
        clearInterval(intervalID);
        
    }

 egg.style.top=count+"px";

//  console.log(this.basketPosition+40,egg.offsetLeft,this.basketPosition-40);
 if(egg.offsetLeft<=this.basketPosition+40&&egg.offsetLeft>this.basketPosition-40&&egg.offsetTop==this.basket.offsetTop)
 {
    
 }
 },10);
 
    }
    const basketMovement=function(key){
        // console.log(basket);
        let basketPosition1=window.basket.offsetLeft
        if(key.key=="ArrowLeft"&&basketPosition1>10)
        {
            basket.style.left=(basketPosition1-5)+"px";  
        }
        if(key.key=="ArrowRight"&&basketPosition1<400)
        {basket.style.left=(basketPosition1+5)+"px";}
        if(key.key=="Enter")
        {eggDrop(basketPosition);}

        window.basketPosition=basketPosition1;
        }

        

this.window.addEventListener("keydown",basketMovement);
})
   











