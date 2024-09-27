// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetUserAppVersionSummaryResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetUserAppVersionSummaryResponseBodyData> Data { get; set; }
        public class GetUserAppVersionSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>6.0</para>
            /// </summary>
            [NameInMap("appVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>iOS</para>
            /// </summary>
            [NameInMap("client")]
            [Validation(Required=false)]
            public string Client { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>组织1</para>
            /// </summary>
            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20210808</para>
            /// </summary>
            [NameInMap("statDate")]
            [Validation(Required=false)]
            public string StatDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("userCnt")]
            [Validation(Required=false)]
            public float? UserCnt { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
