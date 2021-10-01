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
    do while HolyGrail
    Console.WriteLine("which way do you want to go")
    dim input as string = Console.ReadLine()
    select case input
    case "throne"
    Console.WriteLine("Look its King Shuba")

    case "round table"
    Console.WriteLine("The inscription says 'The table Rote used for King Shuba and his honoray members of Nifaqe")

    case "courtyard"
    Console.WriteLine("This place looks so peaceful")
    
    case "armory"
    Console.WriteLine("Mhmmm, this says restricted area")


    case "blacksmith"
    Console.WriteLine("I wonder what kind of weapon we can get made.")
        AddItem()

    case "yard"
    Console.WriteLine("Going back to the yard")

    end select

    end sub

    sub church()
    Console.WriteLine("Where to now")
    dim input as string = Console.ReadLine()
    select case input
    case "stage"
        Console.WriteLine("Why is the stage so small")
        AddItems()

    case "youth center"
    Console.WriteLine("Looks like they are busy in here")

    case "seating"
    Console.WriteLine("I wonder if anything is in here. Mayve we should look around")

    case "food area"
    Console.WriteLine("This food is to healthy")
        AddItems()

    case "band area"
    Console.WriteLine("Wow look at all the instruments in here")
    Console.WriteLine("What is your favorite Instrument")
        AddItems()

    case "chorus area"
    Console.WriteLine(" ")
    if (input = "yes") {
        AddItems()
    } else {Console.WriteLine("To bad")}

    case "bathroom"
    Console.WriteLine("Finally a clean bathroom")

    case "yard"
    Console.WriteLine("Goin Goin, back back to the yard the yard")


    end select
    end Sub 
    
    sub graveyard()
    HolyGrail = true
    end sub

    sub lunchroom()
        Console.WriteLine("What's Next")
        Console.WriteLine(" ")
        dim input as string = Console.ReadLine()
        Select case input
        case "table"
        Console.WriteLine("there is food here")

        case "food line"
        Console.WriteLine("So many different delicious food here")
        AddItems()

        case "bathroom"
        Console.WriteLine("someone need to clean up in here.")


    end sub 

    sub AddItem()
    Console.WriteLine()
    dim name as string = Console.ReadLine()
    Console.WriteLine()
    
    dim NewItem as Item = new Thing(name)
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