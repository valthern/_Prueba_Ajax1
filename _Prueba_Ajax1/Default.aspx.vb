Public Class _Default
    Inherits Page
    Implements ICallbackEventHandler

#Region "Campos Privados"
    Dim _callbackArgs As String
#End Region



#Region "Métodos Protegidos"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        ' Register tha name of the client-side function that will be called by the server
        Dim callbackRef As String = Page.ClientScript.GetCallbackEventReference(Me, "args", "clientCallbackFunction", "")

        ' Define a function used by the client to call the server
        Dim callbackScript As String = String.Format("function myServerCall(args) {{ {0}; }}", callbackRef)

        ' Register the client function with the page
        Page.ClientScript.RegisterClientScriptBlock(Me.GetType(), "myServerCall", callbackScript, True)
    End Sub
#End Region



#Region "Métodos Privados"
    Public Sub RaiseCallbackEvent(ByVal eventArgument As String) Implements ICallbackEventHandler.RaiseCallbackEvent
        _callbackArgs = eventArgument
    End Sub

    Public Function GetCallbackResult() As String Implements ICallbackEventHandler.GetCallbackResult
        Return _callbackArgs & " Servidor"
    End Function
#End Region
End Class