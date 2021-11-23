using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oblik.Domain.Services
{
    public class StatementOfMaterialValueService
    {
        private static StatementOfMaterialValueService instance = new StatementOfMaterialValueService();
        public static StatementOfMaterialValueService Instance { get => instance; }
        private StatementOfMaterialValueService() { }

        public void EditMaterialValues(string nameMaterialValues, DateTime dateReceipt, DateTime RemoveDate, string yearIssue, decimal count, string price, string placeStorage, string responsiblePerson)
        {
            
        }
        public void DeleteMaterialValues()
        {

        }
        public void AddNewMaterialValues()
        {

        }
        public void OpenFile()
        {

        }
        public void SearchMaterialValues()
        {

        }
    }
}
