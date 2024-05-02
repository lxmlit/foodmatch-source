Imports Foodmatch.Celiac

Namespace GERD
    Public Class GERDController
        Inherits FormGERD

        Function ContainsKeyword(input As String, keyword As String) As Boolean
            Return input.ToLower().Contains(keyword.ToLower())
        End Function

        Private Sub gerdMatchBtn_Click(sender As Object, e As EventArgs) Handles gerdMatchBtn.Click
            Dim gerdTextBoxLower = gerdTextBox.Text.ToLower()
            Dim gerdDataInstance As New GERDModel

            If ContainsKeyword(gerdTextBoxLower, "choco") OrElse ContainsKeyword(gerdTextBoxLower, "chocolate") OrElse gerdDataInstance.chocolateList.Contains(gerdTextBoxLower) Then
                gerdResultsLbl.Text = "RISKY. Chocolate, cocoa and caffeine contains theobromine.
Eating such foods cause the body to release serotonin hormones which may lead to relaxation of the
body’s LES (lower esophageal sphincter), allowing acid from the stomach to leak into the esophagus.
When this happens, burning sensation in the esophagus can be felt, which is a symptom of acid reflux (Healthline, 2023)."

            ElseIf ContainsKeyword(gerdTextBoxLower, "peppermint") OrElse ContainsKeyword(gerdTextBoxLower, "mint") Then
                gerdResultsLbl.Text = "RISKY. Peppermint and mint worsen GERD symptoms through LES
(lower esophageal sphincter) relaxation (Mount Sinai, 2024)."

            ElseIf ContainsKeyword(gerdTextBoxLower, "spicy") OrElse ContainsKeyword(gerdTextBoxLower, "hot") Then
                gerdResultsLbl.Text = "RISKY. Spicy foods can cause abdominal pain and burning symptoms.
Spicy foods contain capsaicin which irritates parts of the esophagus, resulting in acid reflux.
If you regularly experience acid reflux, it is safest to avoid eating spicy foods (Healthline, 2023)."

            ElseIf gerdDataInstance.carbonatedBeverageList.Contains(gerdTextBoxLower) Then
                gerdResultsLbl.Text = "RISKY. Have properties that potentially worsen GERD,
such as high acidity and carbonation. GERD Patients are recommended to stop drinking carbonated
drinks (National Library of Medicine, 2021 & National Institute of Diabetes and Digestive and
Kidney Diseases, 2020, as cited in MedicalNewsToday, 2023)."

            ElseIf ContainsKeyword(gerdTextBoxLower, "fried") OrElse ContainsKeyword(gerdTextBoxLower, "fry") OrElse
                ContainsKeyword(gerdTextBoxLower, "fries") OrElse gerdDataInstance.fattyFriedFoodList.Contains(gerdTextBoxLower) Then
                gerdResultsLbl.Text = "RISKY. Fatty and Fried foods both contribute to acid reflux. 
Both Fatty and Fried Foods generally lower pressure on your LES that’s why it delays our stomach
from emptying. The slow emptying of your stomach can lead to acid backing up into the esophagus
(National Institute of Diabetes and Digestive and Kidney Diseases, 2020, as cited in Healthline, 2023)."

            ElseIf ContainsKeyword(gerdTextBoxLower, "tomato") OrElse gerdDataInstance.tomatoList.Contains(gerdTextBoxLower) Then
                gerdResultsLbl.Text = "RISKY. Tomatoes are highly acidic which can cause acid reflux or heartburn.
The acid level from tomatoes can relax the LES which is the muscle that separates the stomach from the esophagus.
Limiting the consumption of tomatoes or simply controlling the portion size can be a lot of help because it puts
less pressure on your stomach (Vanguard Gastroenterology, 2023)."

            ElseIf ContainsKeyword(gerdTextBoxLower, "milk") OrElse gerdDataInstance.dairyFoodList.Contains(gerdTextBoxLower) Then
                gerdResultsLbl.Text = "RISKY. Foods that contain dairy are more likely to cause heartburns
. Although it doesn’t directly cause acid reflux, it can worsen the symptoms upon consumption.
Eating cold full fat yogurt can slow down your digestion because it numbs the lower esophageal sphincter
(GERDHelp, 2024)."

            ElseIf ContainsKeyword(gerdTextBoxLower, "oxybutynin") Then
                gerdResultsLbl.Text = "RISKY. Anticholinergic drugs weaken the LESP
(lower esophageal sphincter pressure) and reduces the production of saliva
leading to prolonged time of acid clearance. This drug also delays gastric
emptying which leads to bigger chance of experiencing GERD
(Mungan & Simsek, 2017). Consult your doctor first before taking this drug."

            ElseIf gerdDataInstance.citrusFruitsList.Contains(gerdTextBoxLower) Then
                gerdResultsLbl.Text = "RISKY. Citrus fruits are high in citric acid
which stimulates your stomach to produce more stomach acid.
Therefore, the chance of experiencing reflux increase (The Surgical Clinic, n.d.)."

            ElseIf ContainsKeyword(gerdTextBoxLower, "mint") Then
                gerdResultsLbl.Text = "RISKY. Peppermint and mint worsen GERD symptoms
through LES (lower esophageal sphincter) relaxation (Mount Sinai, 2024)."

            ElseIf ContainsKeyword(gerdTextBoxLower, "chip") OrElse
                ContainsKeyword(gerdTextBoxLower, "syrup") OrElse
                ContainsKeyword(gerdTextBoxLower, "frozen") OrElse
                ContainsKeyword(gerdTextBoxLower, "candy") Then
                gerdResultsLbl.Text = "RISKY. Processed foods delay digestion because
they are not easy for the body to digest. Processed foods are
also known for worsening symptoms of GERD
(Cooper University Health Care, 2024)."

            ElseIf ContainsKeyword(gerdTextBoxLower, "codeine") Then
                gerdResultsLbl.Text = "RISKY. Opiods or narcotics may decrease
esophageal contractions that push food to the stomach and weaken
the lower esophageal sphincter’s function. Because of this,
new symptoms of GERD may emerge or existing symptoms may
worsen (Lacy, 2016). Consult your doctor first
when taking this medication."

            ElseIf gerdDataInstance.calciumBlockerList.Contains(gerdTextBoxLower) Then
                gerdResultsLbl.Text = "RISKY. Calcium channel blockers (CCBs)
interfere with esophageal peristalsis, which is the esophagus’
sequenced contractions that serve to push food down to the
stomach. Furthermore, calcium channel blockers loosen the
lower esophageal sphincter, exposing the esophagus to
gastric acid (Seretis et al., 2012)."

            ElseIf ContainsKeyword(gerdTextBoxLower, "aspirin") Then
                gerdResultsLbl.Text = "RISKY. Pain relievers
'contribute to a high-acid environment'. Although painkillers
are not the main cause of GERD,
it can make GERD worse (Tampa Bay Reflux Center, 2021)."

            ElseIf ContainsKeyword(gerdTextBoxLower, "onion") Then
                gerdResultsLbl.Text = "RISKY. Onions worsen GERD
symptoms especially when eaten raw. Onions 'are a rich
source Of FODMAPs (fermentable oligosaccharides,
disaccharides, monosaccharides, And polyols)'
which cause digestive issues for some people 
and heartburn for FODMAP-sensitive people
(Raman & Kubala, 2023)."

            ElseIf ContainsKeyword(gerdTextBoxLower, "beer") Then
                gerdResultsLbl.Text = "RISKY. Current studies show
that there is no 'significant relationship between alcohol
consumption And increased risk of GERD'
(Heidarzadeh-Esfahani et al., 2021). However, some people
report that they experience worsened symptoms of GERD due
to alcohol. Hence, alcohol may still pose a risk if your
stomach is sensitive to it. Best drink in moderation. 
(Nall, 2023)."

            ElseIf gerdDataInstance.antiCholDrugList.Contains(gerdTextBoxLower) Then
                gerdResultsLbl.Text = "RISKY. Anticholinergic drugs
weaken the LESP (lower esophageal sphincter pressure) and
reduces the production of saliva leading to prolonged time
of acid clearance. This drug also delays gastric emptying
which leads to bigger chance of experiencing GERD
(Mungan & Simsek, 2017). Consult your doctor first before
taking this drug."


            ElseIf gerdDataInstance.opoidList.Contains(gerdTextBoxLower) Then
                gerdResultsLbl.Text = "RISKY. Opiods or narcotics may
decrease esophageal contractions that push food to the stomach
and weaken the lower esophageal sphincter’s function. Because
of this, new symptoms of GERD may emerge or existing symptoms
may worsen (Lacy, 2016). Consult your doctor first when taking
this medication."

            ElseIf gerdDataInstance.painRelieversList.Contains(gerdTextBoxLower) Then
                gerdResultsLbl.Text = "RISKY. Pain relievers 'contribute
to a high-acid environment'. Although painkillers are not the
main cause of GERD, it can make GERD worse
(Tampa Bay Reflux Center, 2021)."

            ElseIf ContainsKeyword(gerdTextBoxLower, "onion") Then
                gerdResultsLbl.Text = "RISKY. Onions worsen GERD symptoms
especially when eaten raw. Onions 'are a rich source of FODMAPs
(fermentable oligosaccharides, disaccharides, monosaccharides,
and polyols)' which cause digestive issues for some people and
heartburn for FODMAP-sensitive people (Raman & Kubala, 2023)."

            ElseIf gerdDataInstance.alcoholList.Contains(gerdTextBoxLower) Then
                gerdResultsLbl.Text = "RISKY. Current studies show that there
is no 'significant relationship between alcohol consumption and
increased risk of GERD' (Heidarzadeh-Esfahani et al., 2021).
However, some people report that they experience worsened
symptoms of GERD due to alcohol. Hence, alcohol may still pose
a risk if your stomach is sensitive to it. Best drink in 
moderation. (Nall, 2023)."

            ElseIf String.IsNullOrEmpty(gerdTextBoxLower) OrElse String.IsNullOrWhiteSpace(gerdTextBoxLower) Then
                gerdResultsLbl.Text = "Invalid Input ..."

            Else
                gerdResultsLbl.Text = "SAFE"
            End If
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            symptomsTabLabel.Text = "•	Asthmatic symptoms

•	Backwash of food or sour liquid

•	Chest pain

•	Dysphagia

•	Heartburn

•	Laryngitis

•	Nausea

•	Sore throat

Sourced from Cleveland Clinic, 2023; Mayo Clinic, 2023
"


            riskFactorsTabLabel.Text = "•	50+ years of age

•	Asthma

•	Connective tissue disorder/s

•	Eating large meals late at night

•	Female biological assignment

•	Gastroparesis

•	Hiatal hernia

•	Heavy exercise engagement or sedentary lifestyle

•	Obesity

•	Pregnancy

•	Smoking

Sourced from MedicalNewsToday, 2023
"
        End Sub

    End Class

End Namespace

