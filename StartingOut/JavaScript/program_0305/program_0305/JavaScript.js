// This program demonstrates two functions that
// have local variables with the same name.

function main() {
    // Call the texas function.
    texas();
    // Call the california function.
    california()
}

// Definition fo the texas function. It creates
// a local variable named birds.
function texas() {
    birds = 5000;
    console.log('texas has', birds, 'birds.');
}

// Definition fo the california function. It also
// a local variable named birds.
function california() {
    birds = 8000;
    console.log('california has', birds, 'birds.');
}

// Call the main funcion.
main();