namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private int[,] gameBoard = new int[3, 3];  // Declare a 2D array to represent the game board (3x3) to track player moves
        private Random random = new Random();     // Create an instance of the Random class for generating random numbers
        private int currentPlayer = 0;            // Initialize the current player to 0 (CPU O)

        public Form1()
        {
            InitializeComponent();        // Initialize the form and its components
            InitializeGameBoard();       // Call a function to set up the initial game board
        }

        private void InitializeGameBoard()
        {
            for (int row = 0; row < 3; row++)    // Loop through rows (0 to 2)
            {
                for (int col = 0; col < 3; col++)    // Loop through columns (0 to 2)
                {
                    gameBoard[row, col] = -1;   // Set each cell of the game board to -1 (indicating an empty cell)
                }
            }
        }

        private void SimulateGame()
        {
            for (int turn = 0; turn < 5; turn++)    // Loop for 5 turns (3 for each player)
            {
                MakeMove(0);    // Make a move for CPU O
                if (CheckForWinner())    // Check if there's a winner after the move
                {
                    DisplayResult();    // Display the result (winner) and exit the function
                    return;
                }

                MakeMove(1);    // Make a move for CPU X
                if (CheckForWinner())    // Check if there's a winner after the move
                {
                    DisplayResult();    // Display the result (winner) and exit the function
                    return;
                }

                currentPlayer = (currentPlayer == 0) ? 1 : 0;    // Toggle the player after both moves (0 -> 1, 1 -> 0)
            }

            MessageBox.Show("Game ended in a tie!");    // Display a tie message if the loop completes without a winner
        }

        private void MakeMove(int player)
        {
            int row, col;
            do
            {
                row = random.Next(0, 3);    // Generate a random row index (0 to 2)
                col = random.Next(0, 3);    // Generate a random column index (0 to 2)
            } while (gameBoard[row, col] != -1);    // Keep generating if the cell is already occupied

            gameBoard[row, col] = player;    // Assign the current player's value to the chosen cell
            UpdateButtonText(row, col, player);    // Update the display text of the button associated with the chosen cell
        }

        private bool CheckForWinner()
        {
            // Check rows for a winner
            for (int row = 0; row < 3; row++)
            {
                if (gameBoard[row, 0] != -1 &&
                    gameBoard[row, 0] == gameBoard[row, 1] &&
                    gameBoard[row, 1] == gameBoard[row, 2])
                {
                    return true;  // Returns true if a player has won in any row
                }
            }

            // Check columns for a winner
            for (int col = 0; col < 3; col++)
            {
                if (gameBoard[0, col] != -1 &&
                    gameBoard[0, col] == gameBoard[1, col] &&
                    gameBoard[1, col] == gameBoard[2, col])
                {
                    return true;  // Returns true if a player has won in any column
                }
            }

            // Check diagonals for a winner
            if (gameBoard[0, 0] != -1 &&
                gameBoard[0, 0] == gameBoard[1, 1] &&
                gameBoard[1, 1] == gameBoard[2, 2])
            {
                return true;  // Returns true if a player has won diagonally from top-left to bottom-right
            }

            if (gameBoard[0, 2] != -1 &&
                gameBoard[0, 2] == gameBoard[1, 1] &&
                gameBoard[1, 1] == gameBoard[2, 0])
            {
                return true;  // Returns true if a player has won diagonally from top-right to bottom-left
            }

            return false;  // Returns false if no player has won
        }

        private void DisplayResult()
        {
            string resultMessage = "";

            if (CheckForWinner())
            {
                int winningPlayer = (currentPlayer == 0) ? 1 : 0;  // Determine the opposite player as the winning player
                resultMessage = "Player " + (winningPlayer + 1) + " wins!";  // Constructs a message indicating which player has won
            }
            else
            {
                resultMessage = "Game ended in a tie!";  // Sets the message to indicate a tie if there's no winner
            }

            lblResults.Text = resultMessage;  // Displays the result message in a label named lblResults
        }


        private void UpdateButtonText(int row, int col, int player)
        {
            // Retrieve the button control corresponding to the given row and column
            Button button = tlpGameBoard.Controls["btn" + row + col] as Button;

            // Update the button's text based on the player's value (0 for "O", 1 for "X")
            button.Text = (player == 0) ? "O" : "X";
        }

        private void btnNewGame_Click_1(object sender, EventArgs e)
        {
            // Reset the game board and clear the text of all buttons
            InitializeGameBoard();
            foreach (Control control in tlpGameBoard.Controls)
            {
                if (control is Button)
                {
                    control.Text = "";
                }
            }

            // Clear the result label
            lblResults.Text = "";

            // Simulate a new game
            SimulateGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Clear the result label when the form is loaded
            lblResults.Text = "";
        }

    }
}