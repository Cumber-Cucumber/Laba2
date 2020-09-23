using System;
using System.Text;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1) Типы ---------------------------------------------------------------------------------------------------------------------------

            ////a.

            //byte byte8 = 255;
            //sbyte sbyte8 = -128;
            //short short16 = -32768;
            //ushort ushort16 = 65535;
            //int int32 = -2147483648;
            //uint uint32 = 4294967295;
            //long long64 = -9223372036854775808;
            //ulong ulong64 = 18446744073709551615;
            //char char16 = 'я';
            //bool bool8 = true;
            //float float32 = 3456789098765.3452435243f;
            //double double64 = 2345687654323456789876543.45634563465457f;
            //decimal decimacl128 = 78987678765677656;
            //string string_ = "Help me oh my god";
            //Object object_1 = "Object";
            //Object object_2 = 8;


            //Console.WriteLine("byte: " + byte8);
            //Console.WriteLine("sbyte: " + sbyte8);
            //Console.WriteLine("short: " + short16);
            //Console.WriteLine("ushort: " + ushort16);
            //Console.WriteLine("int: " + int32);
            //Console.WriteLine("uint: " + uint32);
            //Console.WriteLine("long: " + long64);
            //Console.WriteLine("ulong: " + ulong64);
            //Console.WriteLine("char: " + char16);
            //Console.WriteLine("bool: " + bool8);
            //Console.WriteLine("float: " + float32);
            //Console.WriteLine("double: " + double64);
            //Console.WriteLine("decimal: " + decimacl128);
            //Console.WriteLine("string: " + string_);
            //Console.WriteLine("Object: " + object_1);
            //Console.WriteLine("Object: " + object_2);

            ////b.

            //byte np = 100;
            //short np_1 = np;
            //int np_2 = np_1;
            //long np_3 = np_2;
            //float np_d = 1.5f;
            //double np_4 = np_d;
            //double np_5 = np_1;

            //long yp = 100;
            //int yp_1 = (int)yp;
            //short yp_2 = (short)yp_1;
            //byte yp_3 = (byte)yp_2;
            //double yp_d = 1.5f;
            //float yp_4 = (float)yp_d;
            //float yp_5 = (float)yp;

            //bool convert_bool = true;
            //string convert_string = Convert.ToString(convert_bool);
            //Console.WriteLine("After convert: " + convert_string);

            ////c.

            //byte pancacke = 2;
            //Object box = pancacke; // Запаковка
            //byte unbox = (byte)pancacke; // Распаковка

            ////d.

            //int? nullable = null;
            //Console.WriteLine(nullable ?? 1);

            ////e.

            //var number = 10;
            //number = 12.12;


            ////2) Строки ----------------------------------------------------------------------------------------------------------------------

            ////a.

            //string str1 = "aaaaaaaaaaaaa";
            //string str2 = "aaaaaaaaaaaaabbbbbbbbbb";
            //Console.WriteLine(String.Compare(str1, str2));

            //b.

            //string str1 = "aaaa aaaaa aaaa aa";
            //string str2 = "bbbbbbbbbbbbbbb";
            //string str3 = "ccccccccccccccc";

            //string concat_str = str1 + str2 + str3; // Cцепление/конкатинация
            //Console.WriteLine(concat_str);

            //string copy_str = str1;
            //Console.WriteLine(copy_str + " = " + str1); // Копирование

            //string sub_str = str1.Substring(0, 10); // Выделение подстроки
            //Console.WriteLine(sub_str);

            //string[] split_str = str1.Split(new char[] { ' ' }); // Разбиение на слова
            //foreach (string word in split_str)
            //{
            //    Console.WriteLine(word);
            //}

            //string ins_str = str1.Insert(3, str2); // Вставка подстроки в заданную позицию
            //Console.WriteLine(ins_str);

            //string delet_str = str1.Substring(5); // Удаление подстроки
            //Console.WriteLine(delet_str);

            //Console.WriteLine($"{str1}\n  {str2}\n {str3}"); // Интерполирование

            ////c.

            //string str1 = null; // Нулевая строка - плохая, почти ничего нельзя делать
            //string str2 = ""; // Пустая строка - хорошая, можно делать почти всё
            //string str3 = "aaaaaaaaaaaaaa";

            //bool chek_null_and_emty_or_not = String.IsNullOrEmpty(str1);
            //Console.WriteLine(" 1 string: " + chek_null_and_emty_or_not);
            //chek_null_and_emty_or_not = String.IsNullOrEmpty(str2);
            //Console.WriteLine(" 2 string: " + chek_null_and_emty_or_not);
            //chek_null_and_emty_or_not = String.IsNullOrEmpty(str3);
            //Console.WriteLine(" 3 string: " + chek_null_and_emty_or_not);

            ////d.

            //StringBuilder str = new StringBuilder("Сcucummbers");

            //str.Remove(1, 1);
            //str.Remove(6, 1);

            //str = str.Insert(0, "Oh my god is that a cucumber? "); // Вставка в начало
            //str = str.AppendFormat(" is incredibly useful product because of its usefulness. Delicious"); // Вставка в конец
            //Console.WriteLine(str);


            ////3) Массивы --------------------------------------------------------------------------------------------------------------------

            ////a.

            //int[,] array_2x2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; // Двумерный массив
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(" " + array_2x2[i, j]);
            //    }
            //    Console.WriteLine("");
            //}

            ////b.

            //string[] arr_str = { "aaaaaaa", "bbbbbbb", "ccccccc", "ddddddd", "eeeeeee", "fffffff" }; // Массив строк
            //for (int i = 0; i < arr_str.Length; i++)
            //{
            //    Console.WriteLine(arr_str[i]);
            //}

            //Console.WriteLine("Length: " + arr_str.Length + "\n");
            //Console.WriteLine("Replacement item number: ");

            //int replacement_item_number;
            //while (true)
            //{
            //    string read_replacement_item_number = Console.ReadLine();
            //    replacement_item_number = Convert.ToInt32(read_replacement_item_number);

            //    if (replacement_item_number > 0 && replacement_item_number <= arr_str.Length)
            //        break;
            //    else
            //    {
            //        Console.WriteLine("Incorrect item number, try again: ");
            //        continue;
            //    }
            //}

            //replacement_item_number--;

            //Console.WriteLine("Change to: ");

            //string read_new_item = Console.ReadLine();
            //arr_str[replacement_item_number] = read_new_item;

            //for (int i = 0; i < arr_str.Length; i++)
            //{
            //    Console.WriteLine(arr_str[i]);
            //}

            ////c.

            //int[][] arr_stepped = new int[3][]; // Ступенчатый массив
            //arr_stepped[0] = new int[2];
            //arr_stepped[1] = new int[3];
            //arr_stepped[2] = new int[4];
            //int number;

            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("Enter " + i + " element in first line: ");
            //    string read_number = Console.ReadLine();
            //    number = Convert.ToInt32(read_number);
            //    arr_stepped[0][i] = number;
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter " + i + " element in second line: ");
            //    string read_number = Console.ReadLine();
            //    number = Convert.ToInt32(read_number);
            //    arr_stepped[1][i] = number;
            //}

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Enter " + i + " element in third line: ");
            //    string read_number = Console.ReadLine();
            //    number = Convert.ToInt32(read_number);
            //    arr_stepped[2][i] = number;
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    Console.Write(arr_stepped[0][i] + " ");
            //}
            //Console.WriteLine("");

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write(arr_stepped[1][i] + " ");
            //}
            //Console.WriteLine("");

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.Write(arr_stepped[2][i] + " ");
            //}
            //Console.WriteLine("");

            ////d.

            //var str_nt = "aaaaaaaaaaaaaaaa";
            //var arr_nt = new[] { 1, 2, 3 };


            ////4) Кортежи ----------------------------------------------------------------------------------------------------------------------

            ////a.

            //(int, string, char, string, ulong) kor = (10, "aaaaaaa", 'b', "ccccccc", 10000000000);

            ////b.
            //Console.WriteLine(kor);

            //Console.WriteLine(kor.Item1);
            //Console.WriteLine(kor.Item3);
            //Console.WriteLine(kor.Item4);

            ////c.

            //var kor_item_1 = kor.Item1;
            //var kor_item_2 = kor.Item2;
            //var kor_item_3 = kor.Item3;
            //var kor_item_4 = kor.Item4;
            //var kor_item_5 = kor.Item5;

            //var (kor_item_1_2, kor_item_2_2, kor_item_3_2, kor_item_4_2, kor_item_5_2) = (kor.Item1, kor.Item2, kor.Item3, kor.Item4, kor.Item5);

            //var (_, _, a, b, _) = ("Name", "Lastname", "Age", "Work", "Status");
            //Console.WriteLine(a + " " + b);

            ////d.

            //var kor_1 = (1, 2);
            //var kor_2 = (3, 2);
            //Console.WriteLine(kor_1 == kor_2);
            //Console.WriteLine(kor_1 != kor_2);

            //// Локальная функция --------------------------------------------------------------------------------------------------------------

            //int[] array = { 1, 15, 44, 3 };
            //string str = "aaaaaaaaaaaaaaaaa";

            //var kor_result = local_function(array, str);
            //Console.WriteLine(kor_result);

            //static (int, int, int, char) local_function(int[] arr, string st)
            //{
            //    int max = 0, max_num = 0;
            //    int min = 10000, min_num = 0;

            //    for (int i = 1; i < arr.Length; i++) // Максимальный элемент  
            //    {
            //        if (arr[max_num] < arr[i])
            //        {
            //            max = arr[i];
            //            max_num++;
            //        }
            //    }

            //    for (int i = 1; i < arr.Length; i++) // Минимальный элемент
            //    {
            //        if (arr[min_num] > arr[i])
            //        {
            //            min = arr[i];
            //            min_num++;
            //        }
            //    }

            //    int sum = 0;

            //    for (int i = 0; i < arr.Length; i++) // Сумма элементов массива
            //    {
            //        sum += arr[i];
            //    }

            //    char first_symbol;

            //    first_symbol = Convert.ToChar(st.Substring(0, 1)); // Первый символ
            //    var kor = (max, min, sum, first_symbol);

            //    return kor;
            //}


            ////6) Checked / unchecked --------------------------------------------------------------------------------------------------------

            //Console.WriteLine(func_chek());
            //Console.WriteLine(func_unchek());

            //static byte func_chek() 
            //{
            //    byte num = 255;
            //    //byte a = checked((byte)(num + 1)); // Исключение, т.к. произошло переполнение
            //    byte a = checked(num);
            //    return num;
            //}

            //static byte func_unchek()
            //{
            //    byte a;
            //    byte num = 255;
            //    a = unchecked((byte)(num + 1)); // Исключения нет
            //    return num;
            //}
        }
    }
}
