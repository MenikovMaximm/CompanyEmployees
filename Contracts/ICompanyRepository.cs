using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Entities;

namespace Contracts
{
    public interface ICompanyRepository
    {
        void AnyMethodFromCompanyRepository();

        IEnumerable<Company> GetAllCompanies(bool trackChanges);

        IEnumerable<Company> GetByIds(IEnumerable<Guid> ids, bool trackChanges);
        Company GetCompany(Guid companyId, bool trackChanges);

        void CreateCompany(Company company);
    }
}
