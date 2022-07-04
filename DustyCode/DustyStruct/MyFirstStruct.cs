public struct MyStruct
{
    private int x, y;


    public MyStruct(int _x,int _y) 
    {
        x  = _x;
        y = _y;

    }

    public int X 
    {
        get => x;
        set => x = value;
    }
    public int Y 
    {
        get => y;
        set => y = value;
    }




}