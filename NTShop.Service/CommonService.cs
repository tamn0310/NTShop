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
    }

    public class CommonService : ICommonService
    {
        IFooterRepository _footerRepository;
        IUnitOfWork _unitOfWork;
        ISlideRepository _slideRepository;

        public CommonService(IFooterRepository footerRepository, IUnitOfWork unitOfWork, ISlideRepository slideRepository)
        {
            this._footerRepository = footerRepository;
            this._unitOfWork = unitOfWork;
            this._slideRepository = slideRepository;
        }

        public Footer GetFooter()
        {
            return _footerRepository.GetSingleByCondition(x => x.ID == CommonConstants.DefaultFooterId);
        }

        public IEnumerable<Slide> GetSlides()
        {
            return _slideRepository.GetMulti(x=>x.Status==true);
        }
    }
}