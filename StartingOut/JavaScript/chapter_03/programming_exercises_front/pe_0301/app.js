var c1Button = document.getElementById("c1");
var c2Button = document.getElementById("c2");

var kmDisplay = document.querySelector("#kmDisplay");
var miDisplay = document.querySelector("#miDisplay");

var kMeter = 0;
var mile = 0;

console.log(kmDisplay);
console.log(c1);

c1Button.addEventListener("click", function(){
  kMeter++;
  console.log(kMeter);
  kmDisplay.textContent = kMeter;
});
