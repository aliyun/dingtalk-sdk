// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class UpdateSpaceRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("spaceInfoVOList")]
        [Validation(Required=false)]
        public List<UpdateSpaceRequestSpaceInfoVOList> SpaceInfoVOList { get; set; }
        public class UpdateSpaceRequestSpaceInfoVOList : TeaModel {
            [NameInMap("billingArea")]
            [Validation(Required=false)]
            public float? BillingArea { get; set; }

            [NameInMap("buildingArea")]
            [Validation(Required=false)]
            public float? BuildingArea { get; set; }

            [NameInMap("buildingType")]
            [Validation(Required=false)]
            public long? BuildingType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            [NameInMap("floor")]
            [Validation(Required=false)]
            public string Floor { get; set; }

            [NameInMap("houseState")]
            [Validation(Required=false)]
            public long? HouseState { get; set; }

            [NameInMap("houseType")]
            [Validation(Required=false)]
            public long? HouseType { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("parentDeptId")]
            [Validation(Required=false)]
            public long? ParentDeptId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("tagCode")]
            [Validation(Required=false)]
            public string TagCode { get; set; }

        }

    }

}
