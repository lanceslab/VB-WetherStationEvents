Public Class MainWeatherForm

    ' declares a Weather Station object using the "WithEvents" keyword so it can generate events
    Private WithEvents myStation As New WeatherStation
    Private mSummary As New SummaryForm
    ' Each time the Timer generates a Tick event, MonitorTheWeather is called in the WeatherStation class:
    Private Sub timerWeatherStation_Tick() Handles timerWeatherStation.Tick
        myStation.MonitorTheWeather()
        SummaryForm.WeatherCountUpdate(NormalInteger, LightningInteger, RainingInteger,
                               SnowingInteger, TornadoInteger)

    End Sub

    Private NormalInteger As Integer = 0
    Private LightningInteger As Integer = 0
    Private RainingInteger As Integer = 0
    Private SnowingInteger As Integer = 0
    Private TornadoInteger As Integer = 0

    ' Each event is raised by the "MonitorTheWeather" method from the WeatherStation CLASS.
    ' method handles the WeatherEvent raised by the WeatherStation object for Normal weather.
    Private Sub myStation_Normal() Handles myStation.Normal
        lblEventDetected.Text = "The weather is normal"
        NormalInteger += 1
    End Sub
    ' method handles the WeatherEvent raised by the WeatherStation object for Lightning.
    Private Sub myStation_Lightning() Handles myStation.Lightning
        lblEventDetected.Text = "A Lightning storm is in progress"
        LightningInteger += 1
    End Sub
    ' method handles the WeatherEvent raised by the WeatherStation object for Raining.
    Private Sub myStation_Raining() Handles myStation.Raining
        lblEventDetected.Text = "Rainfall has been detected"
        RainingInteger += 1
    End Sub
    ' method handles the WeatherEvent raised by the WeatherStation object for Snowing.
    Private Sub myStation_Snowing() Handles myStation.Snowing
        lblEventDetected.Text = "It has begun to snow"
        SnowingInteger += 1
    End Sub
    ' method handles the WeatherEvent raised by the WeatherStation object for a Tornado.
    Private Sub myStation_Tornado() Handles myStation.Tornado
        lblEventDetected.Text = "There is a Tornado headed your way!"
        TornadoInteger += 1
    End Sub

    ' Timer control is enabled and begins to generate a Tick event every 2 seconds:
    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        timerWeatherStation.Enabled = True
    End Sub

    Private Sub buttonSummary_Click(sender As System.Object, e As System.EventArgs) Handles buttonSummary.Click

        NormalInteger = 0
        LightningInteger = 0
        RainingInteger = 0
        SnowingInteger = 0
        TornadoInteger = 0
        '  Just before showing the Summary form, the main form can pass to it a reference to the same
        '  WeatherStation object declared at the top of the main form.
        SummaryForm.Show()

    End Sub
End Class
