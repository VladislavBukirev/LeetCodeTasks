namespace LeetCodeTasks;

public class ValidSudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        var rows = new HashSet<char>[9];
        var columns = new HashSet<char>[9];
        var boxes = new HashSet<char>[9];

        for (var i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            columns[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (var i = 0; i < 9; i++)
        {
            for (var j = 0; j < 9; j++)
            {
                var cell = board[i][j];

                if (cell == '.')
                    continue;

                var boxIndex = (i / 3) * 3 + (j / 3);
                
                if (rows[i].Contains(cell) || columns[j].Contains(cell) || boxes[boxIndex].Contains(cell))
                    return false;

                rows[i].Add(cell);
                columns[j].Add(cell);
                boxes[boxIndex].Add(cell);
            }
        }

        return true; 
    }
}