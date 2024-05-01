Namespace Celiac
    Public Class CeliacModel
        'lists of Strings that will be used when evaluating the input on textBox'
        Public beerList As New List(Of String) From {
            "beer", "gin",
            "whiskey", "budweiser",
            "coors", "corona",
            "heineken"
        }

        Public pastaList As New List(Of String) From {
            "pasta", "carbonara",
            "spaghetti", "fettuccine",
            "macaroni", "lasagna",
            "ravioli"
        }

        Public cerealList As New List(Of String) From {
            "cereal", "cereals"
        }

        Public glutenFoodList As New List(Of String) From {
            "wheat", "barley",
            "bread", "breads",
            "rye", "spelt",
            "triticale", "crackers",
            "kamut", "salad dressings",
            "semolina", "cookies",
            "crackers", "cake",
            "cakes", "couscous",
            "malt"
        }

        Public beansList As New List(Of String) From {
            "black beans"
        }

    End Class

End Namespace

