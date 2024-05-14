// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class CreateSpaceRequest : TeaModel {
        [NameInMap("billingArea")]
        [Validation(Required=false)]
        public float? BillingArea { get; set; }

        [NameInMap("buildingArea")]
        [Validation(Required=false)]
        public float? BuildingArea { get; set; }

        [NameInMap("floor")]
        [Validation(Required=false)]
        public string Floor { get; set; }

        [NameInMap("houseState")]
        [Validation(Required=false)]
        public long? HouseState { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("parentDeptId")]
        [Validation(Required=false)]
        public string ParentDeptId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("tagCode")]
        [Validation(Required=false)]
        public string TagCode { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
