// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetClosingAccountsResponseBody : TeaModel {
        /// <summary>
        /// 规则列表
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetClosingAccountsResponseBodyResult> Result { get; set; }
        public class GetClosingAccountsResponseBodyResult : TeaModel {
            /// <summary>
            /// 封账规则
            /// </summary>
            [NameInMap("closingAccountModel")]
            [Validation(Required=false)]
            public GetClosingAccountsResponseBodyResultClosingAccountModel ClosingAccountModel { get; set; }
            public class GetClosingAccountsResponseBodyResultClosingAccountModel : TeaModel {
                /// <summary>
                /// 封账时间-日
                /// </summary>
                [NameInMap("closingDay")]
                [Validation(Required=false)]
                public int? ClosingDay { get; set; }

                /// <summary>
                /// 封账时间-时分
                /// </summary>
                [NameInMap("closingHourMinutes")]
                [Validation(Required=false)]
                public long? ClosingHourMinutes { get; set; }

                /// <summary>
                /// 封账范围-结束日
                /// </summary>
                [NameInMap("endDay")]
                [Validation(Required=false)]
                public int? EndDay { get; set; }

                /// <summary>
                /// 封账范围-结束月
                /// </summary>
                [NameInMap("endMonth")]
                [Validation(Required=false)]
                public int? EndMonth { get; set; }

                /// <summary>
                /// 封账范围-开始日
                /// </summary>
                [NameInMap("startDay")]
                [Validation(Required=false)]
                public int? StartDay { get; set; }

                /// <summary>
                /// 封账范围-开始月
                /// </summary>
                [NameInMap("startMonth")]
                [Validation(Required=false)]
                public int? StartMonth { get; set; }

            }

            /// <summary>
            /// 开关
            /// </summary>
            [NameInMap("switchOn")]
            [Validation(Required=false)]
            public bool? SwitchOn { get; set; }

            /// <summary>
            /// 解封规则
            /// </summary>
            [NameInMap("unsealClosingAccountModel")]
            [Validation(Required=false)]
            public GetClosingAccountsResponseBodyResultUnsealClosingAccountModel UnsealClosingAccountModel { get; set; }
            public class GetClosingAccountsResponseBodyResultUnsealClosingAccountModel : TeaModel {
                /// <summary>
                /// 解封时间点
                /// </summary>
                [NameInMap("invalidTimeStamp")]
                [Validation(Required=false)]
                public long? InvalidTimeStamp { get; set; }

            }

            /// <summary>
            /// 人员ID
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
