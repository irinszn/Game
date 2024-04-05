using System.Runtime.CompilerServices;

namespace Characters;

class Player : ICharacter
{
    public int x { get; private set; }
    public int y { get; private set; }
    public char characterSymbol { get; private set; }

    public Player(int x, int y)
    {
        characterSymbol = '@';
        this.x = x;
        this.y = y;
        Console.SetCursorPosition(x, y);
        Move();
    }

    private void Move()
    {
        Console.Write("\b ");
        Console.SetCursorPosition(x, y);
        Console.Write(characterSymbol);
    }

    private bool CheckIfMoveIsUnavaliabe()
    {
        if (x < 0 || y < 0)
        {
            return true;
        }
        return false;
    }

    public void MoveRight()
    {
        ++x;
        if (CheckIfMoveIsUnavaliabe())
        {
            --x;
            return;
        }
        Move();
    }

    public void MoveLeft()
    {
        --x;
        if (CheckIfMoveIsUnavaliabe())
        {
            Console.Beep();
            ++x;
            return;
        }
        Move();
    }

    public void MoveDown()
    {
        ++y;
        if (CheckIfMoveIsUnavaliabe())
        {
            Console.Beep();
            --y;
            return;
        }
        Move();
    }

    public void MoveUp()
    {
        --y;
        if (CheckIfMoveIsUnavaliabe())
        {
            ++y;
            return;
        }
        Move();
    }
}

