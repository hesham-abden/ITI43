var Shape = function (name) {
  if (this.constructor == Shape) {
    throw "Abstract Class";
  }
  this.name = name;
  this.toString = function () {
    return this.name;
  };
};
//============================================================================\\
var Rectangle = function (height, widht, name) {
  this.height = height;
  this.width = widht;
  Shape.call(this, name);
  if (!Rectangle.count > 0) {
    Rectangle.count = 0;
  }
  if(Rectangle.count==1)
  {
    throw "Can't create more than one object"
  }
  Rectangle.count++;

  this.getArea = function () {
    return this.height * this.width;
  };
  this.getPerimeter = function () {
    return 2 * (this.height + this.width);
  };
  this.displayInfo = function () {
    console.log(
      `Height = ${this.height},Width =${
        this.width
      },Area = ${this.getArea()},Perimeter = ${this.getPerimeter()}`
    );
  };
  this.valueOf = function () {
    return this.getArea();
  };
  this.toString = function () {
     this.displayInfo();
  };
  Object.defineProperties(this, {
    height: {
      writable: false,
      configurable: false,
      enumerable: false,
    },
    widht: {
      writable: false,
      configurable: false,
      enumerable: false,
    },
  });
  Object.freeze(this);
};
//============================================================================\\
Rectangle.prototype = Object.create(Shape.prototype);
Rectangle.prototype.constructor = Rectangle;
var rec1 = new Rectangle(5, 10, "hesham");
// var rec2 = new Rectangle(5, 10, "hesham");


//============================================================================\\
var Square = function (length, name) {
  Rectangle.call(this, length, length, name);
  if (!Square.count > 0) {
    Square.count = 0;
  }
  if(Square.count==1)
  {
    throw "Can't create more than one object"
  }
  Square.count++;

  this.getArea = function () {
    return length * length;
  };
  this.getPerimeter = function () {
    return length * 4;
  };
  this.toString = function () {
    return "Square : " + this.name;
  };
};
Square.prototype = Object.create(Rectangle.prototype);
Square.prototype.constructor = Square;
//============================================================================\\
// var seq = new Square(5, "name1");
// var seq = new Square(6, "name2");
// var seq = new Square(7, "name3");
console.log(Square.count);// will display 3 (the count of created objects)
// console.log(rec1.valueOf() + rec2.valueOf()); // sum of areas
