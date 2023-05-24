function esPrimo(numero) {
    //Si es 1 o menor, devuelve false
    if (numero <= 1) {
      return false
    }
    //Divide el numero entre 2 y su raiz cuadrada
    for (let i = 2; i <= Math.sqrt(numero); i++) {
      //Si es divisible, devuelve false
      if (numero % i === 0) {
        return false;
      }
    }
    return true
  }
  
  let numerosPrimos = [];
  let i = 2;
  //Continua hasta que el array tenga 10 entradas
  while(numerosPrimos.length < 10){
    if (esPrimo(i)) {
      //Añade el numero primo
      numerosPrimos.push(i);
    }
    i++;
  }
  console.log(numerosPrimos);
  