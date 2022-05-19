// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class UpdateSpaceRequest : TeaModel {
        /// <summary>
        /// 修改后空间信息
        /// </summary>
        [NameInMap("spaceInfoVOList")]
        [Validation(Required=false)]
        public List<UpdateSpaceRequestSpaceInfoVOList> SpaceInfoVOList { get; set; }
        public class UpdateSpaceRequestSpaceInfoVOList : TeaModel {
            /// <summary>
            /// 计费面积
            /// </summary>
            [NameInMap("billingArea")]
            [Validation(Required=false)]
            public float? BillingArea { get; set; }

            /// <summary>
            /// 建筑面积
            /// </summary>
            [NameInMap("buildingArea")]
            [Validation(Required=false)]
            public float? BuildingArea { get; set; }

            /// <summary>
            /// 楼栋类型
            /// </summary>
            [NameInMap("buildingType")]
            [Validation(Required=false)]
            public long? BuildingType { get; set; }

            /// <summary>
            /// 修改的空间的唯一标识
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            /// <summary>
            /// 房屋所在楼层，当tagCode为House时选填
            /// </summary>
            [NameInMap("floor")]
            [Validation(Required=false)]
            public string Floor { get; set; }

            /// <summary>
            /// 房屋状态，tagcode为house时选填，0空置/1未领/2入住/3空关/4装修
            /// </summary>
            [NameInMap("houseState")]
            [Validation(Required=false)]
            public long? HouseState { get; set; }

            /// <summary>
            /// 房屋类型，当tagcode为House时必填
            /// </summary>
            [NameInMap("houseType")]
            [Validation(Required=false)]
            public long? HouseType { get; set; }

            /// <summary>
            /// 修改后名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 父节点id
            /// </summary>
            [NameInMap("parentDeptId")]
            [Validation(Required=false)]
            public float? ParentDeptId { get; set; }

            /// <summary>
            /// 空间类型
            /// </summary>
            [NameInMap("tagCode")]
            [Validation(Required=false)]
            public string TagCode { get; set; }

        }

    }

}
