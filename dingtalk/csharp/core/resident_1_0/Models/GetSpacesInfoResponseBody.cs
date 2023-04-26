// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class GetSpacesInfoResponseBody : TeaModel {
        [NameInMap("spaceList")]
        [Validation(Required=false)]
        public List<GetSpacesInfoResponseBodySpaceList> SpaceList { get; set; }
        public class GetSpacesInfoResponseBodySpaceList : TeaModel {
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
            public int? HouseState { get; set; }

            [NameInMap("isVirtual")]
            [Validation(Required=false)]
            public int? IsVirtual { get; set; }

            [NameInMap("parentReferId")]
            [Validation(Required=false)]
            public long? ParentReferId { get; set; }

            [NameInMap("referId")]
            [Validation(Required=false)]
            public long? ReferId { get; set; }

            [NameInMap("spaceName")]
            [Validation(Required=false)]
            public string SpaceName { get; set; }

            [NameInMap("tagCode")]
            [Validation(Required=false)]
            public string TagCode { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
