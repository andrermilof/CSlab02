using System;

namespace exer1
{
    public class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Non");
        }
        public virtual void Read()
        {
            Console.WriteLine("Non");
        }
        public virtual void Write()
        {
            Console.WriteLine("Non");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Non");
        }
    }

    public class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study: excelent");
        }
        public override void Read()
        {
            Console.WriteLine("Read: excelent");
        }
        public override void Write()
        {
            Console.WriteLine("Write: excelent");
        }
        public override void Relax()
        {
            Console.WriteLine("Relax: excelent");
        }
    }

    public class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study: good");
        }
        public override void Read()
        {
            Console.WriteLine("Read: good");
        }
        public override void Write()
        {
            Console.WriteLine("Write: good");
        }
        public override void Relax()
        {
            Console.WriteLine("Relax: good");
        }
    }

    public class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study: bad");
        }
        public override void Read()
        {
            Console.WriteLine("Read: bad");
        }
        public override void Write()
        {
            Console.WriteLine("Write: bad");
        }
        public override void Relax()
        {
            Console.WriteLine("Relax: bad");
        }
    }

    public class ClassRoom
    {
        private Pupil[] pupils;
        public ClassRoom(params Pupil[] args)
        {
            if (args.Length == 1 || args.Length > 4)
                throw new Exception("Invalid arguments");

            pupils = args;
        }
        public void Show()
        {
           foreach(Pupil i in pupils)
           {
                i.Study();
                i.Write();
                i.Read();
                i.Relax();
                Console.WriteLine("\n");
           }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil ePupil = new ExcelentPupil();
            GoodPupil gPupil = new GoodPupil();
            BadPupil bPupil = new BadPupil();

            ClassRoom room = new ClassRoom(ePupil, ePupil, gPupil, bPupil);
            room.Show();
        }
    }
}
