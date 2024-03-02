# Match3-Unity-Game
## Project evaluation:

#### Advantages:

+ Project does not use Serialized Unity Events for UI elements, uses code to subscribe instead, avoiding loss of references and merge conflicts
+ Project code is simple and readable
+ While not used widely, project uses high level event such as OnMoveEvent (BoardController.cs)
+ Project uses regular c# classes (non-MonoBheaviour) where applicable and is code driven
+ Project have little hard coding or magic strings/numbers

#### Disadvantages & Recommendations:

+ Project uses pattern for the entire application's loop, causing much boilerplate and trouble when extending the whole application to include new features, screens; developers will need to know all existing application states to add or remove one.
> Should avoid this pattern completely for the whole application.
+ Regarding coding conventions, project uses outdated and inconsistent naming styles, screaming caps, inconsistent access modifiers.
> Should use .editorconfig file to enforce conventions better.
+ Project sometimes uses internal modifier when no other assemblies are used.
> Should remove these modifiers completely or make all public methods internal for consistency.
+ Project does not make helpers/ classes static when no instances are being created.
> Should declare classes as static if they fall into this case.
+ Project does not preserve gameplay randomness by using Unity's Random.state, this may cause unfair/unmoderated randomness
> Should use a helper class preserve the random state used to generate items.
+ Project uses does not have magic string, but implementation of fields (used to store those strings) is centralized (Constants.cs)
> Should be declared in partial classes or nested classes
+ Being code driven, project makes editor collaboration with other disciplines harder (not much config exposed in the inspector)
> For now, the scope of the project is relatively simple, the Game Settings prefab works just fine. When extending the project, should have more scriptable objects/prefabs for designers to play with for each feature.
+ Uses of Resources.Load during gameplay
> Should only use this at level loading or cache them if they are retrieved (fixed and refactored in code).
+ Object pooling not implemented for C# objects (Item class) nor Game Objects (Items prefabs).
> Should use them for less strain on CPU and reduce garbage.
+ UI Panels are not prefabs, cause difficulty in collaboration and may make merge conflicts more frequent.
> Should turn them into prefabs and even maybe instantiate them into the game at runtime.