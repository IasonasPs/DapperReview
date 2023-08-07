using DapperReview.Entities;

namespace DapperReview.Contracts
{
    public interface ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanies();
        
    }
}
