using System.Text.RegularExpressions;
using System.Collections.Generic;

class FileReadProcess
{
    public static string ReadFile(string path)
    {          

        System.IO.TextReader reader = new System.IO.StreamReader(path);
        string text = reader.ReadToEnd();            
        reader.Close();
        return text;
    }

    //remove title and extract abstract from document
    public static string getAbstract(string text)
    {
        string titlePattern = @".T\n([\s\S]+?)\.A";
        try
        {
            string title = Regex.Match(text, titlePattern).Groups[1].ToString();
            text = text.Replace(title, "");
        }
        catch (System.ArgumentException e)
        {
            //title not found - do nothing
        }
       
        
        string pattern = @"[\s\S]+\.W([\s\S]+)";
        Match match = Regex.Match(text, pattern);
        return match.Groups[1].ToString();

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

