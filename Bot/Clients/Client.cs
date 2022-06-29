using Sport.Constants;
using Sport.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net;
using System.Text;

namespace Sport.Clients
{
    public class Client
    {
        private HttpClient _httpClient;
        private static string _address;

        public Client()
        {
            _address = Constant.address;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", "7b935028f5msh40de1f419ce48b6p18ba32jsn4a92e75d583e");
            _httpClient.BaseAddress = new Uri(_address);
        }
        public async Task<EventLiveList> GetEventLiveListAsync()
        {
            var response = await _httpClient.GetAsync($"/GetEventLiveList/EventLiveList");
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<EventLiveList>(content);
            return result;
        }
        public async Task<EventListByDate> GetEventListByDateAsync(string date)
        {
            var response = await _httpClient.GetAsync($"/GetEventListByDate/EventListByDate?date={date}");
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<EventListByDate>(content);
            return result;
        }
        public async Task<RefereeList> GetRefereeListAsync()
        {
            var response = await _httpClient.GetAsync($"/GetRefereeList/RefereeList");
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<RefereeList>(content);
            return result;
        }
        public async Task<TeamList> GetTeamListAsync()
        {
            var response = await _httpClient.GetAsync($"/GetTeamListControleer/TeamList");
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<TeamList>(content);
            return result;
        }

        public async Task<ManagerList> GetManagerListAsync()
        {
            var response = await _httpClient.GetAsync($"/ManagerList/ManagerList");
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<ManagerList>(content);
            return result;
        }
        public async Task<PlayerList> GetPlayerListAsync()
        {
            var response = await _httpClient.GetAsync($"/GetPlayerList/PlayerList");
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<PlayerList>(content);
            return result;
        }
        public async Task<SaveManager> SaveManager(int id)
        {
            var response = await _httpClient.GetAsync($"/ManagerList/SaveManagers?id={id}");

            var content = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<SaveManager>(content);

            var v = JsonConvert.SerializeObject(result);


            return result;
        }

        public async Task<SaveReferee> SaveReferee(int id)
        {
            var response = await _httpClient.GetAsync($"/GetRefereeList/SaveReferees?id={id}");
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<SaveReferee>(content);
            var v = JsonConvert.SerializeObject(result);
            return result;
        }
        public async Task<SavePlayer> SavePlayer(int id)
        {
            var response = await _httpClient.GetAsync($"/GetRefereeList/SaveReferees?id={id}");
            var content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<SavePlayer>(content);
            var v = JsonConvert.SerializeObject(result);
            return result;
        } 
    }
}   

