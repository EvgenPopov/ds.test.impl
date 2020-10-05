using ds.test.impl.PluginsRepository;

namespace ds.test.impl
{
    /// <summary>
    /// implementation of the Plugins class through the singleton pattern
    /// now there are four types of calculations "division", "multiplication", "substraction", "division"
    /// example of using Run method - Plugins.Rum("division", 10, 2 )
    /// 
    /// 
    /// to get information about a specific pattern use 
    /// 
    /// {   Plugins plug = new Plugins("division");
    ///     Console.WriteLine(plug.Version);
    /// }
    /// 
    /// </summary>
    public class Plugins
    {
        private PluginSingleton plugins;

        public Plugins(string name)
        {
            plugins = PluginSingleton.GetInstance(name);
            PluginName = plugins.GetPlugin(name).PluginName;
            Version = plugins.GetPlugin(name).Version;
            Description = plugins.GetPlugin(name).Description;
        }
        public string PluginName { get; private set; }
        public string Version { get; private set; }
        public string Description { get; private set; }



        /// <summary>
        /// directly the run method itself, which, when specifying the name of the plugin, will perform this operation.
        /// can be used statically. For example : Console.WriteLine(Plugins.Run("Multiplication", 1, 2));
        /// </summary>
        public static int Run(string name, int FirstValue, int secondValue)
        {
            return PluginSingleton.GetInstance(name, FirstValue, secondValue).Run();
        }
    }
}
