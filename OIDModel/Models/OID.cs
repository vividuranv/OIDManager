using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIDModel
{
    public class OID
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int parent;

        public int Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        private string identifier;

        public string Identifier
        {
            get { return identifier; }
            set { identifier = value; }
        }

        private string otherIdentifiers;

        public string OtherIdentifiers
        {
            get { return otherIdentifiers; }
            set { otherIdentifiers = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string information;

        public string Information
        {
            get { return information; }
            set { information = value; }
        }

        private bool approved;

        public bool Approved
        {
            get { return approved; }
            set { approved = value; }
        }

        private DateTime dateTime;

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }


    }
}
