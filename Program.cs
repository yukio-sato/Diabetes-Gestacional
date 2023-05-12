Console.Clear();
int mg;
void frase(string txt)
{
for (int i = 0; i < txt.Length; i++)
{
    Console.Write(txt[i]);
    Thread.Sleep(55);
}
}
Console.ForegroundColor = ConsoleColor.Yellow;
frase("Glicemia (em mg/dL): ");
Console.ForegroundColor = ConsoleColor.White;
mg = int.Parse(Console.ReadLine()!);
if (mg < 92)
{
    Console.ForegroundColor = ConsoleColor.Red;
    frase("\n\nReavalie cerca de 24 até 28 semanas com TTOG 75g de glicose");
}
else if (mg >= 92 && mg < 126)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    frase("\n\nCompatível com Diabetes Gestacional");
}
else if (mg >= 126)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    frase("\n\nDiabetes Mellitus na Gravidez");
}
Console.ResetColor();