// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QueryActiveUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("activeUserInfos")]
        [Validation(Required=false)]
        public List<QueryActiveUsersResponseBodyActiveUserInfos> ActiveUserInfos { get; set; }
        public class QueryActiveUsersResponseBodyActiveUserInfos : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("actionIndexL14d")]
            [Validation(Required=false)]
            public double? ActionIndexL14d { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("actionIndexL30d")]
            [Validation(Required=false)]
            public double? ActionIndexL30d { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("actionIndexL7d")]
            [Validation(Required=false)]
            public double? ActionIndexL7d { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("activeScore")]
            [Validation(Required=false)]
            public double? ActiveScore { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ranking")]
            [Validation(Required=false)]
            public long? Ranking { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

    }

}
