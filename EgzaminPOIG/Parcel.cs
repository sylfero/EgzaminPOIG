using System;

namespace EgzaminPOIG
{
    abstract class Parcel
    {
        protected IPerson sender;
        protected IPerson recipient;
        protected uint weight;
        protected uint width;
        protected uint length;
        protected uint height;
        protected DateTime postingDate;
        public uint Number { get; set; }

        public Parcel(IPerson sender, IPerson recipient, uint weight, uint width, uint length, uint height)
        {
            this.sender = sender;
            this.recipient = recipient;
            this.weight = weight;
            this.width = width;
            this.length = length;
            this.height = height;
            postingDate = DateTime.Now;
            Poczta.SetNumber(this);
        }

        public abstract decimal ObliczKoszt();
        public abstract string GenerujListPrzewozowy();
    }
}
