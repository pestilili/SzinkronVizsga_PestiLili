let jobbNyil = document.getElementById("jobb-nyil");
let balnyil = document.getElementById("bal-nyil");

let auto1 = document.getElementById("supra");
let auto2 = document.getElementById("nissan");
let auto3 = document.getElementById("szisajargany");
let auto4 = document.getElementById("miata");

let jobb = 0;

function valaszt(element){
    if (element == "jobb"){
        jobb += 1;
    }
    if (element == "bal"){
        jobb -= 1;
    }
    if (jobb == 0){
        auto1.style.visibility = "visible";
        auto2.style.visibility = "hidden";
        auto3.style.visibility = "hidden";                
        auto4.style.visibility = "hidden";
        balnyil.style.pointerEvents = "none";
        localStorage.setItem("auto", "supra");
       
        
    }
    else{
        balnyil.style.pointerEvents = "auto";
    }
    if (jobb == 1){
        auto1.style.visibility = "hidden";
        auto2.style.visibility = "visible";
        auto3.style.visibility = "hidden";                
        auto4.style.visibility = "hidden";
        localStorage.setItem("auto", "nissan");
    }
    if (jobb == 2){
        auto1.style.visibility = "hidden";
        auto2.style.visibility = "hidden";
        auto3.style.visibility = "visible";                
        auto4.style.visibility = "hidden";
        localStorage.setItem("auto", "szisajargany");
    }
    if (jobb == 3){
        auto1.style.visibility = "hidden";
        auto2.style.visibility = "hidden";
        auto3.style.visibility = "hidden";                
        auto4.style.visibility = "visible";
        jobbNyil.style.pointerEvents = "none";
        localStorage.setItem("auto", "miata");
    }
    else{
        jobbNyil.style.pointerEvents = "auto";
    }

}
