using System;

namespace Defining2
{
    // classes have a name, unique within the namespace
    public class Book
    {
        // TODO: classes have member variables, or "fields" to hold data
        string _name;
        string _author;
        int _numPages;


        // TODO: classes have one or more constructors
        public Book(string name, string author, int numPages) {
            _name = name;
            _author = author;
            _numPages = numPages;
        }


        // TODO: methods are used to operate on the class and data
        public void Describe() {
            Console.WriteLine($"{_name} written by {_author} with {_numPages} pages.");
        }

    }
}
