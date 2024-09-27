// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class QueryPointAutoIssueSettingResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryPointAutoIssueSettingResponseBodyResult Result { get; set; }
        public class QueryPointAutoIssueSettingResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("pointAutoNum")]
            [Validation(Required=false)]
            public long? PointAutoNum { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("pointAutoState")]
            [Validation(Required=false)]
            public bool? PointAutoState { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("pointAutoTime")]
            [Validation(Required=false)]
            public long? PointAutoTime { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
