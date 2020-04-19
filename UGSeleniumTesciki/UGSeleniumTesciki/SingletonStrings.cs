using System.IO;

namespace UGSeleniumTesciki
{
    public class SingletonStrings
    {
        private static readonly SingletonStrings instance = new SingletonStrings();
        private const string KRZYSZTOF_CHROME_EXE = @"C:\Program Files (x86)\Google\Chrome\Application";
        private const string KAROL_CHROME_EXE = @"D:\Selenium\chromedriver_win32";

        public const string DISCORD_PATH = @"https://support.discordapp.com/hc/en-us";
        public const string LIGO_LEGO_PATH = @"https://auth.riotgames.com/login#client_id=rso-web-client-prod&login_hint=eune&redirect_uri=https%3A%2F%2Flogin.leagueoflegends.com%2Foauth2-callback&response_type=code&scope=openid&state=yEMI3eYDKlVzhovK4CRsxIZxf0JVEXSbc6r5rDg9byQ&ui_locales=en-pl";
        public const string POGODA_INTERIA_PATH = @"https://pogoda.interia.pl/prognoza-szczegolowa-gdansk,cId,8048";
        public const string WZR_UG_PATH = @"https://wzr.ug.edu.pl/studia/index.php?str=1879";
       
        public readonly string PATH_CHROME_EXE;

        // Explicit static constructor to tell C# compiler  
        // not to mark type as beforefieldinit  
        static SingletonStrings()
        {
        }

        private SingletonStrings()
        {
            if (Directory.Exists(KAROL_CHROME_EXE))
                PATH_CHROME_EXE = KAROL_CHROME_EXE;
            else if (Directory.Exists(KRZYSZTOF_CHROME_EXE))
                PATH_CHROME_EXE = KRZYSZTOF_CHROME_EXE;
        }
        public static SingletonStrings Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
