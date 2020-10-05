namespace ds.test.impl.PluginsRepository
{
    /// <summary>
    /// implementation of the IPlugin interface through an abstract class
    /// </summary>
    class DivisionPlugin : AbstractionPlugin
    {
        public override string PluginName => "division";

        public override string Version => "1.0";

        public override string Description => "division operation";

        public override int Run(int input1, int input2)
        {
            return input1 / input2;
        }
    }
}
