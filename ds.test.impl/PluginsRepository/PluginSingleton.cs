using ds.test.impl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ds.test.impl.PluginsRepository
{
    public class PluginSingleton : PluginFactory ///
    {
        private static PluginSingleton instance;

        public IPlugin plugin { get; }
        public string NameOfOperation { get; }
        public int FirstValue { get; }
        public int SecondValue { get; }
        public int PluginsCount => GetPluginsName.Length;


        /// <summary>
        /// names of all interfaces
        /// </summary>
        public string[] GetPluginsName => new string[]
        {
            "addition",
            "multiplication",
            "division",
            "subtraction"
        };



        /// <summary>
        /// list of all implementations of the IPlugin interface
        /// </summary>
        private static List<AbstractionPlugin> ListOfPlugins = new List<AbstractionPlugin>()
        {
            new AdditionPlugin(), new SubtractionPlugin(), new DivisionPlugin(), new MultiplicationnPlugin()

        };


        /// <summary>
        /// Constructor where the necessary checks are made
        /// </summary>
        private PluginSingleton(string nameOfOperation, int firstValue, int secondvalue)
        {

            if (nameOfOperation == null)
                throw new ArgumentNullException("","you cannot use an empty string");

            NameOfOperation = nameOfOperation.ToLower();


            if (!GetPluginsName.Contains(NameOfOperation))
                throw new ArgumentOutOfRangeException("","this operation doesn't exist");
            else if (NameOfOperation == "division" && GetPluginsName.Contains(NameOfOperation) && secondvalue == 0)
                throw new DivideByZeroException("you cannot divide by zero");
            else if (firstValue > 10001 || firstValue < -10001 || secondvalue > 10001 || secondvalue < -10001)
                throw new ArgumentOutOfRangeException("", "sorry, very large");


            FirstValue = firstValue;
            SecondValue = secondvalue;
            plugin = GetPlugin(nameOfOperation);

        }

        /// <summary>
        /// overloading the constructor to pass a lightweight static class to get information about the required plugin by its name. Used in Plugin class
        /// </summary>
        private PluginSingleton(string nameOfOperation)
        {

            if (nameOfOperation == null)
                throw new ArgumentNullException("","you can not use empty line");

            NameOfOperation = nameOfOperation.ToLower();

            
             if (!GetPluginsName.Contains(NameOfOperation))
                throw new ArgumentOutOfRangeException("", "this operation doesn't exist");

            plugin = GetPlugin(nameOfOperation);

        }

        /// <summary>
        ///  returns a static version of this class, used to statically call the Add method in the Plugin class
        /// </summary>
        public static PluginSingleton GetInstance(string nameofoperation, int firstValue, int secondValue)
        {
            if (instance == null)
                instance = new PluginSingleton(nameofoperation, firstValue, secondValue);

            return instance;
        }

        /// <summary>
        /// method overload to get information about the required plugin, used in the Plugin class
        /// </summary>
        public static PluginSingleton GetInstance(string nameofoperation)
        {
            if (instance == null)
                instance = new PluginSingleton(nameofoperation);

            return instance;
        }

        /// <summary>
        /// returns the interface specified in the plugin nameUsing it, we can get the RUN method
        /// </summary>
        public IPlugin GetPlugin(string PluginName)
        {
            PluginName = NameOfOperation;

            return ListOfPlugins.Single(item => item.PluginName == PluginName);
        }

        public int Run()
        {
            return plugin.Run(FirstValue, SecondValue);
        }

    }
}
