using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace porto_spots.Services
{
    public static class GitFetcher
    {
        public static HttpClient? HttpClient;

        public static void Initialize(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public static async Task<T?> FetchJsonAsync<T>(string gitLink)
        {
            if (HttpClient == null)
                throw new NotImplementedException("The http client has not been injected in the Git Fetching Service");

            return await HttpClient.GetFromJsonAsync<T>(gitLink);
        }

        public static async Task<string> FetchStringAsync(string gitLink)
        {
            if (HttpClient == null)
                throw new NotImplementedException("The http client has not been injected in the Git Fetching Service");

            return  await (await HttpClient.GetAsync(gitLink)).Content.ReadAsStringAsync();
        }

    }

    public class GitLink
    {
        private const string BASE_URL = "https://raw.githubusercontent.com/PortoSpots/BackendData/master";
        private const string ARTICLES_SUB_URL = "articles";
        private const string LISTS_SUB_URL = "lists";
        private const string MAIN_LIST_FILE = "main-list";

        private string Url;
        public GitLink()
        {
            Url = BASE_URL;
        }

        public override string ToString() => Url;


        public GitLink Append_Url(string subUrl)
        {
            this.Url = $"{this.Url}/{subUrl}";
            return this;
        }

        public string Append_EndUrl(string endUrl)
        {
            this.Url = $"{this.Url}/{endUrl}";
            return this.Url;
        }

        public GitLink AppendArticles_Url() => Append_Url(ARTICLES_SUB_URL);

        public string AppendArticle_EndUrl(string articleName) => Append_EndUrl($"{articleName}.json");

        public string AppendMainList_EndUrl() => Append_EndUrl($"{LISTS_SUB_URL}/{MAIN_LIST_FILE}.json");

    }
}