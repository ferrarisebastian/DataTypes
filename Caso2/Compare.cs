using System;

namespace DataTypes.Caso2
{
    /// <summary>
    /// Comparamos un tipo string
    /// </summary>
    public static class Compare
    {
        public static void Start()
        {
            string string1 = "99";
            string string2 = string1;
            Console.WriteLine($"\n********************* {string1.GetType().FullName} - Es de Tipo por {(string1.GetType().IsValueType ? "VALOR" : "REFERENCIA")}\n\nValores iniciales:\nstring string1 ='99';\nstring string2 = string1;\n\nResultado:\nstring1 = {string1};\nstring2 = {string2};");
            SetValuesString(string1, string2);
            Console.WriteLine($"Resultado Final:\nstring1 = {string1};\nstring2 = {string2};");
        }

        private static void SetValuesString(string string1, string string2)
        {
            string1 = "22";
            string2 = "33";

            Console.WriteLine("\nSeteamos nuevos valores:\nstring1 = '22';\nstring2 = '33';\n");
        }
    }
}
