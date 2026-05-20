let szisaGomb = document.getElementById("SziSa");
let gaborGomb = document.getElementById("Gabi");
let meGomb = document.getElementById("me");
let havasGomb = document.getElementById("Havas");
let BrianGomb = document.getElementById("Brian");
let neniGomb = document.getElementById("nene");

let szisaKep = document.getElementById("kep1");
let gaborKep = document.getElementById("kep2");
let meKep = document.getElementById("kep3");
let havasKep = document.getElementById("kep4");
let brianKep = document.getElementById("kep5");
let neniKep = document.getElementById("kep6");


let lenyomott = "";
function mozgat(element){
    if (element == "szisa"){
        szisaKep.style.visibility = "visible";
    }
    else{
        szisaKep.style.visibility = "hidden";
    }
    if (element == "gabor"){
        gaborKep.style.visibility = "visible";
    }
    else{
        gaborKep.style.visibility = "hidden";
    }
    if (element == "me"){
        meKep.style.visibility = "visible";
    }
    else{
        meKep.style.visibility = "hidden";
    }
    if (element == "havas"){
        havasKep.style.visibility = "visible";
    }
    else{
        havasKep.style.visibility = "hidden";
    }
    if (element == "brian"){
        brianKep.style.visibility = "visible";
    }
    else{
        brianKep.style.visibility = "hidden";
    }
    if (element == "neni"){
        neniKep.style.visibility = "visible";
    }
    else{
        neniKep.style.visibility = "hidden";
    }
    
}

