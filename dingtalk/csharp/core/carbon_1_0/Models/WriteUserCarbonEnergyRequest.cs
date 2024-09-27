// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcarbon_1_0.Models
{
    public class WriteUserCarbonEnergyRequest : TeaModel {
        [NameInMap("userDetailsList")]
        [Validation(Required=false)]
        public List<WriteUserCarbonEnergyRequestUserDetailsList> UserDetailsList { get; set; }
        public class WriteUserCarbonEnergyRequestUserDetailsList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-11-26 10:09:37</para>
            /// </summary>
            [NameInMap("actionEndTime")]
            [Validation(Required=false)]
            public string ActionEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12320211126</para>
            /// </summary>
            [NameInMap("actionId")]
            [Validation(Required=false)]
            public string ActionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-11-26 10:09:37</para>
            /// </summary>
            [NameInMap("actionStartTime")]
            [Validation(Required=false)]
            public string ActionStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VIDEO</para>
            /// </summary>
            [NameInMap("actionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3.21</para>
            /// </summary>
            [NameInMap("carbonAmount")]
            [Validation(Required=false)]
            public string CarbonAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding12344</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

    }

}
