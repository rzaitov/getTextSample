using System;

using GNU.Gettext;

namespace GetTextNet
{
	public static class Text
	{
		public static readonly string MyNameIs = "__MyNameIs__";
		public static readonly string GoodFeet = "__GoodFeet__";
		public static readonly string PerfectFeet = "__PerfectFeet__";
		public static readonly string PluralDay = "__PluralDay__";
		public static readonly string PluralDays = "__PluralDays__";

		static void Dummy()
		{
			//GettextResourceManager c = new GettextResourceManager ();
			//c.GetPluralString ("__PluralDay__", "__PluralDays__", 1);

		}
	}
}

#if NEVERCOMPILE
GetString ("__MyNameIs__");
GetString ("__GoodFeet__");
GetString ("__PerfectFeet__");
GetPluralString ("__PluralDay__", "__PluralDays__", 0);
#endif
