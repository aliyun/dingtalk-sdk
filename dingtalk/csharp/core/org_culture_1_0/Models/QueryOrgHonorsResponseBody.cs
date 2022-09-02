// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class QueryOrgHonorsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryOrgHonorsResponseBodyResult Result { get; set; }
        public class QueryOrgHonorsResponseBodyResult : TeaModel {
            /// <summary>
            /// 下次获取数据的游标
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("openHonors")]
            [Validation(Required=false)]
            public List<QueryOrgHonorsResponseBodyResultOpenHonors> OpenHonors { get; set; }
            public class QueryOrgHonorsResponseBodyResultOpenHonors : TeaModel {
                /// <summary>
                /// 荣誉含义
                /// </summary>
                [NameInMap("honorDesc")]
                [Validation(Required=false)]
                public string HonorDesc { get; set; }

                /// <summary>
                /// 荣誉id
                /// </summary>
                [NameInMap("honorId")]
                [Validation(Required=false)]
                public long? HonorId { get; set; }

                /// <summary>
                /// 荣誉图片url
                /// </summary>
                [NameInMap("honorImgUrl")]
                [Validation(Required=false)]
                public string HonorImgUrl { get; set; }

                /// <summary>
                /// 荣誉名字
                /// </summary>
                [NameInMap("honorName")]
                [Validation(Required=false)]
                public string HonorName { get; set; }

                /// <summary>
                /// 荣誉附赠的挂件图url
                /// </summary>
                [NameInMap("honorPendantImgUrl")]
                [Validation(Required=false)]
                public string HonorPendantImgUrl { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
