function esPrimo(numero) {
    // Retorna falso si el número es menor o igual a 1
    if (numero <= 1) {
        return false;
    }
    // Retorna falso si el número es divisible por algún número
    for (let i = 2; i <= Math.sqrt(numero); i++) {
        if (numero % i === 0) {
            return false;
        }
    }
    //Si supera todo lo anterior, es primo
    return true;
}

   /*
  const numero = 7601;
  if (esPrimo(numero)) {
    // Imprime el mensaje si el número es primo.
    console.log(numero + " es un número primo."); 
  } else {
    // Imprime el mensaje si el número no es primo.
    console.log(numero + " no es un número primo."); 
  }*/

//Comprueba si son primos los numeros del 3000 al 3100
for (let i = 3000; i <= 3100; i++) {
    // Imprime el mensaje si el número es primo.
    if (esPrimo(i)) {
        console.log(i + " es un número primo.");
    } else {
        //Imprimer el mensaje si el numero no es primo
        console.log(i + " no es un número primo.");
    }
}
