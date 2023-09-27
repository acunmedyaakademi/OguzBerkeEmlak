using Emlak.DAL.Repositories.Abstract;
using Emlak.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Repository.Concrate
{
    public class PortfoyRepository : RepositoryBase<Portfoy> ,IPortfoyRepository
    {
    }
}
