/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmanufacturing_1_0.Models
{
    public class IndustrializeManufactureJobBookRequest : TeaModel {
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("instNo")]
        [Validation(Required=false)]
        public string InstNo { get; set; }

        [NameInMap("isBatchJob")]
        [Validation(Required=false)]
        public string IsBatchJob { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("manufactureDate")]
        [Validation(Required=false)]
        public string ManufactureDate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("mesAppKey")]
        [Validation(Required=false)]
        public string MesAppKey { get; set; }

        [NameInMap("processEnName")]
        [Validation(Required=false)]
        public string ProcessEnName { get; set; }

        [NameInMap("processName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("productEnName")]
        [Validation(Required=false)]
        public string ProductEnName { get; set; }

        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        [NameInMap("productSpecification")]
        [Validation(Required=false)]
        public string ProductSpecification { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("qualifiedQuantity")]
        [Validation(Required=false)]
        public string QualifiedQuantity { get; set; }

        [NameInMap("reworkableQuantity")]
        [Validation(Required=false)]
        public string ReworkableQuantity { get; set; }

        [NameInMap("scrappedQuantity")]
        [Validation(Required=false)]
        public string ScrappedQuantity { get; set; }

        [NameInMap("unitPrice")]
        [Validation(Required=false)]
        public string UnitPrice { get; set; }

        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public string UserIdList { get; set; }

        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("userNameList")]
        [Validation(Required=false)]
        public string UserNameList { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
