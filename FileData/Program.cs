using System;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Validator validator = new Validator();

            if (!string.IsNullOrEmpty(args[0]) && !string.IsNullOrEmpty(args[0]))
            {

                if (validator.isValid(args[0]) == Validator.Type.version)
                    Console.WriteLine(new ThirdPartyTools.FileDetails().Version(args[1]));
                else if (validator.isValid(args[0]) == Validator.Type.size)
                    Console.WriteLine(new ThirdPartyTools.FileDetails().Size(args[1]));
                else
                    Console.WriteLine("InValid");
            }

            Console.ReadLine();
        }
    }
}
