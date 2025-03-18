using System; // в этой версии дирректива using не нужна
using System.Collections;

ArrayList aList1 = new ArrayList();
aList1.Add("Коллекция");
aList1.Add("типа");
aList1.Add("ArrayList");

float f1 = 21.34F; // F в значении инициализации переменной f1 задает тип значения как float, так как по умолчанию используется тип double
aList1.Add(f1);

Console.WriteLine("aList1");
Console.WriteLine("\tCount: {0}", aList1.Count); // \t – это символ табуляции, обеспечивающий отступ при выводе в окно консоли.
Console.WriteLine("\tCapacity: {0}", aList1.Capacity);


