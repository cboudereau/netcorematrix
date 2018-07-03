namespace libnetstandard16
{
    public class LibNetStandard16
    {
        public static string Hello()
        {
            var msgs =
                new string[]
                    { "hello from libnetstandard16 + internal dependencies",
                      //libnet20.LibNet20.Hello(),
                      //libnet35.LibNet35.Hello(),
                      //libnet461.LibNet461.Hello(),
                      //libnet472.LibNet472.Hello(),
                    };

            return System.String.Join(System.Environment.NewLine, msgs);
        }
    }
}
