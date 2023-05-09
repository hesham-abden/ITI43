function Sequence(start, end, step) {
  this.start = start;
  this.end = end;
  this.step = step;
  this.seq = new Array();
  fill = function (obj) {
    var s = obj.start;
    let count = 0;
    while (s <= obj.end) {
      obj.seq.push(s);
      s += obj.step;
      count++;
    }
  };
  fill(this);
  this.push = function (num) {
    if (num == this.end + this.step) {
      this.seq.push(num);
      this.end += this.step;
    } else {
      throw "not in sequence";
    }
  };
  this.pop = function () {
    this.end -= this.step;
    return this.seq.pop();
  };
  this.append = function (x) {
    if (x == this.start - this.step) {
      this.seq.unshift(x);
      this.start = x;
    } else {
      throw "not in sequence";
    }
  };
}
var sequence = new Sequence(5, 45, 5);
//----------------------------------------------------------------------//

function Box(h, w, l) {
    if(!Box.count>0)
    Box.count=0;
  this.height = h;
  this.weight = w;
  this.length = l;
  this.content = new Array();
  this.add = function (a, b, c, d, e, f) {
    this.content.push(new Book(a, b, c, d, e, f));
    Box.count++;
  };
  this.delete=function(t){
    let index=0;
    let flag=true;
    this.content.forEach(item=>{
        if(item.title==t&&flag==true)
        {
            this.content.splice(index,1);
            Box.count--;
            flag=false;
        }
        index++;
    })

  }
  Box.getCount = function () {
    return Box.count;
  };
}

function Book(title, numofChapter, author, numofPages, publisher, numofCopies) {
  this.title = title;
  this.numofChapter = numofChapter;
  this.author = author;
  this.numofPages = numofPages;
  this.publisher = publisher;
  this.numofCopies = numofCopies;
}
var box = new Box(5, 6, 7);
box.add("HP", 7, "JK.", 1919, "DE",8488);
box.add("HP", 7, "JK.", 1919, "DE",8488);
var box2 = new Box("L","W","L");
box2.add("HP", 7, "JK.", 1919, "DE",8488);
box2.add("HP", 7, "JK.", 1919, "DE",8488);
box2.add("HP", 7, "JK.", 1919, "DE",8488);
var box3 = new Box("L","W","L");
box3.add("HP", 7, "JK.", 1919, "DE",8488);
box3.add("HP", 7, "JK.", 1919, "DE",8488);
box3.add("HP", 7, "JK.", 1919, "DE",8488);

//--------------------------------------------------------------------------------------------    