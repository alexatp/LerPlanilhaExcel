using ClosedXML.Excel;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var xls = new XLWorkbook("notas.xlsx");
var planilha = xls.Worksheets.First(w => w.Name == "Plan1");
var totalLinhas = planilha.Rows().Count();

Console.WriteLine("Total de linhas na planilha: " + totalLinhas);

//lendo todas as linhas da planilha
//os dados começam na linha 2
for(int l = 2; l <= totalLinhas; l++)
{
    Console.WriteLine("Disciplina:" + planilha.Cell($"A{l}").Value.ToString());
}