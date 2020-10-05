namespace ds.test.impl.PluginsRepository
{
    /// <summary>
    /// this is on of operation
    /// </summary>
    class AdditionPlugin : AbstractionPlugin
    {
        public override string PluginName => "addition";

        public override string Version => "1.0";

        public override string Description => "addition operation";

        public override int Run(int input1, int input2)
        {
            return input1 + input2;
        }
    }
}
