// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class GetResidentInfoResponseBody : TeaModel {
        /// <summary>
        /// 小区地址
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// 全员群opencid
        /// </summary>
        [NameInMap("allUserGroupOpenConversationId")]
        [Validation(Required=false)]
        public string AllUserGroupOpenConversationId { get; set; }

        /// <summary>
        /// 全员群群主 userid
        /// </summary>
        [NameInMap("allUserGroupOwnerUserId")]
        [Validation(Required=false)]
        public string AllUserGroupOwnerUserId { get; set; }

        [NameInMap("buildingArea")]
        [Validation(Required=false)]
        public float? BuildingArea { get; set; }

        /// <summary>
        /// 小区归属的市的id
        /// </summary>
        [NameInMap("cityId")]
        [Validation(Required=false)]
        public int? CityId { get; set; }

        /// <summary>
        /// 通信录模式:0标准/1自定义
        /// </summary>
        [NameInMap("contactMode")]
        [Validation(Required=false)]
        public int? ContactMode { get; set; }

        /// <summary>
        /// 小区归属的区/县的id
        /// </summary>
        [NameInMap("countyId")]
        [Validation(Required=false)]
        public int? CountyId { get; set; }

        /// <summary>
        /// 交付时间
        /// </summary>
        [NameInMap("deliveryTime")]
        [Validation(Required=false)]
        public long? DeliveryTime { get; set; }

        /// <summary>
        /// 经纬度，格式：经度,纬度
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// 小区名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("projectManager")]
        [Validation(Required=false)]
        public GetResidentInfoResponseBodyProjectManager ProjectManager { get; set; }
        public class GetResidentInfoResponseBodyProjectManager : TeaModel {
            [NameInMap("avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
        };

        /// <summary>
        /// 物业部门群cid
        /// </summary>
        [NameInMap("propertyDeptGroupOpenConversationId")]
        [Validation(Required=false)]
        public string PropertyDeptGroupOpenConversationId { get; set; }

        /// <summary>
        /// 物业部门群主userid
        /// </summary>
        [NameInMap("propertyDeptGroupOwnerUserId")]
        [Validation(Required=false)]
        public string PropertyDeptGroupOwnerUserId { get; set; }

        /// <summary>
        /// 小区归属的省的id
        /// </summary>
        [NameInMap("provId")]
        [Validation(Required=false)]
        public long? ProvId { get; set; }

        /// <summary>
        /// 物业管理范围-东
        /// </summary>
        [NameInMap("scopeEast")]
        [Validation(Required=false)]
        public string ScopeEast { get; set; }

        /// <summary>
        /// 物业管理范围-北
        /// </summary>
        [NameInMap("scopeNorth")]
        [Validation(Required=false)]
        public string ScopeNorth { get; set; }

        /// <summary>
        /// 物业管理范围-南
        /// </summary>
        [NameInMap("scopeSouth")]
        [Validation(Required=false)]
        public string ScopeSouth { get; set; }

        /// <summary>
        /// 物业管理范围-西
        /// </summary>
        [NameInMap("scopeWest")]
        [Validation(Required=false)]
        public string ScopeWest { get; set; }

        /// <summary>
        /// 物业电话
        /// </summary>
        [NameInMap("telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

        /// <summary>
        /// 小区归属的街道/镇的id
        /// </summary>
        [NameInMap("townId")]
        [Validation(Required=false)]
        public int? TownId { get; set; }

        /// <summary>
        /// 1纯住宅；2:商住混合；3:办公；4:办公商业混合；5:商业；6:公共场所；7:其他
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
