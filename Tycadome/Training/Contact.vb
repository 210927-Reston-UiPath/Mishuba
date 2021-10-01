Class Contact    
    Property Name As String
    Property PhoneNumber As Integer 
    Public Sub New(ByVal name as String, ByVal number as integer)
        Me.Name = Name
        Me.PhoneNumber = number
    End Sub
    Public Sub New()
        
    End Sub

   Overrides Function ToString() As String
        return $"Name: {Me.Name} Number: {Me.Phonenumber}"
    End Function

End Class