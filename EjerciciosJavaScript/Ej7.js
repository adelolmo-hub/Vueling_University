class Persona {
    constructor(edad) {
        this.edad = edad;
    }

    //Devuelve True si la edad es igual o mayor que 18
    esMayorDeEdad() {
        return this.edad >= 18;
    }
}

// Crear un array
var arrayDePersonas = [];
//Crea 5 instacias de Persona con edades distintas
var persona1 = new Persona(25);
var persona2 = new Persona(30);
var persona3 = new Persona(40);
var persona4 = new Persona(12);
var persona5 = new Persona(9);
//Añade las instancias al array
arrayDePersonas.push(persona1);
arrayDePersonas.push(persona2);
arrayDePersonas.push(persona3);
arrayDePersonas.push(persona4);
arrayDePersonas.push(persona5);

let edadesMayorDeEdad = [];
arrayDePersonas.forEach(function(persona){
    // Verificar si la persona es mayor de edad
    if (persona.esMayorDeEdad()) {
        //Añade su edad al array
        edadesMayorDeEdad.push(persona.edad);
    }
})
//Suma todas las edades del array
var suma = edadesMayorDeEdad.reduce(function(acumulador, numero) {
    return acumulador + numero;
  }, 0);
 
//Calcula la media de todas las edades e imprimela
var media = suma / edadesMayorDeEdad.length;
console.log(media);
