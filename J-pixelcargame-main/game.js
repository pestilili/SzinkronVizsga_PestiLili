let supra = document.getElementById("supra");
let nissan = document.getElementById("nissan");
let szisa = document.getElementById("szisajargany");
let mita = document.getElementById("miata");

let auto = document.getElementById("auto");
let money = document.getElementById("money");
let szoveg = document.getElementById("nyertel");

if(localStorage.getItem("szin") == "kek" && localStorage.getItem("auto") == "supra"){
    supra.style.visibility = ("visible");
}
if(localStorage.getItem("szin") == "kek" && localStorage.getItem("auto") == "miata"){
    miata.style.visibility = ("visible");
    miata.style.filter = ("hue-rotate(210deg)") ;
}
if(localStorage.getItem("szin") == "kek" && localStorage.getItem("auto") == "nissan"){
    nissan.style.visibility = ("visible");
    nissan.style.filter = ("hue-rotate(0deg)") ;
}
if(localStorage.getItem("szin") == "kek" && localStorage.getItem("auto") == "szisajargany"){
    szisa.style.visibility = ("visible");
    szisa.style.filter = ("hue-rotate(0deg)") ;
}

if(localStorage.getItem("szin") == "red" && localStorage.getItem("auto") == "supra"){
    supra.style.visibility = ("visible");
}
if(localStorage.getItem("szin") == "red" && localStorage.getItem("auto") == "miata"){
    miata.style.visibility = ("visible");
    miata.style.filter = ("hue-rotate(0deg)") ;
}
if(localStorage.getItem("szin") == "red" && localStorage.getItem("auto") == "nissan"){
    nissan.style.visibility = ("visible");
    nissan.style.filter = ("hue-rotate(150deg)"); 
}
if(localStorage.getItem("szin") == "red" && localStorage.getItem("auto") == "szisajargany"){
    szisa.style.visibility = ("visible");
    style.filter = ("hue-rotate(150deg)");

}



let AutoHely = 0;
let oldal = 0;

let pont = 0;


let fa = setInterval(() => {
    szoveg.style.visibility = "hidden";
    
    oldal = Math.floor(Math.random() * 2);
    if (oldal == 0){
        money.style.transform = "translateX(0vh)";
    }
    else{
        money.style.transform = "translateX(50vh)";
    } 
    money.style.visibility = "visible";
}, 3000);


let t = 0;
let id = setInterval(() => {
   if (oldal == AutoHely && t % 10 == 0) {
        szoveg.style.visibility = "visible";
        pont += 5;
        oldal = -1;
       
        money.style.visibility = "hidden";
    }
    
    if(pont == 25){

        document.getElementsByTagName("body")[0].innerHTML += "<div id=\"nyeremeny\">Elért pontjaid: " +pont+ "</div>";

        clearInterval(fa);
        clearInterval(id);
        pont = 0;
    
    }
    t++;
}, 100);

document.addEventListener("keydown", function (event) {

    if(event.key === "ArrowLeft"){
        for (let i = 0; i < 4; i++) {
            document.querySelectorAll("#auto img")[i].style.transform = "translateX(0vh)";
            AutoHely = 0;
        }
    }
    else if(event.key === "ArrowRight"){
        for (let i = 0; i < 4; i++) {
            document.querySelectorAll("#auto img")[i].style.transform = "translateX(50vh)";
            AutoHely = 1;
        }
    }        
})


