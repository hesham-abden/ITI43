window.addEventListener("load",function(){
let gobutton=this.document.getElementById("gobutton");
let inputName=document.querySelector("input");
let levelSelector=document.querySelector("select");

gobutton.addEventListener("click",function(){
    if(inputName.value!=""&&levelSelector.value=="1")//validation for inputs(name,level)
    {
        window.location.href=`game.html?${inputName.value}`  //send data to the game html through url querying
    }   
})
})
