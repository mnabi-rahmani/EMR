using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WardForms.Models;
using WardForms.Repository;

namespace WardForms.Repository
{
    public class FacilityGroupMembersRepository : Repository<FacilityGroupMember>
    {
     public   ApplicationDbContext Context = new ApplicationDbContext();

        public FacilityGroupMembersRepository()
        {

        }
        public List<FacilityGroupMember> GetAllMember()
        {

            return Context.FacilityGroupMembers.ToList();


        }


        public void UpdateGroupMember(FacilityGroupMember _facilityGroupMember)
        {
            Context.Entry(_facilityGroupMember).State = EntityState.Modified;
            Context.SaveChanges();

        }
    }
}