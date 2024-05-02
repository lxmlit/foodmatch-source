Imports Foodmatch.Crohn

Namespace Crohn

    Public Class CrohnController
        Inherits FormCrohn
        Function ContainsKeyword(input As String, keyword As String) As Boolean
            Return input.ToLower().Contains(keyword.ToLower())
        End Function

        Private Sub crohnMatchBtn_Click(sender As Object, e As EventArgs) Handles crohnMatchBtn.Click
            Dim crohnTextBoxLower = crohnTextBox.Text.ToLower()
            Dim crohnDataInstance As New CrohnModel

            If ContainsKeyword(crohnTextBoxLower, "beer") OrElse ContainsKeyword(crohnTextBoxLower, "wine") Then
                crohnResultsLbl.Text = "RISKY. Alcoholic beverages may irritate the gastrointestinal
tract lining, causing for bleeding and malabsorption of nutrients to occur. Some studies
suggest that alcohol worsens symptoms of Crohn’s disease. Whilst this may not apply to
everyone, it’s best to consult your doctor before drinking alcohol as it may have a
negative interaction with your current medications, if there are any (Frothingham, 2021)."


            ElseIf crohnDataInstance.dairyProdList.Contains(crohnTextBoxLower) OrElse ContainsKeyword(crohnTextBoxLower, "milk") Then
                crohnResultsLbl.Text = "RISKY. Dairy products pose a risk to your gastrointestinal
health if it is especially high in fat or fiber. Even more so if you are lactose 
intolerant, as dairy products have high levels of lactose. Opt for low-fat and 
low-fiber dairy products. If you are lactose intolerant, it’s best to consume
dairy in moderation or find alternative products to get calcium from 
(Nall, 2023; Amidor, 2024)."

            ElseIf crohnDataInstance.nutSeedList.Contains(crohnTextBoxLower) OrElse ContainsKeyword(crohnTextBoxLower, "nut") OrElse
                    ContainsKeyword(crohnTextBoxLower, "seed") Then
                crohnResultsLbl.Text = "RISKY. Nuts and sees are hard for the body to break down.
Thus, this may cause irritation in your gastrointestinal tract, leading to 
emergence of symptoms (Hawaii Gastroenterology Specialists, 2019)."

            ElseIf crohnDataInstance.sweetenerList.Contains(crohnTextBoxLower) Then
                crohnResultsLbl.Text = "RISKY. A type of sweetener. Splenda with sucralose is
potentially harmful for patients of Crohn’s disease. In an experimental
study conducted by Rodriguez-Palacios et al. (2018), they experimented
with two groups of mice: one group is healthy, one group diseased with
a Crohn’s-like disease. When fed with Splenda-supplemented water, the
healthy mice experienced no significant effects in their gastrointestinal
tract. However, diseased mice experienced an overgrowth of E.coli in
their intestines and 'increased bacterial penetration into the gut wall'.
The researchers then concluded that it is best for Crohn’s Disease patients
to be prudent and avoid consuming products that contain Splenda sucralose
because it may cause inflammation or flare-ups."

            ElseIf crohnDataInstance.fruitsVegIsolubleList.Contains(crohnTextBoxLower) Then
                crohnResultsLbl.Text = "RISKY. Raw fruits and vegetables 'contain a lot of
insoluble fiber' making it hard to digest for patients of Crohn’s disease
(Cherney, 2022). Absolute avoidance isn’t necessary, you just have to limit
your intake."

            ElseIf ContainsKeyword(crohnTextBoxLower, "fry") OrElse ContainsKeyword(crohnTextBoxLower, "fried") OrElse
                 ContainsKeyword(crohnTextBoxLower, "fries") OrElse crohnDataInstance.highFatFriedFoodList.Contains(crohnTextBoxLower) Then
                crohnResultsLbl.Text = "Fatty fried foods are not well-absorbed by the digestive
tract and may cause painful cramps and diarrhea (Weill Cornell Medicine, 2017).
Fatty food is also a significant contributing factor to the inflammation
flare-ups of patients. Having a high-fat diet leads to detrimental 
consequences such as developing inflammatory bowel diseases or worsening
existing inflammatory bowel diseases (Keewan et al., 2020)."

            ElseIf ContainsKeyword(crohnTextBoxLower, "spicy") OrElse ContainsKeyword(crohnTextBoxLower, "hot") Then
                crohnResultsLbl.Text = "RISKY. Spicy foods are one of the top triggers of Crohn’s
disease. Spicy foods contain capsaicin, which is the reason why spicy foods feel
hot. Capsaicin may irritate the lining of your small intestine and trigger gut
inflammation (Bergam, 2023), worsening stomach pain and diarrhea
(CARESPACE, 2023). Even for healthy people, frequent consumption of spicy foods
may lead to development of Crohn’s disease (Bergam, 2023),
especially if they are at high risk."

            ElseIf crohnDataInstance.carbonatedDrinksList.Contains(crohnTextBoxLower) Then
                crohnResultsLbl.Text = "RISKY. Carbonated beverages are known to contribute
to 'inflammation induction and gut microbiota alteration'. It is a beverage highly
associated with the risk of Crohn’s Disease. Reducing intake of carbonated
beverages could decrease the occurrence of the disease
(Yang, Xiang & He, 2019). Dr. Keith Sultan of the Northwell Long Island
Jewish Medical Center also described carbonated beverages as 'notorious'
for causing cramps, bloating and diarrhea most especially to patients of
Crohn’s Disease (Myers, 2023)."

            ElseIf crohnDataInstance.fruitsFodmapList.Contains(crohnTextBoxLower) Then
                If ContainsKeyword(crohnTextBoxLower, "ripe banana") Then
                    crohnResultsLbl.Text = "SAFE"
                Else
                    crohnResultsLbl.Text = "RISKY.  Fruits high in FODMAP
(fermentable oligosaccharides, disaccharides, monosaccharides and polyols)
carbohydrates may worsen symptoms of bloating and diarrhea (Amidor, 2024)."
                End If

            ElseIf crohnDataInstance.caffeinatedBeveragesList.Contains(crohnTextBoxLower) OrElse ContainsKeyword(crohnTextBoxLower, "coffee") OrElse
                    ContainsKeyword(crohnTextBoxLower, "tea") Then
                crohnResultsLbl.Text = "RISKY. Caffeine is known to stimulate bowel
movement and worsen symptoms of diarrhea (Nall, 2023). Although there is little
to no association between caffeinated beverages and Crohn’s Disease 
(Myers, 2023), people with Crohn’s disease are typically advised to
refrain from drinking it, especially during flare-ups. Caffeinated
beverages are not necessarily harmful, but it may aggravate some
symptoms. Best drink in moderation and regulated doses. Better if
you will opt for decaffeinated beverages instead."

            ElseIf ContainsKeyword(crohnTextBoxLower, "beans") OrElse crohnDataInstance.beansLegumesList.Contains(crohnTextBoxLower) Then
                crohnResultsLbl.Text = "RISKY. Beans and legumes are a healthy source
of nutrient, especially when you’re healthy or in remission. But if you are
experiencing flare-ups, beans and legumes are something that you should avoid
because it can intensify pain and cause bloating (Weekley, 2024, as cited in
Cleveland Clinic, 2024). To further add, beans and legumes are
'high in insoluble fiber', a component that is difficult to digest,
which may cause flare-ups or worsen diarrhea (Bernstein, 2022)."

            ElseIf String.IsNullOrEmpty(crohnTextBoxLower) OrElse String.IsNullOrWhiteSpace(crohnTextBoxLower) Then
                crohnResultsLbl.Text = "Invalid Input ..."

            Else
                crohnResultsLbl.Text = "SAFE"

            End If
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            symptomsTabLabel.Text = "•	Abdominal pain or cramps
•	Abscesses of infections in anal canal
•	Bile ducts inflammation
•	Blood in stools 
•	Bloody stool 
•	Changes in the menstrual cycle 
•	Chronic diarrhea 
•	Eye inflammation (e.g. Uveitis, episcleritis)
•	Fatigue 
•	Fever 
•	Joint pain
•	Kidney stones 
•	Loss of appetite 
•	Mouth ulcers 
•	Osteoporosis 
•	Rashes  
•	Skin tags 
•	Weight loss 

Cleveland Clinic, 2023; Urogynecology Clinic, 2020;
Gastroenterology Consultants of San Antonio, 2024
"


            riskFactorsTabLabel.Text = "•	15-30 or 60+ years of age

•	Ancestry (Northern European, Anglo-Saxon, Ashkenazi Jewish)

•	Cigarette smoking

•	Family history of Crohn’s disease

•	Residence in Northern United States or Europe

•	Use of oral contraceptives

•	White or Caucasian race

Sourced from: Healthline, 2020; Health Union, 2015
"
        End Sub
    End Class
End Namespace

