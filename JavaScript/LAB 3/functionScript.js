const PascalCase=function(inputvalue)
{      
    inputvalue=new String(inputvalue); //making sure the input is string 
    let resultname =inputvalue[0].toUpperCase();
    
        for(let i=1;i<inputvalue.length;i++)
        {
            if(inputvalue[i-1]==' ')
            {
                resultname+=inputvalue[i].toUpperCase();
                
            }
            else
            {
                resultname+=inputvalue[i].toLowerCase();
            }
        }
    
    
    
    return resultname;
}


const LongestWord=function(inputvalue)
{   
    inputvalue=String(inputvalue);    //making sure the input is string 
    let result=inputvalue.split(' ');
    let longest=result[0];

     for(i=1;i<result.length;i++)
     {
     if(longest.length<(result[i].length))
        {
             longest=result[i]
        }
    }
    return longest;
}


const Sortalpha=function(inputvalue)
{   if(inputvalue===String(inputvalue)) //if we remove the condition with the statment, it would sort numbers as expected.
    { 
        let result=inputvalue.split('');
            for(let i=0;i<result.length;i++)
    {
                for(let j=0;j<result.length-i;j++)
        {
                    if(result[j]>result[j+1])
            {
                        let temp  =  result[j];
                        result[j] = result[j+1];
                        result[j+1] = temp;
            }
        }
    }
    
return result;
}
else
return 'NOT A STRING'
}


const Randonum=function(size)
{
    let arrayofrandos=[];
    for(let i=0;i<size;i++)
    {
        arrayofrandos[i]=Math.floor(((Math.random()*10)+1));
    }
return arrayofrandos;
}

 const  CurrentMonth=function()
 {
    let month=Date().split(" ");
    return month[1];
 }
