

namespace lands.Interfaces
{
    using System.Globalization;

    public interface Ilocalize
    {
        CultureInfo GetCurrentCultureInfo();

        void setLocale(CultureInfo ci);
    }
}
