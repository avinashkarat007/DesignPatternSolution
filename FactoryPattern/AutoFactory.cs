using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    /// <summary>
    /// A simple auto factory class that creates various types of auto mobiles based on a key for a type look up.
    /// </summary>
    public class AutoFactory
    {
        private Dictionary<string, Type> autos;

        public AutoFactory()
        {
            LoadTypesAndReturn();
        }

        public IAuto CreateInstance(string carName)
        {
            Type t = GetTypeToCreate(carName);

            if (t == null)
            {
                return new NullAuto();
            }

            return Activator.CreateInstance(t) as IAuto;
        }

        Type GetTypeToCreate(string carName)
        {
            foreach (var auto in autos)
            {
                if (auto.Key.Contains(carName))
                {
                    return autos[auto.Key];
                }     
            }

            return null;
        }

        // This method returns all the types in the current executing assembly as a Dictionary.
        private void LoadTypesAndReturn()
        {
            autos = new Dictionary<string, Type>();

            var typesInAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in typesInAssembly)
            {
                if (type.GetInterface(typeof(IAuto).ToString()) != null)
                {
                    autos.Add(type.Name.ToLower(),type);
                }
            }
        }
    }
}
