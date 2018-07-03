namespace appnet461
{
    class Program
    {
        static void Main(string[] args)
        {
            var msgs =
                new string[]
                    { "hello from appnet35",
                      libnet20.LibNet20.Hello(),
                      libnet35.LibNet35.Hello(),
                      libnet461.LibNet461.Hello(),
                      libnetstandard16.LibNetStandard16.Hello(),
                      //Uncomment this line to see msbuild error
                      //libnetstandard.LibNetStandard.Hello(),
                      //Can't reference libnetcore11 +
                    };

            System.Console.WriteLine(System.String.Join(System.Environment.NewLine, msgs));
            System.Console.ReadLine();
        }
    }
}
