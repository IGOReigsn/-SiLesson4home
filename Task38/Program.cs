/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76  */

// -------------------МЕТОДЫ----------------------------------------------------------------------------
// -------------------МЕТОДЫ ВЗЯТЫЕ ИЗ ПРЕДЫДУЩИХ ЗАДАНИЙ----------------------------------------------------------------------------
int InputNumber(string qwerStr)//проверяет "численность"."Не выпускает" без ввода ЧИСЛА
    {int num;
    string? text;
    while(true)
        {
            Console.WriteLine(qwerStr);
            text=Console.ReadLine();
           if(int.TryParse(text,out num)) break;
           Console.WriteLine("Введено некорректное значение.Попробуйте еще раз"); 
        }
    return num;  
    }
//------------------------------------------------------------------------------------------------------
int InputNumberWithFilter(string qwerStr, bool zeroEnable, bool negativEnable)//Пропускает положительные. 0 и отрицательные пропускает в соответствии со булевыми значениями zeroEnable,negativEnable
    {int num;
    while(true)
        {
            num=InputNumber(qwerStr);//проверяет "численность"."Не выпускает" без ввода ЧИСЛА
           if(num>0 || num==0 && zeroEnable || num<0 && negativEnable) break;
           Console.WriteLine("Введено не разрешенное значение.Попробуйте еще раз"); 
        }
    return num;  
    }
// -------------------МЕТОДЫ НАПИСАННЫЕ ДЛЯ ТЕКУЩЕГО ЗАДАНИЯ----------------------------------------------------------------------------
void PrnArrayDouble(double[] array) // ВЫВОД МАССИВА НА ПЕЧАТЬ
    {
    System.Console.WriteLine("[ "+String.Join(", ",array)+"]");
    }
//------------------------------------------------------------------------------------------------------
void RandomsArrayDouble(double[] array, int min, int max) // МАССИВ - ЗАПОЛНЕНИЕ СЛУЧАЙНЫМИ ЧИСЛАМИ. MAX - МАКСИМАЛЬНО ДОПУСТИМОЕ ЧИСЛО
    {
    Random rnd = new Random();
    for (int i=0;i<array.Length;i++)  { array[i] = Math.Round((rnd.Next(min,max+1)+rnd.NextDouble()),3);} 
    }
//------------------------------------------------------------------------------------------------------
double DifferentsMinMaxInArray(double[] array) //Разность от максимума до минимума в массиве
    {
    double min =array[0], max=array[0];
    for (int i=0; i<array.Length; i++)
        {
            if (array[i]>max) {max=array[i];}
            else if (array[i]<min) {min=array[i];}
        }
    return (max-min);
    }
//------------------------------------------------------------------------------------------------------
// -------------------ОСНОВНАЯ ПРОГРАММА----------------------------------------------------------------------------

int size=InputNumberWithFilter("Введите размер массива :",false,false);
double [] ar =new double[size];
RandomsArrayDouble(ar,0,99);
PrnArrayDouble(ar);
Console.WriteLine ("Разность от максимума до минимума в массиве: "+ DifferentsMinMaxInArray(ar));
