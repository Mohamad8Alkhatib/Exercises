class SaveHelper
{
    public static void SaveObject(ISaveable obj)
    {
        System.Console.WriteLine($"{obj.GetType().Name} has been saved");
    }
}