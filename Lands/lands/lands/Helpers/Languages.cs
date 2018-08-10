namespace lands.Helpers
{
    using Xamarin.Forms;
    using Interfaces;
    using Resources;

    public class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<Ilocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<Ilocalize>().setLocale(ci);
        }

        public static string Error
        {
            get
            {
                return Resource.Error;
            }
        }

        public static string Accept
        {
            get
            {
                return Resource.Accept;
            }
        }

        public static string Emailvalidation
        {
            get
            {
                return Resource.EmailValidation;
            }
        }

        public static string Rememberme
        {
            get
            {
                return Resource.Rememberme;
            }
        }
        public static string EmailPlaceHolder
        {
            get
            {
                return Resource.EmailPlaceHolder;
            }
        }

        public static string PassPlaceHolder
        {
            get
            {
                return Resource.PassPlaceHolder;
            }
        }



    }
}
