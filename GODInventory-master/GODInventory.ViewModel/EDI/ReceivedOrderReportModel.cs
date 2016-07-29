using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GODInventory.MyLinq;

namespace GODInventory.ViewModel.EDI
{
    public class ReceivedOrderReportModel
    {
        public List<t_orderdata> entities;
        public IEnumerable<IGrouping<long, t_orderdata>> grouped_entities;

        public ReceivedOrderReportModel(List<t_orderdata> orders) {
            this.entities = orders;
            this.grouped_entities = orders.GroupBy(o => o.出荷No);
        }

        public int 出荷NoCount {
            get { return grouped_entities.Count(); }
        }

    }
}
