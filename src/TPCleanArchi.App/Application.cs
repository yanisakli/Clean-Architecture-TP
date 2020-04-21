public class Application
{
    IOutput output;
    ReadToFile readToFile;
    WriteToFile writeToFile;
    ToDoList toDoList;

    public Application(IOutput output)
    {
        this.output = output;
        this.readToFile = new ReadToFile();
        this.writeToFile = new WriteToFile();
        this.toDoList = new ToDoList();
    }

    public void GetMarks(DateTime dateTime)
    {
        output.Write("GET from DB");
        string[] lines = this.readToFile.ReadLines();

        foreach(var line in lines)
        {
            output.Write($"{line}");
        }
    }

    public void AddMark(string text)
    {
        output.Write($"ADD {text} to DB");
        Mark mark = new Mark(text);
        this.toDoList.Add(mark);
        this.writeToFile.WriteLine($"{mark}");
    }
}