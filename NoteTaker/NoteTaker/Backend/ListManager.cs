using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralForm.Backend
{
    public class ListManager <T>
    {
        private List<T> list;
        private T newItem;

        public List<T> oldList
        {
            get
            {
                return this.list;
            }
            set
            {
                this.list = oldList;
            }
        }

        public void remove(int index)
        {
            this.list.RemoveAt(index);
        }

        public void add()
        {

        }

        public void update()
        {

        }

    }
}
