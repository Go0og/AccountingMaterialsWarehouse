using Contract.BindingModel;
using Contract.SearchModel;
using Contract.StorageModel;
using Contract.StorageModel.dbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseImplement.Implements
{
    public class DivisionStorage : IDivisionStorage
    {
        public bool CreateDivision(DivisionbindingModel model)
        {
            using var context = new Database();
            var NewDivision = Division.Create(model);
            if (NewDivision == null) 
            {
                return false;
            } 
            context.Divisions.Add(NewDivision);
            context.SaveChanges();
            return true;
        }
        public bool UpdateDivision(DivisionbindingModel Model)
        {
            using var context = new Database();
            var UpdateDivision = context.Divisions.FirstOrDefault(x => x.Id == Model.Id);
            if (UpdateDivision == null) 
            {
                return false;
            }
            UpdateDivision.Update(Model);
            context.SaveChanges();
            return true;
        }
        public bool DeleteDivision(DivisionbindingModel Model)
        {
            using var context = new Database();
            var DeleteDivision = context.Divisions.FirstOrDefault(x=>x.Id == Model.Id);
            if (DeleteDivision == null)
            {
                return false;
            }
            context.Divisions.Remove(DeleteDivision);
            context.SaveChanges();
            return true;
        }

        public List<Division> GetFillteredList(DivisionSearchModel Model)
        {
            using var context = new Database();
            if (Model.Id.HasValue)
            {
                return context.Divisions
                    .Where(x => x.Id == Model.Id)
                    .ToList();
            }
            return new();
        }

        public List<Division> GetFullList()
        {
            using var context = new Database();
            return context.Divisions.ToList();
        }

        public Division? GetItem(DivisionSearchModel Model)
        {
            using var context = new Database();
            if (Model.Id.HasValue)
            {
                return context.Divisions.FirstOrDefault(x => x.Id == Model.Id);
            }
            return null;
        }


    }
}
