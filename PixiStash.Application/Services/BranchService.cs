using AutoMapper;
using PixiStash.Application.DTO.BranchDTO;
using PixiStash.Application.Services.IServices;
using PixiStash.Core.Models;
using PixiStash.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixiStash.Application.Services
{
    internal class BranchService : IBranchService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BranchService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public void Create(BranchDto DTOmodel)
        {
          var data = _mapper.Map<Branch>(DTOmodel);
            _unitOfWork.Branches.Add(data);
            _unitOfWork.save();
        }

        public void CreateBranch(Branch model)
        {
            throw new NotImplementedException();
        }

        public void DeleteBranch(Guid id)
        {
            throw new NotImplementedException();
        }

        public BranchDto GetBranch(Guid id)
        {
            throw new NotImplementedException();
        }

        

      


        public List<BranchDto> GetBranches()
        {
          var branch =  _unitOfWork.Branches.GetAll();
         var data  =  _mapper.Map<List<BranchDto>>(branch);

          return data;

        }

        public List<Branch> GetByComId(Guid ComId)
        {
            throw new NotImplementedException();
        }

        public void UpdateBranch(BranchDto DTOmodel)
        {
            // Retrieve the existing branch entity based on the DTOmodel's Id
            var existingBranch =  _unitOfWork.Branches.FindWhere(b => b.BranchId == DTOmodel.BranchId && b.CompanyId == DTOmodel.CompanyId);

            if (existingBranch == null)
            {
                
                throw new InvalidOperationException("Branch not found for the provided Id.");
            }

            // Update the properties of the existing branch entity with the values from the DTOmodel
            // (Assuming you have appropriate properties in BranchDto and Branch entities)
            existingBranch.BranchName = DTOmodel.BranchName;
            existingBranch.Description = DTOmodel.Description;
            existingBranch.Address = DTOmodel.Address;
            existingBranch.City = DTOmodel.City;
            existingBranch.State = DTOmodel.State;
            existingBranch.ZipCode = DTOmodel.ZipCode;
            existingBranch.Phone = DTOmodel.Phone;
            existingBranch.Email = DTOmodel.Email;
            existingBranch.ContactPerson = DTOmodel.ContactPerson;
           // existingBranch.CompanyId = DTOmodel.CompanyId;

            _unitOfWork.Branches.Edit(existingBranch);       

            // Save the changes to the database
             _unitOfWork.save();
        }

      public async  Task<BranchDto> GetBranchDetails(Guid id, Guid comid)
        {
            var branches = await _unitOfWork.Branches
                .Where(b => b.CompanyId == comid);
                        // Filter the branches by the specified Id
            var branch = branches.SingleOrDefault(b => b.BranchId == id);

            if (branch == null)
            {
                // Handle the case where the branch is not found
                return null;
            }

            // Map the branch to BranchDto and return
            var branchDto = _mapper.Map<BranchDto>(branch);
            return branchDto;
        }

        BranchDto IBranchService.GetBranchDetail(Guid id, Guid comid)
        {
            throw new NotImplementedException();
        }
    }
}
