namespace practica1.Ej2;

public class PhotoBook
{
    protected int numPages {get; set;}
    public int id {get;set;}
    public PhotoBook(int p = 16)
    {
        numPages = p;
    }
    public int GetNumberPages()
    {
        return numPages;
    }

}