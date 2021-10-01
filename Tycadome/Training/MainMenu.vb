Imports System.IO 
Imports System.Text.Json
Class MainMenu
    implements IMenu
    dim friends as List(of Contact) = new List(of Contact)
    dim filename as String = "friends.json"
    dim jsonstring as string = ""
    Sub Start() implements IMenu.Start
        Console.WriteLine("Hello World!")
        dim repeat as Boolean = True 
        Do While repeat
            Console.WriteLine("What would you like to do?")
            Console.WriteLine("[0] Say hello")
            Console.WriteLine("[1] Showing off friends")
            Console.WriteLine("[x] Exit")
            dim input as string = Console.ReadLine()
            Select Case input
                Case "0"
                    Console.WriteLine("Hello")
                    AddFriend()
                case "1"
                    Console.WriteLine("Show All Friends")
                    ShowFreinds() 
                Case "x"
                    Console.WriteLine("Exit")
                    repeat = false
            End Select
        Loop
    End Sub
    Sub AddFriend ()
    Console.WriteLine("Name: ")
    dim name as string = Console.ReadLine()
    Console.WriteLine("Number: ")
    dim number as String = Console.ReadLine()
    dim newfriend as Contact = new Contact(name, Int32.Parse(number))
    friends.Add(newfriend) 
    Console.WriteLine("New Friend Created! " + newfriend.ToString())
    
    
    End sub
    Sub ShowFriends()
        Console.WriteLine("Friend list plus contact info")
        for Each person As Contact In GetContactsFromFile()
        Console.WriteLine(person.ToString())
        Next
    End Sub
    Sub Addfriend2File(ByVal person as Contact)
        dim exisitingContact as List(of Contact = GetContacts()
        existingContacts.add(person)
        jsonstring = JsonSerializer.Serialize(existingContacts)
        file.WriteAllText(filename, jsonstring)
    End Sub
    Function GetContacts() As List(of Contact)
    try jsonString = file.ReadAll(filename)
    return JsonSerializer.Deserialize(of List(of Contact))(jsonstring))
    Catch ex As Exception  
    Return new List(of Contact)
    End Try
    End Function
    
End Class
