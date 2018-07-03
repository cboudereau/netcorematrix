namespace appnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            var msgs =
                new string[]
                    { "hello from appnetcore",
                      libnet20.LibNet20.Hello(),
                      libnet35.LibNet35.Hello(),
                      libnet461.LibNet461.Hello(),
                      libnetcore.LibNetCore.Hello(),
                      libnetcore11.LibNetCore11.Hello(),
                      libnetstandard.LibNetStandard.Hello(),
                      libnetstandard16.LibNetStandard16.Hello()
                    };

            System.Console.WriteLine(System.String.Join(System.Environment.NewLine, msgs));
            System.Console.ReadLine();
        }
    }
}
