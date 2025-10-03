# 🎮 Math Quiz Game

A **Math Quiz Game** built with **C# WinForms**, where players can choose quiz level, operation type, number of rounds, and time duration. The game generates randomized math questions, tracks correct/wrong/skipped answers, and displays results.

---

## ✨ Features

- **Quiz Setup (Form1)**
  - Select quiz level: Easy, Medium, Hard, Mix
  - Select operation type: Addition, Subtraction, Multiplication, Division, or Mix
  - Set number of rounds and time limit

- **Quiz Gameplay (Form2)**
  - Randomly generates math questions based on chosen level and operation type
  - Displays 4 answer options using radio buttons (one correct, three wrong)
  - Tracks rounds passed, correct/wrong/skipped answers
  - Optional timer for timed quizzes
  - Next Question and Check Answer buttons
  - Restart and exit options

- **Results Display (Form3)**
  - Shows summary of the game: rounds passed, level, operation type, time, correct/wrong/skipped answers
  - Animated title color using timers

---

## 🚀 How It Works

1. **Form1 (Setup)**
   - Player selects quiz level, operation type, number of rounds, and time duration
   - Choices are saved to a text file (`QuizOrder.txt`)

2. **Form2 (Gameplay)**
   - Reads player choices from file
   - Randomly generates questions according to level and operation
   - Tracks player's answers and statistics
   - Results saved to a text file (`GameResult.txt`)

3. **Form3 (Result)**
   - Reads results from file
   - Displays game summary with visual timers

---

## 🖼️ Screenshots
| Picture 1 | Picture 2 | Picture 3 |
|-----------|-----------|-----------|
| <img width="509" height="483" alt="111" src="https://github.com/user-attachments/assets/2981dcb6-d14a-4ea8-914c-612d163b1494" />
 | <img width="605" height="433" alt="222" src="https://github.com/user-attachments/assets/bc9dd48c-5c7d-4717-80a2-aabfaf00afc2" />
 | <img width="710" height="413" alt="333" src="https://github.com/user-attachments/assets/183b61fb-349c-4f37-b2b6-4848174a4419" />
 |

---

## 🕹️ How to Run

1. Clone the repository:
```bash
git clone https://github.com/yourusername/Math-Quiz-Game.git



