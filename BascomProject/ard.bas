$regfile = "m328pdef.dat"
$crystal = 16000000
$baud = 9600

Config PORTD.0 = Output
PORTD.0 = 0
Config PORTD.2 = Output
PORTD.2 = 0

Config Lcdpin = Pin, Db4 = PORTD.4, Db5 = PORTD.5, Db6 = PORTD.6, Db7 = PORTD.7, E = PORTb.3, Rs = PORTB.4
Config lcd = 16*2
Cursor Off Noblink
Config ADC = Single, Prescaler = Auto, Reference = Avcc

Open "comb.0:9600,8,n,1" For Input As #1
Open "comb.1:9600,8,n,1" For Output As #2

Dim A As String * 1
Dim B As Byte
Dim WL as Long
Dim Prev_WL as Long
Dim TH as Long
Dim TL as Long
Dim Temp as Long
Dim Prev_Temp as Long
WL = 100
Prev_WL = WL
Temp = 100
Prev_temp = Temp

waitms 2000

Do
   WL = Getadc(0)
   WL = WL * 100
   WL = WL / 1024
   Print #2, WL; "%"
   Upperline

   If WL < 10 Then
      PORTD.0 = 1
      PORTD.2 = 1
   Else
      PORTD.0 = 0
      PORTD.2 = 0
   End If

   If WL >= 98 Then
      Lcd "Level:";Chr(255);Chr(255);Chr(255);Chr(255);Chr(255);Chr(255);Chr(255);Chr(255);Chr(255);Chr(255)
   Else
      If WL >= 90 AND WL < 98 Then
         Lcd "Level:";Chr(255);Chr(255);Chr(255);Chr(255);Chr(255);Chr(255);Chr(255);Chr(255);Chr(255);" "
      Else
         If WL >= 80 AND WL < 90 Then
            Lcd "Level:";Chr(255);Chr(255);Chr(255);Chr(255);Chr(255);Chr(255);Chr(255);Chr(255);"  "
         Else
            If WL >= 70 AND WL < 80 Then
               Lcd "Level:";Chr(255);Chr(255);Chr(255);Chr(255);Chr(255);Chr(255);Chr(255);"   "
            Else
               If WL >= 60 AND WL < 70 Then
                  Lcd "Level:";Chr(255);Chr(255);Chr(255);Chr(255);Chr(255);Chr(255);"    "
               Else
                  If WL >= 50 AND WL < 60 Then
                     Lcd "Level:";Chr(255);Chr(255);Chr(255);Chr(255);Chr(255);"     "
                  Else
                     If WL >= 40 AND WL < 50 Then
                        Lcd "Level:";Chr(255);Chr(255);Chr(255);Chr(255);"      "
                     Else
                        If WL >= 30 AND WL < 40 Then
                           Lcd "Level:";Chr(255);Chr(255);Chr(255);"       "
                        Else
                           If WL >= 20 AND WL < 30 Then
                              Lcd "Level:";Chr(255);Chr(255);"        "
                           Else
                              If WL >= 10 AND WL < 20 Then
                                 Lcd "Level:";Chr(255);"         "
                              Else
                                 If WL < 10 Then
                                    Lcd "Level:          "
                                    waitms 200
                                    Upperline
                                    Lcd "Level:";Chr(255);"         "
                                    waitms 200
                                    If Prev_WL > WL Then
                                       Print #2, "Level is "; WL; "%"; "Pacient need help!"
                                    End if
                                 End If
                              End If
                           End If
                        End If
                     End If
                  End If
               End If
            End If
         End If
      End If
   End If
   Prev_WL = WL

   TH = Getadc(1)
   TH = TH / 2
   TL = TH / 20
   Temp = TH - TL
   If Temp > 57 Then
      Temp = Temp + 2
   Else
      If Temp > 38 Then
         Temp = Temp + 1
      End If
   End If
   If Temp < Prev_Temp OR Temp > Prev_Temp Then
      Lowerline
      Lcd "Temp. is: "; Temp; "c  "
      Prev_Temp = Temp
      Print #2, "Temp. is "; Temp; "c"
   End if
Loop