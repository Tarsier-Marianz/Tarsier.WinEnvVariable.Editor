using System;
using System.Text.RegularExpressions;

namespace Tarsier.Config {
    internal static class StringUtils {
        internal static String ToSafeString(this object obj) {
            return obj != null ? obj.ToString().Trim() : String.Empty;
        }

        internal static String ToStringType(this String value) {
            return String.Format("'{0}'", value.EscapeQuote());
        }

        internal static string ToTriggerString(this string argValue, string defaultValue) {
            return string.IsNullOrEmpty(argValue.ToSafeString()) ? defaultValue : argValue;
        }

        internal static String EscapeQuote(this String value) {
            value = value.ToSafeString().Trim();
            if(!(String.IsNullOrEmpty(value))) {
                return value.Replace("'", "''");
            }
            return String.Empty;
        }

        internal static string RemoveNonAlphaNumeric(this object value) {
            return value.ToSafeString().RemoveNonAlphaNumeric();
        }

        internal static string RemoveNonAlphaNumeric(this string value) {
            Regex regex = new Regex("[^a-zA-Z0-9]");
            return regex.Replace(value, string.Empty);
        }

        internal static string TrimDashes(this string value) {
            if(String.IsNullOrEmpty(value)) {
                return String.Empty;
            }
            return Regex.Replace(value.Trim(), "-{2,}", "-");
        }

        internal static string TrimUnderscore(this string value) {
            if(String.IsNullOrEmpty(value)) {
                return String.Empty;
            }
            return Regex.Replace(value.Trim(), "_{2,}", "_");
        }
        internal static string ReplaceUnderscore(this string value) {
            if(String.IsNullOrEmpty(value)) {
                return String.Empty;
            }
            return Regex.Replace(value.TrimDashes(), "-", "_");
        }
        internal static string RemoveSpaces(this string value) {
            if(String.IsNullOrEmpty(value)) {
                return String.Empty;
            }
            return value.Trim().Replace(" ", "");
        }

        internal static string ParseDollarSign(this string sheetName) {
            if(String.IsNullOrEmpty(sheetName)) {
                return String.Empty;
            }
            string[] array = sheetName.Split(new char[] { '$' });
            return array[0];
        }

        public static string ToAlphaOnly(this string input) {
            Regex rgx = new Regex("[^a-zA-Z]");
            return rgx.Replace(input, "");
        }

        public static string ToNumericOnly(this string input) {
            Regex rgx = new Regex("[^0-9]");
            return rgx.Replace(input, "");
        }

        internal static string GetTabs(this int count) {
            return RepeatChar('\t', count);
        }

        internal static string GetSpaces(this int count) {
            return RepeatChar(' ', count);
        }

        internal static string RepeatChar(this char character, int count) {
            count = (count < 0) ? 0 : count;
            return new String(character, count);
        }

        internal static string TruncatePath(this string path) {
            if(Regex.IsMatch(path, "^(\\w+:|\\\\)(\\\\[^\\\\]+\\\\).*(\\\\[^\\\\]+\\\\[^\\\\]+)$"))
                return Regex.Replace(path, "^(\\w+:|\\\\)(\\\\[^\\\\]+\\\\).*(\\\\[^\\\\]+\\\\[^\\\\]+)$", "$1$2...$3");
            return path;
        }

    }
}

