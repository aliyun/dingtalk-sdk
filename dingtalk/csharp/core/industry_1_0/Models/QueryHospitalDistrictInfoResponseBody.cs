// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryHospitalDistrictInfoResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryHospitalDistrictInfoResponseBodyContent> Content { get; set; }
        public class QueryHospitalDistrictInfoResponseBodyContent : TeaModel {
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("deleted")]
            [Validation(Required=false)]
            public int? Deleted { get; set; }

            [NameInMap("districtName")]
            [Validation(Required=false)]
            public string DistrictName { get; set; }

            [NameInMap("districtType")]
            [Validation(Required=false)]
            public int? DistrictType { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("parentDistrictId")]
            [Validation(Required=false)]
            public long? ParentDistrictId { get; set; }

        }

        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("totalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
