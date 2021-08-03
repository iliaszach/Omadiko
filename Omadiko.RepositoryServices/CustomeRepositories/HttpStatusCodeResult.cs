using Omadiko.Entities.Models;

namespace Omadiko.RepositoryServices
{
    internal class HttpStatusCodeResult : Provider
    {
        private object badRequest;

        public HttpStatusCodeResult(object badRequest)
        {
            this.badRequest = badRequest;
        }
    }
}