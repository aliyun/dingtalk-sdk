// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetClosingAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetClosingAccountsResponseBodyResult> Result { get; set; }
        public class GetClosingAccountsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("closingAccountModel")]
            [Validation(Required=false)]
            public GetClosingAccountsResponseBodyResultClosingAccountModel ClosingAccountModel { get; set; }
            public class GetClosingAccountsResponseBodyResultClosingAccountModel : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("closingDay")]
                [Validation(Required=false)]
                public int? ClosingDay { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("closingHourMinutes")]
                [Validation(Required=false)]
                public long? ClosingHourMinutes { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("endDay")]
                [Validation(Required=false)]
                public int? EndDay { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("endMonth")]
                [Validation(Required=false)]
                public int? EndMonth { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("startDay")]
                [Validation(Required=false)]
                public int? StartDay { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("startMonth")]
                [Validation(Required=false)]
                public int? StartMonth { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("switchOn")]
            [Validation(Required=false)]
            public bool? SwitchOn { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("unsealClosingAccountModel")]
            [Validation(Required=false)]
            public GetClosingAccountsResponseBodyResultUnsealClosingAccountModel UnsealClosingAccountModel { get; set; }
            public class GetClosingAccountsResponseBodyResultUnsealClosingAccountModel : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("invalidTimeStamp")]
                [Validation(Required=false)]
                public long? InvalidTimeStamp { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
