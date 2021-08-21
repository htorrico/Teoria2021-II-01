Imports Modeo

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult

        Dim person1 As New Person

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
