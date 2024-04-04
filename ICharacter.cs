namespace Characters;

public interface ICharacter
{
    char characterSymbol { get; }
    void MoveRight();
    void MoveLeft();
    void MoveDown();
    void MoveUp();
}

