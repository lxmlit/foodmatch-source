Imports Foodmatch.IBS

Namespace UC
    Public Class UCController
        Inherits FormUC

        'scans the keyword for inputs'
        Function ContainsKeyword(input As String, keyword As String) As Boolean
            Return input.ToLower().Contains(keyword.ToLower())
        End Function

        'event if button is clicked, this event will fire'
        Private Sub ucMatchBtn_Click(sender As Object, e As EventArgs) Handles ucMatchBtn.Click
            Dim ucTextBoxLower = ucTextBox.Text.ToLower()
            Dim UCDataInstance As New UCModel

            'logic for displaying texts based on inputs in the textbox'
            If UCDataInstance.redMeatProcessedList.Contains(ucTextBoxLower) Then
                ucResultsLbl.Text = "RISKY. The IOIBD (Inquiry into Bowel Inflammation Diseases)
hints at those battling with colitis of the ulcerative
kind to diminish their intake of meat both red and 
processed for the prevention of exacerbating symptoms,
as these can set off issues in individuals living with
ulcerative colitis because they present challenges
during digestion and may agitate the bowel walls,
leading to swelling and an increase in distressing signals
like hurt and loose stools (MedicalNewsToday, 2023)."

            ElseIf UCDataInstance.peasBeansLentilsList.Contains(ucTextBoxLower) OrElse ContainsKeyword(ucTextBoxLower, "bean") Then
                ucResultsLbl.Text = "RISKY. Food containing peas, beans and lentils are rich in protein and fiber
(fiber-rich foods are risky for UC patients). Because of their indigestible sugars,
they are known to produce gas and cause bloating (Vandever & Rush, 2023). "

            ElseIf UCDataInstance.spicyFoodsList.Contains(ucTextBoxLower) Then
                ucResultsLbl.Text = "RISKY. Certain edibles, including fiery sauces, chilies,
plus burning peppers could amplify the suffering signs linked
to ulcerative colitis—a variation on intestinal malady.
As ulcerative colitis flares soar, symptoms intensify along
with a heightening in ache or unease. Consuming zesty eatables
amidst such flare-ups might worsen sufferings (MedicalNewsToday, 2023)."

            ElseIf UCDataInstance.sweetsList.Contains(ucTextBoxLower) Then
                ucResultsLbl.Text = "RISKY. May trigger ulcerative colitis flare-up
(MedicalNewsToday, 2023)."

            ElseIf UCDataInstance.boozeList.Contains(ucTextBoxLower) Then
                ucResultsLbl.Text = "RISKY. Might exacerbate symptoms of ulcerative colitis
(Healthline, 2023). "

            ElseIf UCDataInstance.nutsList.Contains(ucTextBoxLower) OrElse ContainsKeyword(ucTextBoxLower, "nut") Then
                If ContainsKeyword(ucTextBoxLower, "walnut") Then
                    ucResultsLbl.Text = "SAFE"
                Else
                    ucResultsLbl.Text = "RISKY. Whole nuts may aggravate ulcerative colitis symptoms.
They could be difficult to digest because of their high sulfur content
(Healthline, 2023)."
                End If

            ElseIf ContainsKeyword(ucTextBoxLower, "fried") OrElse ContainsKeyword(ucTextBoxLower, "fries") Then
                If ContainsKeyword(ucTextBoxLower, "air-fried") OrElse ContainsKeyword(ucTextBoxLower, "air fried") OrElse ContainsKeyword(ucTextBoxLower, "oven fried") OrElse ContainsKeyword(ucTextBoxLower, "oven-fried") OrElse
                   ContainsKeyword(ucTextBoxLower, "air-fry") OrElse ContainsKeyword(ucTextBoxLower, "air-fried") OrElse ContainsKeyword(ucTextBoxLower, "air fried") OrElse ContainsKeyword(ucTextBoxLower, "air fry") OrElse
                    ContainsKeyword(ucTextBoxLower, "oven-fry") OrElse ContainsKeyword(ucTextBoxLower, "oven-fried") Then
                    ucResultsLbl.Text = "SAFE"
                Else
                    ucResultsLbl.Text = "RISKY. The main concern for fried foods are its greasiness and oiliness.
Oils used for frying fried foods often contain lots of trans fats which promote gut
inflammation. It’s best to opt for air-fried or oven-fried foods instead
(Taylor, 2023)."
                End If

            ElseIf UCDataInstance.nsaidsDrugList.Contains(ucTextBoxLower) Then
                ucResultsLbl.Text = "RISKY. Although NSAIDs are known to ease
inflammation and pain, it also causes the digestive
system to lose 'some of its normal protective
substances'. Instead, NSAIDs can cause
inflammation and worsen intestinal (small intestine)
bleeding (Tresca, 2022). Studies posted at the National
Center for Biotechnology Information in 1996 and 2010
also suggest the risk of taking NSAIDs for somebody
with ulcerative colitis, or at risk for ulcerative
colitis. NSAIDs have the potential to cause mucosal
injury leading to 'increased intestinal permeability'.
Before taking NSAIDs, first consult your doctor. "

            ElseIf ContainsKeyword(ucTextBoxLower, "corn") Then
                ucResultsLbl.Text = "RISKY. The thick skins of the corn and popcorn kernels are
not easy to digest. For many UC (ulcerative colitis) patients,
popcorns and corns cause cramps and discomfort. Additionally,
popcorns and corns are high in fiber, which can worsen UC symptoms
(Nutrition4IBD, 2019)."

            ElseIf ContainsKeyword(ucTextBoxLower, "chocolate") OrElse ContainsKeyword(ucTextBoxLower, "coffee") OrElse ContainsKeyword(ucTextBoxLower, "energy drink") Then
                ucResultsLbl.Text = "RISKY. Food contains caffeine. Caffeine stimulates bowel movement,
speeding up the process of digestion. Because of this, frequent trips to the
bathroom/toilet may happen. Although much research is yet to be done,
the Crohn’s and Colitis Foundation lists caffeine as potential UC flare triggers
(Knudsen, 2022). "

            ElseIf UCDataInstance.carbonatedProdList.Contains(ucTextBoxLower) Then
                ucResultsLbl.Text = "RISKY. Frequent intake of carbonated beverages lead to a higher risk
of inflicting ulcerative colitis (Almofarreh et al., 2022). Additionally,
carbonated beverages often produce gas (MayoClinic, 2023)
which is disadvantageous for UC patients. "

            ElseIf UCDataInstance.wholeGrainFoodList.Contains(ucTextBoxLower) Then
                ucResultsLbl.Text = "RISKY. Whole grain foods are high in fiber,
making it hard for UC patients to digest especially at times of flare-up
(Vandever & Rush, 2023). "

            ElseIf UCDataInstance.driedFruitsList.Contains(ucTextBoxLower) OrElse ContainsKeyword(ucTextBoxLower, "dried") Then
                ucResultsLbl.Text = "RISKY. Dried fruits are high in fiber,
which is not very beneficial for UC patients (Vandever & Rush, 2023). "

            ElseIf ucDataInstance.seedAndGrainList.Contains(ucTextBoxLower) OrElse ContainsKeyword(ucTextBoxLower, "seed") Then
                ucResultsLbl.Text = "RISKY. Seeds contain insoluble fiber,
meaning it cannot be dissolved in water (Vandever & Rush, 2023).
This could cause problems in digestion for UC patients. "

            ElseIf String.IsNullOrEmpty(ucTextBoxLower) OrElse String.IsNullOrWhiteSpace(ucTextBoxLower) Then
                ucResultsLbl.Text = "Invalid Input ..."

            Else
                ucResultsLbl.Text = "SAFE"
            End If

        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            symptomsTabLabel.Text = "•	Abdominal bloating, cramps and/or pain
•	Anemia
•	Aphthous/mouth ulcers (canker sores)
•	Chills
•	Chronic fatigue
•	Dehydration
•	Diarrhea
•	Eye pain or inflammation
•	Feeling like you haven’t completely-
  emptied your colon after you use the toilet
•	Frequent fevers
•	Inability to defecate despite urgency
•	Joint pain
•	Liver Diseases
•	Nausea
•	Nutritional deficiencies
•	Rectal Pain and bleeding
•	Skin sores
•	Stool mucous/pus 
•	Stunted growth in children
•	Unexplained weight loss
•	Unhealthy diet and lifestyle
•	Waking up at night to poop
"

            riskFactorsTabLabel.Text = "• Age 15-40 or 60-80 years
• Appendectomy
• Ashkenazi Jewish ancestry
• Bacteria and chemicals from environment
• Certain infections (e.g. salmonella, shigella,
  clostridium difficile infection, campylobacter)
• Difference in gut microbiome
• Family history of ulcerative colitis 
• Psychological stress 
• Residence in northern climates and developed countries
• Smoking cessation
• Unhealthy diet and lifestyle 
• White or Caucasian race 
"

        End Sub



    End Class
End Namespace

