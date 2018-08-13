using System;

namespace DataTypes
{
    public static class SetValuesHelper
    {
        public static void SetValuesInt(int int1, int int2)
        {
            int1 = 22;
            int2 = 33;

            Console.WriteLine("\nSeteamos nuevos valores:\nint1 = 22;\nint2 = 33;\n");
        }

        public static void SetValuesString(string string1, string string2)
        {
            string1 = "22";
            string2 = "33";

            Console.WriteLine("\nSeteamos nuevos valores:\nstring1 = '22';\nstring2 = '33';\n");
        }

        public static void SetValuesUser(User user1, User user2)
        {
            user1.Name = "Pedro";
            user2.Name = "Jose";

            Console.WriteLine("\nSeteamos nuevos valores:\nuser1.Name = 'Pedro';\nuser2.Name = 'Jose';\n");
        }
    }
}
