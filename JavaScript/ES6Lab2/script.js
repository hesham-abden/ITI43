const getData = async function () {
  try {
    let users = await fetch("http://jsonplaceholder.typicode.com/users");
    let data = await users.json();
    let posts = await fetch("http://jsonplaceholder.typicode.com/posts");
    let postsData = await posts.json();
    let table = document.querySelector("table");
    data.forEach((Element) => {
      let temprow = document.createElement("tr");
      table.appendChild(temprow);
      let tempd = document.createElement("td");
      tempd.innerText = Element["username"];
      temprow.appendChild(tempd);

      tempd = document.createElement("td");
      tempd.innerText = Element["email"];
      temprow.appendChild(tempd);

      tempd = document.createElement("td");
      tempd.innerText =
        Element["address"].geo.lat + "/" + Element["address"].geo.lng;
      temprow.appendChild(tempd);

      tempd = document.createElement("td");
      tempd.innerText = Element["company"].name;
      temprow.appendChild(tempd);

      tempd = document.createElement("td");
      let tempul = document.createElement("ul");
      tempd.appendChild(tempul);
      postsData.forEach((e) => {
        if (e["userId"] == Element.id) {
        let templi = document.createElement("li");
        templi.innerText = e.title;
        tempul.appendChild(templi);
        }
      });
      temprow.appendChild(tempd);
    });
  } catch (error) 
  {
    console.log(error);
  }
};


getData();
