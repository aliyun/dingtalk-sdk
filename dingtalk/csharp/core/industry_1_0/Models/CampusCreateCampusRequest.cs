// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CampusCreateCampusRequest : TeaModel {
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("area")]
        [Validation(Required=false)]
        public double? Area { get; set; }

        [NameInMap("belongProjectGroupId")]
        [Validation(Required=false)]
        public long? BelongProjectGroupId { get; set; }

        [NameInMap("campusName")]
        [Validation(Required=false)]
        public string CampusName { get; set; }

        [NameInMap("capacity")]
        [Validation(Required=false)]
        public int? Capacity { get; set; }

        [NameInMap("cityId")]
        [Validation(Required=false)]
        public int? CityId { get; set; }

        [NameInMap("country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        [NameInMap("countyId")]
        [Validation(Required=false)]
        public int? CountyId { get; set; }

        [NameInMap("creatorUnionId")]
        [Validation(Required=false)]
        public string CreatorUnionId { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("orderEndTime")]
        [Validation(Required=false)]
        public long? OrderEndTime { get; set; }

        [NameInMap("orderInfo")]
        [Validation(Required=false)]
        public string OrderInfo { get; set; }

        [NameInMap("orderStartTime")]
        [Validation(Required=false)]
        public long? OrderStartTime { get; set; }

        [NameInMap("provId")]
        [Validation(Required=false)]
        public int? ProvId { get; set; }

        [NameInMap("telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

    }

}
