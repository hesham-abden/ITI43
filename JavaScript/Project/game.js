let birdKilledBar=document.querySelectorAll("div")[5];
let birdCount=0;        //bird killed counter
let score=0;  
let time=60; 
let scoreBar=document.querySelectorAll("div")[3];
let timeBar=document.querySelectorAll("div")[4];
let birdTime=1000;
let gameMode=false;  //game condition
let username=location.search.substring(1).replace("%20"," ");
let submitBox=document.querySelector('button');
let alertBox=document.querySelector("p");
document.querySelectorAll(".bar")[0].innerText=`Welcome:${username}`;
if(username in localStorage)
{
    alertBox.innerText=`Welcome Back! ${username}\nLast Visit:\n${localStorage[username]}\nClick this button to start`;
}
else
{
    alertBox.innerText=`Welcome ${username}\nClick this button to start`;
}
window.addEventListener("load",function(){
submitBox.addEventListener("click",GameOn);
})

const GameOn=function(){
    this.parentElement.classList.add("invisible");
    document.body.querySelector("div").classList.remove("alertbackground");
    gameMode=true;
    let intervalId=setInterval(() => {
    let img=new Image;
    let position=Math.random()*500;
    birdNum=Math.floor(Math.random()*3+1);
    img.src=`./images/bird${birdNum}.gif`
    img.value=birdNum;
    birdTime=Math.floor(Math.random()*2000);
    img.style.top=position+"px"; 
    document.body.append(img);   
    let birdInterval=birdMovement(img);
    timeBar.innerText=`Time Limit : ${time}`;
    img.addEventListener("click",function(){birdHit(img,birdInterval)});
    if(gameMode==false)
{    
    clearInterval(bombInterval);
    bombInterval=null;
    clearInterval(birdInterval);
    birdInterval=null;
    clearInterval(intervalId);
    intervalId=null;
    clearInterval(timeInterval);
    timeInterval=null;

    let date=Date().split("G");
    localStorage.setItem(`${username}`,`Score : ${score}\nDate : ${date[0]}`);
    submitBox.removeEventListener("click",GameOn);
    alertBox.innerText=`Well Done ${username}\n Your Score :${score}`;
    document.querySelectorAll("img").forEach((element)=>element.remove())
    birdCount=0;
    score=0;
    birdKilledBar.innerText=`Dragon Killed : ${birdCount}`      //counter for killing birds
    scoreBar.innerText=`Score : ${score}`
    time=60;
    timeBar.innerText=`Time Limit : ${time}`;
    this.parentElement.classList.remove("invisible");
    submitBox.addEventListener("click",GameOn);
    submitBox.innerText="Restart";
 
    
}
},birdTime);

let bombInterval=setInterval(() => {
    let bombObj=new Image;
    bombObj.src="./images/bomb.png";
   let bombPosition=Math.random()*1000;
    bombObj.style.left=bombPosition+"px";
    bombObj.style.top="0px";
    let top=0;
    document.body.append(bombObj);
    bombObj.addEventListener("click",function(){
        let allBirdImages=document.querySelectorAll("img");
        allBirdImages.forEach(element => {
            //range of the bomb=(+200,-200);
        if((bombObj.offsetLeft>element.offsetLeft-200)&&(element.offsetLeft+200>bombObj.offsetLeft)&&(bombObj.offsetTop>element.offsetTop-200)&&(element.offsetTop+200>bombObj.offsetTop))
            {
                birdHit(element); 
                
            }
            
        })
        
        clearInterval(bombMovementInterval);
    });
    
        let bombMovementInterval=setInterval(() => {
            top+=1;                           // bomb movement speed
        bombObj.style.top=top+"px";
        if(bombObj.offsetTop==500)
        {
            bombObj.remove();
            
        }
        if(gameMode==false)
        {
            clearInterval(bombMovementInterval);
        }
        
        
    }, 10);
},7*birdTime);
    // for the time counter (seconds timer);
let timeInterval=setInterval(() => {
    time--;
    if(time==0)
        {
            gameMode=false;
        }
                }, 1000);
}

    
const birdHit=function(birdImage)
{       
    switch (birdImage.value) {   //score mangement
        case 1:
            score+=5;
            break;
        case 2:
            score+=10;
            break;
        case 3:
            score-=10;
            break;    
    }
    
    birdKilledBar.innerText=`Bird Killed : ${++birdCount}`      //counter for killing birds
    scoreBar.innerText=`Score : ${score}` //updating score board
    birdImage.src="./images/explode.gif";        //changing gif for the explosion
    if(score>50)
    {
        gameMode=false;
    }
    setTimeout(function(){
        birdImage.remove();                   
    }, 300);
}
const birdMovement=function(birdImage)
{
    let left=0;
    let birdInterval=setInterval(() => {
        left+=20;                           // bird movement speed
    birdImage.style.left=left+"px";
    if(birdImage.offsetLeft>="1200")             //removing img after reaching the max width.
    {
        clearInterval(birdInterval);
        birdImage.remove();
    }
    }, 100);

return birdInterval;
}
