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
    End Sub

    sub kingdom()
    do while "holy grail"
    Console.WriteLine("which way do you want to go")
    select case input
    case "throne"
    throne()

    case "round table"
    RoundTable()

    case "courtyard"
    Courtyard()

    case "armory"
    Armory()

    case "blacksmith"
    Blacksmith()
    end select

    end sub

    sub church()
    do while "holy grail"
    Console.WriteLine("Where to now")
    select case input
    case "stage"
    stage()

    case "youth center"
    YouthCenter()

    case "seating"
    Seating()

    case "food area"
    FoodArea()

    case "band area"
    BandArea()

    case "chorus area"
    ChorusArea()

    case "bathroom"
    Bathroom()

    end select
    end Sub 
    
    sub graveyard()
    "holy grail" = true
    end sub

    sub lunchroom()
    do while "holy grail" 
        Console.WriteLine("What's Next")
        Select case input
        case "table"
        Console.WriteLine("there is food here")

        case "food line"
        Console.WriteLine("So much different delicious food here")
        AddItems()

        case "bathroom"
        Console.WriteLine("someone need to clean up in here.")


    end sub 

    sub AddItems(byVal FalseGrail as Wishlist)
    dim PastItems as List(of Wishlist = GetItems())
    PastItems.add(FalseGrail)
    ItemName = JsonSerializer.Serialize(PastItems)
    file.WriteAllText(Priceless, ItemName)
    end Sub 
 
    Function GetItems() as List(of Wishlist)
    try ItemName = file.ReadAll(Priceless)
    return JsonSerializer.Deserialize(of List(of Wishlist))(jsonstring)
    Catch ex as Exception
    Return new List(of Wishlist)
    end try 
    end Function

    End Sub
    


End Module
