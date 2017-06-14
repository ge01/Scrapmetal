// Using the function given, return a string passed in as an argument, but with
// all excess whitespaces removed.
// function noWhitespace(a) {
//
// }
//
// var str = "         abc        de fog         ";
// console.log(str);
// console.log(str.trim());
// console.log(str.replace(/\s+/g, ''));

// Inside the provided function, using a string literal template, return a string
// where the parameters (firstName, lastName) are concatenated in a way as to provide
// the following output if "Tom" and "Riddle" were passed in -
// "Hello, Tom Riddle; nice to meet you.".

// function literal(firstName, lastName) {
//   let greeting1 = '"Hello,';
//   let greeting2 = '; nice to meet you."';
//   return `${greeting1} ${firstName} ${lastName}${greeting2}`;
// }
//
// function literal(firstName, lastName) {
//   return '"Hello, ' + firstName + " " + lastName + '; nice to meet you."';
// }

function literal(firstName, lastName) {
  return `"Hello, ${firstName} ${lastName}; nice to meet you."`;
}



console.log(literal("Tom", "Riddle"));
