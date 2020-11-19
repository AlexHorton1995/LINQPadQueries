<Query Kind="Statements" />

string AppendTextString = string.Empty; //alphabet forwards
string AppendTextStringBack = string.Empty; //alphabet backwards
string Alphabet = "abcdefghijklmnopqrstuvwxyz"; //alpha

for (int i = 25; i >= 0 ; i--)
{
	//reverse for loop
	AppendTextStringBack += Alphabet.Substring(i, 1);
}

for (int i = 0; i < 26; i++)
{
	//forward loop
	AppendTextString += Alphabet.Substring(i, 1);
}

string.Format(@"The value of forward string is: {0}", AppendTextString).Dump();
string.Format(@"The value of backward string is: {0}", AppendTextStringBack).Dump();
