# ❌⭕ Tic Tac Toe

A two-player Tic Tac Toe desktop game built with **C# and Windows Forms (.NET Framework)**.

## ✨ Features

- Two players take turns (Player 1 = X, Player 2 = O)
- Win detection for all 8 lines: 3 rows, 3 columns, 2 diagonals
- Winning line is highlighted
- Draw detection after 9 moves
- Invalid move protection (can't click an occupied cell)
- Board locks automatically when the game ends
- Reset button restarts the game at any time, even mid-game
- Custom X/O images and a board drawn with GDI+

## 🧠 How it works

The game state is tracked with a small struct and two enums:

```csharp
enum enPlayer { Player1, Player2 }
enum enWinner { Player1, Player2, Draw, InProgress }

struct stGameStatus
{
    public enWinner Winner;
    public short PlayCount;
    public bool GameOver;
}
```

Each cell is a `Button` whose `Tag` holds its state: `"?"` (empty), `"X"` or `"O"`.

| Method | Responsibility |
|---|---|
| `ChangeImage(Button)` | Validates the move, places X/O, switches turn, checks win/draw |
| `CheckWinner()` | Checks all 8 winning lines |
| `CheckValue(b1, b2, b3)` | Checks one line, highlights it and sets the winner |
| `EndGame()` | Shows the result and disables the board |
| `ChangingButtonsClickability(bool)` | Enables or disables all 9 cells |
| `ResetGame()` | Resets the board and state (used by the constructor and the Reset button) |

## 🛠️ Tech Stack

- C#
- .NET Framework, Windows Forms
- GDI+ (`Graphics`, `Pen`) for drawing the board

## 🚀 Getting Started

1. Clone the repo
   ```bash
   git clone https://github.com/<your-username>/<repo-name>.git
   ```
2. Open `Tik_Tak_Toe_Game.sln` in **Visual Studio**
3. Press **F5** to build and run

## 📸 Screenshots

<!-- Add screenshots here -->
| In progress | Win | Draw |
|---|---|---|
| ![](screenshots/playing.png) | ![](screenshots/win.png) | ![](screenshots/draw.png) |

## 📚 What I learned

- Modeling game state with enums and structs
- Avoiding duplicated logic by extracting shared methods
- Setting state explicitly instead of toggling it
- Handling edge cases like a win on the final move

## 🔮 Ideas for the future

- Score counter across rounds
- Play against the computer (AI)
- Player names and sound effects

## 👤 Author

**Mohammad**
Computer Information Systems student at the University of Jordan
[YouTube: Start Coding with Mohammad](https://youtube.com/@start-coding-with-mohammad?si=Pa2HQyF8gtO67RJN) · [LinkedIn](www.linkedin.com/in/mohammad-hamdan-0b7b6b30a)
