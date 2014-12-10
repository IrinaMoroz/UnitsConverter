UnitsConverter
==============
Сделать конвертер между разными величинами. К примеру килограммы в граммы

Должен быть класс UnitsConverter. У него должен быть метод AddConverter который принимает делегат на функцию, которая и будет делать конвертирование и плюс еще один параметр тип ковертации. Тип конвертации должен быть Enum. Пример:

public enum UnitsConverterType
{
 KgToGramm,
 GrammToPound,
 ParrotsToElephants, // https://www.google.com.ua/search?q=5 попугаев в слонятах)
 ....
}


Так же должен быть метод занимающийся самой конвертацией. Он должен быть ввида:
double Convert(UnitsConverterType[] direction, double inputValue)

В него будет передаваться порядок конвертирование и исходное число. по указаному типу конвертирования он должен найти сохранённый в AddConverter делегат, и вызвать его передав inputValue, потом найте следующий и так же его вызвать. Когда весь массив direction будет обработан - нужно вернуть результат. Пример вызова:


double result = UnitsConverter.Convert(new []{UnitsConverterType.KgToGramm, UnitsConverterType.GrammToPound}, 10);
