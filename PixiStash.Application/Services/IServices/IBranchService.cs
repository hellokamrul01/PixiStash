using PixiStash.Application.DTO;
using PixiStash.Application.DTO.BranchDTO;
using PixiStash.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Application.Services.IServices
{
    public interface IBranchService
    {
        void CreateBranch(Branch model);
        void Create(BranchDto DTOmodel);
        void DeleteBranch(Guid id);
        BranchDto GetBranch(Guid id);
        Task<BranchDto> GetBranchDetails(Guid id, Guid comid);
        BranchDto GetBranchDetail(Guid id,Guid comid);
        List<BranchDto> GetBranches();
        List<Branch> GetByComId(Guid ComId);
        void UpdateBranch(BranchDto DTOmodel);

    }
}
