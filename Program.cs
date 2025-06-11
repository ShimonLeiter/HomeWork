namespace HW49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] color = { "red", "green", "blue" };
            string[] patterns = { "stripped", "checked", "plain" };

            for (int i = 0; i < patterns.Length; i++)
            {
                for (int k = 0; k < patterns.Length; k++)
                {

                    Shirt shirt = new Shirt(color[i], patterns[k]);

                }
            }



        }
    }
}
