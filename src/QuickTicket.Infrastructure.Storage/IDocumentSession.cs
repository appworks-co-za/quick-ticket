using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuickTicket.Infrastructure.Storage
{
    public interface IDocumentSession<TDocument>
    {
        /// <summary>
        /// When implemented by a derived class one or more documents are retrieved for the give collection of document ids
        /// </summary>
        Task<IReadOnlyDictionary<string, TDocument>> LoadMany(IEnumerable<string> documentIds);

        /// <summary>
        /// When implemented by a derived class changes to the documents loaded into the session will be persisted
        /// to the underlying storage.
        /// </summary>
        /// <returns></returns>
        Task SaveChanges();
    }
}