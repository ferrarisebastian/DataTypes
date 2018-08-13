using System;

namespace DataTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int int1 = 99;
            int int2 = int1;
            var tipo = int1.GetType().IsValueType ? "VALOR" : "REFERENCIA";
            Console.WriteLine($"********************* {int1.GetType().FullName} - Es de Tipo por {tipo}\nValores iniciales:\nint int1 = 99;\nint int2 = int1;\n\nResultado:\nint1 = {int1};\nint2 = {int2};");
            SetValuesHelper.SetValuesInt(int1, int2);
            Console.WriteLine($"Resultado Final:\nint1 = {int1};\nint2 = {int2};");

            string string1 = "99";
            string string2 = string1;
            tipo = string1.GetType().IsValueType ? "VALOR" : "REFERENCIA";
            Console.WriteLine($"********************* {string1.GetType().FullName} - Es de Tipo por {tipo}\nValores iniciales:\nstring string1 ='99';\nstring string2 = string1;\n\nResultado:\nstring1 = {string1};\nstring2 = {string2};");
            SetValuesHelper.SetValuesString(string1, string2);
            Console.WriteLine($"Resultado Final:\nstring1 = {string1};\nstring2 = {string2};");

            User user1 = new User { Id = "1", Name = "Juan" };
            User user2 = user1;
            tipo = user1.GetType().IsValueType ? "VALOR" : "REFERENCIA";
            Console.WriteLine($"********************* {user1.GetType().FullName} - Es de Tipo por {tipo}\nValores iniciales:\nUser user1 = new User ( Id = '1',Name = 'Juan' );\nUser user2 = user1;\n\nResultado:\nuser1.Name = {user1.Name};\nuser2.Name = {user2.Name};");
            SetValuesHelper.SetValuesUser(user1, user2);
            Console.WriteLine($"Resultado Final:\nuser1.Name = {user1.Name};\nuser2.Name = {user2.Name};");

            Console.ReadLine();
        }
    }
}
