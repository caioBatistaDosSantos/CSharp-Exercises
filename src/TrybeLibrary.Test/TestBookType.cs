using Xunit;
using FluentAssertions;
using System;
using TrybeLibrary;

namespace TrybeLibrary.Test;

public class TestBookType
{
    [Trait("Category", "2 - Crie a struct Book")]
    [Fact(DisplayName = "Deve ter criado corretamente a struct Book")]    
    public void TestBookExists()
    {
        var book = new Book();
        book.GetType().IsInstanceOfType(typeof(Book));
    }

    [Trait("Category", "2 - Crie a struct Book")]
    [Fact(DisplayName = "Deve ter criado corretamente a struct Book")]    
    public void TestBookTypeExists()
    {
        var book = new Book() { Type = BookTypes.Children };
        book.Type.GetType().IsInstanceOfType(typeof(BookTypes));
    }
}
