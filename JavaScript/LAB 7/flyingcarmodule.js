import { Car } from "./carmodule.js";
export class FlyingCar extends Car
{   
    constructor(model,year,canFly=true)
    {   super(Car);
        this.model=model;
        this.year=year;
        this.canFly=canFly;
    }
    toString(){return `${super.toString()},I can fly!`}
}

