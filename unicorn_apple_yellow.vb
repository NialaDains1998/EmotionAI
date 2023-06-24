Public Class EmotionalIntelligence
   Dim emoLevel As Integer
   Dim emoFocus As String
   
   Public Sub RecordEmotionLevel(input As Integer)
       'This method records the emotional level of the user
       emoLevel = input 
   End Sub
   
   Public Sub RecordEmotionalFocus(focus As String)
       'This method records the current emotional focus of the user
       emoFocus = focus 
   End Sub
   
   Public Sub ReassessProgress()
       'This method allows the user to reassess their emotional progress
       If emoLevel <= 5
           Console.Writeline("You seem to be struggling with emotions right now. Let's find ways to help you.")
       End If
       If emoLevel > 5
           Console.Writeline("You seem to be doing better with your emotions. Is there anything you want to focus on?")
       End If
   End Sub
   
   Public Sub ProvideHelp()
       'This method provides help to the user
       If emoFocus = ""
           Console.Writeline("Let's explore a few options that may help with your emotions.") 
           Console.Writeline("1. Relaxation and mindfulness exercises")
           Console.Writeline("2. Talking to a friend or family member")
           Console.Writeline("3. Journaling or reflective writing")
           Console.Writeline("4. Professional therapy")
       ElseIf emoFocus = "anxiety"
           Console.Writeline("There are many strategies for managing anxiety. Let's explore a few options.")
           Console.Writeline("1. Identifying triggers and avoiding them when possible")
           Console.Writeline("2. Mindful breathing and relaxation techniques")
           Console.Writeline("3. Cognitive restructuring and understanding cognitive distortions")
           Console.Writeline("4. Cognitive-behavioral therapy")
       ElseIf emoFocus = "depression"
           Console.Writeline("Depression can be difficult to manage, but there are ways to improve your emotional wellbeing. Let's explore a few options.")
           Console.Writeline("1. Exercise and physical activity")
           Console.Writeline("2. Self-care activities and hobbies")
           Console.Writeline("3. Talking to a friend or family member")
           Console.Writeline("4. Cognitive-behavioral therapy or medication")
       End If
   End Sub
   
   Public Sub FollowUp()
       'This method follows up with the user to check their progress
       Console.Writeline("How are you feeling now? Have any of these strategies been helpful?")
   End Sub
   
End Class