using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Math.Polynomials
{
    public partial class Polynomial<T>
    {
        public string ToString(string format)
        {
            Polynomial<T> o = this;

            if (string.IsNullOrEmpty(format))
            {
                return o.ToString();
            }

            return o.ToString
                    (
                        format,
                        // System.Globalization.CultureInfo.CurrentCulture
                        new FormatProvider()
                    );
        }

        public string ToString(string format, FormatProvider provider)
        {
            Polynomial<T> o = this;
            string formatted = null;

            if (String.IsNullOrEmpty(format))
            {
                formatted = o.ToString();

                return formatted;
            }

            IFormatProvider ifp = null;

            if (provider == null)
            {
                ifp = provider.CurrentCulture;
            }
            else
            {
                formatted = provider.FormatMethod(o as PolynomialBase, format);
            }

            return formatted;
        }
    }
}
