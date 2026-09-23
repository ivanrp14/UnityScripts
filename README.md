# UnityScripts

Loose scripts for a Unity **endless runner**. There is no scene and no `ProjectSettings`: they are meant to be copied into a project that already has the character, the ground, and the obstacles.

## Scripts

All of them live in `EndlesRunner/` (that is the folder name in the repo).

| Script | Role |
| --- | --- |
| `PlayerController` | `Rigidbody` movement, jump, and horizontal limits (`minX`, `maxX`). Uses an `Animator` |
| `ObstacleSpawner` | Spawns obstacles |
| `SpawnController` | Spawn control |
| `SpawnManager` | Coordinates the spawners |

## Stack

- Unity
- C#

## How to use it

1. Copy the `EndlesRunner` folder into your project's `Assets`.
2. Put `PlayerController` on the player. It needs a `Rigidbody` and, if you want animation, an `Animator`.
3. Assign `groundLayers` so the jump knows when the player is on the ground.
4. Place `ObstacleSpawner` and `SpawnManager` on a scene object and link the prefabs in the Inspector.

`speed` and `jumpForce` default to 5 in the script; change them in the Inspector.
