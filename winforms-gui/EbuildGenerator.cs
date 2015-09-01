namespace WinFormsGUI
{
	using System;
	using System.IO;
	using System.Text;
	using System.Diagnostics;
	using ICSharpCode.TextEditor;
	using TemplateEngine;


	static class EbuildGenerator
	{
		public static void GenerateEbuildText(this TextEditorControl editor, string url, string sha1, string ebuildclass, string ebuildname)
		{
			//var query = new StringBuilder(4000);
			//query.AppendFormat ("url={1}{0}sha1={2}{0}ebuildclass={3}{0}ebuildname={4}", "&", url, sha1, ebuildclass, ebuildname);
			//Trace.WriteLine (TemplateEngine.GetPhysicalRoot ());
			//var content = TemplateEngine2.ProcessRequest("test1.aspx", query.ToString());
			var text = new StringBuilder(4096);
			text.AppendLine (string.Format("# Copyright 1999-{0} Gentoo Foundation", DateTime.Now.Year));
			text.AppendLine ("# Distributed under the terms of the GNU General Public License v2");
			text.AppendLine ("# $Id$");
			text.AppendLine ();
			text.AppendLine ("EAPI=5"); // как узнать текущий EAPI ?
			text.AppendLine ("inherit mono-env nuget dotnet"); // как придумать, какие пакеты нужны, глядя на репозиторий?
			text.AppendLine ();
			text.AppendLine (string.Format("NAME=\"{0}\"", ebuildname));
			text.AppendLine ("HOMEPAGE=\"https://github.com/nunit/${NAME}\"");
			text.AppendLine ();
			text.AppendLine (string.Format("EGIT_COMMIT=\"{0}\"", sha1));
			text.AppendLine ("SRC_URI=\"${HOMEPAGE}/archive/${EGIT_COMMIT}.zip -> ${PF}.zip\"");
			text.AppendLine ("S=\"${WORKDIR}/${NAME}-${EGIT_COMMIT}\"");
			text.AppendLine ();
			text.AppendLine ("SLOT=\"0\"");


			editor.Text = text.ToString();
		}
	}
}

