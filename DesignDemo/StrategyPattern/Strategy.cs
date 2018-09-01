using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    abstract class Strategy
    {
        public abstract void AlgorithmInterface();
    }

    class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            {
                Console.WriteLine("算法A实现");
            }
        }
    }

    class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            {
                Console.WriteLine("算法B实现");
            }
        }
    }

    class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            {
                Console.WriteLine("算法C实现");
            }
        }
    }

    class Context
    {
        Strategy m_strategy;
        public Context(Strategy strategy)
        {
            this.m_strategy = strategy;
        }

        public void ContextInterface()
        {
            m_strategy.AlgorithmInterface();
        }
    }
}
