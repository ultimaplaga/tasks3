
using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    private bool isAvailable;

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        isAvailable = true;
    }

    public void BorrowBook()
    {

        if (isAvailable == true)
        {
            isAvailable = false;
            Console.WriteLine($"{Title} götürüldü.");
        }
        else
        {
            Console.WriteLine($"{Title} artıq götürülüb.");
        }
    }

    public void ReturnBook()
    {
        if (isAvailable)
        {
            Console.WriteLine($"{Title} artıq kitabxanadadır.");
        }
        else
        {
            isAvailable = true;
            Console.WriteLine($"{Title} geri qaytarıldı.");
        }
    }

    public void ShowInfo()
    {
        string status;

        if (isAvailable)
        {
            status = "Available";
        }
        else
        {
            status = "Borrowed";
        }

        Console.WriteLine(
            $"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Status: {status}"
        );
    }
}