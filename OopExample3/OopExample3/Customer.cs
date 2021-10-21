using System;
using System.Collections.Generic;
using System.Text;

namespace OopExample3
{
    class Customer
    {
        private string name;
        private Boolean member = false;
        private string memberType;

        public Customer(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public Boolean isMember()
        {
            if (this.name=="suny")
                return true;
            else
                return false;
        }
        public void setMember(Boolean member)
        {
            this.member = member;
        }
        public string getMemberType()
        {
            return this.memberType;
        }
        public void setMemberType(string type)
        {
            this.memberType = type;
        }
       
    }
}
