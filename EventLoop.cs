using System;

public class EventLoop
{
    public event EventHandler<EventArgs> LeftHandler = (sender, args) => { };

    public event EventHandler<EventArgs> RightHandler = (sender, args) => { };

    public event EventHandler<EventArgs> UpHandler = (sender, args) => { };

    public event EventHandler<EventArgs> DownHandler = (sender, args) => { };

    public void Run()
    {
        while (true)
        {
            var key = Console.ReadKey(true);
            int column = Console.CursorLeft;
            int row = Console.CursorTop;
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    LeftHandler(this, new CursorPositionEventArgs(column, row));
                    break;
                case ConsoleKey.RightArrow:
                    RightHandler(this, new CursorPositionEventArgs(column, row));
                    break;
                case ConsoleKey.UpArrow:
                    UpHandler(this, new CursorPositionEventArgs(column, row));
                    break;
                case ConsoleKey.DownArrow:
                    DownHandler(this, new CursorPositionEventArgs(column, row));
                    break;
            }
        }
    }

    private class CursorPositionEventArgs : EventArgs
    {
        public CursorPositionEventArgs(int columnPosition, int rowPosition)
        {
            this.ColumnPosition = columnPosition;
            this.RowPosition = rowPosition;
        }

        public int ColumnPosition { get; }

        public int RowPosition{ get; }
    }
}
