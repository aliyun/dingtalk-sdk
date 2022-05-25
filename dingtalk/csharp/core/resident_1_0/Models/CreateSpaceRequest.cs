// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class CreateSpaceRequest : TeaModel {
        /// <summary>
        /// 仅当tag未房屋时有用
        /// </summary>
        [NameInMap("billingArea")]
        [Validation(Required=false)]
        public float? BillingArea { get; set; }

        /// <summary>
        /// 仅当tag未房屋时有用
        /// </summary>
        [NameInMap("buildingArea")]
        [Validation(Required=false)]
        public float? BuildingArea { get; set; }

        /// <summary>
        /// 仅当tag未房屋时有用
        /// </summary>
        [NameInMap("floor")]
        [Validation(Required=false)]
        public string Floor { get; set; }

        /// <summary>
        /// 仅当tag未房屋时有用
        /// </summary>
        [NameInMap("houseState")]
        [Validation(Required=false)]
        public long? HouseState { get; set; }

        /// <summary>
        /// 空间名称，如A栋，二单元，406室等
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 父节点id，根节点为-7
        /// </summary>
        [NameInMap("parentDeptId")]
        [Validation(Required=false)]
        public string ParentDeptId { get; set; }

        /// <summary>
        /// 空间tag标识，目前有House/Unit/Building/Partition
        /// </summary>
        [NameInMap("tagCode")]
        [Validation(Required=false)]
        public string TagCode { get; set; }

        /// <summary>
        /// * 空间类型为楼时，1住宅/2公寓/3排屋/4洋房/5叠墅/6别墅/7商铺/8办公用房/9经营用房/10其他      * 空间类型为房屋是，1普通住宅/2公寓/3排屋/4物业管理用房/5社区用房/6别墅/7商铺/8办公用房（商写）/9经营用房/10其他
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
