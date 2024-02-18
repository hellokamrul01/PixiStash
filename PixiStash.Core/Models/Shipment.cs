using System;
using System.ComponentModel.DataAnnotations;

namespace PixiStash.Core.Models
{
    public class Shipment
    {
        public Guid ShipmentId { get; set; }
        [Display(Name = "Shipment Number")]
        public string ShipmentName { get; set; }
        [Display(Name = "Sales Order")]
        public int SalesOrderId { get; set; }
        public DateTimeOffset ShipmentDate { get; set; }
        [Display(Name = "Shipment Type")]
        public Guid ShipmentTypeId { get; set; }
        [Display(Name = "Warehouse")]
        public Guid WarehouseId { get; set; }
        [Display(Name = "Full Shipment")]
        public bool IsFullShipment { get; set; } = true;

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
