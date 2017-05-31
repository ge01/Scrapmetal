// This program displays step-by-step instructions
// for disassembling an Acme dryer.
// The main function performs the program's main logic.
function main() {
    // Display the start-up message.
    startupMessage();
    alert("Press Enter to see Step 1.");
    // Display step 1.
    step1();
    alert("Press Enter to see Step 2.");
    // Display step 2.
    step2();
    alert("Press Enter to see Step 3.");
    // Display step 3.
    step3();
    // Display step 4.
    alert("Press Enter to see Step 4.");
    step4();
}

// The startupMessage function displays the 
// program's initial message on the screen.
function startupMessage() {
    console.log("This program tells you how to");
    console.log("disassemble an ACME laundry dryer.");
    console.log("There are 4 steps in the process.");
    console.log();
}

// The step1 function displays the instructions
// for step 1.
function step1() {
    console.log("Step 1: Unplug the dryer and");
    console.log("move it away from the wall.");
    console.log();
}

// The step2 function displays the instructions
// for step 2.
function step2() {
    console.log("Step 2: Remove the six screws");
    console.log("from the back of the dryer");
    console.log();
}

// The step3 function displays the instructions
// for step 3.
function step3() {
    console.log("Step 3: Remove the back panel");
    console.log("from the dryer.");
    console.log();
}

// The step function displays the instructions
// for step 4.
function step4() {
    console.log("Step 4: Pull the top of the");
    console.log("dryer straight up");
    console.log();
}

// Call the main function to begin the program.
main();