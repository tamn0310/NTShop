using NTShop.Common;
using NTShop.Data.Infrastructure;
using NTShop.Data.Reponsitories;
using NTShop.Model.Models;
using System.Collections.Generic;

namespace NTShop.Service
{
    public interface ICommonService
    {
        Footer GetFooter();
        IEnumerable<Slide> GetSlides();

        SystemConfig GetSystemConfig(string code);
    }

    public class CommonService : ICommonService
    {
        IFooterRepository _footerRepository;
        IUnitOfWork _unitOfWork;
        ISlideRepository _slideRepository;
        ISystemConfigRepository _systemConfigRepository;

        public CommonService(IFooterRepository footerRepository, IUnitOfWork unitOfWork, ISlideRepository slideRepository, ISystemConfigRepository systemConfigRepository)
        {
            this._footerRepository = footerRepository;
            this._unitOfWork = unitOfWork;
            this._slideRepository = slideRepository;
            this._systemConfigRepository = systemConfigRepository;
        }

        public Footer GetFooter()
        {
            return _footerRepository.GetSingleByCondition(x => x.ID == CommonConstants.DefaultFooterId);
        }

        public IEnumerable<Slide> GetSlides()
        {
            return _slideRepository.GetMulti(x=>x.Status==true);
        }

        public SystemConfig GetSystemConfig(string code)
        {
            return _systemConfigRepository.GetSingleByCondition(x => x.Code == code);
        }
    }
}