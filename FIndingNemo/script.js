let attemptDisplay = document.getElementById("attempt-number");
let display = document.getElementById("display");

let attemptCount = 0;
attemptDisplay.innerHTML = attemptCount;
const randomNumber = getRandomNumber();
document.getElementById("button-tryagain").style.display = "none";

const imageList = document.querySelectorAll(".question-mark-image");

imageList.forEach(image => {
    image.addEventListener("click", (e) => {
        attemptCount++;
        attemptDisplay.innerHTML = attemptCount;
        
        if(e.target.id == `q${randomNumber}`) {
            let correctGuess = document.getElementById(`q${randomNumber}`);
            correctGuess.src = "nemo.jpg";
            display.innerHTML = "Hurrayyy, you guessed it right!";
            document.getElementById("button-tryagain").style.display = "inline-block";
            display.style.color = "green";
            image.style.pointerEvents = "none";
            disableAllImages();
            return;
        }
        else {
            let currentGuess = document.getElementById(`${e.target.id}`);
            currentGuess.src = "cross.png";
            display.innerHTML = "You guessed it wrong!";
            display.style.color = "red";
        }

        if(attemptCount > 4) {
            display.innerHTML = "You are out of chances!";
            document.getElementById("button-tryagain").style.display = "inline-block";
            disableAllImages();
        }
    })
})

function getRandomNumber() {
    return Math.floor(Math.random() * 10) + 1;
}

function disableAllImages() {
    imageList.forEach(img => {
        img.style.pointerEvents = "none";
    });
}