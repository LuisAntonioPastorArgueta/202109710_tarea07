Module Module1
    Sub Main()
        Const Rows As Integer = 2
        Const Cols As Integer = 2
        Dim A(Rows - 1, Cols - 1) As Integer
        Console.WriteLine("Ingresar elementos de la matriz A:")
        For i As Integer = 0 To Rows - 1
            For j As Integer = 0 To Cols - 1
                Console.Write($"Ingrese el elemento [{i},{j}]: ")
                A(i, j) = Convert.ToInt32(Console.ReadLine())
            Next
        Next
        Console.Clear()
        Console.WriteLine("Matriz A:")
        For i As Integer = 0 To Cols - 1
            For j As Integer = 0 To Rows - 1
                Console.Write($"{A(i, j)} ")
            Next
            Console.WriteLine()
        Next
        Console.WriteLine("Matriz transpuesta de A:")
        For i As Integer = 0 To Cols - 1
            For j As Integer = 0 To Rows - 1
                Console.Write($"{A(j, i)} ")
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub
End Module
