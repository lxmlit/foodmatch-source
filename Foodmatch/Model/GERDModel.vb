Namespace GERD
    Public Class GERDModel
        'lists of Strings that will be used when evaluating the input on textBox'
        Public chocolateList As New List(Of String) From {
            "chocolate", "smore",
            "smores"
        }

        Public spicyFoodList As New List(Of String) From {
            "kimchi", "jalapeno",
            "jalapenos", "chili"
        }

        Public carbonatedBeverageList As New List(Of String) From {
            "soda", "sprite",
            "royal", "fanta",
            "coke", "soft drinks",
            "soft drink", "energy drink",
            "energy drinks", "carbonated water"
        }

        Public fattyFriedFoodList As New List(Of String) From {
            "potato chips", "butter",
            "whole milk", "cheese",
            "ice cream", "high fat sour cream",
            "high fat salad dressings", "bacon",
            "sausage", "sausages",
            "pork belly", "pork bellies",
            "pork shoulder flap", "pork shoulder flaps",
            "beef ribeye", "beef ribeyes",
            "beef short-ribs", "beef short-ribs",
            "prime rib", "prime ribs",
            "beef rib", "beef ribs",
            "pork rib", "pork ribs",
            "new york strip", "new york strips",
            "pork shoulder", "pork shoulders",
            "ground turkey", "ground turkeys",
            "pizza"
        }

        Public tomatoList As New List(Of String) From {
            "ketchup", "salsa"
        }

        Public dairyFoodList As New List(Of String) From {
            "cheese", "yogurt",
            "ice cream", "cream",
            "whole milk", "full fat yogurt",
            "hot chocolate"
        }

        Public citrusFruitsList As New List(Of String) From {
            "lemon", "lemons",
            "orange", "oranges",
            "lime", "limes",
            "grapefruit", "grapefruits",
            "pineapple", "pineapples"
        }

        Public calciumBlockerList As New List(Of String) From {
            "amitriptyline",
            "doxepin",
            "silenor"
        }

        Public antiCholDrugList As New List(Of String) From {
             "oxybutynin",
            "atropine",
            "belladonna alkaloids",
            "benztropine mesylate",
            "clidinium",
            "cyclopentolate",
            "darifenacin",
            "dicylomine",
            "fesoterodine",
            "flavoxate",
            "glycopyrrolate",
            "homatropine hydrobromide",
            "hyoscyamine",
            "ipratropium",
            "orphenadrine",
            "propantheline",
            "scopolamine",
            "methscopolamine",
            "solifenacin",
            "tiotropium",
            "tolterodine",
            "trihexpheridyl",
            "trospium",
            "diphenhydramine",
            "brompheniramine",
            "dimenhydrinate",
            "doxylamine"
        }

        Public opoidList As New List(Of String) From {
            "codeine", "fentanyl",
            "hydromorphone", "tapentadol",
            "morphine"
        }

        Public painRelieversList As New List(Of String) From {
            "aspirin", "acetaminophen",
            "tylenol", "ibuprofen",
            "aspirin",
            "naproxen sodium",
            "oxaprozin",
            "daypro",
            "eotodolac",
            "Lodine",
            "indomethacin",
            "indocin",
            "naproxen",
            "naprosyn",
            "relafen",
            "nabumetone",
            "cliclofenac",
            "cataflam",
            "naproxen",
            "esomeprazole",
            "vimovo",
            "celecoxib",
            "celebrex"
        }

        Public alcoholList As New List(Of String) From {
            "beer", "vodka",
            "rum", "gin",
            "whiskey"
        }

    End Class
End Namespace

