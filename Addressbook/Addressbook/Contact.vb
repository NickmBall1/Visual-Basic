Public Class Contact
    Public first As String
    Public last As String
    Public phone As String
    Public email As String
    Public address As String
    Public Overrides Function tostring() As String
        Return last & "," & first
    End Function
End Class
