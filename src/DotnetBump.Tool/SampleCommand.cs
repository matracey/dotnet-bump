using System.Threading.Tasks;
using McMaster.Extensions.CommandLineUtils;

namespace Tool
{
    //Example Command
    [Command(
        Name = "dotnet samplecommand",
        FullName = "dotnet-samplecommand")]
    [HelpOption]
    public class SampleCommand
    {
        //Example Argument
        [Argument(0, ShowInHelpText = true, Name = "path", Description = "Path to the directory to execute this command.")]
        public string Path { get; private set; }


        public SampleCommand() 
        {

        }

        public async Task<int> OnExecute(CommandLineApplication app)
        {
           

            return await Task.FromResult(0);
        }
    }
}