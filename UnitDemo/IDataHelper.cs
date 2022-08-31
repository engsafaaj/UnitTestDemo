using System;
using System.Collections.Generic;
using System.Text;

namespace UnitDemo
{
    public interface IDataHelper<Table>
    {
        int Add(Table table);
        int Edit(Table table);
        int Delete(Table table);
        List<Table> GetData();
        List<Table> Search(string SearchItem);
        Table Find(int Id);
    }
}
