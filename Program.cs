﻿Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("----------------------------------------------");
 Console.ResetColor();
Console.WriteLine("\n**********************************************");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"\n{"№",-4}{"Название",-25}{"Цена",-6}" +
    $"{"Кол.",-6}{"Сумма",-6}");
Console.ResetColor();
Console.WriteLine($"{"1",-4}{"КОФФЕ СТАНДАРТНЫЙ",-24}" +
    $"{"69.00",-7}{"1.00",-6}{"60.00",-6}" +
    $"\n{" ",-4}{"НДС с расчитанной",-37}{"10.53",-10}" +
    $"\n{" ",-4}{"cтавкой 18%"}" + "\n" +
    $"\n{"2",-4}{"РУЛЕТ-СПРИНГ ТВ ИЗ",-24}{"70.00",-7}" +
    $"{"1.00",- 6}{"70.00",- 7}" +
    $"\n {" ",-3}{"КУ"}" +
    $"\n{" ",-4}{"НДС с расчитанной", -38}{"6.36",-10}" +
    $"\n{" ",-4}{"cтавкой 10%"}" +
    $"\n" +
    $"\n" +
    $"\n");

Console.WriteLine(" **********************************************");
Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine($"\n{"Итого:",-40}{"139.00"}");
Console.ResetColor();
Console.WriteLine($"\n" +
    $"\n{" ",-4}{"Электронные средства",-36}{"139.00",-10}" +
    $"\n{" ",-4}{"НДС итога чека с",-37}{"10.53",-10}" +
    $"\n{" ",-4}{"расчитанной ставкой",-36}" +
    $"\n{" ",-4}{"18%"}" +
    $"\n{" ",-4}{"НДС итога чека с",-37}{"6.36",-10}" +
    $"\n{" ",-4}{"расчитанной ставкой",-36}" +
    $"\n{" ",-4}{"10%"}" +
$"\n" +
   $"\n");

Console.WriteLine(" **********************************************" + $"\n" +
    $"\n{" ",-4}{"ВИД НАЛОГООБЛОЖЕНИЯ: ОСН"}" +
    $"\n{" ",-4}{"РЕГ. НОМЕР ККТ: 0000143873023483"}" +
    $"\n{" ",-4}{"ЗАВОД №:"}" +
    $"\n{" ",-4}{"ФН №: 8710000100265168"}" +
    $"\n{" ",-4}{"ФД №:6026"}" + $"\n{" ",-4}{"ФПД: 3322278314"}" 
    );






