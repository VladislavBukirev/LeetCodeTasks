namespace LeetCodeTasks;

public class RotateImage
{
    public void Rotate(int[][] matrix)
    {
        var n = matrix.Length;

        for (var i = 0; i < n; i++)
            for (var j = i; j < n; j++)
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);

        for (var i = 0; i < n; i++)
            Array.Reverse(matrix[i]);
    }
}