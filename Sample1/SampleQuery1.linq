<Query Kind="VBStatements">
  <Connection>
    <ID>ac4df304-e462-4afa-a4bf-93c80314bcca</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-VBBHMUF</Server>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>BikeStores</Database>
  </Connection>
</Query>

Dim AppendTextString As String = String.Empty 'alphabet forwards
Dim AppendTextStringBack As String = String.Empty 'alphabet backwards
Dim Alphabet As String = "abcdefghijklmnopqrstuvwxyz" 'alpha

For i = 0 To 25
	'forward loop
	AppendTextString += Alphabet.Substring(i, 1)
Next

For i = 25 To 0 Step - 1
	'reverse for loop
	AppendTextStringBack += Alphabet.Substring(i, 1)
Next

String.Format("The value of forward string is: {0}", AppendTextString).Dump()
String.Format("The value of backward string is: {0}", AppendTextStringBack).Dump()


