let slider = document.getElementById("mySlider");
let output = document.getElementById("demo");
let attemptDisplay = document.getElementById("attempt-number");
let display = document.getElementById("display");

let attemptCount = 0;
attemptDisplay.innerHTML = attemptCount;
const randomNumber = getRandomNumber();
document.getElementById("button-tryagain").style.display = "none";
display.innerHTML = "Guess the number by moving the slider";

slider.onchange = function () {
  let circle = document.getElementById(`c${this.value}`);
  if (this.value > randomNumber) {
    circle.style.backgroundColor = "red";
    display.innerHTML = "Sorry! The number you guessed is greater";
  }
  else {
    if (this.value < randomNumber) {
      circle.style.backgroundColor = "#FFD966";
      display.innerHTML = "Sorry! The number you guessed is smaller";
    }
    else {
      circle.style.backgroundColor = "green";
      display.innerHTML = "Well done! perfect guess...";
      document.getElementById("button-tryagain").style.display = "inline-block";
      document.getElementById("mySlider").disabled = true;
    }
  }

  attemptCount++;
  attemptDisplay.innerHTML = attemptCount;
  if (attemptCount > 6) {
    display.innerHTML = "You are out of chances!"
    document.getElementById("button-tryagain").style.display = "inline-block";
    document.getElementById("mySlider").disabled = true;
    return;
  }
}

function getRandomNumber() {
  return Math.floor(Math.random() * 10) + 1;
}