using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace app.HeadFirstDesignPatterns.DecoratorPattern
{
    public class LowerCaseInputStream : TextReader
    {
        private TextReader _source;

        public LowerCaseInputStream(TextReader source)
        {
            _source = source;
        }

        public override int Read()
        {
            int c = _source.Read();
            return (c == -1 ? c : Char.ToLower((char)c));
        }

        public override int Read(char[] b, int index, int count)
        {
            int result = _source.Read(b, index, count);
            for (int i = index; i < index + result; i++)
            {
                b[i] = b[i];
                //Convert.ToByte(System.Text.Encoding.UTF8.GetString(buffer[i]).ToCharArray());
            }
            return result;
        }
    }
}