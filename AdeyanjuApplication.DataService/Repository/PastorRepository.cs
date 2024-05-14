using AdeyanjuApplication.DataService.Data;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DbSet;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeyanjuApplication.DataService.Repository
{
    public class PastorRepository : GenericRepository<Pastor>, IPastorRepository
    {
        public PastorRepository(AppDbContext dbContext, ILogger logger) : base(dbContext, logger)
        {
        }

        public override async Task<IEnumerable<Pastor>> GetAll()
        {
            try
            {
                return await _dbSet.Where(x => x.Status == 1).OrderBy(x => x.Created).ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "(Repo) GetAll function error", typeof(PastorRepository));
                throw;
            }
        }

        public override async Task<bool> Update(Pastor newPastor)
        {
            try
            {
                var result = await _dbSet.FirstOrDefaultAsync(x => x.Id == newPastor.Id);
                if (result == null)
                {
                    return false;
                }
                result.Updated = DateTime.UtcNow;
                result.BranchName = newPastor.BranchName;
                result.ChurchAddress = newPastor.ChurchAddress;
                result.Email = newPastor.Email;
                result.FirstName = newPastor.FirstName;
                result.LastName = newPastor.LastName;
                result.EmailConfirmed = newPastor.EmailConfirmed;
                result.HomeAddress = newPastor.HomeAddress;
                result.Occupation = newPastor.Occupation;
                result.UpdatedBy = newPastor.UpdatedBy;
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "(Repo) Update function error", typeof(PastorRepository));
                throw;
            }
        }

        public override async Task<bool> Delete(string Id)
        {
            try
            {
                var result = await _dbSet.FirstOrDefaultAsync(x => x.Id == Id);
                if (result == null)
                {
                    return false;
                }
                result.Status = 0;
                result.Updated = DateTime.UtcNow;
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "(Repo) Delete function error", typeof(PastorRepository));
                throw;
            }
        }
    }
}
