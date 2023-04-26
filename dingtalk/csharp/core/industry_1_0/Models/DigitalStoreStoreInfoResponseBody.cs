// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class DigitalStoreStoreInfoResponseBody : TeaModel {
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("businessHours")]
        [Validation(Required=false)]
        public string BusinessHours { get; set; }

        [NameInMap("dingDeptId")]
        [Validation(Required=false)]
        public long? DingDeptId { get; set; }

        [NameInMap("latitude")]
        [Validation(Required=false)]
        public string Latitude { get; set; }

        [NameInMap("locationAddress")]
        [Validation(Required=false)]
        public string LocationAddress { get; set; }

        [NameInMap("longitude")]
        [Validation(Required=false)]
        public string Longitude { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("parentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("storeAcreage")]
        [Validation(Required=false)]
        public string StoreAcreage { get; set; }

        [NameInMap("storeBandwidth")]
        [Validation(Required=false)]
        public string StoreBandwidth { get; set; }

        [NameInMap("storeCode")]
        [Validation(Required=false)]
        public string StoreCode { get; set; }

        [NameInMap("storeId")]
        [Validation(Required=false)]
        public long? StoreId { get; set; }

        [NameInMap("telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

    }

}
