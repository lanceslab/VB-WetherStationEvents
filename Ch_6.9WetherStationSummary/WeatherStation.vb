

Public Class WeatherStation
    ' defines a delegate named WeatherEvent that serves as a template for
    ' events that pass no arguments and return nothing.
    Public Delegate Sub WeatherEvent()
    ' Defines the events the class can raise and each event are of type WeatherEvent.
    Public Event Normal As WeatherEvent
    Public Event Raining As WeatherEvent
    Public Event Snowing As WeatherEvent
    Public Event Lightning As WeatherEvent
    Public Event Tornado As WeatherEvent

    ' a random number generator is declared and is used by the ReadWeatherSensor method 
    Private randGenerator As New Random
    ' ReadWeatherSensor method to simulate data returned by a physical weather sensor.
    Private Function ReadWeatherSensor() As Integer
        Return randGenerator.Next(5)
    End Function
    ' When the ReadWeatherSensor method returns a value between 0 and 4, the MonitorTheWeather method
    ' uses the value to raise different events:
    Public Sub MonitorTheWeather()
        Dim sensorValue As Integer = ReadWeatherSensor()
        Select Case sensorValue
            Case 0
                RaiseEvent Normal()
                'NormalInteger2 += 1
                'RaiseEvent NormalInt()
            Case 1
                RaiseEvent Raining()
                'LightningInteger2 += 1
                'RaiseEvent RainingInt()
            Case 2
                RaiseEvent Snowing()
                'RainingInteger2 += 1
                'RaiseEvent SnowingInt()
            Case 3
                RaiseEvent Lightning()
                'LightningInteger2 += 1
                'RaiseEvent LightningInt()
            Case 4
                RaiseEvent Tornado()
                'TornadoInteger2 += 1
                'RaiseEvent TornadoInt()
        End Select
    End Sub

End Class
