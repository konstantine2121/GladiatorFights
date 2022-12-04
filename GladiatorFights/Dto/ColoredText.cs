using System;

namespace GladiatorFights.Dto
{
    public class ColoredText
    {
        public ConsoleColor FontColor;
        public string Text;

        public ColoredText(string text = "", ConsoleColor fontColor = ConsoleColor.White)
        {
            Text = text;
            FontColor = fontColor;
        }
    }
}
