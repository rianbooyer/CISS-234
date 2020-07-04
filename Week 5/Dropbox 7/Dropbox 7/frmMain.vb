'Rian Booyer
'CISS 234 ADE
'Dropbox 7 astronomy helper
'Astronomy Helper
'Create an application that displays the following data about the planets of the solar
'system (including Pluto, which is no longer considered a planet). (For your information,
'the distances are shown in AUs, or astronomical units. 1 AU equals approximately
'93 million miles. In your application simply display the distances as they are
'shown here, in AUs.)

'Mercury
'Type Terrestrial
'Average distance from the sun 0.387 AU
'Mass 3.31  1023 kg
'Surface temperature 173°C to 430°C

'Venus
'Type Terrestrial
'Average distance from the sun 0.7233 AU
'Mass 4.87  1024 kg
'Surface temperature 472°C

'Earth
'Type Terrestrial
'Average distance from the sun 1 AU
'Mass 5.967  1024 kg
'Surface temperature 50°C to 50°C

'Mars
'Type Terrestrial
'Average distance from the sun 1.5237 AU
'Mass 0.6424  1024 kg
'Surface temperature 140°C to 20°C

'Jupiter
'Type Jovian
'Average distance from the sun 5.2028 AU
'Mass 1.899  1027 kg
'Temperature at cloud tops 110°C

'Saturn
'Type Jovian
'Average distance from the sun 9.5388 AU
'Mass 5.69  1026 kg
'Temperature at cloud tops 180°C

'Uranus
'Type Jovian
'Average distance from the sun 19.18 AU
'Mass 8.69  1025 kg
'Temperature above cloud tops 220°C

'Neptune
'Type Jovian
'Average distance from the sun 30.0611 AU
'Mass 1.03  1026 kg
'Temperature at cloud tops 216°C

'Pluto
'Type Low density
'Average distance from the sun 39.44 AU
'Mass 1.2  1022 kg
'Surface temperature 230°C

'The application should have a separate form for each planet. On the main form, create a
'menu system that allows the user to select the planet he or she wishes to know more
'about.

Public Class frmMain

    Private Sub frmFileExit_Click(sender As Object, e As EventArgs) Handles frmFileExit.Click
        Me.Close()
    End Sub

    
    Private Sub mnuPlanetsMercury_Click(sender As Object, e As EventArgs) Handles mnuPlanetsMercury.Click
        Dim frmMercury As New frmMercury()
        frmMercury.ShowDialog()
    End Sub

    Private Sub VenusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VenusToolStripMenuItem.Click
        Dim frmVenus As New frmVenus()
        frmVenus.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EarthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EarthToolStripMenuItem.Click
        Dim frmEarth As New frmEarth()
        frmEarth.Show()
    End Sub

    Private Sub MarsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarsToolStripMenuItem.Click
        Dim frmMars As New frmMars()
        frmMars.Show()
    End Sub

    Private Sub JupiterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JupiterToolStripMenuItem.Click
        Dim frmJupiter As New frmJupiter()
        frmJupiter.Show()
    End Sub

    Private Sub SaturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaturnToolStripMenuItem.Click
        Dim frmSaturn As New frmSaturn()
        frmSaturn.Show()
    End Sub

    Private Sub UranusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UranusToolStripMenuItem.Click
        Dim frmUranus As New frmUranus()
        frmUranus.Show()
    End Sub

    Private Sub NeptuneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeptuneToolStripMenuItem.Click
        Dim frmNeptune As New frmNeptune()
        frmNeptune.Show()
    End Sub

    Private Sub PlutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlutoToolStripMenuItem.Click
        Dim frmPluto As New frmPluto()
        frmPluto.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Programmed by Rian Booyer. For CISS 234 ADE 7/24/2017", "About")
    End Sub
End Class
