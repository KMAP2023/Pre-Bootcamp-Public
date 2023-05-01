// const cars = ['Tesla', 'Mercedes', 'Honda']
// const [ randomCar ] = cars
// const [ ,otherRandomCar ] = cars
// //Predict the output
// console.log(randomCar) //log all three cars => i was wrong
// console.log(otherRandomCar) // log honda => i thought it was going to cut off the first 2 cars
// // the first console actually logged tesla as there was no index
// // the 2nd console cut off the first index and dropped the last car and logged mercedes

// const employee = {
//     name: 'Elon',
//     age: 47,
//     company: 'Tesla'
// }
// const { name: otherName } = employee;
// //Predict the output
// console.log(name); //log elon
// console.log(otherName); // log otherName
// // it deployed an error as soon as it got to console.log(name) because const cannot be hoisted
// // but it can be fixed if we were using dot notation console.log(employee.name)

// const person = {
//     name: 'Phil Smith',
//     age: 47,
//     height: '6 feet'
// }
// const password = '12345'; // sets pw as 12345
// const { password: hashedPassword } = person; // sets as undefined 
// //Predict the output
// console.log(password); // logs 12345
// console.log(hashedPassword); // undefined


// const numbers = [8, 2, 3, 5, 6, 1, 67, 12, 2]; // sets these #
// const [,first] = numbers; // gets [1] which is 2
// const [,,,second] = numbers; // gets [3] which is 5
// const [,,,,,,,,third] = numbers; // gets[8] which is 2
// //Predict the output
// console.log(first == second); // logs 2 == 5 which is false
// console.log(first == third); // logs 2 == 2 which is true 
// // i got it right!!!!!! yay me


// const lastTest = {
//     key: 'value',
//     secondKey: [1, 5, 1, 8, 3, 3]
// }
// const { key } = lastTest; // sets the key as lastTest
// const { secondKey } = lastTest; // sets the secondKey as lastTest
// const [ ,willThisWork] = secondKey; // sets the index of the secondKey to willThisWork ==> is actually the index of 1 which is the number 5 from the array
// //Predict the output
// console.log(key); //log value
// console.log(secondKey); // log lastTest
// console.log(secondKey[0]); // log 1
// console.log(willThisWork); //??? ==> logged as 5
// // ====> i got this one semi right
