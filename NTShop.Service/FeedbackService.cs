using NTShop.Data.Infrastructure;
using NTShop.Data.Reponsitories;
using NTShop.Model.Models;

namespace NTShop.Service
{
    public interface IFeedbackService
    {
        Feedback Create(Feedback feedback);
        void Save();
    }

    public class FeedbackService:IFeedbackService
    {
        public IFeedbackRepository _feedbackRepository;
        public IUnitOfWork _unitOfWork;

        public FeedbackService(IFeedbackRepository feedbackRepository, IUnitOfWork unitOfWork)
        {
            this._feedbackRepository = feedbackRepository;
            this._unitOfWork = unitOfWork;
        }

        public Feedback Create(Feedback feedback)
        {
            return _feedbackRepository.Add(feedback);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}