using System.Threading.Tasks;

namespace Project.WEB.Repositories
{
    public interface IRepository

    {

        Task<HttpResponseWrapper<T>> Get<T>(string url);
        Task<HttpResponseWrapper<object>> Post<T>(string url, T model);



        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T model);



        Task<HttpResponseWrapper<object>> DeleteAsync<T>(string url);

        Task<HttpResponseWrapper<object>> PutAsync<T>(string url, T model);



        Task<HttpResponseWrapper<TResponse>> PutAsync<T, TResponse>(string url, T model);

        
    }

}