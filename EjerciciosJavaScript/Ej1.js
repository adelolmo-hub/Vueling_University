class Persona {
    constructor(edad) {
      this.edad = edad;
    }
  
    //Devuelve True si la edad es igual o mayor que 18
    esMayorDeEdad() {
      return this.edad >= 18;
    }
  }
  
  // Crear una instancia de Persona con una edad determinada
  var persona = new Persona(20);
  
  // Verificar si la persona es mayor de edad
  if (persona.esMayorDeEdad()) {
    console.log("La persona es mayor de edad.");
  } else {
    console.log("La persona es menor de edad.");
  }