using System;
using System.Globalization;

using GNU.Gettext;

namespace GetTextNet
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			CultureInfo ci = new CultureInfo ("ru-RU");

			GettextResourceManager catalog = new GettextResourceManager ("MainCatalog");

			Console.WriteLine (catalog.GetString (Text.MyNameIs, ci));
			Console.WriteLine (catalog.GetString (Text.GoodFeet, ci));
			Console.WriteLine (catalog.GetString (Text.PerfectFeet, ci));

			for (int i = 0; i < 6; i++)
			{
				Console.WriteLine (catalog.GetPluralString(Text.PluralDay, Text.PluralDays, i, ci), i);
			}

			Console.ReadLine ();
		}
	}
}