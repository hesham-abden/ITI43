window.addEventListener("load",function(){
let work=new Worker("Extra.js");
work.onmessage = function (data) {
    console.log(data.data);
};
work.postMessage("");
console.log("Late Message");

})