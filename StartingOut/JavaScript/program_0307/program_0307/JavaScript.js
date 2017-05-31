// This program converts cups to fluid ounces.

function main() {
    // display the intro screen.
    intro();
    // Get the number of cups.
    cups_needed = parseInt(prompt('Enter the number of cups: ')); 
    // Convert the cups to ounces.
    cups_to_ounces(cups_needed);
}

// The intro function displays an introductory screen.
function intro() {
    console.log('This program converts measurements');
    console.log('in cups to fluid ounces. For your');
    console.log('reference the formula is:');
    console.log('1 cup = 8 fluid ounces');
    console.log('');
}

// The cups_to_ounces function accepts a number of
// cups and displays the equivalent number of ounces.
function cups_to_ounces(cups) {
    ounces = cups * 8;
    console.log('That converts to', ounces, 'ounces.');
}

main();