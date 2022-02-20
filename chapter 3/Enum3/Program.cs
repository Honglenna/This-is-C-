
namespace Enum3
{
    class Program
    {
        enum DialogResult { YES = 10, NO, CANCEL, CONFIRM = 50, OK }

        static void Main(string[] args)
        {
            System.Console.WriteLine((int)DialogResult.YES);
            System.Console.WriteLine((int)DialogResult.NO);
            System.Console.WriteLine((int)DialogResult.CANCEL);
            System.Console.WriteLine((int)DialogResult.CONFIRM);
            System.Console.WriteLine((int)DialogResult.OK);
        }
    }
}
