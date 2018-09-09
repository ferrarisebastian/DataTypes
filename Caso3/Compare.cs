using System;

namespace DataTypes.Caso3
{
    /// <summary>
    /// Comparamos un tipo User
    /// </summary>
    public static class Compare
    {
        public static void Start()
        {
            
            User user1 = new User { Id = "1", Name = "Juan" };
            User user2 = user1;
            Console.WriteLine($"\n********************* {user1.GetType().Name} - Es de Tipo por {(user1.GetType().IsValueType ? "VALOR" : "REFERENCIA")}\n\n- Valores iniciales:\nUser user1 = new User ( Id = '1',Name = 'Juan' );\nUser user2 = user1;\n\nResultado:\nuser1.Name = {user1.Name};\nuser2.Name = {user2.Name};");
            SetValuesUser(user1, user2);
            Console.WriteLine($"Resultado:\nuser1.Name = {user1.Name};\nuser2.Name = {user2.Name};");
        }

        private static void SetValuesUser(User user1, User user2)
        {
            user1.Name = "Pedro";
            user2.Name = "Jose";

            Console.WriteLine("\n- Seteamos nuevos valores:\nuser1.Name = 'Pedro';\nuser2.Name = 'Jose';\n");
        }
    }
}
