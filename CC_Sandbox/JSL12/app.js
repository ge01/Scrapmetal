// Using the function given, return a string passed in as an argument, but with
// all excess whitespaces removed.
function noWhitespace(a) {

}

var str = "         abc        de fog         ";
console.log(str);
console.log(str.trim());
console.log(str.replace(/\s+/g, ''));
