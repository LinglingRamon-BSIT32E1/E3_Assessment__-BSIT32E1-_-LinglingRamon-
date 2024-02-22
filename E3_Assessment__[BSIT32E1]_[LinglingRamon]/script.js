function EvenOrOdd() {
    let num = parseInt(prompt("Enter a number:"));
    let results = num % 2 === 0 ? "Even" : "Odd";
    document.getElementById("result").innerText = "" + results;
  }


