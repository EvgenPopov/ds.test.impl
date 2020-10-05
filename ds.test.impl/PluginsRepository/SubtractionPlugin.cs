namespace ds.test.impl.PluginsRepository
{
    /// <summary>
    /// implementation of the IPlugin interface through an abstract class
    /// </summary>
    class SubtractionPlugin : AbstractionPlugin
    {
        public override string PluginName => "subtraction";

        public override string Version => "1.0";

        public override string Description => "subtraction operation";

        public override int Run(int input1, int input2)
        {
            return input1 / input2;
        }
    }
}
