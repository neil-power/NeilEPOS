Public Class User

    Public Property UserID As Integer 'Unique UserID
    Public Property UserName As String 'User display name
    Public Property Password As String ' Password to login
    Public Property AccessLevel As UserAccessLevel 'Access level

    Public Shared Function FromLine(line As String) 'Converts from line in file to user data type
        Dim SplitLine As String() = line.Split(",") 'Splits line on commas
        Dim NewUserID As Integer = SplitLine(0) 'Converts ID to integer to add leading zeroes
        Return New User With {.UserID = NewUserID.ToString("00000"), .UserName = SplitLine(1), .Password = SplitLine(2), .AccessLevel = SplitLine(3)} 'Adds user on line to user structure
    End Function

    Public Enum UserAccessLevel 'Data structure containg possible access levels
        Manager 'Can add/remove users, edit product details, view summaries and all user actions
        User 'Can make sales, lookup product details
        None 'No permissions
    End Enum

End Class
