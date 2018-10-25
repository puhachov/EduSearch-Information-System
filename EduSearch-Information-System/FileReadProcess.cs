using System.Text.RegularExpressions;
using System.Collections.Generic;

class FileReadProcess
{

    const string DOC_TITLE = "Title";
    const string DOC_AUTHOR = "Author";
    const string DOC_BIB = "Bibliography";
    const string DOC_BODY = "Body";
    const string DOC_ID = "ID";

    public static string ReadFile(string path)
    {

        System.IO.TextReader reader = new System.IO.StreamReader(path);
        string text = reader.ReadToEnd();
        reader.Close();
        return text;
    }

    public static Dictionary<string, string> getDocumentParts(string document) {
        Dictionary<string, string> documentObj = new Dictionary<string, string>();

        string docNo = getSection(document, @".I([\s\S]+?)\.T");
        string title = getSection(document, @".T\n([\s\S]+?)\.A");
        title = title.Replace('\n', ' ');
        string author = getSection(document, @".A\n([\s\S]+?)\.B");
        string bib = getSection(document, @".B\n([\s\S]+?)\.W");
        string body = getSection(document, @"\.W([\s\S]+)");

        body = ReplaceFirstOccurrence(body,title,"");
        body = body.Replace('\n', ' ');
        body = char.ToUpper(body[0]) + body.Substring(1);

        documentObj.Add(DOC_ID, docNo);
        documentObj.Add(DOC_TITLE, title);
        documentObj.Add(DOC_AUTHOR, author);
        documentObj.Add(DOC_BIB, bib);
        documentObj.Add(DOC_BODY, body);

        return documentObj;
    }

    //remove title and extract abstract from document
    public static string getSection(string text, string sectionPattern)
    {
        string section = "";
        try
        {
            section = Regex.Match(text, sectionPattern).Groups[1].ToString();
            section.Replace('\n', ' ');
        }
        catch (System.ArgumentException e)
        {
            //title not found - do nothing
        }

        return section;
    }

    public static string ReplaceFirstOccurrence(string Source, string Find, string Replace)
    {
        int Place = Source.IndexOf(Find);
        string result = Source;
        if (Place > -1)
        {
            result = Source.Remove(Place, Find.Length);
        }
        return result;
    }

    //extract information needs into a List
    public static List<string> getInformationNeeds(string text)
    {
        List<string> results = new List<string>();
        string pattern = @"\.D\n([\s\S]+?).I ([0-9]{3})";
        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches)
        {
            results.Add(match.Groups[1].ToString());
        }

        //add the last information need
        string lastMatchPattern = @"[\s\S]+\.D\n([\s\S]+)";
        Match lastMatch = Regex.Match(text, lastMatchPattern);
        results.Add(lastMatch.Groups[1].ToString());

        return results;

    }
}

