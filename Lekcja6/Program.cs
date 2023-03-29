abstract class Movable
{
    public abstract void moveUp();
    public abstract void moveDown();
    public abstract void moveLeft();
    public abstract void moveRight();
    public virtual void Display()
    {
        Console.WriteLine("Cannot display anything!");
    }
}

class MovablePoint : Movable
{
    public int x { get; set; }
    public int y { get; set; }
    int xSpeed { get; set; }
    int ySpeed { get; set; }

    public MovablePoint(int x, int y, int xSpeed, int ySpeed)
    {
        this.x = x;
        this.y = y;
        this.xSpeed = xSpeed;
        this.ySpeed = ySpeed;
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public override void moveUp()
    {
        y += ySpeed;
    }

    public override void moveDown()
    {
        y -= ySpeed;
    }

    public override void moveLeft()
    {
        x -= xSpeed;
    }

    public override void moveRight()
    {
        x += xSpeed;
    }

    public override void Display()
    {
        Console.WriteLine($"Współrzędne punktu to ({x}, {y})");
    }
}

class MovableCircle : Movable
{
    int radius { get; set; }
    MovablePoint center { get; set; }

    public MovableCircle(int radius, MovablePoint center)
    {
        this.radius = radius;
        this.center = center;
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public override void moveUp()
    {
        center.moveUp();
    }

    public override void moveDown()
    {
        center.moveDown();
    }

    public override void moveLeft()
    {
        center.moveLeft();
    }

    public override void moveRight()
    {
        center.moveRight();
    }

    public override void Display()
    {
        Console.WriteLine($"Promień koła wynosi {radius}, a jego centrum znajduje się na współrzędnych ({center.x}, {center.y})");
    }
}

class Program
{
    static void Main()
    {
        var point = new MovablePoint(3, 4, 1, 1);
        point.Display();

        point.moveUp();
        point.Display();

        point.moveDown();
        point.Display();

        point.moveLeft();
        point.Display();

        point.moveRight();
        point.Display();

        Console.WriteLine();

        var circle = new MovableCircle(5, point);
        circle.Display();

        circle.moveUp();
        circle.Display();
    }
}