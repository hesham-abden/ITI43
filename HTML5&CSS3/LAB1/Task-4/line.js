window.addEventListener("load", function () {
  let can = document.getElementById("can");
  let coord=0;
  let ctx = can.getContext("2d");
  ctx.beginPath();
  ctx.moveTo(0, 0);
  ctx.strokeStyle = "red";
  ctx.lineWidth = 5;
  let IntervalId = setInterval(() => {
    ctx.lineTo(coord, coord);
    ctx.stroke();
    coord++;
    console.log(" Interval Checker");
    if(coord>can.width)
    {
        ctx.closePath();
        
        this.alert("Animation End")
        clearInterval(IntervalId);
    }
  }, 10);

  
});
