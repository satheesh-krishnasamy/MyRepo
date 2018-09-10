﻿namespace ReportGeneratorUtils
{
    using System.Net;
    using System.Text;

    internal abstract class ObjectToXmlConverterBase : IObjectToXmlConverter
    {
        public abstract void ConvertToXml(ref StringBuilder sb, IReportPart reportContentItem);

        internal static string GetHtmlEncodedString(string valueToEncode)
        {
            return WebUtility.HtmlEncode(valueToEncode);
        }
    }
}
