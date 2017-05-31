// This program demonstrates an argument being
// passed to a function.

function main() {
    value = 5;
    showDouble(value);
}

// The showDouble function accepts an argument
// and displays double its value.
function showDouble(number) {
    result = number * 2;
    console.log(result);
}

// Call the main function.
main();