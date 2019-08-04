
'  keeps a running count of each type of event raised by the WeatherStation class.
Public Class SummaryForm
    Private myStation As New WeatherStation

    Private NormalInteger1 As Integer
    Private LightningInteger1 As Integer
    Private RainingInteger1 As Integer
    Private SnowingInteger1 As Integer
    Private TornadoInteger1 As Integer

    Private Sub SummaryForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        textBoxNormal.Text = "0"
        textBoxLightning.Text = "0"
        textBoxRaining.Text = "0"
        textBoxSnowing.Text = "0"
        textBoxTornado.Text = "0"
    End Sub

    Public Sub WeatherCountUpdate(ByVal pNormalInteger1 As Integer,
                   ByVal pLightningInteger1 As Integer,
                   ByVal pRainingInteger1 As Integer,
                   ByVal pSnowingInteger1 As Integer,
                   ByVal pTornadoInteger1 As Integer)

        NormalInteger1 = pNormalInteger1
        LightningInteger1 = pLightningInteger1
        RainingInteger1 = pRainingInteger1
        SnowingInteger1 = pSnowingInteger1
        TornadoInteger1 = pTornadoInteger1

        textBoxNormal.Text = NormalInteger1.ToString
        textBoxLightning.Text = LightningInteger1.ToString
        textBoxRaining.Text = RainingInteger1.ToString
        textBoxSnowing.Text = SnowingInteger1.ToString
        textBoxTornado.Text = TornadoInteger1.ToString
    End Sub

End Class