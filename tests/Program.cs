using Altom.AltWalker;

namespace Demo.Tests
{

    public class ModelName
    {

        public void vertex_A()
        {
        }

        public void vertex_B()
        {
        }

        public void edge_A()
        {
        }

    }

    public class Program
    {

        public static void Main(string[] args)
        {
            ExecutorService service = new ExecutorService();
            service.RegisterModel<ModelName>();
            service.Run(args);
        }
    }

}
