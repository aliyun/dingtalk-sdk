// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CampusListRenterResponseBody : TeaModel {
        /// <summary>
        /// 租客列表
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<CampusListRenterResponseBodyResult> Result { get; set; }
        public class CampusListRenterResponseBodyResult : TeaModel {
            /// <summary>
            /// 绑定钉钉组织ID
            /// </summary>
            [NameInMap("bindRenterCorpId")]
            [Validation(Required=false)]
            public string BindRenterCorpId { get; set; }

            /// <summary>
            /// 绑定时间
            /// </summary>
            [NameInMap("bindTime")]
            [Validation(Required=false)]
            public long? BindTime { get; set; }

            /// <summary>
            /// 企业信用代码
            /// </summary>
            [NameInMap("creditCode")]
            [Validation(Required=false)]
            public string CreditCode { get; set; }

            /// <summary>
            /// 到期时间
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// 扩展信息
            /// </summary>
            [NameInMap("extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            /// <summary>
            /// 租客名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 租客部门ID
            /// </summary>
            [NameInMap("renterDeptId")]
            [Validation(Required=false)]
            public long? RenterDeptId { get; set; }

            /// <summary>
            /// 起始时间
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// 状态
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public int? State { get; set; }

        }

    }

}
