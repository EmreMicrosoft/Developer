using System;

namespace Developer.CSharp.Fundamentals.Notes
{
    public class CharacterConstants
    {
        /*  ****** CHARACTER CONSTANTS ******
            Character literals are enclosed in single quotes. 
            For example, 'x' and can be stored in a simple variable of char type. 
            A character literal can be a plain character (such as 'x'), an escape sequence (such as '\t'), or a universal character (such as '\u02C0').
            There are certain characters in C# when they are preceded by a backslash. They have special meaning and they are used to represent like newline (\n) or tab (\t). Here, is a list of some of such escape sequence codes −
            
                Escape sequence	        Meaning
                \\	                    \ character
                \'	                    ' character
                \"	                    " character
                \?	                    ? character
                \a	                    Alert or bell
                \b	                    Backspace
                \f	                    Form feed
                \n	                    Newline
                \r	                    Carriage return
                \t	                    Horizontal tab
                \v	                    Vertical tab
                \xhh . . .	            Hexadecimal number of one or more digits
        */
        
        //Following is the example to show few escape sequence characters:
        public static void Run()
        {
            Console.WriteLine("Hello\tWorld\n\n");
            Console.ReadLine();
        }

    }
}