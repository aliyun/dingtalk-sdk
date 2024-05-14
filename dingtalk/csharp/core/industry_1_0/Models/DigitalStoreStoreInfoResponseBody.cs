// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class DigitalStoreStoreInfoResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("businessHours")]
        [Validation(Required=false)]
        public string BusinessHours { get; set; }

        [NameInMap("dingDeptId")]
        [Validation(Required=false)]
        public long? DingDeptId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("latitude")]
        [Validation(Required=false)]
        public string Latitude { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("locationAddress")]
        [Validation(Required=false)]
        public string LocationAddress { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("longitude")]
        [Validation(Required=false)]
        public string Longitude { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("storeAcreage")]
        [Validation(Required=false)]
        public string StoreAcreage { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("storeBandwidth")]
        [Validation(Required=false)]
        public string StoreBandwidth { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("storeCode")]
        [Validation(Required=false)]
        public string StoreCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("storeId")]
        [Validation(Required=false)]
        public long? StoreId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

    }

}
