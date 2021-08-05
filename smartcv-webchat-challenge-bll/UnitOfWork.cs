using smartcv_webchat_challenge_bll.Interfaces;
using smartcv_webchat_challenge_dal;
using smartcv_webchat_challenge_dal.Interfaces;
using smartcv_webchat_challenge_common.Models;
using smartcv_webchat_challenge_dal.Repositories;

namespace smartcv_webchat_challenge_bll
{
    public class UnitOfWork : IUnitOfWork
    {
        private BaseRepository<User> _users;
        private BaseRepository<Message> _messages;

        public IRepository<User> Users
        {
            get
            {
                return _users ??
                    (_users = new BaseRepository<User>());
            }
        }

        public IRepository<Message> Messages
        {
            get
            {
                return _messages ??
                    (_messages = new BaseRepository<Message>());
            }
        }
    }
}
