using System.Collections.Generic;

namespace Slave.TranslatorPlugin
{
	public class LanguagePair
	{
	    public string Code { get; set; }

	    public string Caption { get; set; }


	    public LanguagePair(string code, string caption)
		{
			Code = code;
			Caption = caption;
		}

		public static List<LanguagePair> GoogleLanguagePairs
		{
			get
			{
			    var lps = new List<LanguagePair> {
			        new LanguagePair("zh|en", "Du chinois simpl. vers l'anglais"),
			        new LanguagePair("zt|en", "Du chinois trad. vers l'anglais"),
			        new LanguagePair("en|zh", "De l'anglais vers le chinois simpl."),
			        new LanguagePair("en|zt", "De l'anglais vers le chinois trad."),
			        new LanguagePair("en|nl", "De l'anglais vers le hollandais"),
			        new LanguagePair("en|fr", "De l'anglais vers le fran�ais"),
			        new LanguagePair("en|de", "De l'anglais vers l'allemand"),
			        new LanguagePair("en|el", "De l'anglais vers le grec"),
			        new LanguagePair("en|it", "De l'anglais vers l'italien"),
			        new LanguagePair("en|ja", "De l'anglais vers le japonais"),
			        new LanguagePair("en|ko", "De l'anglais vers cor�en"),
			        new LanguagePair("en|pt", "De l'anglais vers le portugais"),
			        new LanguagePair("en|ru", "De l'anglais vers le russe"),
			        new LanguagePair("en|es", "De l'anglais vers l'espagnol"),
			        new LanguagePair("nl|en", "Du hollandais vers l'anglais"),
			        new LanguagePair("nl|fr", "Du hollandais vers le fran�ais"),
			        new LanguagePair("fr|en", "Du fran�ais vers l'anglais"),
			        new LanguagePair("fr|de", "Du fran�ais vers l'allemand"),
			        new LanguagePair("fr|el", "Du fran�ais vers le grec"),
			        new LanguagePair("fr|it", "Du fran�ais vers l'italien"),
			        new LanguagePair("fr|pt", "Du fran�ais vers le portugais"),
			        new LanguagePair("fr|nl", "Du fran�ais vers le hollandais"),
			        new LanguagePair("fr|es", "Du fran�ais vers l'espagnol"),
			        new LanguagePair("de|en", "De l'allemand vers l'anglais"),
			        new LanguagePair("de|fr", "De l'allemand vers le fran�ais"),
			        new LanguagePair("el|en", "Du grec vers l'anglais"),
			        new LanguagePair("el|fr", "Du grec vers le fran�ais"),
			        new LanguagePair("it|en", "De l'italien vers l'anglais"),
			        new LanguagePair("it|fr", "De l'italien vers le fran�ais"),
			        new LanguagePair("ja|en", "Du japonais vers l'anglais"),
			        new LanguagePair("ko|en", "Du cor�en vers l'anglais"),
			        new LanguagePair("pt|en", "Du portugais vers l'anglais"),
			        new LanguagePair("pt|fr", "Du portugais vers le fran�ais"),
			        new LanguagePair("ru|en", "Du russe vers l'anglais"),
			        new LanguagePair("es|en", "De l'espagnol vers l'anglais"),
			        new LanguagePair("es|fr", "De l'espagnol vers le fran�ais")
			    };
			    return lps;
			}
		}
	}
}
