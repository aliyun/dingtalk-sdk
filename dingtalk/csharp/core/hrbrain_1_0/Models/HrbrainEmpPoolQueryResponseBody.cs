// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainEmpPoolQueryResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public HrbrainEmpPoolQueryResponseBodyContent Content { get; set; }
        public class HrbrainEmpPoolQueryResponseBodyContent : TeaModel {
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public int? NextToken { get; set; }

            [NameInMap("poolInfos")]
            [Validation(Required=false)]
            public List<HrbrainEmpPoolQueryResponseBodyContentPoolInfos> PoolInfos { get; set; }
            public class HrbrainEmpPoolQueryResponseBodyContentPoolInfos : TeaModel {
                [NameInMap("poolCode")]
                [Validation(Required=false)]
                public string PoolCode { get; set; }

                [NameInMap("poolDesc")]
                [Validation(Required=false)]
                public string PoolDesc { get; set; }

                [NameInMap("poolName")]
                [Validation(Required=false)]
                public string PoolName { get; set; }

                [NameInMap("poolTags")]
                [Validation(Required=false)]
                public List<HrbrainEmpPoolQueryResponseBodyContentPoolInfosPoolTags> PoolTags { get; set; }
                public class HrbrainEmpPoolQueryResponseBodyContentPoolInfosPoolTags : TeaModel {
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
