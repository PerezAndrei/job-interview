using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpfeatures
{
    class DVD : IPlayable
    {
        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    class TV : IPlayable
    {
        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    interface IPlayable {
        void Play();
        void Stop();
        void Pause() {
            Console.WriteLine("Pause");
        }
    }
}
