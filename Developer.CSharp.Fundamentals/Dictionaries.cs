using System.Collections.Generic;

namespace Developer.CSharp.Fundamentals
{
    public class Dictionaries
    {
        // Dictionaries are special lists, whereas every value in the list has a key which is also a variable. 
        // A good example for a dictionary is a phone book.

        // Notice that when defining a dictionary, we need to provide a generic definition with two types
        //  - the type of the key and the type of the value. 
        // In this case, the key is a string whereas the value is an integer.

        // There are two ways of adding a single value to the dictionary, 
        // either using the brackets operator or using the Add method.

        private readonly Dictionary<string, long> _phoneBook = new Dictionary<string, long>();

        public void AddToDictionary()
        {
            _phoneBook.Add("Alex", 4154346543);
            _phoneBook["Jessica"] = 4159484588;
        }

        public void AddToDictionaryViaBrackets()
        {
            var phoneBook = new Dictionary<string, long>  // var --> Dictionary<string, long>
            {
                { "Alex", 415434543 }
            };
            phoneBook["Jessica"] = 415984588;

            if (phoneBook.ContainsKey("Alex"))
            {
                var result = "Alex's number is " + phoneBook["Alex"];
            }
        }

        public void RemoveFromDictionary()
        {
            var phonebook = new Dictionary<string, long>
            {
                { "Alex", 415434543 }
            };  // var --> Dictionary<string, long>
            phonebook["Jessica"] = 415984588;

            phonebook.Remove("Jessica");
        }
        // FOR MORE INFORMATION: http://www.learncs.org/en/Dictionaries
    }
}