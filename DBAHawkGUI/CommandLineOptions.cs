using CommandLine;
namespace DBAHawkGUI
{
    public class CommandLineOptions
    {
        [Option('t', "Tags", Required = false, HelpText = "Tag filtering")]
        public string TagFilters { get; set; }

        [Option('x', "NoTagMenu", Required = false, HelpText = "Remove Tag Menu")]
        public bool NoTagMenu { get; set; }
    }

}
