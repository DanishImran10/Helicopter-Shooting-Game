# Helicopter Strike 🚁💥

**Helicopter Strike** is a fast-paced 3D action game built in Unity where players navigate a helicopter through a challenging terrain environment, taking down enemy helicopters and tanks. The objective is to survive waves of enemy attacks while earning points by destroying enemy units.

## 🎯 Gameplay
- Navigate the helicopter using keyboard controls.
- Fire bullets at **enemy helicopters** to destroy them before they crash into you.
- Drop bombs on **enemy tanks** on the ground to eliminate them.
- Earn points for each enemy destroyed.
- The game ends if:
  - An enemy helicopter crashes into the player's helicopter.
  - Enemy tanks successfully shoot down the player's helicopter.

## 🔥 Features
- **Dynamic Enemy AI** that follows and targets the player.
- Multiple enemy types (Helicopters & Tanks).
- Realistic physics with **colliders** and **rigidbodies**.
- Prefab-based enemy spawning system.
- Scoring system for rewarding destruction.
- Explosive bomb-dropping mechanic for ground enemies.

## 🛠️ Development Highlights
- Implemented **prefab instantiation** for spawning enemies dynamically.
- Used **Translate()** to control helicopter movement.
- Set up **LookAt()** functionality for enemy units to track player position.
- Managed physics interactions with **colliders** and **rigidbodies**.
- Built shooting and bomb-dropping mechanics using raycasting and rigidbody forces.

## 🎯 Controls
| Action      | Key      |
|-------------|----------|
| Move Left   | `LeftArrow`      |
| Move Right  | `RightArrow`      |
| Move Forward | `UpArrow`      |
| Move Backward | `DownArrow`    |
| Flight | `Space`    |
| Fire Bullets | `F` |
| Drop Bomb   | `B`      |

## 🌄 Environment Design
The game world is set in a rugged terrain environment, with:
- Rolling hills and mountains.
- Enemy tanks patrolling the ground.
- Helicopters swarming the skies.

![Gameplay Screenshot](Helicopter%20Shooting%20Game/Snowman/images/image1.png)

## 🖥️ Technologies Used
- Unity (C#)
- Rigidbody Physics
- Collision Detection
- Prefab Instantiation
- Explosion Effects with Particle Systems.
