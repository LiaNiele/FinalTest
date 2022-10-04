// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Метод вывода массива
void PrintArray(string[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// Ввод размера массива
Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

// Создание первого пустого массива и заполнение его строками через консоль
string[] arrayInput = new string[size];
for (int i = 0; i < size; i++){
    Console.WriteLine($"Введите {i+1} элемент массива: ");
    string word = Convert.ToString(Console.ReadLine());
    arrayInput[i] = word;
}

// Создание второго пустого массива и запись в него строк, длина которых 3 символа и меньше
string[] arrayOutput = new string[size];
int length = 3;
int pos = 0;

for (int j = 0; j < size; j++){
    if (arrayInput[j].Length <= length){
        arrayOutput[pos] = arrayInput[j];
        pos++;
    }
}

// Вывод результата
Console.WriteLine();
PrintArray(arrayOutput);