# RoomManager

- Join the `user` a random room.

```csharp
var result = RoomManager.JoinAsync(user);
```

- Join the `user` to a room with id `id` which have not password.

```csharp
var roomId = 12345l;
var result = RoomManager.JoinAsync(roomId, user);
```

- Join the `user` to random room with specified `level`.

```csharp
var level = 120;
var result = RoomManager.JoinAsync(level, user);
```

- Join the `user` to a room with id `id` and password `password`.

```csharp
var roomId = 12345l;
var password = "room pasword";
var result = RoomManager.JoinAsync(roomId, password, user);
```

- Find the room which user is in.

```csharp
var room = FindRoom(user);
```

- Find the room with his unique id.

```csharp
var roomId = 12345l;
var room = FindRoom(roomId);
```