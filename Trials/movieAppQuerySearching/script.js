let moviequery=$("input").val()
let imgPath="https://image.tmdb.org/t/p/w500/";

  const getData=function(uRl)
{
    fetch(uRl).then((respone)=>respone.json())
    .then((data)=>(
    displayData(data.results)
    // console.log(data.results)
    ))
    
}
const displayData=function(dataResults)
{
    dataResults.forEach(movie => {
        const { title, poster_path, id,release_data } = movie;
        let movieElement=$("<div></div>");
    movieElement.addClass("movie");
    movieElement.html(`
                          <a href="./DetailsPage.html?id=${id}">
                          <img src="${imgPath + poster_path}" alt="Move" />
                          <h4 id="moveName">${title}</h4>
                          </a> `
                      );
   $("#main").append(movieElement); 
        
    });
}
$("button").click(function(){
    $("#main").empty();
    moviequery=$("input").val();
    let uRl=`https://api.themoviedb.org/3/search/movie?api_key=d7e9f95217dd3fba63feb5aa2b16d37c&query=${moviequery}`;
    console.log(uRl);
    getData(uRl);
})
