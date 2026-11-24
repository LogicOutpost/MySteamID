# MySteamID

A lightweight Rust server plugin that allows players to retrieve their own SteamID directly through an in-game chat command.

## Features

- Allows players to retrieve their SteamID.
- Displays the SteamID privately to the requesting player.
- No Steam API key required.
- No external dependencies.

## Chat Commands

| Command | Description |
|---|---|
| `/steamid` | Displays your SteamID privately in chat. |

## Requirements

- Rust Dedicated Server
- Oxide/uMod plugin framework

## Installation

1. Download `MySteamID.cs`.
2. Place the file inside your server's `oxide/plugins` directory.
3. The plugin will automatically compile and load.
4. Join your server and type `/steamid` in chat.

## Author

**LogicOutpost**

## Version

1.0.0
