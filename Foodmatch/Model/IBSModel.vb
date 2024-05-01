Namespace IBS
    Public Class IBSModel

        'lists of Strings that will be used when evaluating the input on textBox'
        Public fattyFoodList As New List(Of String) From {
            "pork belly", "pork bellies",
            "pork shoulder flap", "pork shoulder flaps",
            "beef ribeye", "beef ribeyes",
            "beef short-ribs", "beef short-ribs",
            "prime rib", "prime ribs",
            "beef rib", "beef ribs",
            "pork rib", "pork ribs",
            "new york strip", "new york strips",
            "pork shoulder", "pork shoulders",
            "ground turkey", "ground turkeys"
        }

        Public processedFoodList As New List(Of String) From {
            "sausage", "sausages",
            "bacon", "bacons",
            "pepperone", "pepperoni",
            "salami", "salamis"
        }

        Public dairyProductsList As New List(Of String) From {
            "butter", "ghee",
            "lard", "milk",
            "cheese", "cheddar",
            "cream", "soured cream",
            "ice cream", "cheese cracker", "cheese crackers"}

        Public otherProductList As New List(Of String) From {
            "popcorn", "popcorns",
            "cake", "cakes",
            "biscuit", "biscuits",
            "palm oil", "coconut oil",
            "coconut cream", "soda",
            "coffee"}

        Public fructoseProductsList As New List(Of String) From {
            "apple", "apples",
            "pear", "pears",
            "watermelon", "watermelons",
            "asparagus", "honey"
        }

        Public sugarSubList As New List(Of String) From {
            "sugar alcohol", "sugar alcohols",
            "sorbitol", "mannitol",
            "maltitol", "artificial sweeteners", "sucralose",
            "acesulfame", "potassium", "aspartame"
        }

        Public spicyFoodList As New List(Of String) From {
            "miso", "soy sauce",
            "saki"
        }
    End Class
End Namespace
