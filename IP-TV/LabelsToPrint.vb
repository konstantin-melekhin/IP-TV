Module LabelsToPrint
    Public Sub IP_Lab(SN As ArrayList, LabelScenario As Integer, x As Integer, y As Integer, x2 As Integer, y2 As Integer, COM3 As IO.Ports.SerialPort, COM6 As IO.Ports.SerialPort)
        Dim StrToPrint As String
        Select Case LabelScenario
            Case 0 '"Этикетки 45х8 и 39х19"
                StrToPrint = $"
^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^JUS^LRN^CI0^XZ
^XA
^MMT
^PW531
^LL0154
^LS0
^BY2,3,41^FT" & 83 + x2 & "," & 106 + y2 & "^BCN,,N,N
^FD>:" & Mid(SN(1), 1, 2) & ">5" & Mid(SN(1), 3) & "^FS
^FT" & 76 + x2 & "," & 62 + y2 & "^A0N,29,28^FH\^FDS/N:^FS
^FT" & 129 + x2 & "," & 62 + y2 & "^A0N,29,28^FH\^FD" & SN(1) & "^FS
^PQ3,0,1,Y^XZ"
                COM6.Open()
                COM6.Write(StrToPrint) 'ответ в COM порт
                COM6.Close()

                StrToPrint = "
^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^JUS^LRN^CI0^XZ
^XA
^MMT
^PW461
^LL0236
^LS0
^BY2,3,56^FT" & 31 + x & "," & 130 + y & "^BCN,,N,N
^FD>:" & Mid(SN(1), 1, 2) & ">5" & Mid(SN(1), 3) & "^FS
^FT" & 24 + x & "," & 70 + y & "^A0N,29,28^FH\^FDS/N:^FS
^FT77,70^A0N,29,28^FH\^FD" & SN(1) & "^FS
^BY2,3,41^FT" & 31 + x & "," & 209 + y & "^BCN,,N,N
^FD>:" & SN(2) & "^FS
^FT" & 24 + x & "," & 165 + y & "^A0N,29,28^FH\^FDMAC:^FS
^FT" & 86 + x & "," & 165 + y & "^A0N,29,28^FH\^FD" & SN(3) & "^FS
^PQ1,0,1,Y^XZ"
                COM3.Open()
                COM3.Write(StrToPrint) 'ответ в COM порт
                COM3.Close()

            Case 1 '"Этикетка 44х21_Rus"
                StrToPrint = $"
^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH{x},{y}^JMA^JUS^LRN^CI0^XZ
^XA
^MMT
^PW520
^LL0260
^LS0
^FO224,32^GFA,00256,00256,00008,:Z64:
eJxjYBhpIH1e5QEEDQAmOAR9:0B52
^FO0,32^GFA,00512,00512,00008,:Z64:
eJydkbENgzAURL/lgpI2nRkkUlZigpDRGIURXLqwfPjfvyZlQvMk4B2+w+z/axN3sQVSD+YRXBBc8SELTvKFizxQSYABCWBABkboQOhgQJk8qYMBx2SlzoDk7NQZsIir7he957p7rnuOY+ZSn9+hjp91k27S+XzotF2nb2pT1e6KtmyV1NLUegYMrdW1XtOaVevGilmrJq1sWt3e4lN8fP3DG8uUuZ8=:8613
^FO0,0^GFA,00768,00768,00008,:Z64:
eJzVkTEOwjAQBB1RhI6WAikfQfAz8NP8FD/BZQori289T6AANyNZ2fHdJqV/P2d4gw/4hsrGomKeVM1VzbxoNzd186ljxqUZlwXLYHFcFqyDzXFZsA12x2XBiFtg5nkfgvguBJELQXhCEN4QxDsW6JuCg8k6k+5M3tiksllh08zmNHHQTKepneYaTVaaLTSdaZ4/8IJ3eE2/cz5dk68G:DF61
^FO64,0^GFA,01536,01536,00024,:Z64:
eJzt0U9qg0AUBvBPBnybh90KleQKI90ICXiVQC8gdFuqQaib4JlGusg1DEK7CcXuXEjT0dHEgsuuit/q8YP3hxlgyZJfKUVyrcOWSW3n3FuXF1PXdHO4WzcSMx6cIYf+5m7ikqfeUL2yWqkHRFNPW6pj7Xpg2blpbdeZQ7LaHzpQjIiMn+9fiWShHbC0756Nf25ysv2i6FwkDPUy+EMueg97F8mw9733i3YFAhMs4x9PuXB8JQ6yhA12Rq8ec+Led3DA3tUr46zdA7ujn94y25Odl3DBAcToaR7Ir4z9CoF262juPKX7Jm7jFYdpov8lbL5vzxh5mM1f+ZJ/mh/tx2BG:E4F6
^FO64,64^GFA,01792,01792,00028,:Z64:
eJzt0L1qwzAQB/AzhnhR7fUGU72CSoaqEOxXMXToqpKlQyAuXUOfpY+gIGgW02dQyNClgzvVg3F7lkOwDaFTO/m/HT993B3AlH9MYAdl0i94ObC0f1QOn5H9o2pk/dqOTPQKDWvPcl0hRrlfgpQcVtGGCdFZUHJTI6bar+ne+rFJi1jQ256GZSjRhIjK+iHZ3uSKLUTZGUPUZJnyZ9SLPkB2sts4dmYV3bvZ63ewbHXVs4RM+AzSrb4j+5i/dMZr3Da8IqtAes6KuXB2iEGaZ3cvPNpFcS3c7IZs1/03a43+izbJycTYqNF2n55hnamsNbA039EWy6cIlblElG52uDevD2/M7ZV/fe8+rWkQed7uDFKo+XGfEFCr5/IXNmXKlN/zA+8aeaQ=:5CFD
^FO64,32^GFA,02304,02304,00036,:Z64:
eJzt0TFqwzAUBuBnBO5i1FUlwmeQ6RAX2voqMl47CLJ0KCRgcK6QoYfI1lXG4C7Fc8eGQLp61BDqWpHtFJwmkC3gf5P43vsRAhgy5GIi5cFr+zougftHDb7LFHwdN48so+iEsWHtAH9pTckYEOLaXkJc61tJ1hrGnxqTbZkA4k+T2kzjNyWFMRkVe+P4AqgfahMmbXdtfOAbY6oc70ya1yYtOmPFCnje7Mnt+xLcZ6mN/OgMQvSQmSttfozByIGw6szDEtzPbo+ZtSnCf814CaOeIdrEM2Pe8c6stFkVnWF1V9Sa7HXsydFiot8+mTNZiMZQEVmNSdWtJ28WwVW1IQEq5daYYK14ZPU+ip84n2t6Rf/MDRky5BLyC4Rvh1g=:069C
^FO288,64^GFA,01536,01536,00024,:Z64:
eJzt0TEKwjAUgOEnDm/ru4BtPIaD4o2k4NKhaMXBSXsD7+BWqEPAIZtewEK7S404mKFQY+oiKjo5SP/hDV8SQghA3a9rmNl+cjQzfXIyhz66Y5F0x9Mp7x8xoHEBl6XZYTHLVcPZJjBeFlBWTszx1FmIt06IQJMUlGMcWaujMiGAMATS98q7x+tekuVHoObiG2/GkZ3wPNe+ffBVZM/5YaBt/+AnxUJejLQVlTNmXn6SFAa+T5Qq0mtSsvK1U+WpJAy8LuHNQTvuvv6zurp/7ArRcHEe:E769
^FO320,0^GFA,01920,01920,00020,:Z64:
eJzt0zEOgzAMBVBHDBl9hBwlF6sUjobERTgCYweU1A4d4o8rdelUvCCekOXEH6K7/rLiThQOIq6pre20LMZgTSxbm9SatSgWwFhs6rYkXrduSSyCZTEGK2IJTF+Tth7tPd5gockjP8EW6bkbm9ostoFpz8Va/WSzsdhNPxzs8C2cpnf1M6O+BZzPzuydwz2v9ipo1/vz7tnbx7m3aq1U3e98yQFmIzsZ8nLFQyZ5yCmB9TwXa33ABKb/RwTT/4ge1u6668t6AUhNC3U=:1413
^FO241,56^GB25,0,2^FS
^FO0,209^GB481,0,4^FS
^FO0,102^GB481,0,4^FS
^FO67,23^GB0,75,10^FS
^BY2,3,23^FT0,156^BCN,,N,N
^FD>:{Mid(SN(1), 1, 2)}>5{Mid(SN(1), 3)}^FS
^FT0,128^A0N,21,21^FH\^FDS/N:^FS
^FT44,128^A0N,21,21^FH\^FD{SN(1)}^FS
^BY2,3,23^FT0,202^BCN,,N,N
^FD>:{SN(2)}^FS
^FT0,177^A0N,21,21^FH\^FDMAC:^FS
^FT51,177^A0N,21,21^FH\^FD{SN(3)}^FS
^PQ1,0,1,Y^XZ
"
                COM3.Open()
                COM3.Write(StrToPrint) 'ответ в COM порт
                COM3.Close()
        End Select
    End Sub

    '^FO{0 + x},{32 + y}^GFA,06144,06144,00064,:Z64:
    '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:E061
    '^FO{11 + x},{229 + y}^GB490,0,4^FS
    '^FO{11 + x},{121 + y}^GB490,0,4^FS
    '^BY2,3,23^FT{18 + x},{176 + y}^BCN,,N,N
    '^FD>:{Mid(SN(1), 1, 2)}>5{Mid(SN(1), 3)}^FS
    '^FT{17 + x},{148 + y}^A0N,21,21^FH\^FDS/N:^FS
    '^FT{63 + x},{148 + y}^A0N,21,21^FH\^{SN(1)}^FS
    '^BY2,3,23^FT{17 + x},{222 + y}^BCN,,N,N
    '^FD>:{SN(2)}^FS
    '^FT{17 + x},{197 + y}^A0N,21,21^FH\^FDMAC:^FS
    '^FT{71 + x},{197 + y}^A0N,21,21^FH\^FD{SN(3)}^FS
    '^PQ1,0,1,Y^XZ




End Module
