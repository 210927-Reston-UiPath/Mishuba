Class Thing
property name as String
public sub new (byval name as string)
    me.name
end sub

public sub new()

end sub

overrides function toString() as string
    return $"Name: {me.name}"
    end function

end class