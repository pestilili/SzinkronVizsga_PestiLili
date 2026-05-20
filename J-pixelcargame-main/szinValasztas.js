let a1sz2 = document.getElementById("supra_blue");
let a1sz1 = document.getElementById("supra_original");
let a2sz1 = document.getElementById("nissan_original");
let a2sz2 = document.getElementById("nissan_blue");
let a3sz1 = document.getElementById("szisajargany_original");
let a3sz2 = document.getElementById("szisajargany_blue");
let a4sz1 = document.getElementById("miata_original");
let a4sz2 = document.getElementById("miata_blue");

red = document.getElementById("red")
blue = document.getElementById("blue")
yellow = document.getElementById("yellow")
pink = document.getElementById("pink")
white = document.getElementById("white")
green = document.getElementById("green")

if (localStorage.getItem("auto") == "supra") a1sz1.style.visibility = ("visible");
else if (localStorage.getItem("auto") == "nissan") a2sz1.style.visibility = ("visible");
else if (localStorage.getItem("auto") == "szisajargany") a3sz1.style.visibility = ("visible");
else if (localStorage.getItem("auto") == "miata") a4sz1.style.visibility = ("visible");

function szinvalaszt(element){
    if (element == "blue" && localStorage.getItem("auto") == "miata") a4sz1.style.filter = ("hue-rotate(210deg)") ;
    if (element == "blue" && localStorage.getItem("auto") == "nissan") a2sz1.style.filter = ("hue-rotate(0deg)") ;
    if (element == "blue" && localStorage.getItem("auto") == "supra"){
        window.alert("Fújjjj kék supra !? Ugyan már!")}; 
    if (element == "blue" && localStorage.getItem("auto") == "szisajargany") a3sz1.style.filter = ("hue-rotate(0deg)") ;

    if (element == "red" && localStorage.getItem("auto") == "miata") a4sz1.style.filter = ("hue-rotate(0deg)") ;
    if (element == "red" && localStorage.getItem("auto") == "nissan") a2sz1.style.filter = ("hue-rotate(150deg)"); 
    if (element == "red" && localStorage.getItem("auto") == "supra"){
        window.alert("Piros ?? EZ komoly ? bruh");
        
    }
    
    if (element == "red" && localStorage.getItem("auto") == "szisajargany") a3sz1.style.filter = ("hue-rotate(150deg)");


    if (element == "blue") {
        localStorage.setItem("szin", "kek")
    }
    if (element == "red") {
        localStorage.setItem("szin", "red")
    }
}