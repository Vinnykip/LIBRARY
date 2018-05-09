Module modFancyClose

	Friend OK_to_CloseNow As Boolean = False
	Friend Const FADE_RATE As Decimal = CDec(0.03)
	Friend Enum FancyType As UShort
		FADE			 ' Fade out
		SHRINK_UP	 ' Shrink up
		SHRINK_DN	 ' Shrink down
		SHRINK_LT	 ' Shrink left
		SHRINK_RT	 ' Shrink right
		RUN_RT		 ' Run off the screen to the right
		RUN_LT		 ' Run off the screen to the left
		RUN_UP		 ' Run off the screen to the top
		Run_DN		 ' Run off the screen to the bottom
	End Enum
	Friend iPrevWidth As Integer = 0
	Friend iPrevHeight As Integer = 0
	Friend iSkipUpAmt As Integer	 ' How far each of the skips are when running.
	Friend iSkipDownAmt As Integer	 ' How far each of the skips are when running.
	Friend iSkipLeftAmt As Integer	 ' How far each of the skips are when running.
	Friend iSkipRightAmt As Integer	 ' How far each of the skips are when running.
	Friend iWhichClose As UShort

	'Declare API for timing (replaces timer controls)
	Declare Function GetTickCount Lib "kernel32.dll" () As Integer

	Public glProgramUpTime As Integer

	Friend Sub SelectClose(ByVal frmWhich As Form)
		iWhichClose = CUShort(Int(Rnd() * 9))
		'Debug.Print("Direction " & iWhichClose)
		iSkipDownAmt = CInt((Screen.PrimaryScreen.Bounds.Height - frmWhich.Top) / 20)
		iSkipLeftAmt = CInt((frmWhich.Left + frmWhich.Width) / 20)
		iSkipRightAmt = CInt((Screen.PrimaryScreen.Bounds.Width - frmWhich.Left) / 20)
		iSkipUpAmt = CInt((frmWhich.Top + frmWhich.Height) / 20)
		'Debug.Print("Top: " & Me.Top & ", Left: " & Me.Left & ", Up: " & iSkipUpAmt & ", Down: " & iSkipDownAmt & ", Left: " & iSkipLeftAmt & ", Right: " & iSkipRightAmt)
	End Sub

	Friend Sub FancyCLoseTick(ByVal frmWhich As Form)
		Select Case iWhichClose
            Case FancyType.FADE
                DoFade(frmWhich)
            Case FancyType.SHRINK_UP
                DoShrinkUp(frmWhich)
            Case FancyType.SHRINK_DN
                DoShrinkDown(frmWhich)
            Case FancyType.SHRINK_LT
                DoShrinkLeft(frmWhich)
            Case FancyType.SHRINK_RT
                DoShrinkRight(frmWhich)
            Case FancyType.Run_DN
                DoRunDown(frmWhich)
            Case FancyType.RUN_LT
                DoRunLeft(frmWhich)
            Case FancyType.RUN_RT
                DoRunRight(frmWhich)
            Case FancyType.RUN_UP
                DoRunUp(frmWhich)
        End Select

		iPrevWidth = frmWhich.Width
		iPrevHeight = frmWhich.Height

	End Sub

	Friend Sub DoRunDown(ByVal frmWhich As Form)

		frmWhich.Top += iSkipDownAmt
		If frmWhich.Top > Screen.PrimaryScreen.Bounds.Height Then
			OK_to_CloseNow = True
			frmWhich.Close()
			OK_to_CloseNow = False
		End If

	End Sub

	Friend Sub DoRunLeft(ByVal frmWhich As Form)

		frmWhich.Left -= iSkipLeftAmt
		If frmWhich.Left + frmWhich.Width < 0 Then
			OK_to_CloseNow = True
			frmWhich.Close()
			OK_to_CloseNow = False
		End If

	End Sub

	Friend Sub DoRunRight(ByVal frmWhich As Form)

		frmWhich.Left += iSkipRightAmt
		If frmWhich.Left > Screen.PrimaryScreen.Bounds.Width Then
			OK_to_CloseNow = True
			frmWhich.Close()
			OK_to_CloseNow = False
		End If

	End Sub

	Friend Sub DoRunUp(ByVal frmWhich As Form)

		frmWhich.Top -= iSkipUpAmt
		If frmWhich.Top + frmWhich.Height < 0 Then
			OK_to_CloseNow = True
			frmWhich.Close()
			OK_to_CloseNow = False
		End If

	End Sub

	Friend Sub DoShrinkRight(ByVal frmWhich As Form)

		frmWhich.Width -= 15
		frmWhich.Left += 15
		If frmWhich.Width = iPrevWidth Then
			iWhichClose = FancyType.SHRINK_DN
			DoShrinkDown(frmWhich)
		End If

	End Sub

	Friend Sub DoShrinkLeft(ByVal frmWhich As Form)

		frmWhich.Width -= 15
		If frmWhich.Width = iPrevWidth Then
			iWhichClose = FancyType.SHRINK_UP
			DoShrinkUp(frmWhich)
		End If

	End Sub

	Friend Sub DoShrinkDown(ByVal frmWhich As Form)

		frmWhich.Height -= 15
		frmWhich.Top += 15
		If frmWhich.Height = iPrevHeight Then
			OK_to_CloseNow = True
			frmWhich.Close()
			OK_to_CloseNow = False
		End If

	End Sub

	Friend Sub DoFade(ByVal frmWhich As Form)

		frmWhich.Opacity -= FADE_RATE
		Application.DoEvents()
		If frmWhich.Opacity < 2 * FADE_RATE Then
			OK_to_CloseNow = True
			frmWhich.Close()
			OK_to_CloseNow = False
		End If

	End Sub

	Friend Sub DoShrinkUp(ByVal frmWhich As Form)

		frmWhich.Height -= 15
		If frmWhich.Height = iPrevHeight Then
			OK_to_CloseNow = True
			frmWhich.Close()
			OK_to_CloseNow = False
		End If

	End Sub

End Module
