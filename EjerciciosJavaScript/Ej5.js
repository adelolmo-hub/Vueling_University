let lorem_ipsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
let palabras = lorem_ipsum.split(" "); //Divide el array por los espacion en blanco

let biggestWord = "";
//Recorre el array
for(let i = 0; i < palabras.length; i++){
    //Guarda el valor de la palabra si es mayor que la anterior
    if(palabras[i].length > biggestWord.length){
        biggestWord = palabras[i]; 
    }
}

console.log(biggestWord);