Module ColorTheme
    Public Property PrimaryColor As Color
    Public Property SecondaryColor As Color
    Public ColorList As List(Of String) = New List(Of String)() From {
        "#4F7942",
        "#00A36C"
    }

    Function ChangeColorBrightness(color As Color, correctionFactor As Double) As Color
        Dim red As Double = color.R
        Dim green As Double = color.G
        Dim blue As Double = color.B
        'If correction factor is less than 0, darken color.'
        If correctionFactor < 0 Then
            correctionFactor = 1 + correctionFactor
            red *= correctionFactor
            green *= correctionFactor
            blue *= correctionFactor
            'If correction factor is greater than zero, lighten color.'
        Else
            red = (255 - red) * correctionFactor + red
            green = (255 - green) * correctionFactor + green
            blue = (255 - blue) * correctionFactor + blue
        End If
        Return Color.FromArgb(color.A, CByte(red), CByte(green), CByte(blue))
    End Function

End Module