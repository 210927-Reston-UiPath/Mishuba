Imports System

Module Program
    Sub Main(args As String())
        dim walk as Direction = move()
        dim Priceless as Items = "items.json"
        dim ItemName as String = ""
        dim Winner as String = "holy grail"
        dim "holy grail" as boolean = false
        
    Console.WriteLine("Let's begin here shall we")
    
    
    do while "holy grail"
        Console.WriteLine("Where do you want to go")
        Console.WriteLine("kingdom")
        Console.Writeline("church")
        Console.Writeline("graveyard")
        Console.Writeline("lunchroom")
        dim input as string = Console.ReadLine()
        select case input
        case "kingdom"
        kingdom()

        case "church"
        church()

        case "graveyard"
        graveyard()

        case "lunchroom"
        lunchroom()

        end select

        Console.WriteLine("Hello World!")
    End Sub

    sub kingdom()
    Console.WriteLine("which way do you want to go")

    end sub

    sub 
End Module
