// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcarbon_1_0.Models
{
    public class WriteUserCarbonRequest : TeaModel {
        /// <summary>
        /// 入参集
        /// </summary>
        [NameInMap("userDetailsList")]
        [Validation(Required=false)]
        public List<WriteUserCarbonRequestUserDetailsList> UserDetailsList { get; set; }
        public class WriteUserCarbonRequestUserDetailsList : TeaModel {
            /// <summary>
            /// 行为结束时间
            /// </summary>
            [NameInMap("actionEndTime")]
            [Validation(Required=false)]
            public string ActionEndTime { get; set; }

            /// <summary>
            /// 系统唯一id，生成格式：userId+日期20211126
            /// </summary>
            [NameInMap("actionId")]
            [Validation(Required=false)]
            public string ActionId { get; set; }

            /// <summary>
            /// 行为起始时间
            /// </summary>
            [NameInMap("actionStartTime")]
            [Validation(Required=false)]
            public string ActionStartTime { get; set; }

            /// <summary>
            /// 碳能量行为类型，需要联系管理员添加
            /// </summary>
            [NameInMap("actionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            /// <summary>
            /// 碳能量数据
            /// </summary>
            [NameInMap("carbonAmount")]
            [Validation(Required=false)]
            public string CarbonAmount { get; set; }

            /// <summary>
            /// 钉钉组织id
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// 钉钉部门id
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            /// <summary>
            /// 钉钉用户id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 版本，默认为1
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

    }

}
