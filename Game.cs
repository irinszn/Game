namespace Game;

using Characters;

public class Game
{
    private ICharacter player;

    public Game()
    {
        player = new Player(1, 1);

    }

    public void GoingLeft(object sender, EventArgs args)
        => player.MoveLeft();

    public void GoingRight(object sender, EventArgs args)
        => player.MoveRight();

    public void GoingDown(object sender, EventArgs args)
        => player.MoveDown();

    public void GoingUp(object sender, EventArgs args)
        => player.MoveUp();
}
