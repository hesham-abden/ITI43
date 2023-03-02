
var Rectangle={
    height:'10',
    width:'20',
    getArea:function(){
        return this.height*this.width
    },
    getPerimeter:function(){
        return 2*(this.height+this.width)
    },
    displayInfo:function(){
        console.log(`Height = ${this.height},Width =${this.width},Area = ${this.getArea()},Perimeter = ${this.getPerimeter()}`)
    }
}
var obj={
    name:"a",
    id:"1",
    getsetGen:function(object){
        Object.keys(object).forEach(key=>{
            if(typeof(object[key])!='function')
            {
                object[`get${key}`]=
                (function(){
                    return function(){ return this[key]}})(),

                    object[`set${key}`]=(function(){
                    return function(item)
                    {this[key]=item}})()
                    
            }
        })
        }
    }
    obj.getsetGen(obj);
    console.log(obj.getid());
    console.log(obj.getname());
    obj.setid("B");
    console.log(obj.getid());
    obj.getsetGen(Rectangle);
    console.log(Rectangle.getheight());
    Rectangle.setheight("S");
    console.log(Rectangle.getheight());
  


   



