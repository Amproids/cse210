using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture john = new Scripture("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        john.StudyScripture();
        Scripture proverbs = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        proverbs.StudyScripture();
    }
}