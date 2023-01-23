window.addEventListener("load", function () {
  let firstName = document.getElementById("firstname");
  let lastName = document.getElementById("lastname");
  let submitButton = document.querySelector("button");
  let dataButton = document.querySelectorAll("button")[1];
  submitButton.addEventListener("click", function () {
    localStorage.setItem("First Name", `${firstName.value}`);
    localStorage.setItem("Last Name", `${lastName.value}`);
  });
  dataButton.addEventListener("click", function () {
    let tempFirst = localStorage.getItem("First Name");
    let tempLast = localStorage.getItem("Last Name");
    let tempLine = document.createElement("div");
    tempLine.innerText = `${tempFirst} ${tempLast}`;
    tempLine.classList.add("content");
    document.body.append(tempLine);
  });
});
