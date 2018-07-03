namespace libnetstandard
{
    public class LibNetStandard
    {
        public static string Hello()
        {
            var msgs =
                new string[]
                    { "hello from libnetstandard + internal dependencies",
                      libnet20.LibNet20.Hello(),
                      libnet35.LibNet35.Hello(),
                      libnet461.LibNet461.Hello(),
                      libnetstandard16.LibNetStandard16.Hello()
                    };

            return System.String.Join(System.Environment.NewLine, msgs);
        }
    }
}
