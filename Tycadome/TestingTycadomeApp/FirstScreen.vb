Imports System.IO
Imports System.text.json
Class FirstScreen
    Implements Starting
        dim Item as List(of Wishlist) = new List(Wishlist)
        dim Priceless as Items = "items.json"
        dim ItemName as String = ""
        dim Winner as String = "holy grail"
        dim HolyGrail as boolean = false

        sub start() implements Starting.start

    Console.WriteLine("Let's begin here shall we")
    do while HolyGrail
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
    HolyGrail = true
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

    sub AddItem()
    Console.WriteLine()
    dim name as string = Console.ReadLine()
    Console.WriteLine()
    
    dim NewItem as Thing = new Thing(name, int32.Parse(number))
    Item.add(NewItem)
     Console.WriteLine("New item put into your bag! " + NewItem.toString())

    sub ShowItems()
    Console.WriteLine("Here is a list of non holy grail items")
    For each FalseGrail as Wishlist in getItemFromFile()
    Console.WriteLine(FalseGrail.ToString())
    
    next
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