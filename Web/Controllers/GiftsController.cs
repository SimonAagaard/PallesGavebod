using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Entities;
using Newtonsoft.Json;

namespace Web.Controllers
{
    public class GiftsController : Controller
    {
        private readonly DataContext _context;
        private readonly HttpClient _httpClient;
        private Uri BaseEndPoint { get; set; }
        private Uri BaseEndPointGirls { get; set; }
        private Uri BaseEndPointBoys { get; set; }

        public GiftsController()
        {
            BaseEndPoint = new Uri("https://localhost:44344/api/gifts");
            BaseEndPointGirls = new Uri("https://localhost:44344/api/gifts/girl");
            BaseEndPointBoys = new Uri("https://localhost:44344/api/gifts/boy");
            _httpClient = new HttpClient();
        }

        // GET: Gifts
        public async Task<IActionResult> Index()
        {
            // use HTTP client to read data from API. Move on once the headers have been read. Errors are caught slightly quicker this way.
            var response = await _httpClient.GetAsync(BaseEndPoint, HttpCompletionOption.ResponseHeadersRead);
            // Make sure that we got a success status code in the headers. Returns an exception (and 500 status code) if not successful
            response.EnsureSuccessStatusCode();
            // Turn the response body into a string
            var data = await response.Content.ReadAsStringAsync();
            // Treat the response body string as JSON, and deserialize it into a list of gifts
            return View(JsonConvert.DeserializeObject<List<Gift>>(data));
        }

        //Get girls
        public async Task<IActionResult> GirlGifts()
        {
            var response = await _httpClient.GetAsync(BaseEndPointGirls, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            return View(JsonConvert.DeserializeObject<List<Gift>>(data));
        }

        //Get boys
        public async Task<IActionResult> BoyGifts()
        {
            var response = await _httpClient.GetAsync(BaseEndPointBoys, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            return View(JsonConvert.DeserializeObject<List<Gift>>(data));
        }

        // GET: Gifts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gift = await _context.Gifts
                .FirstOrDefaultAsync(m => m.GiftNumber == id);
            if (gift == null)
            {
                return NotFound();
            }

            return View(gift);
        }

        // GET: Gifts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gifts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GiftNumber,Title,Description,CreationDate,BoyGift,GirlGift")] Gift gift)
        {
            if (ModelState.IsValid)
            {
                var response = await _httpClient.PostAsJsonAsync<Gift>(BaseEndPoint, gift);
                response.EnsureSuccessStatusCode();
                return RedirectToAction(nameof(Index));
            }
            return View(gift);
        }

        private bool GiftExists(int id)
        {
            return _context.Gifts.Any(e => e.GiftNumber == id);
        }
    }
}
