Namespace IBS
    Public Class IBSController
        Inherits formIBS

        Function ContainsKeyword(input As String, keyword As String) As Boolean
            Return input.ToLower().Contains(keyword.ToLower())
        End Function

        Private Sub ibsMatchBtn_Click(sender As Object, e As EventArgs) Handles ibsMatchBtn.Click
            Dim ibsTextBoxLower = ibsTextBox.Text.ToLower()
            Dim ibsDataInstance As New IBSModel

            'exclude air fried, air fry'
            If ContainsKeyword(ibsTextBoxLower, "air fry") OrElse ContainsKeyword(ibsTextBoxLower, "air fried") OrElse
                ContainsKeyword(ibsTextBoxLower, "air-fried") OrElse ContainsKeyword(ibsTextBoxLower, "air-fry") OrElse
                ContainsKeyword(ibsTextBoxLower, "almond milk") OrElse ContainsKeyword(ibsTextBoxLower, "coconut milk") OrElse
                ContainsKeyword(ibsTextBoxLower, "vegan cheese") OrElse ContainsKeyword(ibsTextBoxLower, "yogurt") OrElse
                ContainsKeyword(ibsTextBoxLower, "stevia") Then
                resultsLabel.Text = "SAFE"

            ElseIf ContainsKeyword(ibsTextBoxLower, "fried") OrElse ContainsKeyword(ibsTextBoxLower, "fries") OrElse ContainsKeyword(ibsTextBoxLower, "fry") Then
                resultsLabel.Text = "RISKY (especially for IBS diarrhea).
Fried foods are high in fat and may be hard to digest for people with IBS.
Frying foods change the chemical composition of food which may make it difficult to digest (Healthline, 2024)."

            ElseIf ibsDataInstance.fattyFoodList.Contains(ibsTextBoxLower) Then
                resultsLabel.Text = "RISKY. This is a fatty cut of meat.
Due to fatty cuts of meat being rich in saturated fats,
it is hard to digest and may cause intestinal inflammation,
worsening the symptoms of IBS (Bolen, 2023).
Some IBS patients cannot tolerate fatty cuts of meat. 
If you have IBS but fatty cuts of meat are not your trigger, 
then this won’t pose much of a risk for you. "

            ElseIf ibsDataInstance.processedFoodList.Contains(ibsTextBoxLower) OrElse ContainsKeyword(ibsTextBoxLower, "pie") Then
                resultsLabel.Text = "RISKY. This is fatty, processed meat.
It may cause inflammation and worsen IBS symptoms (Bolen, 2023)."

            ElseIf ContainsKeyword(ibsTextBoxLower, "pie") Then
                resultsLabel.Text = "RISKY. Pie is a high-fat meal.
High-fat meals are known to worsen IBS symptoms and affect gut
motility, which is the movement and passage of food through
the gastrointestinal tract (Mead, 2019). Furthermore, pies
are considered as ultra-processed foods. Ultra-processed
foods usually contain additives and other hidden
ingredients which may trigger IBS symptoms
(GI Associates & Endoscopy Center, 2020)."

            ElseIf ibsDataInstance.dairyProductsList.Contains(ibsTextBoxLower) OrElse ibsDataInstance.otherProductList.Contains(ibsTextBoxLower) Then
                resultsLabel.Text = "RISKY. Dairy products are common
triggers for IBS flare-ups, especially high-fat dairy products
(Smith, 2023). If you find that dairy products have a negative
effect in your digestive system, it is best to opt for low-fat
dairy products or dairy-free products."

            ElseIf ibsDataInstance.fructoseProductsList.Contains(ibsTextBoxLower) Then
                resultsLabel.Text = "RISKY. Products high in fructose
may cause bloating, indigestion, diarrhea, or constipation,
especially for fructose-intolerant IBS patients
(DiNicolantonio & Lucan, 2015). Fructose intolerance
allows for the malabsorption of fructose and its fermentation
(Melchior et al., 2020). People with fructose-intolerance
report improvements in their IBS symptoms after adhering
to fructose-restricted diets. Meanwhile, people with 
fructose-intolerance who did not adhere to 
fructose-restricted diets continued suffering
IBS symptoms (Choi et al., 2008, as cited in Bolen, 2022)."

            ElseIf ContainsKeyword(ibsTextBoxLower, "beer") Then
                resultsLabel.Text = "RISKY. Alcoholic beverages are known
for irritating the gut and causing flare-ups. Depending on the level of
sensitivity, IBS patients may experience cramping and/or bloating
(Seltzer, 2020). For healthy people, alcohol abuse may lead to 
the development of IBS (The Ridge, 2024). Best drink in moderation."

            ElseIf ibsDataInstance.sugarSubList.Contains(ibsTextBoxLower) Then
                resultsLabel.Text = "RISKY. Sugar substitutes are polyols
that are not fully absorbed by the digestive system. 
These can greatly impact the gut microbiome which 
leads to the triggering of IBS symptoms (Young, 2023).
To further add, sugar substitutes are associated with
abdominal cramps and diarrhea for IBS (Cherney, 2020)."

            ElseIf ibsDataInstance.spicyFoodList.Contains(ibsTextBoxLower) OrElse ContainsKeyword(ibsTextBoxLower, "hot") OrElse
                ContainsKeyword(ibsTextBoxLower, "hot") OrElse ContainsKeyword(ibsTextBoxLower, "spicy") Then
                resultsLabel.Text = "RISKY. IBS symptoms are commonly triggered
by spicy foods. Capsaicin, a component of spicy ingredients, are
known to increase gut motility and abdominal pain (Mead, 2019)."


            ElseIf ContainsKeyword(ibsTextBoxLower, "coffee") Then
                resultsLabel.Text = "RISKY. It has been observed that caffeinated
beverages can result to an increased secretion of gastric acid,
causing abdominal pain. Additionally, people who have high 
amounts of caffeine intake are more prone to developing IBS
due to possible changes in their gut microbiota 
(Barandouzi et al., 2021, as cited in Gillette, 2024)."

            ElseIf ContainsKeyword(ibsTextBoxLower, "pea") OrElse
                   ContainsKeyword(ibsTextBoxLower, "bean") OrElse
                   ContainsKeyword(ibsTextBoxLower, "legume") Then
                resultsLabel.Text = "RISKY. Although beans, peas and legumes are a
rich source of protein and fiber, because of the oligosaccharides that
it contains, it triggers IBS symptoms. Oligosaccharides are components
that are not digested or difficult to digest. To make digestion of beans,
peas and legumes easier, it is recommended to soak them overnight before
thoroughly cooking and then consuming them (Moore et al., 2024)."

            Else
                resultsLabel.Text = "SAFE"
            End If

        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            symptomsTabLabel.Text = "•	Abdominal pain, cramping or bloating when pooping

•	Changes in appearance of poop

•	Changes in bowel movement frequency

•	Constipation

•	Diarrhea at night

•	Feeling like you’re unable to empty bowels after pooping

•	Iron deficiency anemia

•	Mucus in poop

•	Rectal bleeding

•	Unexplained vomiting

•	Weight loss

Sourced from: Mayo Clinic, 2023; Cleveland Clinic, 2023

"


            riskFactorsTabLabel.Text = "•	Diagnosis of PTSD (Post-traumatic Stress Disorder)

•	Estrogen therapy

•	Family history of IBS

•	Female biological assignment

•	History of abuse

•	Severe digestive tract infection

•	Under 50 years of age

Sourced from: Mayo Clinic, 2023; Cleveland Clinic, 2023
"
        End Sub

    End Class
End Namespace
