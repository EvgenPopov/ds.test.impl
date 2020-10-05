namespace ds.test.impl.Interfaces
{
    interface PluginFactory
    {
        int PluginsCount { get; }

        string[] GetPluginsName { get; }

        IPlugin GetPlugin(string plaginName);
    }
}
