export class Car 
{
    constructor(model="BMW",year="1990")
     {
        this.model=model;
        this.year=year;
        
    }
    toString(){return `${this.model},${this.year}`}
}
