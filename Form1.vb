Imports System.IO

Public Class frmTestConfiguration

   Dim Settings As Configuration

   Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click

      Settings = Nothing

      Environment.Exit(0)

   End Sub

   Private Sub btnTest1_Click(sender As Object, e As EventArgs) Handles btnTest1.Click

      Dim WorkingFileName As String

      Settings = New Configuration

      WorkingFileName = Settings.GetINIFileName()
      Debug.Assert(WorkingFileName = "", "Assertion Error in Test 1 - File Name was not blank - had value of " & WorkingFileName)

      btnTest2.Enabled = True
      btnTest3.Enabled = True
      btnTest3B.Enabled = True
      btnTest3C.Enabled = True
      btnTest3D.Enabled = True
      btnTest3E.Enabled = True
      btnTest3F.Enabled = True
      btnTest4.Enabled = True

      btnTest1.Text = btnTest1.Text & " - Pass"
   End Sub

   Private Sub btnTest2_Click(sender As Object, e As EventArgs) Handles btnTest2.Click

      Dim Test2Value As String
      Const DefaultFileName As String = "C:\Users\CardMagik\Documents\GenericVBCode\TestConfiguration\bin\Debug\TestConfiguration.ini"
      Dim SetFilename As String

      Try
         File.Delete(DefaultFileName)

      Catch ex As Exception
         MsgBox("Error during delete of file in test2")
      End Try


      Test2Value = Settings.GetValue("OnlineOrLocal", "Test2")
      Debug.Assert(Test2Value = "Test2", "Assertion Error Test 2 - value returned was not Test2 - it was " & Test2Value)

      SetFilename = Settings.GetINIFileName

      Debug.Assert(SetFilename = DefaultFileName, "Assertion Error - Test 2 - Incorrect File name returned " & SetFilename & " expected " & DefaultFileName)

      btnTest2.Text = btnTest2.Text & " - Pass"

   End Sub

   Private Sub frmTestConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      btnTest2.Enabled = False
      btnTest3.Enabled = False
      btnTest3B.Enabled = False
      btnTest3C.Enabled = False
      btnTest3D.Enabled = False
      btnTest3E.Enabled = False
      btnTest3F.Enabled = False
      btnTest4.Enabled = False
      btnTest5.Enabled = False
      btnTest6.Enabled = False
      btnTest7.Enabled = False
   End Sub

   Private Sub btnTest3_Click(sender As Object, e As EventArgs) Handles btnTest3.Click
      Settings.SetValue("OnlineOrLocal", "Test3")


      btnTest3.Text = btnTest3.Text & " - Done"
   End Sub

   Private Sub btnTest3B_Click(sender As Object, e As EventArgs) Handles btnTest3B.Click
      Dim CurrentValue As String
      CurrentValue = Settings.GetValue("OnlineOrLocal", "")

      Debug.Assert(CurrentValue = "Test3", "Assertion Error - Test3B - assume to get value of Test3 and got " & CurrentValue)

      btnTest3B.Text = btnTest3B.Text & " - Pass"
   End Sub

   Private Sub btnTest3C_Click(sender As Object, e As EventArgs) Handles btnTest3C.Click
      Settings.SetValue("NextVar", "Test3C")
      btnTest3C.Text = btnTest3C.Text & " - Done"
   End Sub

   Private Sub btnTest3D_Click(sender As Object, e As EventArgs) Handles btnTest3D.Click

      Settings.SetValue("AnotherVar", "Test3D")
      btnTest3D.Text = btnTest3D.Text & " - Done"
   End Sub

   Private Sub btnTest3F_Click(sender As Object, e As EventArgs) Handles btnTest3F.Click

      Dim OnlineOrLocal As String
      Dim NextVar As String
      Dim AnotherVar As String

      OnlineOrLocal = Settings.GetValue("ONLINEORLOCAL", "")
      Debug.Assert(OnlineOrLocal = "Test3", "Assertion Error Test 3F - value returned for ONLINEORLOCAL was not Test3- it was " & OnlineOrLocal)

      NextVar = Settings.GetValue("NEXTVAR", "")
      Debug.Assert(NextVar = "Test3C", "Assertion Error Test 3F - value returned for NEXTVAR was not Test3C- it was " & NextVar)

      AnotherVar = Settings.GetValue("ANOTHERVAR", "")
      Debug.Assert(AnotherVar = "Test3D", "Assertion Error Test 3F - value returned for ANOTHERVAR was not Test3D- it was " & AnotherVar)

      btnTest3F.Text = btnTest3F.Text & " - Pass"

   End Sub

   Private Sub btnTest3E_Click(sender As Object, e As EventArgs) Handles btnTest3E.Click

      Dim OnlineOrLocal As String
      Dim NextVar As String
      Dim AnotherVar As String

      OnlineOrLocal = Settings.GetValue("OnlineOrLocal", "")
      Debug.Assert(OnlineOrLocal = "Test3", "Assertion Error Test 3E - value returned for OnlineOrLocal was not Test3- it was " & OnlineOrLocal)

      NextVar = Settings.GetValue("NextVar", "")
      Debug.Assert(NextVar = "Test3C", "Assertion Error Test 3E - value returned for NextVar was not Test3C- it was " & NextVar)

      AnotherVar = Settings.GetValue("AnotherVar", "")
      Debug.Assert(AnotherVar = "Test3D", "Assertion Error Test 3E - value returned for AnotherVar was not Test3D - it was " & AnotherVar)

      btnTest3E.Text = btnTest3E.Text & " - Pass"

   End Sub

   Private Sub btnTest4_Click(sender As Object, e As EventArgs) Handles btnTest4.Click
      Settings = Nothing

      btnTest4.Text = btnTest4.Text & " - Done"

      btnTest5.Enabled = True
      btnTest6.Enabled = True
      btnTest7.Enabled = True

   End Sub

   Private Sub btnTest5_Click(sender As Object, e As EventArgs) Handles btnTest5.Click

      Dim WorkingFileName As String

      Settings = New Configuration("c:\temp\testfile.ini")

      WorkingFileName = Settings.GetINIFileName()
      Debug.Assert(WorkingFileName = "c:\temp\testfile.ini", "Assertion Error in Test 5 - Expected File Name c:\temp\testfile.ini - got " & WorkingFileName)

      btnTest6.Enabled = True
      btnTest7.Enabled = True

      btnTest5.Text = btnTest5.Text & " - Pass"

   End Sub

   Private Sub btnTest6_Click(sender As Object, e As EventArgs) Handles btnTest6.Click

      '      Test 6  - get variable OnlineOrLocal with default of Test6 - should not exist and its value should be Test6, not Test3 like from test 3
      'Check file to see if it was written there and also prior file was NOT Touched

      Try
         File.Delete(Settings.GetINIFileName())

      Catch ex As Exception
         MsgBox("Error during delete of file " & Settings.GetINIFileName() & " in test6")
      End Try

      Dim OnlineOrLocal As String
      OnlineOrLocal = Settings.GetValue("OnlineOrLocal", "Test6")
      Debug.Assert(OnlineOrLocal = "Test6", "Assertion Error in Test 6 - value of OnlineOrLocal should be Test6 - instead it's " & OnlineOrLocal)

      btnTest6.Text = btnTest6.Text & " - Pass"
   End Sub

   Private Sub btnTest7_Click(sender As Object, e As EventArgs) Handles btnTest7.Click
      Dim OnlineOrLocal As String

      Settings.SetValue("OnlineOrLocal", "Test7")

      OnlineOrLocal = Settings.GetValue("OnlineOrLocal", "")

      Debug.Assert(OnlineOrLocal = "Test7", "Assertion Error in Test 7 - value of OnlineOrLocal should be Test7 - instead it's " & OnlineOrLocal)

      btnTest7.Text = btnTest7.Text & " - Pass"

   End Sub
End Class
