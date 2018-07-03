namespace libnetcore
{
    public static class LibNetCore
    {
        public static string Hello()
        {
            var msgs =
                new string[]
                    { "hello from libnetcore + internal dependencies",
                      libnet20.LibNet20.Hello(),
                      libnet35.LibNet35.Hello(),
                      libnet461.LibNet461.Hello(),
                      libnetcore11.LibNetCore11.Hello(),
                      libnetstandard.LibNetStandard.Hello(),
                      libnetstandard16.LibNetStandard16.Hello()
                    };

            return System.String.Join(System.Environment.NewLine, msgs);
        }
    }
}
