using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCS_communication
{
    internal class Instruction
    {
        private String source;
        private String destination;
        private String type;
        private int priority;
        private String id;
        private String systemId;

        public String getSource()
        {
            return source;
        }

        public void setSource(String source)
        {
            this.source = source;
        }

        public String getDestination()
        {
            return destination;
        }

        public void setDestination(String destination)
        {
            this.destination = destination;
        }

        public String getType()
        {
            return type;
        }

        public void setType(String type)
        {
            this.type = type;
        }

        public int getPriority()
        {
            return priority;
        }

        public void setPriority(int priority)
        {
            this.priority = priority;
        }

        public String getId()
        {
            return id;
        }

        public void setId(String id)
        {
            this.id = id;
        }

        public String getSystemId()
        {
            return systemId;
        }

        public void setSystemId(String systemId)
        {
            this.systemId = systemId;
        }
    }
}
