using System;
using McMaster.Extensions.CommandLineUtils;

namespace Tool
{
    [Command(
        Name = "ToolName",
        FullName = "")]
    [Subcommand("SampleCommand", typeof(SampleCommand))]
    public class Program
    {
        public static int Main(string[] args)
        {
            var app = new CommandLineApplication<Program> { ThrowOnUnexpectedArgument = false };
            app.Conventions.UseDefaultConventions().UseConstructorInjection();

            try
            {
                return app.Execute(args);
            }
            catch (CommandParsingException cpe)
            {
                Console.WriteLine(cpe.Message);
                return -1;
            }
        }

        protected int OnExecute(CommandLineApplication app)
        {
            // this shows help even if the --help option isn't specified
            app.ShowHelp();
            return 1;
        }
    }
}