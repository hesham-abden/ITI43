window.addEventListener("load",function(){
let addButton=this.document.querySelector("input[type=button]");
let taskBox=this.document.querySelector("input[type=text]");
let taskTable=this.document.querySelectorAll("table")[1];
window.addEventListener("keydown",function(key){ //adding task on pressing enter
    if(key.key=="Enter")
    {
        addButton.click();
    }
}); 
//adding
 addButton.addEventListener("click",function(){

//task validation
if(taskBox.value!="")
{
    let temptr=document.createElement("tr");
    let count=document.querySelectorAll("table")[1].childElementCount;
    if(count%2==0)
    {temptr.style.backgroundColor="aliceblue"}
    else
    {temptr.style.backgroundColor="#CBEDD5"}
    taskTable.append(temptr);
    let temptd=document.createElement("td");        //checkbox
    let checkBox=document.createElement("input");
    checkBox.setAttribute("type","checkbox");
    temptd.classList.add("checkbox");
    temptd.append(checkBox);
    temptr.append(temptd);

    temptd=document.createElement("td");        //taskbox
    temptd.innerText=taskBox.value;
    taskBox.value="";           //clearing textbox after adding
    temptd.classList.add("task")
    temptr.append(temptd);


    temptd=document.createElement("td");        //delete button
    let img=new Image;
    img.src="images/delete.png";
    temptd.append(img);
    temptr.append(temptd);
    img.addEventListener("click",function(){  
                     //delete button function
        this.parentElement.parentElement.remove();
    }); 

    checkBox.addEventListener("change",function(){           //crossing tasks
            if(this.checked==true)
            this.parentElement.nextElementSibling.style.textDecoration="line-through double 1.5px";
            
            if(this.checked==false)
            this.parentElement.nextElementSibling.style.textDecoration="none"
        });

        
       
}



})











});