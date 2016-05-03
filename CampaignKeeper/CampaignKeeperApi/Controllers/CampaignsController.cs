using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using CampaignKeeperApi.Models;
using CampaignKeeperPcl;

namespace CampaignKeeperApi.Controllers
{
    public class CampaignsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Campaigns
        public IQueryable<Campaign> GetCampaigns()
        {
            return db.Campaigns;
        }

        // GET: api/Campaigns/5
        [ResponseType(typeof(Campaign))]
        public async Task<IHttpActionResult> GetCampaign(int id)
        {
            Campaign campaign = await db.Campaigns.FindAsync(id);
            if (campaign == null)
            {
                return NotFound();
            }

            return Ok(campaign);
        }

        // PUT: api/Campaigns/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCampaign(int id, Campaign campaign)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != campaign.Id)
            {
                return BadRequest();
            }

            db.Entry(campaign).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CampaignExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Campaigns
        [ResponseType(typeof(Campaign))]
        public async Task<IHttpActionResult> PostCampaign(Campaign campaign)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Campaigns.Add(campaign);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = campaign.Id }, campaign);
        }

        // DELETE: api/Campaigns/5
        [ResponseType(typeof(Campaign))]
        public async Task<IHttpActionResult> DeleteCampaign(int id)
        {
            Campaign campaign = await db.Campaigns.FindAsync(id);
            if (campaign == null)
            {
                return NotFound();
            }

            db.Campaigns.Remove(campaign);
            await db.SaveChangesAsync();

            return Ok(campaign);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CampaignExists(int id)
        {
            return db.Campaigns.Count(e => e.Id == id) > 0;
        }
    }
}