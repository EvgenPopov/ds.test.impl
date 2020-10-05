using ds.test.impl.Interfaces;


namespace ds.test.impl.PluginsRepository
{
    /// <summary>
    /// implementation of the IPlugin interface through an abstract class
    /// </summary>
    abstract class AbstractionPlugin : IPlugin
    {

        public abstract string PluginName { get; }

        public abstract string Version { get; }

        public abstract string Description { get; }

        public abstract int Run(int input1, int input2);
    }
}
