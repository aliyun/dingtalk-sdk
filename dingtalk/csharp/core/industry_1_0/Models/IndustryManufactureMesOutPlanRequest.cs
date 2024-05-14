// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureMesOutPlanRequest : TeaModel {
        [NameInMap("approvalStatus")]
        [Validation(Required=false)]
        public string ApprovalStatus { get; set; }

        [NameInMap("approver")]
        [Validation(Required=false)]
        public string Approver { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("baseDataName")]
        [Validation(Required=false)]
        public string BaseDataName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("outSourceProjectCode")]
        [Validation(Required=false)]
        public string OutSourceProjectCode { get; set; }

        [NameInMap("outSourceTeamId")]
        [Validation(Required=false)]
        public string OutSourceTeamId { get; set; }

        [NameInMap("price")]
        [Validation(Required=false)]
        public string Price { get; set; }

        [NameInMap("processIdentificationCode")]
        [Validation(Required=false)]
        public string ProcessIdentificationCode { get; set; }

        [NameInMap("processUuids")]
        [Validation(Required=false)]
        public string ProcessUuids { get; set; }

        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        [NameInMap("productSpecification")]
        [Validation(Required=false)]
        public string ProductSpecification { get; set; }

        [NameInMap("projectCode")]
        [Validation(Required=false)]
        public string ProjectCode { get; set; }

        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("sendPlanQuantity")]
        [Validation(Required=false)]
        public string SendPlanQuantity { get; set; }

        [NameInMap("supplierCode")]
        [Validation(Required=false)]
        public string SupplierCode { get; set; }

        [NameInMap("supplierName")]
        [Validation(Required=false)]
        public string SupplierName { get; set; }

        [NameInMap("totalWage")]
        [Validation(Required=false)]
        public string TotalWage { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
