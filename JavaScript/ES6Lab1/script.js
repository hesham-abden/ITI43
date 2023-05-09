class Engine {
    
    static #count=0;
    constructor(color) {
        this.color=color;
        Engine.#count++;
    }
    Move(){
        console.log("Moving");
        }
    static get count(){return Engine.#count}
}
let engine=new Engine("Red");
/*==============================================*/
class Car extends Engine
 {
    #ownerName
    constructor(color,ownerName,brandName,producationYear) {
        super(color)
        
        this.#ownerName=ownerName;
        this.brandName=brandName;
        this.producationYear=producationYear;
    }
    get ownerName(){return this.#ownerName}
    set (ownerName){this.#ownerName=ownerName}
    Move(){
        console.log(this.brandName);
        super.Move();
    }

}
let car=new Car("Red","Owner","Brand","1977");
Engine.prototype.toString=function()
{
    return `${this.constructor.name}`;
}

function outerfun(){
    var  arr=[]
    
    for(var i=0;i<3;i++){
       arr.push( function(){
            console.log(i);
        })
    }
    return arr
}
var result=outerfun();

