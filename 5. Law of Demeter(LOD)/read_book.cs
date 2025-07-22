using System;

class Read {
    public void ReadContent() {
        Console.WriteLine("Read");
    }
}

class Book {
    private Read _read = new Read();
    public void Read() {
        _read.ReadContent();
    }
}

class BookShelf {
    private Book _book = new Book();
    public void Read() {
        _book.Read();
    }
}

class Library {
    private BookShelf _bookShelf = new BookShelf();
    public void Read() {
        _bookShelf.Read();
    }
}

class Person {
    private Library _library = new Library();
    public void Read() {
        _library.Read();
    }
}

class Program {
    static void Main(string[] args) {
        Person person = new Person();
        person.Read();  // Output: Read
    }
}
