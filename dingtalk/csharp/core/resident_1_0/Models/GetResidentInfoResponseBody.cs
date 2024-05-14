// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class GetResidentInfoResponseBody : TeaModel {
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("allUserGroupOpenConversationId")]
        [Validation(Required=false)]
        public string AllUserGroupOpenConversationId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("allUserGroupOwnerUserId")]
        [Validation(Required=false)]
        public string AllUserGroupOwnerUserId { get; set; }

        [NameInMap("buildingArea")]
        [Validation(Required=false)]
        public float? BuildingArea { get; set; }

        [NameInMap("cityId")]
        [Validation(Required=false)]
        public int? CityId { get; set; }

        [NameInMap("contactMode")]
        [Validation(Required=false)]
        public int? ContactMode { get; set; }

        [NameInMap("countyId")]
        [Validation(Required=false)]
        public int? CountyId { get; set; }

        [NameInMap("deliveryTime")]
        [Validation(Required=false)]
        public long? DeliveryTime { get; set; }

        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

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

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("propertyDeptGroupOpenConversationId")]
        [Validation(Required=false)]
        public string PropertyDeptGroupOpenConversationId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("propertyDeptGroupOwnerUserId")]
        [Validation(Required=false)]
        public string PropertyDeptGroupOwnerUserId { get; set; }

        [NameInMap("provId")]
        [Validation(Required=false)]
        public long? ProvId { get; set; }

        [NameInMap("scopeEast")]
        [Validation(Required=false)]
        public string ScopeEast { get; set; }

        [NameInMap("scopeNorth")]
        [Validation(Required=false)]
        public string ScopeNorth { get; set; }

        [NameInMap("scopeSouth")]
        [Validation(Required=false)]
        public string ScopeSouth { get; set; }

        [NameInMap("scopeWest")]
        [Validation(Required=false)]
        public string ScopeWest { get; set; }

        [NameInMap("telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

        [NameInMap("townId")]
        [Validation(Required=false)]
        public int? TownId { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
