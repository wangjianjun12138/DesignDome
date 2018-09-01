using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    abstract class CashSuper
    {
        public abstract Double AcceptCash(Double money);
    }

    class CashNormal:CashSuper
    {
        public override double AcceptCash(double money)
        {
            return money;
        }
    }

    class CashDiscount : CashSuper
    {
        private Double m_discount;

        public CashDiscount(Double discount)
        {
            m_discount = discount;
        }

        public override double AcceptCash(double money)
        {
            return money * m_discount;
        }
    }

    class CashReturn : CashSuper
    {
        private Double m_returnCondition;
        private Double m_returnValue;

        public CashReturn(Double returnCondition,Double returnValue)
        {
            m_returnCondition = returnCondition;
            m_returnValue = returnValue;
        }

        public override double AcceptCash(double money)
        {
            return money - Math.Floor(money / m_returnCondition) * m_returnValue;
        }
    }

    class CashConext
    {
        CashSuper m_cashSuper = null;

        public CashConext(CashSuper cashSuper)
        {
            m_cashSuper = cashSuper;
        }
        public CashConext(String eventInfo)
        {
            switch (eventInfo)
            { 
                case"无折扣":
                    m_cashSuper = new CashNormal();
                    break;
                case "打8折":
                    m_cashSuper = new CashDiscount(0.8);
                    break;
                case "满100减10":
                    m_cashSuper = new CashReturn(100,10);
                    break;
                default:
                    break;
            }
        }

        public Double ContextInterface(Double money)
        {
            return m_cashSuper.AcceptCash(money);
        }
    }
}
