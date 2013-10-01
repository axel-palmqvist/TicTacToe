using System;



public class Board
{
    public Board()
    {

    }

    public void BoardGraphics()
    {
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                draw(x * 5, y * 3);
            }
        }
    }
    public void draw(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.Write("┌───┐");
        Console.SetCursorPosition(x, y + 1);
        Console.Write("│   │");
        Console.SetCursorPosition(x, y + 2);
        Console.Write("└───┘");
    }
}