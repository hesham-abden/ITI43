var Vehicle = function(speed,color){
    if(typeof(speed)!="number"||typeof(color)!="number")
    {
        
        throw "speed/color should be a number"
    }
    this.speed=speed;
    this.color=color;
    this.turnRight=function(){
        return "Turn Right"
    }
    this.turnLeft=function(){
        return "Turn Left"
    }
    this.start=function(){
        return true;
    }
    this.stop=function(){
        return false;
    };
    this.goBackward=function(s)
    {
        return -1*this.speed;
    }
    this.goForward=function(s)
    {
        return this.speed;
    }
    this.toString=function(){
        return this;
    }
    this.valueOf=function(){
        return this;
    }
    Object.defineProperties(this, {
        speed: {
          writable: false,
          configurable: false,
          enumerable: false,
        },
        color: {
          writable: false,
          configurable: false,
          enumerable: false,
        },
      });
}
var Bicyle= function(speed,color){
    
    this.ringBell=function(){
        return "BEEP"
    }
    
    Vehicle.call(this,speed,color);
    
}
Bicyle.prototype = Object.create(Vehicle.prototype);
Bicyle.prototype.constructor = Bicyle;
//==============================================================\\
var MotorVehicle= function(speed,color,size,plate){
    
    if(typeof(size)!="number"){throw "size should be a number"}
    if(typeof(plate)!="string"){throw "size should be a string"}
    this.size=size;
    this.plate=plate;
    this.getSizeOfEngine=function(){
        return this.size;
    }
    this.getPlate=function(){
        return this.plate
    }
    Vehicle.call(this,speed,color)
    Object.defineProperties(this, {
        size: {
          writable: false,
          configurable: false,
          enumerable: false,
        },
        plate: {
          writable: false,
          configurable: false,
          enumerable: false,
        },
      });
    
}
MotorVehicle.prototype = Object.create(Vehicle.prototype);
MotorVehicle.prototype.constructor = MotorVehicle;

//=====================================================================\\
var DumpTruck= function(speed,color,size,plate,load,numofwheels,weight){
    
    if(typeof(load)!="number"){throw "load should be a number"}
    if(typeof(numofwheels)!="number"){throw "num of wheels should be a number"}
    if(typeof(weight)!="number"){throw "weight should be a number"}
    this.load=load;
    this.numofwheels=numofwheels;
    this.weight=weight;
    this.lowerload=function(){
        return "lowerload"
    }
    this.raiseload=function(){
        return "raiseload"
    }
    MotorVehicle.call(this,speed,color,size,plate)
    Object.defineProperties(this, {
        load: {
          writable: false,
          configurable: false,
          enumerable: false,
        },
        numofwheels: {
          writable: false,
          configurable: false,
          enumerable: false,
        },
        weight: {
            writable: false,
            configurable: false,
            enumerable: false,
          },
      });
    
}
DumpTruck.prototype = Object.create(MotorVehicle.prototype);
DumpTruck.prototype.constructor = DumpTruck;

var Car= function(speed,color,size,plate,numofdoors,numofwheels,weight){
    
    if(typeof(numofdoors)!="number"){throw "number of doors should be a number"}
    if(typeof(numofwheels)!="number"){throw "num of wheels should be a number"}
    if(typeof(weight)!="number"){throw "weight should be a number"}
    this.numofdoors=numofdoors;
    this.numofwheels=numofwheels;
    this.weight=weight;
    this.switchAC=function(){
        return "AC On"
    }
    this.getNumofDoors=function(){
        return this.numofdoors;
    }
    MotorVehicle.call(this,speed,color,size,plate)
    Object.defineProperties(this, {
        numofdoors: {
          writable: false,
          configurable: false,
          enumerable: false,
        },
        numofwheels: {
          writable: false,
          configurable: false,
          enumerable: false,
        },
        weight: {
            writable: false,
            configurable: false,
            enumerable: false,
          },
      });
    
}
Car.prototype = Object.create(MotorVehicle.prototype);
Car.prototype.constructor = Car;
//=======================================================\\
var vec1=new Vehicle(10,10);
// var vec2=new Vehicle("A","B");   // throw exception invalid data (String)
var bi1=new Bicyle(10,10);    
// var bi2=new Bicyle(10,"B")   //throw exception invalid input data  (string)
var M1=new MotorVehicle(10,10,10,"XYZ");
// var M2=new MotorVehicle(10,10,10,50);  //throw exception invalid input data (number)
var DT1=new DumpTruck(10,10,10,"XYZ",100,4,1000)
// var DT1=new DumpTruck(10,10,10,"XYZ",100,"B",1000)  //throw exception invalid input data (string)
var C1=new Car(10,10,10,"XYA",10,5,5);
// var Car=new Car(10,10,10,"XYA",10,5,"B");  //throw exception invalid input data (string)
//======================================================\\
console.log(vec1.toString())
console.log(bi1.toString())
console.log(M1.toString())             //overidden method inhertied from Vehicle
console.log(DT1.toString())
console.log(C1.toString())
//=============================================================\\
console.log(vec1.turnLeft())
console.log(bi1.turnLeft())
console.log(M1.turnLeft())                // Inhertited method from Vehicle 
console.log(DT1.turnLeft())
console.log(C1.turnLeft())
