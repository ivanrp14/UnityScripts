# UnityScripts

Scripts sueltos de un **endless runner** para Unity. No hay escena ni `ProjectSettings`: están pensados para copiarse a un proyecto que ya tenga el personaje, el suelo y los obstáculos.

## Scripts

Todos viven en `EndlesRunner/` (el nombre de la carpeta va así en el repo).

| Script | Papel |
| --- | --- |
| `PlayerController` | Movimiento con `Rigidbody`, salto y límites horizontales (`minX`, `maxX`). Usa un `Animator` |
| `ObstacleSpawner` | Genera obstáculos |
| `SpawnController` | Control del spawn |
| `SpawnManager` | Coordina los spawners |

## Stack

- Unity
- C#

## Cómo usarlo

1. Copia la carpeta `EndlesRunner` a `Assets` de tu proyecto.
2. Pon `PlayerController` en el jugador. Necesita un `Rigidbody` y, si quieres animación, un `Animator`.
3. Asigna `groundLayers` para que el salto sepa cuándo está en el suelo.
4. Coloca `ObstacleSpawner` y `SpawnManager` en un objeto de la escena y enlaza los prefabs en el Inspector.

`speed` y `jumpForce` salen a 5 en el script; se pueden cambiar en el Inspector.
