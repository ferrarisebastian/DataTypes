using System;

namespace DataTypes.Caso1
{
    /// <summary>
    /// Comparamos un tipo int
    /// </summary>
    public static class Compare
    {
        public static void Start()
        {
            int int1 = 99;
            int int2 = int1;
            Console.WriteLine($"\n********************* {int1.GetType().FullName} - Es de Tipo por {(int1.GetType().IsValueType ? "VALOR" : "REFERENCIA")}\n\n- Valores iniciales:\nint int1 = 99;\nint int2 = int1;\n\nResultado:\nint1 = {int1};\nint2 = {int2};");
            SetValuesInt(int1, int2);
            Console.WriteLine($"Resultado:\nint1 = {int1};\nint2 = {int2};");
        }

        private static void SetValuesInt(int int1, int int2)
        {
            int1 = 22;
            int2 = 33;

            Console.WriteLine("\n- Seteamos nuevos valores dentro de un método:\nint1 = 22;\nint2 = 33;\n");
        }
    }
}
