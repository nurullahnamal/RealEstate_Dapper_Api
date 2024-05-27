using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task< IActionResult> Index()
        {
            #region istatistik1
            var client =_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7208/api/Statistics/ActiveCategoryCount");

            var jsonData= await  responseMessage.Content.ReadAsStringAsync();
            ViewBag.activeCategoryCount = jsonData;
            #endregion

            #region istatistik2
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client.GetAsync("https://localhost:7208/api/Statistics/ActiveEmployeeCount");

            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.ActiveEmployeeCount = jsonData2;
            #endregion



            #region istatistik3
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3= await client.GetAsync("https://localhost:7208/api/Statistics/ApartmentCount");

            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.ApartmentCount = jsonData3;
            #endregion

            #region istatistik4
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client.GetAsync("https://localhost:7208/api/Statistics/AverageProductByRent");

            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.AverageProductByRent = jsonData4;
            #endregion

            #region istatistik5
            var client5 = _httpClientFactory.CreateClient();
            var responseMessage5 = await client.GetAsync("https://localhost:7208/api/Statistics/AverageProductBySale");

            var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
            ViewBag.AverageProductBySale = jsonData5;
            #endregion

            #region istatistik6
            var client6 = _httpClientFactory.CreateClient();
            var responseMessage6 = await client.GetAsync("https://localhost:7208/api/Statistics/AverageRoomCount");

            var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
            ViewBag.AverageRoomCount = jsonData6;
            #endregion

            #region istatistik7
            var client7 = _httpClientFactory.CreateClient();
            var responseMessage7 = await client.GetAsync("https://localhost:7208/api/Statistics/CategoryCount");

            var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
            ViewBag.CategoryCount = jsonData7;
            #endregion

            #region istatistik8
            var client8 = _httpClientFactory.CreateClient();
            var responseMessage8 = await client.GetAsync("https://localhost:7208/api/Statistics/CategoryNameByMaxProductCount");

            var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
            ViewBag.CategoryNameByMaxProductCount = jsonData8;
            #endregion

            #region istatistik9
            var client9 = _httpClientFactory.CreateClient();
            var responseMessage9 = await client.GetAsync("https://localhost:7208/api/Statistics/CityNameByMaxProductCount");

            var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
            ViewBag.CityNameByMaxProductCount = jsonData9;
            #endregion


            #region istatistik10
            var client10 = _httpClientFactory.CreateClient();
            var responseMessage10 = await client.GetAsync("https://localhost:7208/api/Statistics/DifferentCityCount");

            var jsonData10= await responseMessage10.Content.ReadAsStringAsync();
            ViewBag.DifferentCityCount = jsonData10;
            #endregion


            #region istatistik11
            var client11 = _httpClientFactory.CreateClient();
            var responseMessage11 = await client.GetAsync("https://localhost:7208/api/Statistics/EmployeeNameByMaxProductCount");

            var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
            ViewBag.EmployeeNameByMaxProductCount = jsonData11;
            #endregion


            #region istatistik12
            var client12 = _httpClientFactory.CreateClient();
            var responseMessage12 = await client.GetAsync("https://localhost:7208/api/Statistics/LastProductPrice");

            var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
            ViewBag.LastProductPrice = jsonData12;
            #endregion


            #region istatistik13
            var client13 = _httpClientFactory.CreateClient();
            var responseMessage13 = await client.GetAsync("https://localhost:7208/api/Statistics/NewentBuildingPrice");

            var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
            ViewBag.NewentBuildingPrice = jsonData13;
            #endregion

            #region istatistik14
            var client14 = _httpClientFactory.CreateClient();
            var responseMessage14 = await client.GetAsync("https://localhost:7208/api/Statistics/OldestBuildingYear");

            var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
            ViewBag.OldestBuildingYear = jsonData14;
            #endregion


            #region istatistik15
            var client15 = _httpClientFactory.CreateClient();
            var responseMessage15 = await client.GetAsync("https://localhost:7208/api/Statistics/PassiveCategoryCount");

            var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
            ViewBag.PassiveCategoryCount = jsonData15;

            #region istatistik16
            var client16 = _httpClientFactory.CreateClient();
            var responseMessage16 = await client.GetAsync("https://localhost:7208/api/Statistics/ProductCount");

            var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
            ViewBag.ProductCount = jsonData16;
            #endregion
            #endregion
            return View();
        }


    }
}
