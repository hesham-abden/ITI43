window.addEventListener("load", function () {
  let red = document.getElementById("red");
  let blue = document.getElementById("blue");
  let green = document.getElementById("green");
  let lorem = document.querySelector("div");
  let redRgb=0;
  let blueRgb=0;
  let greenRgb=0;

  red.addEventListener("change", function () {
    redRgb = this.value;
   updateColor();
  });
  blue.addEventListener("change", function () {
    blueRgb = this.value;
    updateColor();
  });
  green.addEventListener("change", function () {
    greenRgb = this.value;
    updateColor();
  });
  const updateColor=function(){
    lorem.style.color=`rgb(${redRgb},${greenRgb},${blueRgb})`
  }
  updateColor();
});
