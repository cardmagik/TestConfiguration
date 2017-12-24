<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestConfiguration
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      Try
         If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
         End If
      Finally
         MyBase.Dispose(disposing)
      End Try
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.btnTest1 = New System.Windows.Forms.Button()
      Me.btnExit = New System.Windows.Forms.Button()
      Me.btnTest2 = New System.Windows.Forms.Button()
      Me.btnTest3 = New System.Windows.Forms.Button()
      Me.btnTest4 = New System.Windows.Forms.Button()
      Me.btnTest5 = New System.Windows.Forms.Button()
      Me.btnTest6 = New System.Windows.Forms.Button()
      Me.btnTest7 = New System.Windows.Forms.Button()
      Me.btnTest3B = New System.Windows.Forms.Button()
      Me.btnTest3C = New System.Windows.Forms.Button()
      Me.btnTest3D = New System.Windows.Forms.Button()
      Me.btnTest3E = New System.Windows.Forms.Button()
      Me.btnTest3F = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'btnTest1
      '
      Me.btnTest1.BackColor = System.Drawing.Color.PeachPuff
      Me.btnTest1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnTest1.Location = New System.Drawing.Point(34, 13)
      Me.btnTest1.Name = "btnTest1"
      Me.btnTest1.Size = New System.Drawing.Size(595, 44)
      Me.btnTest1.TabIndex = 0
      Me.btnTest1.Text = "Test 1 Init Config with blank fileTest 1 Init with blank file"
      Me.btnTest1.UseVisualStyleBackColor = False
      '
      'btnExit
      '
      Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnExit.Location = New System.Drawing.Point(896, 406)
      Me.btnExit.Name = "btnExit"
      Me.btnExit.Size = New System.Drawing.Size(114, 52)
      Me.btnExit.TabIndex = 1
      Me.btnExit.Text = "E&xit"
      Me.btnExit.UseVisualStyleBackColor = True
      '
      'btnTest2
      '
      Me.btnTest2.BackColor = System.Drawing.Color.PeachPuff
      Me.btnTest2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnTest2.Location = New System.Drawing.Point(34, 63)
      Me.btnTest2.Name = "btnTest2"
      Me.btnTest2.Size = New System.Drawing.Size(595, 44)
      Me.btnTest2.TabIndex = 2
      Me.btnTest2.Text = "Test 2 Get OnlineOrLocal - should be Test2 - check file"
      Me.btnTest2.UseVisualStyleBackColor = False
      '
      'btnTest3
      '
      Me.btnTest3.BackColor = System.Drawing.Color.PeachPuff
      Me.btnTest3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnTest3.Location = New System.Drawing.Point(34, 113)
      Me.btnTest3.Name = "btnTest3"
      Me.btnTest3.Size = New System.Drawing.Size(595, 44)
      Me.btnTest3.TabIndex = 3
      Me.btnTest3.Text = "Test 3 Set Variable OnlineOrLocal to Test 3 - Check file"
      Me.btnTest3.UseVisualStyleBackColor = False
      '
      'btnTest4
      '
      Me.btnTest4.BackColor = System.Drawing.Color.PeachPuff
      Me.btnTest4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnTest4.Location = New System.Drawing.Point(34, 413)
      Me.btnTest4.Name = "btnTest4"
      Me.btnTest4.Size = New System.Drawing.Size(595, 44)
      Me.btnTest4.TabIndex = 4
      Me.btnTest4.Text = "Test 4 Release Config"
      Me.btnTest4.UseVisualStyleBackColor = False
      '
      'btnTest5
      '
      Me.btnTest5.BackColor = System.Drawing.Color.PeachPuff
      Me.btnTest5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnTest5.Location = New System.Drawing.Point(637, 13)
      Me.btnTest5.Name = "btnTest5"
      Me.btnTest5.Size = New System.Drawing.Size(651, 44)
      Me.btnTest5.TabIndex = 5
      Me.btnTest5.Text = "Test 5 Init Config with Specified File c:\temp\testfile.ini"
      Me.btnTest5.UseVisualStyleBackColor = False
      '
      'btnTest6
      '
      Me.btnTest6.BackColor = System.Drawing.Color.PeachPuff
      Me.btnTest6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnTest6.Location = New System.Drawing.Point(637, 77)
      Me.btnTest6.Name = "btnTest6"
      Me.btnTest6.Size = New System.Drawing.Size(651, 44)
      Me.btnTest6.TabIndex = 6
      Me.btnTest6.Text = "Test 6 Del File - Get OnlineOrLocal - should be Test6 - check new file"
      Me.btnTest6.UseVisualStyleBackColor = False
      '
      'btnTest7
      '
      Me.btnTest7.BackColor = System.Drawing.Color.PeachPuff
      Me.btnTest7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnTest7.Location = New System.Drawing.Point(637, 153)
      Me.btnTest7.Name = "btnTest7"
      Me.btnTest7.Size = New System.Drawing.Size(651, 44)
      Me.btnTest7.TabIndex = 7
      Me.btnTest7.Text = "Test 7 Set OnlineOrLocal to Test7 - check file c:\temp\testfile.ini"
      Me.btnTest7.UseVisualStyleBackColor = False
      '
      'btnTest3B
      '
      Me.btnTest3B.BackColor = System.Drawing.Color.PeachPuff
      Me.btnTest3B.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnTest3B.Location = New System.Drawing.Point(34, 163)
      Me.btnTest3B.Name = "btnTest3B"
      Me.btnTest3B.Size = New System.Drawing.Size(595, 44)
      Me.btnTest3B.TabIndex = 8
      Me.btnTest3B.Text = "Test 3B Get OnlineOrLocal - should be Test3"
      Me.btnTest3B.UseVisualStyleBackColor = False
      '
      'btnTest3C
      '
      Me.btnTest3C.BackColor = System.Drawing.Color.PeachPuff
      Me.btnTest3C.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnTest3C.Location = New System.Drawing.Point(34, 213)
      Me.btnTest3C.Name = "btnTest3C"
      Me.btnTest3C.Size = New System.Drawing.Size(595, 44)
      Me.btnTest3C.TabIndex = 9
      Me.btnTest3C.Text = "Test 3C Add new variable NextVar with a value of Test3C"
      Me.btnTest3C.UseVisualStyleBackColor = False
      '
      'btnTest3D
      '
      Me.btnTest3D.BackColor = System.Drawing.Color.PeachPuff
      Me.btnTest3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnTest3D.Location = New System.Drawing.Point(34, 263)
      Me.btnTest3D.Name = "btnTest3D"
      Me.btnTest3D.Size = New System.Drawing.Size(595, 44)
      Me.btnTest3D.TabIndex = 10
      Me.btnTest3D.Text = "Test 3D - Add variable AnotherVar with a value of Test3D"
      Me.btnTest3D.UseVisualStyleBackColor = False
      '
      'btnTest3E
      '
      Me.btnTest3E.BackColor = System.Drawing.Color.PeachPuff
      Me.btnTest3E.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnTest3E.Location = New System.Drawing.Point(34, 313)
      Me.btnTest3E.Name = "btnTest3E"
      Me.btnTest3E.Size = New System.Drawing.Size(595, 44)
      Me.btnTest3E.TabIndex = 11
      Me.btnTest3E.Text = "Test 3E - Get Variables OnlineOrLocal, NextVar, AnotherVar"
      Me.btnTest3E.UseVisualStyleBackColor = False
      '
      'btnTest3F
      '
      Me.btnTest3F.BackColor = System.Drawing.Color.PeachPuff
      Me.btnTest3F.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnTest3F.Location = New System.Drawing.Point(34, 363)
      Me.btnTest3F.Name = "btnTest3F"
      Me.btnTest3F.Size = New System.Drawing.Size(595, 44)
      Me.btnTest3F.TabIndex = 12
      Me.btnTest3F.Text = "Test 3F - Case test"
      Me.btnTest3F.UseVisualStyleBackColor = False
      '
      'frmTestConfiguration
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1300, 495)
      Me.Controls.Add(Me.btnTest3F)
      Me.Controls.Add(Me.btnTest3E)
      Me.Controls.Add(Me.btnTest3D)
      Me.Controls.Add(Me.btnTest3C)
      Me.Controls.Add(Me.btnTest3B)
      Me.Controls.Add(Me.btnTest7)
      Me.Controls.Add(Me.btnTest6)
      Me.Controls.Add(Me.btnTest5)
      Me.Controls.Add(Me.btnTest4)
      Me.Controls.Add(Me.btnTest3)
      Me.Controls.Add(Me.btnTest2)
      Me.Controls.Add(Me.btnExit)
      Me.Controls.Add(Me.btnTest1)
      Me.Name = "frmTestConfiguration"
      Me.Text = "Test Configuration Class"
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents btnTest1 As System.Windows.Forms.Button
   Friend WithEvents btnExit As System.Windows.Forms.Button
   Friend WithEvents btnTest2 As System.Windows.Forms.Button
   Friend WithEvents btnTest3 As System.Windows.Forms.Button
   Friend WithEvents btnTest4 As System.Windows.Forms.Button
   Friend WithEvents btnTest5 As System.Windows.Forms.Button
   Friend WithEvents btnTest6 As System.Windows.Forms.Button
   Friend WithEvents btnTest7 As System.Windows.Forms.Button
   Friend WithEvents btnTest3B As System.Windows.Forms.Button
   Friend WithEvents btnTest3C As System.Windows.Forms.Button
   Friend WithEvents btnTest3D As System.Windows.Forms.Button
   Friend WithEvents btnTest3E As System.Windows.Forms.Button
   Friend WithEvents btnTest3F As System.Windows.Forms.Button

End Class
