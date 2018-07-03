namespace appnet20
{
    class Program
    {
        static void Main(string[] args)
        {
            var msgs = 
                new string [] 
                    { "hello from appnet20",
                      libnet20.LibNet20.Hello(),
                      libnet35.LibNet35.Hello(),
                      //Uncomment this line to see msbuild error
                      //libnet461.LibNet461.Hello() 
                    };

            System.Console.WriteLine(System.String.Join(System.Environment.NewLine, msgs));
            System.Console.ReadLine();
        }
    }
}
