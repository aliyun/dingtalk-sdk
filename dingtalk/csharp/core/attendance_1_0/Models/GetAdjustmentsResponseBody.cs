// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetAdjustmentsResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetAdjustmentsResponseBodyResult> Result { get; set; }
        public class GetAdjustmentsResponseBodyResult : TeaModel {
            /// <summary>
            /// 补卡规则集合
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<GetAdjustmentsResponseBodyResultItems> Items { get; set; }
            public class GetAdjustmentsResponseBodyResultItems : TeaModel {
                /// <summary>
                /// 补卡规则id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// 补卡规则名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// 当前页码
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// 总页数
            /// </summary>
            [NameInMap("totalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

        }

    }

}
