

namespace lands.Interfaces
{
    using System.Globalization;

    public interface Ilocalize
    {
        CultureInfo GetCultureInfo();

        void setLocale(CultureInfo ci);
    }
}
