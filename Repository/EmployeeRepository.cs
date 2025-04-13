﻿using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }

        public void AnyMethodFromEmployeeRepository()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync(Guid companyId, bool trackChanges) =>
        FindByCondition(e => e.CompanyId.Equals(companyId), trackChanges)
        .OrderBy(e => e.Name);

        public async Task<Employee> GetEmployeeAsync(Guid companyId, Guid id, bool trackChanges) =>
        FindByCondition(e => e.CompanyId.Equals(companyId) && e.Id.Equals(id),
        trackChanges).SingleOrDefault();

        public void CreateEmployeeForCompany(Guid companyId, Employee employee)
        {
            employee.CompanyId = companyId;
            Create(employee);
        }
        public void DeleteEmployee(Employee employee)
        {
            Delete(employee);
        }
    }
}
