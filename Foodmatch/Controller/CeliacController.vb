Imports Foodmatch.IBS

Namespace Celiac
    Public Class CeliacController
        Inherits FormCD

        Function ContainsKeyword(input As String, keyword As String) As Boolean
            Return input.ToLower().Contains(keyword.ToLower())
        End Function

        Private Sub celiacMatchBtn_Click(sender As Object, e As EventArgs) Handles celiacMatchBtn.Click
            Dim celiacTextBoxLower = celiacTextBox.Text.ToLower()
            Dim celiacDataInstance As New CeliacModel

            If celiacDataInstance.beerList.Contains(celiacTextBoxLower) OrElse ContainsKeyword(celiacTextBoxLower, "beer") Then
                celiacResultsLbl.Text = "RISKY. Contains high gluten content (WebMD, 2024).."

            ElseIf celiacDataInstance.pastaList.Contains(celiacTextBoxLower) OrElse ContainsKeyword(celiacTextBoxLower, "pasta") Then
                celiacResultsLbl.Text = "RISKY. Pasta is made from wheat that is also high in gluten content,
eating less or much more pasta can make you experience unpleasant
celiac flare up (Harvard Health Publishing, 2023)."

            ElseIf celiacDataInstance.cerealList.Contains(celiacTextBoxLower) OrElse ContainsKeyword(celiacTextBoxLower, "cereal") OrElse ContainsKeyword(celiacTextBoxLower, "oat") Then
                celiacResultsLbl.Text = "RISKY. Cereals that contain gluten may cause celiac symptoms.
Opt for gluten-free cereals. (WebMD, 2023)."

            ElseIf celiacDataInstance.glutenFoodList.Contains(celiacTextBoxLower) OrElse
                ContainsKeyword(celiacTextBoxLower, "wheat") OrElse
                ContainsKeyword(celiacTextBoxLower, "barley") OrElse
                ContainsKeyword(celiacTextBoxLower, "rye") OrElse
                ContainsKeyword(celiacTextBoxLower, "bread") OrElse
                ContainsKeyword(celiacTextBoxLower, "baked") Then

                celiacResultsLbl.Text = "RISKY. eating gluten for a person who has celiac disease can damage
the lining of the small intestine (bowel), which prevents the proper absorption
of food nutrients (Everyday Health, 2023)."

            ElseIf ContainsKeyword(celiacTextBoxLower, "gravy") Then
                celiacResultsLbl.Text = "RISKY. Gravies contain gluten.
Be careful with eating meals with gravy because symptoms of
celiac disease may occur. Unless your gravy is gluten-free,
it poses a risk (WebMD, 2023)."

            ElseIf ContainsKeyword(celiacTextBoxLower, "canned soup") Then
                celiacResultsLbl.Text = "RISKY. Canned soups may contain gluten as one of its (hidden) ingredients.
Please make sure that your canned soup is gluten-free or do not contain gluten in its
ingredients before consumption (Restivo, 2023)."

            ElseIf celiacDataInstance.beansList.Contains(celiacTextBoxLower) Then
                celiacResultsLbl.Text = "RISKY. eating beans that has gluten additive for a person who has
celiac disease can damage the lining of the small intestine (bowel), which prevents
the proper absorption of food nutrients (Everyday Health, 2023)."

            Else
                celiacResultsLbl.Text = "SAFE"
            End If
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            symptomsTabLabel.Text = "•	Abdominal pain
•	Anemia
•	Bloating and gas
•	Constipation
•	Dermatitis herpetiformis
•	Diarrhea
•	Elevated liver enzymes
•	Fatigue
•	Headache
•	Hyposplenism
•	Joint pain
•	Mouth ulcers
•	Nausea and vomiting
•	Nervous system injury
•	Osteomalacia
•	Osteoporosis
•	Weight loss
Sourced from: Mayo Clinic, 2023;
"


            riskFactorsTabLabel.Text = "•	Addison’s disease

•	Autoimmune thyroid disease

•	Down syndrome

•	Family history of celiac disease or dermatitis herpetiformis

•	Microscopic colitis

•	Turner syndrome

•	Type 1 diabetes

•	William syndrome

Sourced from: Mayo Clinic, 2023
"
        End Sub


    End Class
End Namespace

