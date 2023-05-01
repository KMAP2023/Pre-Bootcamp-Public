// console.log(example);
// var example = "I'm the example!";    
//undefined
// says I'm the example



// var needle = 'haystack';
// test();
// function test(){
//     var needle = 'magnet';
//     console.log(needle);
// }
//going to log magnet
// test does not get called

// var brendan = 'super cool';
// function print(){
//     brendan = 'only okay';
//     console.log(brendan);
// }
// console.log(brendan);
//it will log super cool
//it will than log only ok.. => i was wrong it did not run the function print

// mean(); //undefined 
// console.log(food);
// var mean = function() {
//     food = "chicken";
//     console.log(food);
//     var food = "fish";
//     console.log(food);
// }
// console.log(food);

// console.log(genre); //undefined
// var genre = "disco";
// rewind(); // unseen error as it is not called
// function rewind() { 
//     genre = "rock"; 
//     console.log(genre); // logs genre as rock
//     var genre = "r&b"; // hoists the genre
//     console.log(genre); // logs r&b
// }
// console.log(genre); // finally logs disco

// dojo = "san jose";
// console.log(dojo); // logs san jose
// learn();
// function learn() {
//     dojo = "seattle";
//     console.log(dojo); //logs seattle
//     var dojo = "burbank"; // hoists burbank as dojo
//     console.log(dojo); // logs burbank
// }
// console.log(dojo); // logs san jose
// whoops.. dojo was never defined, there was never any var/let/const..

console.log(makeDojo("Chicago", 65)); // (first run) logs chicago , 65
console.log(makeDojo("Berkeley", 0)); // (second run) logs berkley, 0
// i did not think that it would run after that but as soon as i saw how the function was ran, it made sense
function makeDojo(name, students) {
    const dojo = {};
    dojo.name = name;
    dojo.students = students;
    if (dojo.students > 50) {
        dojo.hiring = true;
    }
    else if (dojo.students <= 0) {
        dojo = "closed for now";
    }
    return dojo;
}
//it first logged chicago, 65
//runs to function const dojo
//dojo name is chicago
//number of students is 65 therefore > 50
//if statement is true so, it runs as hiring
//runs back up to the second console.log of berkley
// runs to const dojo
// dojo name is berkley
// num of students is < 50
//runs through if and is false
//runs to else if and "is closed for now"
// all running ceases