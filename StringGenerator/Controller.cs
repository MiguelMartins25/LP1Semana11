namespace StringGenerator
{
    public class Controller
    {
        private Model model;
        private View view;

        public Controller()
        {
            model = new Model();
            view = new View();
        }

        public void Run(string[] args)
        {
            if (args.Length == 0)
            {
                view.ShowMessage("Nope");
                return;
            }

            bool valid = int.TryParse(args[0], out int seed);

            if (!valid)
            {
                view.ShowMessage("Nope");
                return;
            }

            string output = model.Generate(seed);

            view.ShowMessage(output);
        }
    }
}