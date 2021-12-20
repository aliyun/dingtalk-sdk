// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class ListSubSpaceResponseBody : TeaModel {
        /// <summary>
        /// result
        /// </summary>
        [NameInMap("spaceList")]
        [Validation(Required=false)]
        public List<ListSubSpaceResponseBodySpaceList> SpaceList { get; set; }
        public class ListSubSpaceResponseBodySpaceList : TeaModel {
            [NameInMap("referId")]
            [Validation(Required=false)]
            public long? ReferId { get; set; }

            [NameInMap("spaceName")]
            [Validation(Required=false)]
            public string SpaceName { get; set; }

            [NameInMap("tagCode")]
            [Validation(Required=false)]
            public string TagCode { get; set; }

            /// <summary>
            /// 空间类型为楼时，1高层/2低层/3别墅/4其他，空间类型为房屋是，1住宅/2公寓/3排屋/4洋房/5叠墅/6别墅/7商铺/8办公用房/9经营用房/10其他
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("floor")]
            [Validation(Required=false)]
            public string Floor { get; set; }

            [NameInMap("isVirtual")]
            [Validation(Required=false)]
            public int? IsVirtual { get; set; }

            [NameInMap("billingArea")]
            [Validation(Required=false)]
            public float? BillingArea { get; set; }

            [NameInMap("buildingArea")]
            [Validation(Required=false)]
            public float? BuildingArea { get; set; }

            /// <summary>
            /// 房屋状态：0空置/1未领/2入住/3空关/4装修
            /// </summary>
            [NameInMap("houseState")]
            [Validation(Required=false)]
            public int? HouseState { get; set; }

            [NameInMap("parentReferId")]
            [Validation(Required=false)]
            public long? ParentReferId { get; set; }

        }

    }

}
