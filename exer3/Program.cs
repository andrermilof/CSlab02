using System;


namespace exer3
{

    public class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Pro");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Pro");
        }
    }

    public class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
        }
    }

    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            DocumentWorker worker;

            switch(str)
            {
                case "pro":
                    worker = new ProDocumentWorker();
                    break;

                case "exp":
                    worker = new ExpertDocumentWorker();
                    break;

                default:
                    worker = new DocumentWorker();
                    break;
            }

            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();
        }
    }
}
