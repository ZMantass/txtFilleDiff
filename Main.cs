using System;

namespace FileDiff
{
    class FileInput
    {
        static void Main()
        {
            bool a = FileEquals("C:\\stage\\htmlmeta",
                "C:\\stage\\htmlmeta-aspnet");

            bool b = FileEquals("C:\\stage\\htmllink",
                "C:\\stage\\htmlmeta-aspnet");

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }

}

