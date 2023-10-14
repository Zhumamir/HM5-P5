using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ConsoleApp2
{

    class Program
    {
        // 1 задание
        //static async Task Main()
        //{
        //    string url = "https://hcsbk.kz/ru/";

        //    try
        //    {
        //        using (HttpClient httpClient = new HttpClient())
        //        {
        //            HttpResponseMessage response = await httpClient.GetAsync(url);

        //            if (response.IsSuccessStatusCode)
        //            {
        //                string content = await response.Content.ReadAsStringAsync();
        //                Console.WriteLine("Сайт есть, держи страничку: " + content);
        //            }
        //            else
        //            {
        //                Console.WriteLine("Ошибка: " + (int)response.StatusCode + " " + response.ReasonPhrase);
        //            }
        //        }
        //    }
        //    catch (HttpRequestException ex)
        //    {
        //        Console.WriteLine("Нет такого сайта ыыыааа: " + ex.Message);
        //    }
        //}



        // 2 задание
        //static void Main()
        //{
        //    int[] array = { 1, 2, 3, 4, 5 };
        //    int index = 5;

        //    try
        //    {
        //        int value = array[index];
        //        Console.WriteLine("Значение элемента с индексом " + index + " равно " + value);
        //    }
        //    catch (IndexOutOfRangeException ex)
        //    {
        //        Console.WriteLine("Произошла ошибка: " + ex.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Завершение обработки массива.");
        //    }
        //}



        // 3 задание
        //static void Main()
        //{
        //    try
        //    {
        //        GenerateException();
        //    }
        //    catch (CustomException ex)
        //    {
        //        Console.WriteLine("Произошла ошибка: " + ex.Message);
        //    }
        //}

        //static void GenerateException()
        //{
        //    Console.WriteLine("Метод GenerateException начал выполнение.");
        //    throw new CustomException("Это пользовательское исключение.");
        //    Console.WriteLine("Метод GenerateException завершил выполнение.");
        //}
        //public class CustomException : Exception
        //{
        //    public CustomException(string message) : base(message)
        //    {
        //        Console.WriteLine("ЫЫЫЫААААА");
        //    }
        //}

        // 4 задание
        static void Main()
        {
            try
            {
                MyClassA.MethodA();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка в методе Main: " + ex.Message);
            }
        }

    }


    // 4 задание
    class MyClassA
    {
        public static void MethodA()
        {
            Console.WriteLine("Метод MethodA начал выполнение.");

            try
            {
                throw new Exception("Исключение в методе MethodA");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка в методе MethodA: " + ex.Message);
                throw;
            }
        }
    }
}
