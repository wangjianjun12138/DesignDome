using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class AnimalFactory
    {
        public static IAnimal CreateInstance(AnimalType type)
        {
            switch (type)
            { 
                case AnimalType.cat:
                    return new Cat();
                case AnimalType.dog:
                    return new Dog();
                case AnimalType.panda:
                    return new Panda();
                default:
                    throw new Exception("错误类型");
            }
        }

        public static IAnimal CreateInstanceByConfig()
        {
           AnimalType type=(AnimalType)Enum.Parse(typeof(AnimalType),Properties.Resources.String_AnimalType);
            switch (type)
            {
                case AnimalType.cat:
                    return new Cat();
                case AnimalType.dog:
                    return new Dog();
                case AnimalType.panda:
                    return new Panda();
                default:
                    throw new Exception("错误类型");
            }
        }

        public static IAnimal CreateInstanceByReflect()
        {
            String assemblyName = Properties.Resources.String_AssemblyName;
            String typeName = Properties.Resources.String_TypeName;
            return (IAnimal)Activator.CreateInstance(assemblyName,typeName).Unwrap();
        }

        public enum AnimalType
        { 
            cat=0,
            dog=1,
            panda=2,
            cow=3
        }
    }
}
