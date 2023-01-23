window.addEventListener("load", function () {
  let button = document.querySelector("button");
  button.addEventListener("click", function () {
    navigator.geolocation.getCurrentPosition(Position);
  });
  function Position(object) {
    // console.log(object.coords.latitude);
    // console.log(object.coords.longitude);
    location.assign(
      "https://maps.google.com/maps?q=" +
        object.coords.latitude +
        ",+" +
        object.coords.longitude
    );
  }
});
