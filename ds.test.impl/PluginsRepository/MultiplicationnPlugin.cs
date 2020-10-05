using System;
using System.Collections.Generic;
using System.Text;

namespace ds.test.impl.PluginsRepository
{
    /// <summary>
    /// implementation of the IPlugin interface through an abstract class
    /// </summary>
    class MultiplicationnPlugin : AbstractionPlugin
    {
        public override string PluginName => "multiplication";

        public override string Version => "1.0";

        public override string Description => "multiplication operation";

        public override int Run(int input1, int input2)
        {
            return input1 * input2;
        }
    }
}
