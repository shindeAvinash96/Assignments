class GameBoard {
  constructor() {
    this.board = Array(3).fill(null).map(() => Array(3).fill(''));
  }
  reset() {
    this.board = Array(3).fill(null).map(() => Array(3).fill(''));
  }
  placeMark(row, col, mark) {
    if (this.board[row][col] === '') {
      this.board[row][col] = mark;
      return true;
    }
    return false;
  }
  getBoard() {
    return this.board;
  }
}

class TicTacToeFacade {
  constructor(updateUI) {
    this.board = new GameBoard();
    this.players = ['X', 'O'];
    this.currentPlayer = 0;
    this.gameOver = false;
    this.updateUI = updateUI;
  }

  makeMove(row, col) {
    if (this.gameOver) return;

    if (this.board.placeMark(row, col, this.players[this.currentPlayer])) {
      if (this.checkWinner()) {
        this.gameOver = true;
        this.updateUI(`${this.players[this.currentPlayer]} wins!`);
      } else if (this.isDraw()) {
        this.gameOver = true;
        this.updateUI("It's a draw!");
      } else {
        this.currentPlayer = 1 - this.currentPlayer;
        this.updateUI(`Player ${this.players[this.currentPlayer]}'s turn`);
      }
    }
  }

  checkWinner() {
    const b = this.board.getBoard();
    const lines = [
      [b[0][0], b[0][1], b[0][2]],
      [b[1][0], b[1][1], b[1][2]],
      [b[2][0], b[2][1], b[2][2]],
      [b[0][0], b[1][0], b[2][0]],
      [b[0][1], b[1][1], b[2][1]],
      [b[0][2], b[1][2], b[2][2]],
      [b[0][0], b[1][1], b[2][2]],
      [b[0][2], b[1][1], b[2][0]]
    ];
    return lines.some(line => line.every(cell => cell === this.players[this.currentPlayer]));
  }

  isDraw() {
    return this.board.getBoard().flat().every(cell => cell !== '');
  }

  reset() {
    this.board.reset();
    this.currentPlayer = 0;
    this.gameOver = false;
    this.updateUI(`Player X's turn`, true);
  }
}

// --- UI Setup ---
const boardElement = document.getElementById('board');
const statusElement = document.getElementById('status');
const resetBtn = document.getElementById('resetBtn');

let game;

function updateUI(message, reset = false) {
  statusElement.textContent = message;

  const cells = document.querySelectorAll('.cell');
  const boardState = game.board.getBoard();

  cells.forEach(cell => {
    const row = cell.dataset.row;
    const col = cell.dataset.col;
    cell.textContent = boardState[row][col];
  });

  if (reset) {
    cells.forEach(cell => cell.textContent = '');
  }
}

// Create board cells dynamically
for (let r = 0; r < 3; r++) {
  for (let c = 0; c < 3; c++) {
    const cell = document.createElement('div');
    cell.classList.add('cell');
    cell.dataset.row = r;
    cell.dataset.col = c;
    cell.addEventListener('click', () => game.makeMove(r, c));
    boardElement.appendChild(cell);
  }
}

game = new TicTacToeFacade(updateUI);

resetBtn.addEventListener('click', () => game.reset());