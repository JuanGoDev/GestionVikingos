# ¡Bienvenido al Valhalla!

## Aplicación para la gestión de vikingos
Establa aplicación tiene como finalidad realizar la gestión de Vikingos para su ingreso al Valhalla.

### La información básica asociada a cada vikingo es la siguiente:
![image](https://github.com/user-attachments/assets/ccddec4a-7faf-43f4-805c-35d60ee4ab0c)

### ¿Cómo se calculan los Valhallapoints en la aplicación?

* Primero se tiene en consideración el número de batallas ganadas del vikingo:
  
  ```
  Puntos = 0;
  Puntos += BatallasGanadas *10; 
  ```
* Luego para sumar más puntos, tenemos en consideración el nivel de honor del vikingo:
  ```
  Puntos += NivelHonor switch
  {
    NivelHonor.Bajo => 50,
    NivelHonor.Medio => 100,
    NivelHonor.Alto => 200,
    _ => 0
  };
  ```

### ¿Cómo se determina el tipo de vikingo en la aplicación?

  * Guerrero de Thor: ```BatallasGanadas >= 10 && NivelHonor == Alto```
  * Guerrero de Freyja: ```BatallasGanadas >= 5 && NivelHonor == Medio```
  * Guerrero de Odín: Si no se cumplen las anteriores condiciones.

### ¿Cómo se determina cuando un vikingo esta listo para el banquete en Valhalla?

* Aquellos vikingos cuyos valhalla points sean al menos 600, recibirán un mensaje "¡Listo para el banquete en Valhalla!".
