﻿namespace AuthorService.Models;

public class AuthorMessage
{
    public required int Id { get; set; }

    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public required DateTime DateOfBirth { get; set; }
}
