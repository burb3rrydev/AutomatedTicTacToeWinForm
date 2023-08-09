using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private int[,] gameBoard = new int[3, 3]; // Create a 2D array to represent the game board (0: O, 1: X)
        private int currentPlayer = 0; // Initialize the current player (0: O, 1: X)
        private int movesCounter = 0; // Initialize the counter for moves made

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetGameBoard(); // Call the method to reset the game board
        }

        private void ResetGameBoard()
        {
            for (int row = 0; row < 3; row++) // Loop through rows of the game board
            {
                for (int col = 0; col < 3; col++) // Loop through columns of the game board
                {
                    gameBoard[row, col] = -1; // Set each cell to an initial value (-1 indicates an empty cell)
                }
            }

            foreach (Button button in tlpGameBoard.Controls) // Loop through each button in the game board UI
            {
                button.Text = ""; // Clear the button text
                button.BackColor = SystemColors.Control; // Reset the button background color
                button.ForeColor = SystemColors.ControlText; // Reset the button text color
            }

            currentPlayer = new Random().Next(2); // Randomly choose the starting player (0 or 1)
            movesCounter = 0; // Reset the moves counter
            lblResults.Text = ""; // Clear the results label
        }

        private void CellButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender; // Get the button that was clicked
            int row = int.Parse(clickedButton.Tag.ToString().Split(',')[0]); // Extract the row index from the button's tag
            int col = int.Parse(clickedButton.Tag.ToString().Split(',')[1]); // Extract the column index from the button's tag

            if (gameBoard[row, col] == -1) // Check if the clicked cell is empty
            {
                gameBoard[row, col] = currentPlayer; // Assign the current player's ID to the clicked cell
                clickedButton.Text = (currentPlayer == 0) ? "O" : "X"; // Set the text of the clicked button to "O" or "X"
                clickedButton.Enabled = false; // Disable the clicked button

                movesCounter++; // Increment the moves counter
                CheckForWinner(); // Call a method to check for a winner

                if (movesCounter % 2 == 0 && movesCounter < 8) // Check if it's the other player's turn and there are remaining empty cells
                {
                    currentPlayer = 1 - currentPlayer; // Switch to the other player (0 to 1 or 1 to 0)
                    MakeCPUMove(); // Call a method to make the CPU's move
                }
            }
        }

        private void CheckForWinner()
        {
            // Check for a winning row
            for (int row = 0; row < 3; row++)
            {
                if (gameBoard[row, 0] != -1 && gameBoard[row, 0] == gameBoard[row, 1] && gameBoard[row, 0] == gameBoard[row, 2])
                {
                    // Highlight the cells that form the winning row
                    HighlightWinnerCells(row, 0, row, 1, row, 2);

                    // Show the winner (either Player O or Player X)
                    ShowWinner(gameBoard[row, 0]);

                    // Exit the function since a winner is found
                    return;
                }
            }

            // Check for a winning column
            for (int col = 0; col < 3; col++)
            {
                if (gameBoard[0, col] != -1 && gameBoard[0, col] == gameBoard[1, col] && gameBoard[0, col] == gameBoard[2, col])
                {
                    // Highlight the cells that form the winning column
                    HighlightWinnerCells(0, col, 1, col, 2, col);

                    // Show the winner (either Player O or Player X)
                    ShowWinner(gameBoard[0, col]);

                    // Exit the function since a winner is found
                    return;
                }
            }

            // Check for a winning diagonal (top-left to bottom-right)
            if (gameBoard[0, 0] != -1 && gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[0, 0] == gameBoard[2, 2])
            {
                // Highlight the cells that form the winning diagonal
                HighlightWinnerCells(0, 0, 1, 1, 2, 2);

                // Show the winner (either Player O or Player X)
                ShowWinner(gameBoard[0, 0]);

                // Exit the function since a winner is found
                return;
            }

            // Check for a winning diagonal (top-right to bottom-left)
            if (gameBoard[0, 2] != -1 && gameBoard[0, 2] == gameBoard[1, 1] && gameBoard[0, 2] == gameBoard[2, 0])
            {
                // Highlight the cells that form the winning diagonal
                HighlightWinnerCells(0, 2, 1, 1, 2, 0);

                // Show the winner (either Player O or Player X)
                ShowWinner(gameBoard[0, 2]);

                // Exit the function since a winner is found
                return;
            }

            // If no winner is found and all moves are used up, it's a tie
            if (movesCounter == 9)
            {
                lblResults.Text = "It's a tie!";
            }
        }

        // Highlight the cells of the winning line
        private void HighlightWinnerCells(int row1, int col1, int row2, int col2, int row3, int col3)
        {
            // Get the Button objects of the cells in the winning line
            Button[] winnerButtons = { GetButton(row1, col1), GetButton(row2, col2), GetButton(row3, col3) };

            // Set the background and text colors of the winning cells
            foreach (Button button in winnerButtons)
            {
                button.BackColor = Color.Green;
                button.ForeColor = Color.White;
            }
        }

        // Display the winner (either Player O or Player X)
        private void ShowWinner(int winner)
        {
            if (winner == 0)
            {
                lblResults.Text = "Player O Wins!";
            }
            else if (winner == 1)
            {
                lblResults.Text = "Player X Wins!";
            }
        }

        // Get a button from the game grid based on its row and column
        private Button GetButton(int row, int col)
        {
            string buttonName = "btn" + row + col;
            return Controls.Find(buttonName, true)[0] as Button;
        }

        // Make a move for the CPU player
        private void MakeCPUMove()
        {
            // Simple random move for the CPU player
            Random random = new Random();
            int row, col;

            do
            {
                row = random.Next(3);
                col = random.Next(3);
            } while (gameBoard[row, col] != -1);

            gameBoard[row, col] = currentPlayer;
            GetButton(row, col).Text = (currentPlayer == 0) ? "O" : "X";
            GetButton(row, col).Enabled = false;

            movesCounter++;
            CheckForWinner();

            if (movesCounter < 9 && lblResults.Text == "")
            {
                currentPlayer = 1 - currentPlayer; // Switch back to the other player
                MakeCPUMove(); // Continue making moves
            }
        }

        // Handle the click event for the "New Game" button
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            ResetGameBoard();
            MakeCPUMove(); // Start with a CPU move
            btnNewGame.Enabled = false; // Disable the New Game button
        }

        // Handle the click event for the "Reset" button
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGameBoard();
            btnNewGame.Enabled = true; // Enable the New Game button
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            lblResults.Text = "";
        }
    }
}




