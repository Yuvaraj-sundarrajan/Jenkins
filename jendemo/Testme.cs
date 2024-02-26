namespace jendemo
{
    public class Testme
    {
        public string SayJenkins(int times)
        {
            String Output = "";
            for (int i = 0; i < times; i++)
            {
                Output += "Hello Jenkins";
            }
            return Output;
        }
    }
}
