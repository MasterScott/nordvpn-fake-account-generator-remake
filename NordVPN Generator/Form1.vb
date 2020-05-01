Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value = 100 Then
            ProgressBar1.Value = 0
            Dim rng As New Random
            TextBox1.Text = accounts(rng.Next(0, accounts.Count))
            Timer1.Stop()
            MessageBox.Show("Account PREMIUM ENJOY!!", "NordVPN Generator")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Start()
    End Sub

    Dim accounts As New List(Of String)({ _
                                                "80.hengst@gmail.com:Fatdump1",
                                                "brantharry@yahoo.com.au:sunnyboy7",
                                                "IDG4EVER@GMAIL.COM:93CORRADO",
                                                "Xboxrules2004@yahoo.com : Spartan2s",
                                                "djwolfi@gmx.de : Mw270980",
                                                "douglasweilee@gmail.com : shinn105",
                                                "dmalone35@yahoo.com : cincity27",
                                                "cupra66@hotmail.fr : evann1910",
                                                "claymayo@hotmail.com : Luckyjerry1",
                                                "dewijones.75@gmail.com:Johanne09",
                                                "dynzo1@gmail.com : P0w3rth1rs7",
                                                "colinzelin@gmail.com : mets5000",
                                                "dannymreed@live.com : Oou812B612",
                                                "damsgaard.jonas@gmail.com:41erikwowerik",
                                                "elia.knudsen@gmail.com : luisa2009",
                                                "elliott.rieves@gmail.com : Lilrayray03",
                                                "chickenisafingerfood@gmail.com : Jimbobjoe1",
                                                "djiby.sakho@free.fr : djibysakho",
                                                "daniel.douglas101@gmail.com : Minecraf1",
                                                "commo@hotmail.co.uk : Xxcpegh123",
                                                "dbeere3@gmail.com : Redstripe1",
                                                "demonic_sage@hotmail.com:3bLJJiGW",
                                                "ellissafincken@hotmail.com : Liliana1",
                                                "davidmullis06@aol.com : bluenose1875",
                                                "davidburtonor@gmail.com : Echo2134",
                                                "elijah.harrison.evans@gmail.com : Slacker52",
                                                "emobruenski@gmail.com : Cupoftea1",
                                                "dirk@daude.net : henner70",
                                                "charles.chapel@gmail.com : Charles95",
                                                "erodgers37@mybc3.bc3.edu : MUMmum123",
                                                "erik.a.gademsky@gmail.com : Godspeed1",
                                                "enno@olbrich.net:94f6291z",
                                                "eliejuniorbadr@gmail.com : Elieelie1",
                                                "frankcanfield7@gmail.com : Frankdad69",
                                                "fontmail1@aol.com : jamaica1",
                                                "erisaafshar@gmail.com : Artais21",
                                                "geocon@iinet.net.au:494maria"
                                                })
End Class
