using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;


namespace XMLReaderClass
{
    public class Reader
    {
        XmlReaderSettings mySettings;

        public Reader()
        {
            mySettings = new XmlReaderSettings();
            mySettings.IgnoreComments = true;
            mySettings.IgnoreWhitespace = true;
            mySettings.CheckCharacters = true;
        }

        public Reader(bool comments, bool whitespaces, bool checkchar)
        {
            mySettings = new XmlReaderSettings();
            mySettings.IgnoreComments = comments;
            mySettings.IgnoreWhitespace = whitespaces;
            mySettings.CheckCharacters = checkchar;
        }

        public XmlReader CreateXMLReader(string fileName)
        {
            FileStream myFS = new FileStream(fileName, FileMode.Open);
            XmlReader myReader = XmlReader.Create(myFS, mySettings);
            return myReader;
        }

        public XmlReader CreateXMLReader(FileStream fs)
        {
            XmlReader myReader = XmlReader.Create(fs, mySettings);
            return myReader;
        }
    }
}
