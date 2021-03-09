## Observer Pattern

### Examples
- Observer pattern (List of observers, AddObserver method, RemoveObserver method)
- C# Events (invocation list, -=, += operator)

### Scenario
- Player dies and it is game over, game controller needs to notify other game objects to end

### Layout
- Subject: GameSceneController.cs
- Observers: EnemyController.cs, HUDController.cs, PowerupController.cs