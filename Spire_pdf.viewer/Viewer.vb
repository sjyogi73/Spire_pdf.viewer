﻿Imports System.IO

Public Class Viewer
    ' License file Invoked into the Global variablee
    'Dim licenseFile As New FileInfo("..\..\..\Reference\license.elic.xml")

    Dim key As String = "Xel6AQDMPEWYDX8L9VEOTTnnYak7/VWrCCuYrwxjnDIlf0gWxlsNTKAkvg6OxCvHQjJZCVArfMegPxYGWZ7Y7CPXw0ouda3k5boDCPeuorLweXC7Qg2U7GKLkYHcb61kSRymMKBpVloYg8BuDjWv61ejCc10eFce0EODE0kXt+06OSNZyhesR/mGDniMk0g3bJ3U9FkN7P2LveLuYw/+BZu3wDBvuIGb8XGZOHm3mlorRhQI7bZb9kxwAPaA+F19kUKqfb0ipYtoRtvyDqlQQowApzSsPTgf3XDYRekgietcQUcFvdLCpkbtPGCA+CE6Q+pPOI91nVTyO62PYeW59/OGoJtmP8WTzkTuj/mS9wiLaBwMu/N5ngD6q2wQDsU2aPGMH17PDfG9gIIxQ0Df4czglSu1c7wKI/JSyVKMo3AOvS63SwwUExf8fJGwod2qeWnav4eAOG8GZSTGHffIn70V1ZinBMduI4S624g+VPbQfcC7C/uz4LOQ2HvTUihZL6oUjJVwHLhT+m4z70ZBlIIi/21WOm//5Mtnk44qnlcbC5qk8/fG7jNBaX2XbQen8Owc5EFN95gCL4HVSkhm1EurdJ8vpcbx6STAYdfspGg/ViE5AfAr3x4HUdBf3VKxNyCkemaY2YW95VG2W9gt5vWgm8ijDkgWxNqTx7c6TtRmIYa5YNrxg6vt+q6UlWupE4CxLXGIUXloClA2f9poPpQVvBUuva1Halj9xsC2+tbklA7Q3F9ntbpyXx2EbXjGpzATuot3pXXd7VLzG4IUClfg6QH4gsa66e2HwoeQoy8zPy4xbcfaR2mO7OCtGblb73vxyUFYq6uPJZKzVVDieMwhA+hL9cmCuYLdUVwZOtmBvYQAtiJ/yd1jGDvK/30hl6ueF0mjVtHvkygdfOy5ZB5EcUsCGlF6ZKDAf90g19MsjvAl3w1St6Wwx67qaCHB0rqD/gZ5kTRyOsegFh0p4JCQs3zhSEQjg2Sl43GAqmvXDT5LdKSGpm4T8x5ehbDPDVJnKeceVT2ocmhJXTbvd0Fg+mQWgMaR6lGIsPVfxbGbCNjS85JUh7OQqhdenPnk8axkxyXGz/yGLoI+zw7rkunVHufYe9ZzvOXjt+pj2YbwsPEppZxdOEbeUgypEIUN8MDz9qKsCo5AYDESnGcU1vDE0vL4pmx25Z//hv+uMO6d6lbTzlot4WNkk83WaPLm7nzNcQoW2y4QMwnmTTOmNnMiURImd0h1ERQl/S/sBeFUEQwcc/Ed4pXS/v+CttBw0JqlEiJY73GlizR301ZIp2pEnoYgFTLvrxP72Jc27T44UWvApaTUBwqfe56ct86DK9vZ205k3eUp/geguFt6q/o2/Cnl/Oqnsnw5mp7T0FtnsHfARNwUaP//rDdo9cR7rTcdm5XC5esgHLikVHO4mPqYhIVYrCePYLSUH9i8ilDRtICwsY8zcAvbYNFySRHggFvFdrQNMjq6m5rEF0zZCIBq1b0nc5LQlJ422pU+zH4ny33ETk0XjgvTAocScqbnhRIdbupejGncrgtJ3vMBf3mIo8vr2eUZkZJymSx9QLxY3qcevSwLEAukokLY+xWtE7btnOSZ6Iw="

    Private Sub Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Spire.License.LicenseProvider.SetLicenseKey(key)
        Try

            PdfViewer1.LoadFromFile("..\..\..\Reference\sample.pdf")
            PdfViewer1.Height = Panel1.Height
            PdfViewer1.Width = Panel1.Width

        Catch ex As Exception

            MsgBox(ex)

        Finally

            PdfViewer1 = Nothing
        End Try
    End Sub

End Class
