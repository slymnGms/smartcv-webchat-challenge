using smartcv_webchat_challenge_common.Models;
using smartcv_webchat_challenge_dal.Interfaces;

namespace smartcv_webchat_challenge_bll.Interfaces
{
    interface IUnitOfWork
    {
        IRepository<User> Users { get; }
        IRepository<Message> Messages { get; }
    }
}
