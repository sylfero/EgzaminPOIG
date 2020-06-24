using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminPOIG
{
    abstract class Parcel
    {
        private IPerson sender;
        private IPerson recipient;
        private uint weight;
        private uint width;
        private uint length;
        private uint height;
        private DateTime postingDate;

        public abstract decimal ObliczKoszt();
        public abstract string GenerujListPrzewozowy();
    }
}
