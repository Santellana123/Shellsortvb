Imports System

Module Program
    Sub Main(args As String())
        Dim array(7) As Integer
        array(0) = 7
        array(1) = 3
        array(2) = 14
        array(3) = 20
        array(4) = 31
        array(5) = 4
        array(6) = 10
        array(7) = 11

        Console.WriteLine("Arreglo desordenado:")
        PrintArray(array)

        ' Guardar el tiempo de inicio
        Dim startTime As DateTime = DateTime.Now

        ShellSort(array)

        ' Guardar el tiempo de finalización
        Dim endTime As DateTime = DateTime.Now

        ' Calcular la duración del algoritmo
        Dim duration As TimeSpan = endTime - startTime
        Console.WriteLine($"\nTiempo de ejecución: {duration.TotalMilliseconds} ms")

        ' Mostrar el arreglo ordenado
        Console.WriteLine("\nArreglo ordenado:")
        PrintArray(array)

        Console.ReadLine()
    End Sub
    Sub ShellSort(ByRef array() As Integer)
        ' se obtiene la longitud del array
        Dim n As Integer = array.Length
        ' se obtiene el tamaño de espacio entre elementos
        Dim gap As Integer = n \ 2

        Console.WriteLine(vbCrLf & "Inicio del algoritmo Shell Sort:")

        ' Mientras el espacio entre elementos sea mayor que 0
        While gap > 0
            Console.WriteLine($"\nGap actual: {gap}")

            ' Aplicar el algoritmo de inserción para cada "subarray" con el tamaño de gap
            For i As Integer = gap To n - 1
                ' Guardar el valor actual del elemento en una variable temporal
                Dim temp As Integer = array(i)
                Dim j As Integer = i

                Console.WriteLine($"\nComparando {temp} con los elementos en su subarray:")

                ' Realizar la inserción
                While j >= gap AndAlso array(j - gap) > temp
                    ' Desplazar elementos hacia la derecha hasta encontrar la posición correcta
                    array(j) = array(j - gap)
                    j -= gap

                    PrintArray(array)
                End While

                ' Colocar el valor temporal en la posición correcta en el subarray
                array(j) = temp
                Console.WriteLine($"Insertar {temp} en la posición {j} del subarray:")
                PrintArray(array)
            Next

            ' Reducir el espacio entre elementos a la mitad en cada iteración
            gap \= 2
        End While

        Console.WriteLine(vbCrLf & "Fin del algoritmo Shell Sort:")
    End Sub

    Sub PrintArray(array() As Integer)
        For Each num In array
            Console.Write(num & " ")
        Next
        Console.WriteLine()
    End Sub
End Module
