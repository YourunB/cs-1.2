using System; // в этой версии дирректива using не нужна
using System.Collections;

ArrayList aList1 = new ArrayList();
aList1.Add("Коллекция");
aList1.Add("типа");
aList1.Add("ArrayList");

float f1 = 21.34F; // F в значении инициализации переменной f1 задает тип значения как float, так как по умолчанию используется тип double
aList1.Add(f1);

Console.WriteLine("aList1");
Console.WriteLine("\tCount: {0}", aList1.Count); // Count класса ArrayList возвращает текущее количество элементов в коллекции, \t – это символ табуляции, обеспечивающий отступ при выводе в окно консоли.
Console.WriteLine("\tCapacity: {0}", aList1.Capacity); // Capacity класса ArrayList возвращает количество элементов, которое может содержать коллекция без автоматического увеличения требуемой памяти

static void PrintCollections(IEnumerable list1) // cоздаnm объект нумератор
{
    System.Collections.IEnumerator myEnumerator = list1.GetEnumerator(); // GetEnumerator возвращает объект нумератор
    while (myEnumerator.MoveNext())
    {
        Console.Write("\t{0}", myEnumerator.Current); // вывести значение текущего элемента коллекции
    }
}

PrintCollections(aList1);

//------------------------------------------Создание новой коллекции целочисленных элементов, используя инициализатор коллекции------------------------------------------------
List<int> dig1 = new List<int> { 0, 1, 2, 3, 4, 5 }; // ПРИМЕР - при использовании инициализатора коллекции вызовы метода Add для заполнения коллекции не нужны, т.к. эти вызовы добавляет компилятор

List<int> collectInt = new List<int> { 10, 20, 30, 40, 50 };
foreach (int i in collectInt)
    Console.WriteLine(i);
