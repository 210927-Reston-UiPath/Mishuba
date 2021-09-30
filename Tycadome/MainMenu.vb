Class MainMenu
    implements IMenu
    Sub Start() implements IMenu.Start
        Console.WriteLine("Hello World!")
        dim repeat as Boolean = True 
        Do While repeat
            Console.WriteLine("What would you like to do?")
            Console.WriteLine("[0] Say hello")
            Console.WriteLine("[x] Exit")
            dim input as string = Console.ReadLine()
            Select Case input
                Case "0"
                    Console.WriteLine("Hello")
                Case "x"
                    Console.WriteLine("World")
                    repeat = false
            End Select
        Loop
    End Sub
End Class