using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DBAHawkConfig.Test
{
    [TestClass]
    public class Initialize
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            Console.WriteLine("Begin Assembly Initialize");
            Helper.CleanupConfig();
        }
    }
}