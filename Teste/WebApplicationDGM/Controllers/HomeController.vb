Public Class HomeController
	Inherits System.Web.Mvc.Controller

	Function Index() As ActionResult
		Return View()
	End Function

	Function About() As ActionResult
		ViewData("Message") = "Esta é uma avaliação básica de código."

		Return View()
	End Function

	Function Contact() As ActionResult
		ViewData("Message") = "Página de contatos."

		Return View()
	End Function
End Class
