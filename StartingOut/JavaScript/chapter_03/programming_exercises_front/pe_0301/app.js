var c1Button = document.getElementById("c1");
var c2Button = document.getElementById("c2");
var resetButton = document.getElementById("reset");
var kmDisplay = document.querySelector("#kmDisplay");
var miDisplay = document.querySelector("#miDisplay");
var numInput = document.querySelector("input");
var startValueDisplay = document.querySelector("p span");
var p = document.querySelector("p");
var kMeters = 0;
var miles = 0;


console.log(kmDisplay);
console.log(c1);

c1Button.addEventListener("click", function(){
  kMeters++;
  console.log(kMeters);
  kmDisplay.textContent = kMeters;

  miles = kMeters * 0.6214;

  miDisplay.textContent = miles.toFixed(2);

  kmDisplay.classList.add("kmColor");
  miDisplay.classList.add("miColor");
});

console.log(resetButton);
resetButton.addEventListener("click", function(){
  kMeters = 0;
  miles = 0;
  kmDisplay.textContent = kMeters;
  miDisplay.textContent = miles;
});

numInput.addEventListener("change", function(){
  //p.textContent = "Value Changed";
  startValueDisplay.textContent = numInput.value;
  kmDisplay = numInput.value;

  console.log(numInput.value);

});
