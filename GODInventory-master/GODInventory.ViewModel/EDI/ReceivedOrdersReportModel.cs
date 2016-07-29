using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GODInventory.MyLinq;
using System.Collections;

namespace GODInventory.ViewModel.EDI
{
    public class ReceivedOrderReportModel 
    {
        List<t_orderdata> entities;

        public ReceivedOrderReportModel( List<t_orderdata> orders)
        {
            this.entities = orders;    
        }

        public ReceivedOrderReportModel()
        {

        }

        public string 部門名
        {
            get { return entities.First().部門名漢字; }
        }

        

        public List<ReceivedOrderReportModel> getList()
        {
            List<ReceivedOrderReportModel> listuser = new List<ReceivedOrderReportModel>();
            
            return listuser;
        }
    }



}
