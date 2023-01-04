window.addEventListener("load",function(){


    //selections
    let addButton=this.document.querySelector("input[value=Add]");
    let studentsTable=this.document.querySelectorAll("table")[1];
    let nameTextBox=document.querySelector("input[name=studentName]");
    let gradeTextBox=document.querySelector("input[name=studentGrade]")
    let nameError=document.querySelector("span");
    let gradeError=document.querySelectorAll("span")[1];
    filterList=this.document.querySelectorAll("select")[0];
    let cleanStr=new Array;
    let  cleanGrade=new Array;
    

    //events
    addButton.onclick=function(){
        nameError.style.display="none";
        gradeError.style.display="none";  
          //name validation
          // cleanStr=document.querySelectorAll("table")[1].innerText.split("\tDELETE\n")
          // cleanStr[cleanStr.length-1]=cleanStr[cleanStr.length-1].replace("\tDELETE","") //cleaning the string
       if(nameTextBox.value!=""&&!(cleanStr.includes(PascalCase(nameTextBox.value)))&&(gradeTextBox.value!="")&&(gradeTextBox.value<=100)&&(gradeTextBox.value>=0)&&(!isNaN(gradeTextBox.value))){
        
        let departmentValue=document.querySelector("input[name=Department]:checked").value;
        //1- created tr
        let trElm=document.createElement("tr");  //<tr></tr>
        trElm.classList.add(departmentValue);

      //2- created td 
        let tdElm=document.createElement("td");
         //<td></td>
         tdElm.setAttribute("name","username");
        tdElm.innerText=PascalCase(nameTextBox.value);//<td>......</td>
        cleanStr.push(tdElm.innerText);
        //3- td-> tr
        trElm.append(tdElm);
         tdElm=document.createElement("td");
         tdElm.setAttribute("name","grade");
        tdElm.innerText=gradeTextBox.value; 
        cleanGrade.push(tdElm.innerText);    // adding grade
         trElm.append(tdElm);
        //-- delete
        let deleteButton=document.createElement("button");
        deleteButton.innerText="DELETE";
        deleteButton.onclick=function(){
          let tempIndex=cleanStr.indexOf(this.parentElement.parentElement.childNodes[0].innerText);
         cleanStr.splice(tempIndex,1);
         cleanGrade.splice(tempIndex,1);
        this.parentElement.parentElement.remove();
           
        }



        tdElm=document.createElement("td");
        tdElm.append(deleteButton);
        trElm.append(tdElm);


        //4- tr-> table
        studentsTable.append(trElm);

      }
      else if(nameTextBox.value==""||(cleanStr.includes(PascalCase(nameTextBox.value)))) {
        
        nameError.style.display="Block";  // name entry error

      }
      else  {
        
        
      gradeError.style.display="Block";  // grade entry error

       }
      //  for(i=0;i<document.querySelectorAll("tr [name=username]").length;i++){
      //   cleanStr[i]=document.querySelectorAll("tr [name=username]")[i].innerText;
      //   cleanGrade[i]=document.querySelectorAll("tr [name=grade]")[i].innerText;}


    }
    
  filterList.onchange=function(){
    switch(this.value){
    case "all":
      for(i=0;i<document.querySelectorAll("tr [name=username]").length;i++)
      {
        document.querySelectorAll("tr [name=grade]")[i].parentElement.classList.remove("hidden")
      }
      break;
      case "success":
      for(i=0;i<document.querySelectorAll("tr [name=username]").length;i++)
      {
        if(document.querySelectorAll("tr [name=grade]")[i].innerText<60)
        {
          document.querySelectorAll("tr [name=grade]")[i].parentElement.classList.add("hidden")
        }
        else{
          document.querySelectorAll("tr [name=grade]")[i].parentElement.classList.remove("hidden")
        }
      }
        break;
      case "fail":
        
        for(i=0;i<document.querySelectorAll("tr [name=username]").length;i++)
        {
          if(document.querySelectorAll("tr [name=grade]")[i].innerText>=60)
          {
            document.querySelectorAll("tr [name=grade]")[i].parentElement.classList.add("hidden")
          }
          else
          {
            document.querySelectorAll("tr [name=grade]")[i].parentElement.classList.remove("hidden")
          }
        }
      break;
      }}
    
  

    


//     nameTextBox.onkeypress=function(event){   //prevent numbers on 
//       if(event.key<=48 || event.key>=57)
//       {
//           event.preventDefault();
//       }
//   }
//   gradeTextBox.onkeypress=function(event){ 
//       //allow only numbers on grade
      
//     if(isNaN(event.key)||(this.value.length>=3)||(this.value>100))
//     {
//         event.preventDefault();
//     }
// }



});//load



{     
 // let cleanStr=document.querySelectorAll("table")[1].innerText.split("\tDELETE\n")[3].slice(0,-7)
 //cleanStr[cleanStr.length]=cleanStr[cleanStr.length].slice(0,-7) //cleaning the string


}

const PascalCase=function(inputvalue)
{      
    inputvalue=new String(inputvalue); //making sure the input is string 
    let resultname =inputvalue[0].toUpperCase();
        for(let i=1;i<inputvalue.length;i++)
        {
            if(inputvalue[i-1]==' ')
            {resultname+=inputvalue[i].toUpperCase();}
            else
            { resultname+=inputvalue[i].toLowerCase(); } }
    return resultname;
}