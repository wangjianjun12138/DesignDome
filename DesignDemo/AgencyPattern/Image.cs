using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyPattern
{
    interface Image
    {
        void Display();
    }

    class RealImage : Image
    {
        private String m_fileName;

        public RealImage(String fileName)
        {
            m_fileName = fileName;
            LoadFormDisk(fileName);
        }

        public void Display()
        {
            Console.WriteLine("Displaying"+m_fileName);
        }

        private void LoadFormDisk(String fileName)
        {
            Console.WriteLine("Loading" + m_fileName);
        }
    }
    class ProxyImage : Image
    {
        private RealImage m_realImage;
        private String m_fileName;

        public ProxyImage(String fileName)
        {
            m_fileName = fileName;
        }

        public void Display()
        {
            if (m_realImage == null)
            {
                m_realImage = new RealImage(m_fileName);
            }
            m_realImage.Display();
        }
    }
}
