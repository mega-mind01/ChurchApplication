﻿using AdeyanjuApplication.DataService.Data;
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
    public class EvangelistRepository : GenericRepository<Evangelist>, IEvangelistRepository
    {
        public EvangelistRepository(AppDbContext dbContext, ILogger logger) : base(dbContext, logger)
        {
        }

        public override async Task<IEnumerable<Evangelist>> GetAll()
        {
            try
            {
                return await _dbSet.Where(x => x.Status == 1).OrderBy(x => x.Created).ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "(Repo) GetAll function error", typeof(EvangelistRepository));
                throw;
            }
        }

        public override async Task<bool> Update(Evangelist newEvangelist)
        {
            try
            {
                var result = await _dbSet.FirstOrDefaultAsync(x => x.Id == newEvangelist.Id);
                if (result == null)
                {
                    return false;
                }
                result.Updated = newEvangelist.Updated;
                result.YearsInService = newEvangelist.YearsInService;
                result.PastorInCharge = newEvangelist.PastorInCharge;
                result.Email = newEvangelist.Email;
                result.FirstName = newEvangelist.FirstName;
                result.LastName = newEvangelist.LastName;
                result.HomeAddress = newEvangelist.HomeAddress;
                result.Occupation = newEvangelist.Occupation;
                result.UpdatedBy = newEvangelist.UpdatedBy;
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "(Repo) Update function error", typeof(EvangelistRepository));
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
                _logger.LogError(ex, "(Repo) Delete function error", typeof(EvangelistRepository));
                throw;
            }
        }
    }
}
