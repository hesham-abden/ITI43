let numarray=[2,1,3,2,7,2,8,4,3,6,10,9,12];
const nofun=function(value,position)
{
    return(position==numarray.indexOf(value));  // indexof return index of the first occurance of this value only.
}
let sortdesc=[...numarray.sort((a,b)=>(a-b))];
let sortasc=[...numarray.sort((a,b)=>(b-a))];
let filterarr=numarray.filter((cond)=>(cond>5));
let maxnum=Math.max(...numarray);
let minnum=Math.min(...numarray);
let norepeted=numarray.filter(nofun);

// const removerepeted=function(array)   // alternative way to remove repeated "looping".
// {
//     let newarray=[];
//     for(i of array)
//     if(!(array[i] in newarray) )
//     {newarray.push(array[i]);}
// return newarray;
// }