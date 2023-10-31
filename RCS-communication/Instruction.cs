using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCS_communication
{
    public class Instruction
    {
        private String id;
        private String systemId;
        private String source;
        private String destination;
        private String type;
        private int priority;

        public String getSource()
        {
            return source;
        }

        public String getDestination()
        {
            return destination;
        }

        public String getType()
        {
            return type;
        }

        public int getPriority()
        {
            return priority;
        }


        public String getId()
        {
            return id;
        }


        public String getSystemId()
        {
            return systemId;
        }

        public Instruction(string id, string systemId, string source, string destination, string type, int priority)
        {
            this.id = id;
            this.systemId = systemId;
            this.source = source;
            this.destination = destination;
            this.type = type;
            this.priority = priority;
        }
    }
}
