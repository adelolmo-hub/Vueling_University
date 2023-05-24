function duplicar(array){
    let arrayDoble = [];
    array.forEach(function(numero){
        //Duplica el valor y añadelo al nuevo array
        arrayDoble.push(numero*2);
    })
    return arrayDoble;
}

let array = [1,2,3,4,5,6,7,8,9,10]
//Imprime le nuevo array duplicado
console.log(duplicar(array))