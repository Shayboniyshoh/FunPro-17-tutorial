using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIUT.DAL
{
    public class ApplicantList
    {
        public List<Applicant> GetAllApplicants()
        {
            return new ApplicantManager().GetAll();
        }

       public List<Applicant> Sort(ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Name:
                    var applicants = GetAllApplicants();
                    applicants.Sort(new ByNameComparer());
                    return applicants;

                case ByAttribute.Surname:
                    break;
                case ByAttribute.DoB:
                    break;
                case ByAttribute.Course:
                    break;
            }

            //if we are here - something went wrong
            return null;
        }

        private class ByNameComparer : IComparer<Applicant>
        {
            public int Compare(Applicant x, Applicant y)
            {
                //throw new NotImplementedException(); originally generated
                return string.Compare(x.Name, y.Name);
            }
        }


        public List<Applicant> SortLINQ(ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Name:
                    return GetAllApplicants().OrderBy(d => d.Name).ToList(); // OrderBy for sorting

                case ByAttribute.Surname:
                    return GetAllApplicants().OrderBy(d => d.Surname).ToList();

                case ByAttribute.DoB:
                    return GetAllApplicants().OrderBy(d => d.DoB).ToList();

                case ByAttribute.Course:
                    return GetAllApplicants().OrderBy(d => d.Course).ToList();

            }

            //if we are here - something went wrong
            return null;
        }


        public List<Applicant> Search(string value, ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Name:
                    return GetAllApplicants().Where(a => a.Name.ToUpper().Contains(value.ToUpper())).ToList(); // Where is for searching
                case ByAttribute.Surname:
                    return GetAllApplicants().Where(a => a.Surname.ToLower().Contains(value.ToLower())).ToList();
            }

            //if we are here - something went wrong
            return null;
        }




    }
}
