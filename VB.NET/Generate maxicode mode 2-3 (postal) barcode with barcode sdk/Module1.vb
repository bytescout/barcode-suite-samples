'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports Bytescout.BarCode

Module Module1

	Sub Main()

		' Create and activate Barcode object instance
		Dim barcode = New Barcode()
		barcode.RegistrationName = "demo"
		barcode.RegistrationKey = "demo"

		' Set barcode symbology (type) 
		barcode.Symbology = SymbologyType.MaxiCode
		' Set MaxiCode mode
		barcode.Options.MaxiCodeMode = 2 ' 2 or 3 depending on the postal code

		' Make barcode dots larger (5 pixels)
		barcode.NarrowBarWidth = 5


		' Prepare barcode value:

		' Special data signatures
		Dim mode23Signature = "[)>" + ChrW(&H1E) + "01" + ChrW(&H1D) + "96"
		Dim separator = ChrW(&H1D)
		Dim endingSignature = ChrW(&H1E) + ChrW(&H4)

		' Mandatory data part.
		Dim postalCode = "123456789" ' 5 or 9 digits in the USA (Mode 2); 1-6 alphanumeric characters in other countries (Mode 3)
		Dim countryCode = "840"	' 3 digits (840 for USA) 
		Dim classOfService = "001" ' 3 digits 
		Dim trackingNumber = "S1Z12345678G"	' 10-character alphanumeric
		Dim upsStandardCarrierAlphaCode = "UPSN"

		' Optional data part.
		' Note, you can use empty strings for unneeded field values like `packageInShipment` or `weightInPounds` 
		' but they should delimited with the separator anyway.
		Dim upsShipperNumber = "S06X610" ' 6-character alphanumeric 
		Dim julianDayOfPickup = "159" ' 3 digits 
		Dim shipmentIdNumber = "1234567" ' 1-30 character alphanumeric 
		Dim packageInShipment = "1/2" ' 1-4 digits �/� 1-4 digits 
		Dim weightInPounds = "3.1" ' 1-5 digits
		Dim addressValidation = "Y"	' �Y� or �N�
		Dim shipToAddress = "S123 MAIN ST" ' 1-35 alphanumeric
		Dim shipToCity = "YORK"	' 1 - 35 alphanumeric
		Dim shipToState = "PA" ' 2-character alpha


		' Generate minimal postal code:

		Dim minimalValue = mode23Signature +
							postalCode + separator +
							countryCode + separator +
							classOfService + separator +
							trackingNumber + separator +
							upsStandardCarrierAlphaCode +
							endingSignature

		barcode.Value = minimalValue
		barcode.SaveImage("postal-maxicode-min.png")


		' Generate full postal code:

		Dim fullValue = mode23Signature +
						postalCode + separator +
						countryCode + separator +
						classOfService + separator +
						trackingNumber + separator +
						upsStandardCarrierAlphaCode + separator +
						upsShipperNumber + separator +
						julianDayOfPickup + separator +
						shipmentIdNumber + separator +
						packageInShipment + separator +
						weightInPounds + separator +
						addressValidation + separator +
						shipToAddress + separator +
						shipToCity + separator +
						shipToState +
						endingSignature

		barcode.Value = fullValue
		barcode.SaveImage("postal-maxicode-full.png")

	End Sub

End Module
