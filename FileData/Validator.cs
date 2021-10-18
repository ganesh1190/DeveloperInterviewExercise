namespace FileData
{
    public class Validator
    {
        public Type isValid(string input) 
        {
            switch (input)
            {
                case "-v":
                case "--v":
                case "/v":
                case "--version":
                   return Type.version ;

                case "-s":
                case "--s":
                case "/s":
                case "--size":
                    return Type.size;

                default:
                    return Type.InValid;
            }
        }

        public enum Type
        {
            version,
            size,
            InValid
        }
    }
}
