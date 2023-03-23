// clicking the 
// like button will change the number of likes

var countlike = 0;

 var countElement = document.querySelector(".countlike")

 console.log(countElement);

 function addLike (){
    countlike++;
    console.log(countlike);
    countElement.innerText = countlike + " like (s)";
 }

console.log("hello world");
