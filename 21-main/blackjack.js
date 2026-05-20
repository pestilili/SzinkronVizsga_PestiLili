let pakli=[
"2_of_clubs.png",
"2_of_diamonds.png",
"2_of_hearts.png",
"2_of_spades.png",
"3_of_clubs.png",
"3_of_diamonds.png",
"3_of_hearts.png",
"3_of_spades.png",
"4_of_clubs.png",
"4_of_diamonds.png",
"4_of_hearts.png",
"4_of_spades.png",
"5_of_clubs.png",
"5_of_diamonds.png",
"5_of_hearts.png",
"5_of_spades.png",
"6_of_clubs.png",
"6_of_diamonds.png",
"6_of_hearts.png",
"6_of_spades.png",
"7_of_clubs.png",
"7_of_diamonds.png",
"7_of_hearts.png",
"7_of_spades.png",
"8_of_clubs.png",
"8_of_diamonds.png",
"8_of_hearts.png",
"8_of_spades.png",
"9_of_clubs.png",
"9_of_diamonds.png",
"9_of_hearts.png",
"9_of_spades.png",
"10_of_clubs.png",
"10_of_diamonds.png",
"10_of_hearts.png",
"10_of_spades.png",
"jack_of_clubs.png",
"jack_of_diamonds.png",
"jack_of_hearts.png",
"jack_of_spades.png",
"queen_of_clubs.png",
"queen_of_diamonds.png",
"queen_of_hearts.png",
"queen_of_spades.png",
"king_of_clubs.png",
"king_of_diamonds.png",
"king_of_hearts.png",
"king_of_spades.png",
"ace_of_clubs.png",
"ace_of_diamonds.png",
"ace_of_hearts.png",
"ace_of_spades.png"
]

let huzopakli = pakli.slice(0);
let bank = Array();
let jatekos = Array();
let osztodiv = document.getElementById("oszto");
let jatekosdiv = document.getElementById("jatekos");
let dealgomb =  document.getElementById("deal");
let hitgomb =  document.getElementById("hit");
let standgomb =  document.getElementById("stand");
let tetmezo = document.getElementById("tet");
let jatekosh1 = document.getElementById("jatekospont");
let bankh1 = document.getElementById("osztopont");
let bankpont = 0;
let jatekospont = 0;

hitgomb.style.visibility = "hidden";
standgomb.style.visibility = "hidden";

function pontFrissit(){
    window.alert(jatekospont + " " + bankpont);
    for (const b of bank) {
        let darab = b.split("_");
        if(Number(darab[0]) != NaN){
            bankpont += parseInt(darab[0]);
        }else if(darab[0] == "ace"){
            if(bankpont + 11 <= 21){
                bankpont += 11;
            }
            else{
                bankpont += 1;
            }
        }else{
            bankpont += 10;
        }
    }

    for (const j of jatekos) {
        let darab = j.split("_");
        if(Number(darab[0]) != NaN){
            jatekospont += parseInt(darab[0]);
        }else if(darab[0] == "ace"){
            if(jatekospont + 11 <= 21){
                jatekospont += 11;
            }
            else{
                jatekospont += 1;
            }
        }else{
            window.alert("face");
            jatekospont += 10;
        }
    }

    window.alert(jatekospont + " " + bankpont);
    bankh1.innerText = bankpont;
    jatekosh1.innerText = jatekospont;
}

function huz(){

    console.log(huzopakli);
    let r = Math.floor(Math.random() * huzopakli.length)
    let huzott = huzopakli[r];
    huzopakli.splice(r, 1);
    console.log(huzopakli);
    return huzott;
}

function deal(){
    bank.push(huz());
    bank.push(huz());
    jatekos.push(huz());
    jatekos.push(huz());
    osztodiv.innerHTML += "<img src=kartyak/" + bank[0] + ">";
    osztodiv.innerHTML += "<img src=kartyak/" + bank[1] + ">";
    jatekosdiv.innerHTML += "<img src=kartyak/" + jatekos[0] + ">";
    jatekosdiv.innerHTML += "<img src=kartyak/" + jatekos[1] + ">";
    dealgomb.style.visibility = "hidden";
    tetmezo.style.visibility = "hidden";
    hitgomb.style.visibility = "visible";
    standgomb.style.visibility = "visible";
    pontFrissit();
}
