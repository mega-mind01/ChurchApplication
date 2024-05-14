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
    public class MemberRepository : GenericRepository<Members>, IMemberRepository
    {
        public MemberRepository(AppDbContext dbContext, ILogger logger) : base(dbContext, logger)
        {
        }

        public override async Task<IEnumerable<Members>> GetAll()
        {
            try
            {
                return await _dbSet.Where(x => x.Status == 1).OrderBy(x => x.Created).ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "(Repo) GetAll function error", typeof(MemberRepository));
                throw;
            }
        }

        public override async Task<bool> Update(Members newMembers)
        {
            try
            {
                var result = await _dbSet.FirstOrDefaultAsync(x => x.Id == newMembers.Id);
                if (result == null)
                {
                    return false;
                }
                result.Updated = DateTime.UtcNow;
                result.Email = newMembers.Email;
                result.FirstName = newMembers.FirstName;
                result.LastName = newMembers.LastName;
                result.EmailConfirmed = newMembers.EmailConfirmed;
                result.HomeAddress = newMembers.HomeAddress;
                result.Occupation = newMembers.Occupation;
                result.UpdatedBy = newMembers.UpdatedBy;
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "(Repo) Update function error", typeof(MemberRepository));
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
                _logger.LogError(ex, "(Repo) Delete function error", typeof(MemberRepository));
                throw;
            }
        }
    }
}
